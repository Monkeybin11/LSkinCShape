using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Song
{

    private string lyrics;
    private string play_url;
    private string singerHeadimg;
    private string mvHash;
    private string songname;
    private string filename;
    private string hash;
    private string extname;
    private string[] mv;
    public string Lyrics { get => lyrics; set => lyrics = value; }
    public string Play_url
    {
        get => play_url; set
        {
            play_url = value;
            play_url = play_url.Replace("\\", "").Replace(@"\", "").Replace("\"","");
       

        }
    }
    public string SingerHeadimg { get => singerHeadimg; set => singerHeadimg = value; }
    public string MvHash { get => mvHash; set => mvHash = value; }
    public string Songname { get => songname; set => songname = value; }
    public string Filename { get => filename; set => filename = value; }
    public string Hash { get => hash; set => hash = value; }
    public string Extname { get => extname; set => extname = value; }
    public string Singername { get; internal set; }
    public string Duration { get; internal set; }
    public string DurationStr { get; internal set; }
    public string[] Mv { get => mv; set
        {

            mv = value;

            for (int i = 0; i < mv.Length; i++)
            {
                if (null == mv[i]) continue;
                mv[i] = mv[i].Replace("\\", "").Replace("\"", "");
                //
            }
           
         }
    }
}
