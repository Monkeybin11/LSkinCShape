using LMusicPlay.Properties;
using LSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static AxPlayer3.AxPlayer;

public partial class MVForm : FormX
{
    public MVForm()
    {
        InitializeComponent();
    }
    public MVForm(AxPlayer3.AxPlayer axPlayer)
    {
        InitializeComponent();
        axPlayer = this.axPlayer1;

    }



    public void Play(Song s)
    {
        axPlayer1.Play(s.Mv[s.Mv.Length-1].Split(',')[1]);
     
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
}
