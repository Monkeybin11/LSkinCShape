using AxAPlayer3Lib;
using System;
using System.Windows.Forms;

namespace AxPlayer3
{
    public partial class AxPlayer:UserControl
    {
        private AxAPlayer3Lib.AxPlayer axPlayer1;
        //private AxAPlayer3Lib.AxPlayer axPlayer1;
     
    
        public AxPlayer()
        {
            InitializeComponent();
            axPlayer1.OnDownloadCodec += new AxAPlayer3Lib._IPlayerEvents_OnDownloadCodecEventHandler(OnDownloadCodecEvent);
         

        }

        private void OnDownloadCodecEvent(object sender, _IPlayerEvents_OnDownloadCodecEvent e)
        {
            Console.WriteLine(e.strCodecPath);
            throw new NotImplementedException("缺少解码器:" + e.strCodecPath);
        }

        public void Open(string url)
        {
            axPlayer1.Open(url);
        }


        public void Play()
        {
            axPlayer1.Play();
        }



        public void Play(string url)
        {
            axPlayer1.Open(url);
            Play();
        }
        public void Pause()
        {

            axPlayer1.Pause();
        }


        /// <summary>
        /// 播放音量 0-1000
        /// </summary>
        public int Volume
        {
            get
            {
                return axPlayer1.GetVolume();
            }
            set
            {
           axPlayer1.SetVolume(value);
            }
        }

        /// <summary>
        /// 视频&音乐总长度 ms
        /// </summary>
        public int Duration
        {
            get
            {
                return axPlayer1.GetDuration();
            }
            set
            {
                axPlayer1.SetPosition(value);
            }
        }
        /// <summary>
        /// 当前播放进度 ms
        /// </summary>
        public int Position
        {
            get
            {
                return axPlayer1.GetPosition();
            }
            set
            {
                axPlayer1.SetPosition(value);
            }
        }

        /// <summary>
        /// 获取进度string [00:00]
        /// </summary>
        public string PositionString
        {
            get
            {
                return CastToFen((int)(Position / 1000) + "");

            }
        }

        /// <summary>
        /// 获取播放进度string [00:00]
        /// </summary>
        public string DurationString
        {
            get
            {
                return CastToFen((int)(Duration / 1000) + "");
            }
        }

        private string CastToFen(String Duration)
        {
            int miao = Convert.ToInt32(Duration);
            string fen = miao / 60 + "";
            string miaox = miao % 60 + "";
            if (fen.Length < 2)
            {
                fen = "0" + fen;
            }
            if (miaox.Length < 2)
            {
                miaox = "0" + miaox;
            }
            return fen + ":" + miaox;
        }

        public enum PLAY_STATE
        {
            PS_READY = 0,  // 准备就绪
            PS_OPENING = 1,  // 正在打开
            PS_PAUSING = 2,  // 正在暂停
            PS_PAUSED = 3,  // 暂停中
            PS_PLAYING = 4,  // 正在开始播放
            PS_PLAY = 5,  // 播放中
            PS_CLOSING = 6,  // 正在开始关闭
        };


        public PLAY_STATE State
        {
            get
            {
                return (PLAY_STATE)axPlayer1.GetState();
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxPlayer));
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axPlayer1
            // 
            this.axPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(312, 239);
            this.axPlayer1.TabIndex = 0;
            // 
            // AxPlayer
            // 
            this.Controls.Add(this.axPlayer1);
            this.Name = "AxPlayer";
            this.Size = new System.Drawing.Size(312, 239);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
