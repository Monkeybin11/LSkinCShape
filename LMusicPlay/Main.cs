using LMusicPlay.Properties;
using LMusicPlay.UI;
using LSkin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static AxPlayer3.AxPlayer;
namespace MusicPlay
{
    public partial class MainWindow : FormX
    {

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        AxPlayer3.AxPlayer axPlayer1 = new AxPlayer3.AxPlayer();
        DownLoadManage downm = new DownLoadManage();
        ImagePro.Zoom zoom = new ImagePro.Zoom();
        ImagePro.GaussianBlur gs = new ImagePro.GaussianBlur();
        string rootPath = Application.StartupPath + "\\Data";
        string audioPath = Application.StartupPath + "\\Data\\Songs\\";
        string lrcPath = Application.StartupPath + "\\Data\\Songs\\";
        string SingerPath = Application.StartupPath + "\\Data\\Songer\\";
        int upVolume = 0;
        private void Init()
        {
            progressBarX1.Maximum = 100;
            progressBarX1.Value = axPlayer1.Volume;
            listView();
        }

        private void nodeClick(object sender, EventArgs e)
        {
            RootNodeX node = sender as RootNodeX;

        }
        private void ButtonX4_Click(object sender, EventArgs e)
        {
            if (axPlayer1.State == PLAY_STATE.PS_PLAY)
            {
                axPlayer1.Pause();
                playBtn.Image = Resources.play;
            }
            else if (axPlayer1.State == PLAY_STATE.PS_PAUSED)
            {
                axPlayer1.Play();
                playBtn.Image = Resources.pause;
            }
            else
            {
                playBtn.Image = Resources.pause;
            }

        }

        private void progressBarX2_UserValueChange(object sender, int value, int ratio)
        {
            if (axPlayer1.State == PLAY_STATE.PS_PAUSED || axPlayer1.State == PLAY_STATE.PS_PLAY)
            {
                axPlayer1.Position = value;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (axPlayer1.State == PLAY_STATE.PS_PAUSED || axPlayer1.State == PLAY_STATE.PS_PLAY)
            {
                progressBarX2.Maximum = axPlayer1.Duration;
                progressBarX2.Value = axPlayer1.Position;
                labelX1.Text = axPlayer1.PositionString;
                labelX2.Text = axPlayer1.DurationString;
                playView1.lrcPanel1.ChangePostion(axPlayer1.Position);

            }

        }
        private void progressBarX1_UserValueChange(object sender, int value, int ratio)
        {
            SetVolume(value, ratio);
        }

        private void SetVolume(int value, int ratio)
        {
            axPlayer1.Volume = value;
            if (ratio >= 50)
            {
                yinliangBtn.Image = Resources.yinLiang50;
            }
            if (ratio == 0)
            {
                yinliangBtn.Image = Resources.yinLiang0;
            }
            if (ratio > 0 && ratio < 50)
            {
                yinliangBtn.Image = Resources.yinLiang49;
            }
            progressBarX1.AsyncData = false; //返回数据事件改成不同步 避免死循环
            progressBarX1.Value = value;
            progressBarX1.AsyncData = true;//
        }


        private void yinliangBtn_Click(object sender, EventArgs e)
        {
            if (axPlayer1.Volume > 0)
            {
                upVolume = axPlayer1.Volume;

                SetVolume(0, 0);
            }
            else
            {
                SetVolume(upVolume, Convert.ToInt32(upVolume * 1.0 / 100 * 100));

            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                ChangeSkin(colorDialog1.Color);
            }

        }
        private void ChangeSkin(Color color)
        {
            header.ThemeColor = color;
            progressBarX1.ThemeColor = color;
            progressBarX2.ThemeColor = color;
            playBtn.ThemeColor = color;
            upBtn.ThemeColor = color;
            nextbtn.ThemeColor = color;
            listView1.treeViewX1.ThemeColor = color;
            searchBar1.RefreshBackColor();
            this.Refresh();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            listView1.singerImg.MouseDown += SingerImg_MouseDown;
            listView();
        }

        private void SingerImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (list == 1)
            {
                playView();
            }
            else
            {
                listView();
            }
        }
        private void listView()
        {
            list = 1;
            playView1.Hide();
            fxyy.Dock = DockStyle.Fill;
            listView1.pages.Controls.Add(fxyy);
            fxyy.Show();

        }
        int list = 1;
        private void playView()
        {

            fxyy.Hide();
            listView1.pages.Controls.Add(playView1);
            list = 0;
            playView1.Dock = DockStyle.Fill;
            playView1.Show();


        }

