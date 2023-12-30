namespace MaldenbrotSet
{
	partial class MaldenbrotSetForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RenderScreen_PB = new PictureBox();
            UpRender_BT = new Button();
            DownRender_BT = new Button();
            label1 = new Label();
            Multiplier_NUD = new NumericUpDown();
            colorPalette_CB = new CheckBox();
            numericUpDownQuality = new NumericUpDown();
            label2 = new Label();
            Render_BT = new Button();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)RenderScreen_PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Multiplier_NUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuality).BeginInit();
            SuspendLayout();
            // 
            // RenderScreen_PB
            // 
            RenderScreen_PB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RenderScreen_PB.Location = new Point(17, 17);
            RenderScreen_PB.Margin = new Padding(4, 5, 4, 5);
            RenderScreen_PB.Name = "RenderScreen_PB";
            RenderScreen_PB.Size = new Size(1049, 534);
            RenderScreen_PB.SizeMode = PictureBoxSizeMode.CenterImage;
            RenderScreen_PB.TabIndex = 1;
            RenderScreen_PB.TabStop = false;
            // 
            // UpRender_BT
            // 
            UpRender_BT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpRender_BT.Location = new Point(992, 560);
            UpRender_BT.Margin = new Padding(4, 5, 4, 5);
            UpRender_BT.Name = "UpRender_BT";
            UpRender_BT.Size = new Size(33, 33);
            UpRender_BT.TabIndex = 2;
            UpRender_BT.Text = "+";
            UpRender_BT.UseVisualStyleBackColor = true;
            // 
            // DownRender_BT
            // 
            DownRender_BT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DownRender_BT.Location = new Point(1034, 560);
            DownRender_BT.Margin = new Padding(4, 5, 4, 5);
            DownRender_BT.Name = "DownRender_BT";
            DownRender_BT.Size = new Size(33, 33);
            DownRender_BT.TabIndex = 3;
            DownRender_BT.Text = "-";
            DownRender_BT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(792, 565);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 4;
            label1.Text = "multiplier:";
            // 
            // Multiplier_NUD
            // 
            Multiplier_NUD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Multiplier_NUD.Location = new Point(920, 560);
            Multiplier_NUD.Margin = new Padding(4, 5, 4, 5);
            Multiplier_NUD.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            Multiplier_NUD.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            Multiplier_NUD.Name = "Multiplier_NUD";
            Multiplier_NUD.ReadOnly = true;
            Multiplier_NUD.Size = new Size(63, 29);
            Multiplier_NUD.TabIndex = 6;
            Multiplier_NUD.TextAlign = HorizontalAlignment.Center;
            Multiplier_NUD.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // colorPalette_CB
            // 
            colorPalette_CB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            colorPalette_CB.AutoSize = true;
            colorPalette_CB.Location = new Point(626, 564);
            colorPalette_CB.Name = "colorPalette_CB";
            colorPalette_CB.Size = new Size(159, 26);
            colorPalette_CB.TabIndex = 7;
            colorPalette_CB.Text = "Цветное говно";
            colorPalette_CB.UseVisualStyleBackColor = true;
            colorPalette_CB.CheckedChanged += ColorPalette_CB_CheckedChanged;
            // 
            // numericUpDownQuality
            // 
            numericUpDownQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownQuality.Location = new Point(99, 567);
            numericUpDownQuality.Margin = new Padding(4, 5, 4, 5);
            numericUpDownQuality.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownQuality.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownQuality.Name = "numericUpDownQuality";
            numericUpDownQuality.Size = new Size(63, 29);
            numericUpDownQuality.TabIndex = 8;
            numericUpDownQuality.TextAlign = HorizontalAlignment.Center;
            numericUpDownQuality.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 569);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 9;
            label2.Text = "Quality:";
            // 
            // Render_BT
            // 
            Render_BT.Anchor = AnchorStyles.Bottom;
            Render_BT.Location = new Point(398, 563);
            Render_BT.Name = "Render_BT";
            Render_BT.Size = new Size(132, 34);
            Render_BT.TabIndex = 10;
            Render_BT.Text = "Рендер";
            Render_BT.UseVisualStyleBackColor = true;
            Render_BT.Click += Render_BT_Click;
            // 
            // progressBar
            //
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar.Location = new Point(171, 558);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(221, 44);
            progressBar.TabIndex = 11;
            // 
            // MaldenbrotSetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(progressBar);
            Controls.Add(Render_BT);
            Controls.Add(label2);
            Controls.Add(numericUpDownQuality);
            Controls.Add(colorPalette_CB);
            Controls.Add(Multiplier_NUD);
            Controls.Add(label1);
            Controls.Add(DownRender_BT);
            Controls.Add(UpRender_BT);
            Controls.Add(RenderScreen_PB);
            Font = new Font("Consolas", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MaldenbrotSetForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)RenderScreen_PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Multiplier_NUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox RenderScreen_PB;
		private Button UpRender_BT;
		private Button DownRender_BT;
		private Label label1;
		private NumericUpDown Multiplier_NUD;
        private Button ChangeRenderPalette_BT;
        private CheckBox colorPalette_CB;
        private NumericUpDown numericUpDownQuality;
        private Label label2;
        private Button Render_BT;
        private ProgressBar progressBar;
    }
}
