using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroED.Tools.BackgroundEditor
{
    public partial class ParallaxPropertiesForm : Form
    {
        public ParallaxPropertiesForm()
        {
            InitializeComponent();
        }

        public class ScrollIndex
        {
            public byte ScrollInfo = 0;
            public ushort StartIndex = 0;
            public ushort LineCount = 1;

            public ScrollIndex()
            {

            }

            public ScrollIndex(ushort startindex = 0, ushort linecount = 0, byte scrollinfo = 0)
            {
                StartIndex = startindex;
                LineCount = linecount;
                ScrollInfo = scrollinfo;
            }
        }

        public List<ScrollIndex> ScrollIndices = new List<ScrollIndex>();

        public Retro_Formats.Background SceneData = new Retro_Formats.Background();

        public int curlayer = 0;
        public int curInfo = 0;
        public int curMappings = 0;
        public bool verticalMode = false;

        public void LoadScrollIndexes()
        {
            ScrollIndices.Clear();
            int curIndex = 0, lastIndex = 0;
            int count = 0;
            for (int i = 0; i < SceneData.Layers[curlayer].LineIndexes.Length; i++)
            {
                lastIndex = curIndex;
                curIndex = SceneData.Layers[curlayer].LineIndexes[i];
                if (i == 0)
                {
                    lastIndex = curIndex;
                }
                if (lastIndex != curIndex)
                {
                    ScrollIndex scrollIndex = new ScrollIndex();
                    scrollIndex.StartIndex = (ushort)(i - count);
                    scrollIndex.LineCount = (ushort)(count <= 0 ? 1 : count);
                    scrollIndex.ScrollInfo = (byte)lastIndex;
                    count = 0;
                    ScrollIndices.Add(scrollIndex);
                }
                else
                {
                    count++;
                }
            }
        }

        public void SaveScrollIndexes()
        {
            //Clear out array
            SceneData.Layers[curlayer].LineIndexes = new byte[SceneData.Layers[curlayer].height * 128];

            //Refill it
            for (int i = 0; i < ScrollIndices.Count; i++)
            {
                for (int s = ScrollIndices[i].StartIndex; s < ScrollIndices[i].StartIndex + ScrollIndices[i].LineCount; s++)
                {
                    SceneData.Layers[curlayer].LineIndexes[s] = ScrollIndices[i].ScrollInfo;
                }
            }
        }

        public void RefreshUI()
        {
            if (SceneData.engineType == Retro_Formats.EngineType.RSDKvRS ||
                SceneData.engineType == Retro_Formats.EngineType.RSDKv1) {
                DrawLayerNUD.Enabled = false;
            }
            else {
                DrawLayerNUD.Enabled = true;
            }

            RSPDNUD.Value = SceneData.HLines[curInfo].RelativeSpeed;
            CSPDNUD.Value = SceneData.HLines[curInfo].ConstantSpeed;
            BehaviourNUD.Value = SceneData.HLines[curInfo].Behaviour;
            DrawLayerNUD.Value = SceneData.HLines[curInfo].DrawLayer;

            StartLineNUD.Value = ScrollIndices[curMappings].StartIndex;
            LineCountNUD.Value = ScrollIndices[curMappings].LineCount;
            LineScrollInfoNUD.Value = ScrollIndices[curMappings].ScrollInfo;
        }

        public void RefreshLists()
        {
            ScrollInfoListBox.Items.Clear();
            for (int i = 0; i < SceneData.HLines.Count; i++)
            {
                ScrollInfoListBox.Items.Add(SceneData.HLines[i].ConstantSpeed + "," + SceneData.HLines[i].RelativeSpeed + "," + SceneData.HLines[i].Behaviour + "," + SceneData.HLines[i].DrawLayer);
            }

            ScrollMappingsBox.Items.Clear();
            for (int i = 0; i < ScrollIndices.Count; i++)
            {
                ScrollMappingsBox.Items.Add(ScrollIndices[i].StartIndex + "," + ScrollIndices[i].LineCount + "," + ScrollIndices[i].ScrollInfo);
            }
        }

        private void ScrollInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScrollInfoListBox.SelectedIndex < 0)
            {
                ScrollInfoListBox.SelectedIndex = 0;
            }
            curInfo = ScrollInfoListBox.SelectedIndex;
            RefreshUI();
        }

        private void RSPDNUD_ValueChanged(object sender, EventArgs e)
        {
            SceneData.HLines[curInfo].RelativeSpeed = (byte)RSPDNUD.Value;
        }

        private void CSPDNUD_ValueChanged(object sender, EventArgs e)
        {
            SceneData.HLines[curInfo].ConstantSpeed = (byte)CSPDNUD.Value;
        }

        private void DrawLayerNUD_ValueChanged(object sender, EventArgs e)
        {
            SceneData.HLines[curInfo].DrawLayer = (byte)DrawLayerNUD.Value;
        }

        private void BehaviourNUD_ValueChanged(object sender, EventArgs e)
        {
            SceneData.HLines[curInfo].Behaviour = (byte)BehaviourNUD.Value;
        }

        private void ScrollMappingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveScrollIndexes();
            if (ScrollMappingsBox.SelectedIndex < 0)
            {
                ScrollMappingsBox.SelectedIndex = 0;
            }
            curMappings = ScrollMappingsBox.SelectedIndex;
            RefreshUI();
        }

        private void StartLineNUD_ValueChanged(object sender, EventArgs e)
        {
            ScrollIndices[curMappings].StartIndex = (ushort)StartLineNUD.Value;
            SaveScrollIndexes();
        }

        private void LineCountNUD_ValueChanged(object sender, EventArgs e)
        {
            ScrollIndices[curMappings].LineCount = (ushort)LineCountNUD.Value;
            SaveScrollIndexes();
        }

        private void LineScrollInfoNUD_ValueChanged(object sender, EventArgs e)
        {
            ScrollIndices[curMappings].ScrollInfo = (byte)LineScrollInfoNUD.Value;
            SaveScrollIndexes();
        }

        private void ParallaxPropertiesForm_Deactivate(object sender, EventArgs e)
        {
            SaveScrollIndexes();
        }

        private void AddInfoButton_Click(object sender, EventArgs e)
        {
            SceneData.HLines.Add(new Retro_Formats.Background.ScrollInfo());
            RefreshUI();
            RefreshLists();
        }

        private void DelInfoButton_Click(object sender, EventArgs e)
        {
            SceneData.HLines.RemoveAt(curInfo);
            RefreshUI();
            RefreshLists();
        }

        private void CopyInfoButton_Click(object sender, EventArgs e)
        {
            SceneData.HLines.Add(new Retro_Formats.Background.ScrollInfo());
            SceneData.HLines[SceneData.HLines.Count - 1].RelativeSpeed = SceneData.HLines[curInfo].RelativeSpeed;
            SceneData.HLines[SceneData.HLines.Count - 1].ConstantSpeed = SceneData.HLines[curInfo].ConstantSpeed;
            SceneData.HLines[SceneData.HLines.Count - 1].Behaviour = SceneData.HLines[curInfo].Behaviour;
            SceneData.HLines[SceneData.HLines.Count - 1].DrawLayer = SceneData.HLines[curInfo].DrawLayer;
            RefreshUI();
            RefreshLists();
        }

        private void ClearInfoButton_Click(object sender, EventArgs e)
        {
            SceneData.HLines.Clear();
            RefreshUI();
            RefreshLists();
        }

        private void AddIndexButton_Click(object sender, EventArgs e)
        {
            ScrollIndices.Add(new ScrollIndex());
            SaveScrollIndexes();
            RefreshUI();
            RefreshLists();
        }

        private void DelIndexButton_Click(object sender, EventArgs e)
        {
            ScrollIndices.RemoveAt(curMappings);
            SaveScrollIndexes();
            RefreshUI();
            RefreshLists();
        }

        private void CopyIndexButton_Click(object sender, EventArgs e)
        {
            ScrollIndices.Add(new ScrollIndex());
            ScrollIndices[ScrollIndices.Count - 1].StartIndex   = ScrollIndices[curMappings].StartIndex;
            ScrollIndices[ScrollIndices.Count - 1].LineCount    = ScrollIndices[curMappings].LineCount;
            ScrollIndices[ScrollIndices.Count - 1].ScrollInfo   = ScrollIndices[curMappings].ScrollInfo;
            SaveScrollIndexes();
            RefreshUI();
            RefreshLists();
        }

        private void ClearIndexButton_Click(object sender, EventArgs e)
        {
            ScrollIndices.Clear();
            ScrollIndices.Add(new ScrollIndex());
            ScrollIndices[0].LineCount = (ushort)(SceneData.Layers[curlayer].height * 128);
            SaveScrollIndexes();
            RefreshUI();
            RefreshLists();
        }
    }
}
