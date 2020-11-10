using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Lrc
    {
        private string songname;
        private string songername;
        private string length;
        private string accesskey;
        private string key;
        private int ScrollValue;

        public string Songname { get => songname; set => songname = value; }
        public string Songername { get => songername; set => songername = value; }
        public string Length { get => length; set => length = value; }
        public string Accesskey { get => accesskey; set => accesskey = value; }
        public string Key { get => key; set => key = value; }
        public int ScrollValue1 { get => ScrollValue; set => ScrollValue = value; }
        public string Id { get; internal set; }
    }