        private void searchBar1_callBackText(object sender, object input, string inputStr)
        {

            listView();
            List<Song> Songs = new List<Song>();


            Songs = http.GetList(http.getJsonText(kugouApi.list(inputStr)));

            // Console.WriteLine(0);

            //   Song s = Songs[0];



            fxyy.Dock = DockStyle.Fill;

            listView1.pages.Controls.Add(fxyy);

            fxyy.fxyyList.Items.Clear();
            int i = 0;
            foreach (var item in Songs)
            {

                ItemSong its = new ItemSong(item, SongdouClick, MvIconClick);
                its.Tag = item;

                its.Width = fxyy.fxyyList.Width;

                i++;

                if (Songs.IndexOf(item) % 2 == 0)
                {
                    its.BackColor = Color.FromArgb(227, 227, 229);
                }

                fxyy.fxyyList.Items.Add(its);

            }


        }
        MVForm mv = null;
        private void MvIconClick(object sender, EventArgs e)
        {
            Song s = sender as Song;
            mv = new MVForm(axPlayer1);
            mv.Text = "正在播放["+s.Songname+"]";
            http.GetSong(s.Hash, s);//获取播放信息
            mv.Show();
            mv.Play(s);

        }

        private void SongdouClick(object sender, EventArgs e)
        {
            Song s = ((Control)sender).Tag as Song;
            http.GetSong(s.Hash, s);//获取播放信息
            axPlayer1.Open(s.Play_url);
            axPlayer1.Play();
            LoadLrc(s);
            changeImg(s);
            playBtn.Image = Resources.pause;
            listView1.singerName.Text = s.Singername;
            listView1.songName.Text = s.Songname;

        }

        faXianYinYue fxyy = new faXianYinYue();

        private void LoadLrc(Song s)
        {
            string lrcFileName = lrcPath + s.Filename + ".lrc";

            LrcPanel lrcPanel = playView1.lrcPanel1;

            //本地文件查找歌词
            if (File.Exists(lrcFileName))
            {
                lrcPanel.LoadLrc(lrcFileName);
                return;
            }

            //从歌曲对象信息里面获取歌词
            if (s.Lyrics != null)
            {
                string content = s.Lyrics;
                StreamWriter sw = new StreamWriter(lrcFileName, false, Encoding.UTF8);
                sw.Write(content);
                sw.Close();
                lrcPanel.LoadLrc(lrcFileName);
                return;
            }


            //联网查找歌词信息
            try
            {
                Lrc l = new Lrc();
                l = http.getLrc(http.getJsonText(kugouApi.getLrcLst(s.Songname, s.Duration)));
                string content = http.Getcontent(http.getJsonText(kugouApi.getLrcText(l.Id, l.Accesskey)));
                content = content.Replace("\\", "");
                string orgStr = Encoding.UTF8.GetString(Convert.FromBase64String(content));
                StreamWriter sw = new StreamWriter(lrcPath + s.Filename + ".lrc", false, Encoding.UTF8);
                sw.Write(orgStr);
                sw.Close();
                lrcPanel.LoadLrc(lrcPath + s.Filename + ".lrc");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lrcPanel.Clear();
            }
        }


        private void changeImg(Song s)
        {
            List<string> photoList = http.GetSingerPhoto(s.Singername);
            string url = http.getUrl(http.getJsonText(kugouApi.getimg(s.Singername)));
            if (url == null) return;
            url = url.Replace(@"\", @"");
            if (photoList.Count <= 0) return;
            Bitmap img = Image.FromStream(System.Net.WebRequest.Create(url).GetResponse().GetResponseStream()) as Bitmap;
            listView1.singerImg.Image = img;
        }





    }
}
