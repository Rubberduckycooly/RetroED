using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RetroED.Tools.BackgroundEditor
{
    public partial class StageChunksView : DockContent
    {
        public Retro_Formats.EngineType engineType;
        public Image _tiles;

        public List<Bitmap> Chunks = new List<Bitmap>();

        public MainView Parent;

        //private Point tilePoint;
        public int selectedChunk;

        public StageChunksView(MainView p)
        {
            InitializeComponent();
            Parent = p;
        }

        public void SetChunks()
        {
            LoadChunks(_tiles);
            Refresh();
        }

        void LoadChunks(Image Tiles)
        {
            BlocksList.Images.Clear();
            for (int i = 0; i < Parent.Chunks.ChunkList.Length; i++)
            {
                Bitmap b = Parent.Chunks.ChunkList[i].Render(_tiles);
                //b.MakeTransparent(Color.FromArgb(255, 255, 0, 255));
                Chunks.Add(b);
                BlocksList.Images.Add(b);
                //b.Dispose();
            }
            BlocksList.SelectedIndex = 0;
        }

        private void BlocksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChunk = BlocksList.SelectedIndex;
            Console.WriteLine("New Chunk " + selectedChunk);
        }
    }
}
