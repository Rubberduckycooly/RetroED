namespace RetroED.Tools.BackgroundEditor
{
    partial class ParallaxPropertiesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScrollInfoListBox = new System.Windows.Forms.ListBox();
            this.DrawLayerNUD = new System.Windows.Forms.NumericUpDown();
            this.UnknownLabel = new System.Windows.Forms.Label();
            this.CSPDNUD = new System.Windows.Forms.NumericUpDown();
            this.RSPDNUD = new System.Windows.Forms.NumericUpDown();
            this.CSPDLabel = new System.Windows.Forms.Label();
            this.BehaviourNUD = new System.Windows.Forms.NumericUpDown();
            this.RSPDLabel = new System.Windows.Forms.Label();
            this.Unknown1Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LineCountNUD = new System.Windows.Forms.NumericUpDown();
            this.StartLineNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScrollMappingsBox = new System.Windows.Forms.ListBox();
            this.LineScrollInfoNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddInfoButton = new System.Windows.Forms.Button();
            this.DelInfoButton = new System.Windows.Forms.Button();
            this.CopyInfoButton = new System.Windows.Forms.Button();
            this.ClearInfoButton = new System.Windows.Forms.Button();
            this.ClearIndexButton = new System.Windows.Forms.Button();
            this.CopyIndexButton = new System.Windows.Forms.Button();
            this.DelIndexButton = new System.Windows.Forms.Button();
            this.AddIndexButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLayerNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSPDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSPDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviourNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartLineNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineScrollInfoNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearInfoButton);
            this.groupBox1.Controls.Add(this.CopyInfoButton);
            this.groupBox1.Controls.Add(this.DelInfoButton);
            this.groupBox1.Controls.Add(this.AddInfoButton);
            this.groupBox1.Controls.Add(this.DrawLayerNUD);
            this.groupBox1.Controls.Add(this.UnknownLabel);
            this.groupBox1.Controls.Add(this.CSPDNUD);
            this.groupBox1.Controls.Add(this.RSPDNUD);
            this.groupBox1.Controls.Add(this.CSPDLabel);
            this.groupBox1.Controls.Add(this.BehaviourNUD);
            this.groupBox1.Controls.Add(this.RSPDLabel);
            this.groupBox1.Controls.Add(this.Unknown1Label);
            this.groupBox1.Controls.Add(this.ScrollInfoListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scroll Info";
            // 
            // ScrollInfoListBox
            // 
            this.ScrollInfoListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ScrollInfoListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScrollInfoListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScrollInfoListBox.FormattingEnabled = true;
            this.ScrollInfoListBox.ItemHeight = 16;
            this.ScrollInfoListBox.Location = new System.Drawing.Point(3, 18);
            this.ScrollInfoListBox.Name = "ScrollInfoListBox";
            this.ScrollInfoListBox.Size = new System.Drawing.Size(126, 152);
            this.ScrollInfoListBox.TabIndex = 0;
            this.ScrollInfoListBox.SelectedIndexChanged += new System.EventHandler(this.ScrollInfoListBox_SelectedIndexChanged);
            // 
            // DrawLayerNUD
            // 
            this.DrawLayerNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawLayerNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrawLayerNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DrawLayerNUD.Location = new System.Drawing.Point(258, 73);
            this.DrawLayerNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DrawLayerNUD.Name = "DrawLayerNUD";
            this.DrawLayerNUD.Size = new System.Drawing.Size(74, 22);
            this.DrawLayerNUD.TabIndex = 19;
            this.DrawLayerNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DrawLayerNUD.ValueChanged += new System.EventHandler(this.DrawLayerNUD_ValueChanged);
            // 
            // UnknownLabel
            // 
            this.UnknownLabel.AutoSize = true;
            this.UnknownLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnknownLabel.Location = new System.Drawing.Point(135, 72);
            this.UnknownLabel.Name = "UnknownLabel";
            this.UnknownLabel.Size = new System.Drawing.Size(85, 17);
            this.UnknownLabel.TabIndex = 18;
            this.UnknownLabel.Text = "Draw Order:";
            // 
            // CSPDNUD
            // 
            this.CSPDNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CSPDNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CSPDNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CSPDNUD.Location = new System.Drawing.Point(258, 45);
            this.CSPDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CSPDNUD.Name = "CSPDNUD";
            this.CSPDNUD.Size = new System.Drawing.Size(74, 22);
            this.CSPDNUD.TabIndex = 17;
            this.CSPDNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CSPDNUD.ValueChanged += new System.EventHandler(this.CSPDNUD_ValueChanged);
            // 
            // RSPDNUD
            // 
            this.RSPDNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RSPDNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RSPDNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RSPDNUD.Location = new System.Drawing.Point(258, 17);
            this.RSPDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RSPDNUD.Name = "RSPDNUD";
            this.RSPDNUD.Size = new System.Drawing.Size(74, 22);
            this.RSPDNUD.TabIndex = 15;
            this.RSPDNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RSPDNUD.ValueChanged += new System.EventHandler(this.RSPDNUD_ValueChanged);
            // 
            // CSPDLabel
            // 
            this.CSPDLabel.AutoSize = true;
            this.CSPDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CSPDLabel.Location = new System.Drawing.Point(135, 46);
            this.CSPDLabel.Name = "CSPDLabel";
            this.CSPDLabel.Size = new System.Drawing.Size(113, 17);
            this.CSPDLabel.TabIndex = 16;
            this.CSPDLabel.Text = "Constant Speed:";
            // 
            // BehaviourNUD
            // 
            this.BehaviourNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviourNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BehaviourNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BehaviourNUD.Location = new System.Drawing.Point(258, 101);
            this.BehaviourNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BehaviourNUD.Name = "BehaviourNUD";
            this.BehaviourNUD.Size = new System.Drawing.Size(74, 22);
            this.BehaviourNUD.TabIndex = 14;
            this.BehaviourNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BehaviourNUD.ValueChanged += new System.EventHandler(this.BehaviourNUD_ValueChanged);
            // 
            // RSPDLabel
            // 
            this.RSPDLabel.AutoSize = true;
            this.RSPDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RSPDLabel.Location = new System.Drawing.Point(135, 18);
            this.RSPDLabel.Name = "RSPDLabel";
            this.RSPDLabel.Size = new System.Drawing.Size(108, 17);
            this.RSPDLabel.TabIndex = 13;
            this.RSPDLabel.Text = "Relative Speed:";
            // 
            // Unknown1Label
            // 
            this.Unknown1Label.AutoSize = true;
            this.Unknown1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Unknown1Label.Location = new System.Drawing.Point(135, 101);
            this.Unknown1Label.Name = "Unknown1Label";
            this.Unknown1Label.Size = new System.Drawing.Size(76, 17);
            this.Unknown1Label.TabIndex = 12;
            this.Unknown1Label.Text = "Behaviour:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearIndexButton);
            this.groupBox2.Controls.Add(this.CopyIndexButton);
            this.groupBox2.Controls.Add(this.DelIndexButton);
            this.groupBox2.Controls.Add(this.AddIndexButton);
            this.groupBox2.Controls.Add(this.LineScrollInfoNUD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LineCountNUD);
            this.groupBox2.Controls.Add(this.StartLineNUD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ScrollMappingsBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scroll Mappings";
            // 
            // LineCountNUD
            // 
            this.LineCountNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LineCountNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LineCountNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LineCountNUD.Location = new System.Drawing.Point(258, 44);
            this.LineCountNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.LineCountNUD.Name = "LineCountNUD";
            this.LineCountNUD.Size = new System.Drawing.Size(74, 22);
            this.LineCountNUD.TabIndex = 17;
            this.LineCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineCountNUD.ValueChanged += new System.EventHandler(this.LineCountNUD_ValueChanged);
            // 
            // StartLineNUD
            // 
            this.StartLineNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartLineNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartLineNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartLineNUD.Location = new System.Drawing.Point(258, 16);
            this.StartLineNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.StartLineNUD.Name = "StartLineNUD";
            this.StartLineNUD.Size = new System.Drawing.Size(74, 22);
            this.StartLineNUD.TabIndex = 15;
            this.StartLineNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartLineNUD.ValueChanged += new System.EventHandler(this.StartLineNUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(135, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Line Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(135, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Line:";
            // 
            // ScrollMappingsBox
            // 
            this.ScrollMappingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ScrollMappingsBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScrollMappingsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScrollMappingsBox.FormattingEnabled = true;
            this.ScrollMappingsBox.ItemHeight = 16;
            this.ScrollMappingsBox.Location = new System.Drawing.Point(3, 18);
            this.ScrollMappingsBox.Name = "ScrollMappingsBox";
            this.ScrollMappingsBox.Size = new System.Drawing.Size(126, 159);
            this.ScrollMappingsBox.TabIndex = 0;
            this.ScrollMappingsBox.SelectedIndexChanged += new System.EventHandler(this.ScrollMappingsBox_SelectedIndexChanged);
            // 
            // LineScrollInfoNUD
            // 
            this.LineScrollInfoNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LineScrollInfoNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LineScrollInfoNUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LineScrollInfoNUD.Location = new System.Drawing.Point(258, 72);
            this.LineScrollInfoNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LineScrollInfoNUD.Name = "LineScrollInfoNUD";
            this.LineScrollInfoNUD.Size = new System.Drawing.Size(74, 22);
            this.LineScrollInfoNUD.TabIndex = 19;
            this.LineScrollInfoNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineScrollInfoNUD.ValueChanged += new System.EventHandler(this.LineScrollInfoNUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(135, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Scroll Info:";
            // 
            // AddInfoButton
            // 
            this.AddInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddInfoButton.Location = new System.Drawing.Point(138, 144);
            this.AddInfoButton.Name = "AddInfoButton";
            this.AddInfoButton.Size = new System.Drawing.Size(24, 23);
            this.AddInfoButton.TabIndex = 20;
            this.AddInfoButton.Text = "+";
            this.AddInfoButton.UseVisualStyleBackColor = true;
            this.AddInfoButton.Click += new System.EventHandler(this.AddInfoButton_Click);
            // 
            // DelInfoButton
            // 
            this.DelInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelInfoButton.Location = new System.Drawing.Point(168, 144);
            this.DelInfoButton.Name = "DelInfoButton";
            this.DelInfoButton.Size = new System.Drawing.Size(24, 23);
            this.DelInfoButton.TabIndex = 21;
            this.DelInfoButton.Text = "-";
            this.DelInfoButton.UseVisualStyleBackColor = true;
            this.DelInfoButton.Click += new System.EventHandler(this.DelInfoButton_Click);
            // 
            // CopyInfoButton
            // 
            this.CopyInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyInfoButton.Location = new System.Drawing.Point(198, 144);
            this.CopyInfoButton.Name = "CopyInfoButton";
            this.CopyInfoButton.Size = new System.Drawing.Size(45, 23);
            this.CopyInfoButton.TabIndex = 22;
            this.CopyInfoButton.Text = "Cpy";
            this.CopyInfoButton.UseVisualStyleBackColor = true;
            this.CopyInfoButton.Click += new System.EventHandler(this.CopyInfoButton_Click);
            // 
            // ClearInfoButton
            // 
            this.ClearInfoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearInfoButton.Location = new System.Drawing.Point(249, 144);
            this.ClearInfoButton.Name = "ClearInfoButton";
            this.ClearInfoButton.Size = new System.Drawing.Size(45, 23);
            this.ClearInfoButton.TabIndex = 23;
            this.ClearInfoButton.Text = "Clr";
            this.ClearInfoButton.UseVisualStyleBackColor = true;
            this.ClearInfoButton.Click += new System.EventHandler(this.ClearInfoButton_Click);
            // 
            // ClearIndexButton
            // 
            this.ClearIndexButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearIndexButton.Location = new System.Drawing.Point(249, 151);
            this.ClearIndexButton.Name = "ClearIndexButton";
            this.ClearIndexButton.Size = new System.Drawing.Size(45, 23);
            this.ClearIndexButton.TabIndex = 27;
            this.ClearIndexButton.Text = "Clr";
            this.ClearIndexButton.UseVisualStyleBackColor = true;
            this.ClearIndexButton.Click += new System.EventHandler(this.ClearIndexButton_Click);
            // 
            // CopyIndexButton
            // 
            this.CopyIndexButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyIndexButton.Location = new System.Drawing.Point(198, 151);
            this.CopyIndexButton.Name = "CopyIndexButton";
            this.CopyIndexButton.Size = new System.Drawing.Size(45, 23);
            this.CopyIndexButton.TabIndex = 26;
            this.CopyIndexButton.Text = "Cpy";
            this.CopyIndexButton.UseVisualStyleBackColor = true;
            this.CopyIndexButton.Click += new System.EventHandler(this.CopyIndexButton_Click);
            // 
            // DelIndexButton
            // 
            this.DelIndexButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelIndexButton.Location = new System.Drawing.Point(168, 151);
            this.DelIndexButton.Name = "DelIndexButton";
            this.DelIndexButton.Size = new System.Drawing.Size(24, 23);
            this.DelIndexButton.TabIndex = 25;
            this.DelIndexButton.Text = "-";
            this.DelIndexButton.UseVisualStyleBackColor = true;
            this.DelIndexButton.Click += new System.EventHandler(this.DelIndexButton_Click);
            // 
            // AddIndexButton
            // 
            this.AddIndexButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddIndexButton.Location = new System.Drawing.Point(138, 151);
            this.AddIndexButton.Name = "AddIndexButton";
            this.AddIndexButton.Size = new System.Drawing.Size(24, 23);
            this.AddIndexButton.TabIndex = 24;
            this.AddIndexButton.Text = "+";
            this.AddIndexButton.UseVisualStyleBackColor = true;
            this.AddIndexButton.Click += new System.EventHandler(this.AddIndexButton_Click);
            // 
            // ParallaxPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(344, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "ParallaxPropertiesForm";
            this.Text = "ParallaxPropertiesForm";
            this.Deactivate += new System.EventHandler(this.ParallaxPropertiesForm_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawLayerNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSPDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSPDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviourNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartLineNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineScrollInfoNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ScrollInfoListBox;
        private System.Windows.Forms.NumericUpDown DrawLayerNUD;
        private System.Windows.Forms.Label UnknownLabel;
        private System.Windows.Forms.NumericUpDown CSPDNUD;
        private System.Windows.Forms.NumericUpDown RSPDNUD;
        private System.Windows.Forms.Label CSPDLabel;
        private System.Windows.Forms.NumericUpDown BehaviourNUD;
        private System.Windows.Forms.Label RSPDLabel;
        private System.Windows.Forms.Label Unknown1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown LineScrollInfoNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LineCountNUD;
        private System.Windows.Forms.NumericUpDown StartLineNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ScrollMappingsBox;
        private System.Windows.Forms.Button ClearInfoButton;
        private System.Windows.Forms.Button CopyInfoButton;
        private System.Windows.Forms.Button DelInfoButton;
        private System.Windows.Forms.Button AddInfoButton;
        private System.Windows.Forms.Button ClearIndexButton;
        private System.Windows.Forms.Button CopyIndexButton;
        private System.Windows.Forms.Button DelIndexButton;
        private System.Windows.Forms.Button AddIndexButton;
    }
}