namespace RetroED.Tools.BackgroundEditor
{
    partial class StageChunksView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlocksList = new RetroED.Tools.ChunkMappingsEditor.TileList();
            this.SuspendLayout();
            // 
            // BlocksList
            // 
            this.BlocksList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BlocksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlocksList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BlocksList.ImageHeight = 128;
            this.BlocksList.ImageSize = 128;
            this.BlocksList.ImageWidth = 128;
            this.BlocksList.Location = new System.Drawing.Point(0, 0);
            this.BlocksList.Margin = new System.Windows.Forms.Padding(5);
            this.BlocksList.Name = "BlocksList";
            this.BlocksList.ScrollValue = 0;
            this.BlocksList.SelectedIndex = -1;
            this.BlocksList.Size = new System.Drawing.Size(317, 381);
            this.BlocksList.TabIndex = 1;
            this.BlocksList.SelectedIndexChanged += new System.EventHandler(this.BlocksList_SelectedIndexChanged);
            // 
            // StageChunksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(317, 381);
            this.Controls.Add(this.BlocksList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StageChunksView";
            this.Text = "Chunks";
            this.ResumeLayout(false);

        }

        #endregion

        public ChunkMappingsEditor.TileList BlocksList;
    }
}