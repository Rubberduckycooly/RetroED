namespace RetroED.Tools.RSVExtractor
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ExtractRSVButton = new System.Windows.Forms.Button();
            this.SelRSVButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportAllCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ExportAllCB);
            this.splitContainer1.Panel1.Controls.Add(this.ExtractRSVButton);
            this.splitContainer1.Panel1.Controls.Add(this.SelRSVButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 290);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 0;
            // 
            // ExtractRSVButton
            // 
            this.ExtractRSVButton.Location = new System.Drawing.Point(92, 186);
            this.ExtractRSVButton.Name = "ExtractRSVButton";
            this.ExtractRSVButton.Size = new System.Drawing.Size(144, 51);
            this.ExtractRSVButton.TabIndex = 2;
            this.ExtractRSVButton.Text = "Extract To";
            this.ExtractRSVButton.UseVisualStyleBackColor = true;
            this.ExtractRSVButton.Click += new System.EventHandler(this.ExtractRSVButton_Click);
            // 
            // SelRSVButton
            // 
            this.SelRSVButton.Location = new System.Drawing.Point(92, 77);
            this.SelRSVButton.Name = "SelRSVButton";
            this.SelRSVButton.Size = new System.Drawing.Size(144, 51);
            this.SelRSVButton.TabIndex = 1;
            this.SelRSVButton.Text = "Select RSV";
            this.SelRSVButton.UseVisualStyleBackColor = true;
            this.SelRSVButton.Click += new System.EventHandler(this.SelRSVButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extract";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(124, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save As";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(124, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Select Frame Dir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pack";
            // 
            // ExportAllCB
            // 
            this.ExportAllCB.AutoSize = true;
            this.ExportAllCB.Checked = true;
            this.ExportAllCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportAllCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExportAllCB.Location = new System.Drawing.Point(92, 159);
            this.ExportAllCB.Name = "ExportAllCB";
            this.ExportAllCB.Size = new System.Drawing.Size(140, 21);
            this.ExportAllCB.TabIndex = 3;
            this.ExportAllCB.Text = "Export All Frames";
            this.ExportAllCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "RSV Extractor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ExtractRSVButton;
        private System.Windows.Forms.Button SelRSVButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ExportAllCB;
    }
}