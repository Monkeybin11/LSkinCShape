using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LMusicPlay.Properties;
using LSkin;

namespace LMusicPlay.UI
{
    public partial class ListView : UserControl
    {
        public ListView()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

            treeViewX1.NodeClick += NodeClick;

            RootNodeX rootNode = new RootNodeX();
            rootNode.RootNode = true;
            rootNode.CanOpen = false;
            rootNode.NodeName = " 推荐";
            rootNode.Nodes.Add(new ChildNodeX(Resources.fxyy, "  发现音乐"));
            rootNode.Nodes.Add(new ChildNodeX(Resources.srfm1, "  私人FM"));
            rootNode.Nodes.Add(new ChildNodeX(Resources.sp, "  视频"));
            rootNode.Nodes.Add(new ChildNodeX(Resources.py, "  朋友"));
            treeViewX1.Items.Add(rootNode);

            RootNodeX rootNode1 = new RootNodeX();
            rootNode1.RootNode = true;
            rootNode1.CanOpen = false;
            rootNode1.NodeName = " 我的音乐";

            ChildNodeX bdyy = new ChildNodeX(Resources.bdyy, "  本地音乐 ");
            rootNode1.Nodes.Add(bdyy);
            rootNode1.Nodes.Add(new ChildNodeX(Resources.xzgl, "  下载管理"));
            rootNode1.Nodes.Add(new ChildNodeX(Resources.wdyp, "  我的音乐云盘"));
            rootNode1.Nodes.Add(new ChildNodeX(Resources.wdsc, "  我的收藏"));
            treeViewX1.Items.Add(rootNode1);

            RootNodeX rootNode2 = new RootNodeX();
            rootNode2.NodeName = " 我创建的歌单";
            rootNode2.RootNode = true;
            rootNode2.Nodes.Add(new ChildNodeX(Resources.ax, "  我喜欢的音乐"));
            rootNode2.Nodes.Add(new ChildNodeX(Resources.yylb1, "  刘杨喜欢的音乐"));
            rootNode2.Nodes.Add(new ChildNodeX(Resources.yylb1, "  最近播放"));

            treeViewX1.Items.Add(rootNode2);

            treeViewX1.SelecedNode = bdyy;
        }

        private void NodeClick(object sender, EventArgs e)
        {

            RootNodeX rx = sender as RootNodeX;
            MessageBox.Show(rx.NodeName);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
