namespace SpriteVortex
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.saveAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.renameBox = new System.Windows.Forms.TextBox();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.btn_Slice = new System.Windows.Forms.Button();
            this.lab_VerticalImages = new System.Windows.Forms.Label();
            this.txt_verticalImages = new System.Windows.Forms.TextBox();
            this.lab_horizontalImages = new System.Windows.Forms.Label();
            this.txt_horizontalImages = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.sheetBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.sheetDialog = new System.Windows.Forms.OpenFileDialog();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.imageSliderPanel = new MetroFramework.Controls.MetroPanel();
            this.backwardButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.lab_FPS = new System.Windows.Forms.Label();
            this.radio30 = new System.Windows.Forms.RadioButton();
            this.radio60 = new System.Windows.Forms.RadioButton();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.sidePanel.Controls.Add(this.radio60);
            this.sidePanel.Controls.Add(this.radio30);
            this.sidePanel.Controls.Add(this.lab_FPS);
            this.sidePanel.Controls.Add(this.forwardButton);
            this.sidePanel.Controls.Add(this.stopButton);
            this.sidePanel.Controls.Add(this.playPauseButton);
            this.sidePanel.Controls.Add(this.backwardButton);
            this.sidePanel.Controls.Add(this.saveAllButton);
            this.sidePanel.Controls.Add(this.saveButton);
            this.sidePanel.Controls.Add(this.renameBox);
            this.sidePanel.Controls.Add(this.displayBox);
            this.sidePanel.Controls.Add(this.btn_Slice);
            this.sidePanel.Controls.Add(this.lab_VerticalImages);
            this.sidePanel.Controls.Add(this.txt_verticalImages);
            this.sidePanel.Controls.Add(this.lab_horizontalImages);
            this.sidePanel.Controls.Add(this.txt_horizontalImages);
            this.sidePanel.Controls.Add(this.btn_Browse);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(944, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(320, 681);
            this.sidePanel.TabIndex = 0;
            // 
            // saveAllButton
            // 
            this.saveAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.saveAllButton.Enabled = false;
            this.saveAllButton.FlatAppearance.BorderSize = 0;
            this.saveAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAllButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAllButton.ForeColor = System.Drawing.Color.White;
            this.saveAllButton.Location = new System.Drawing.Point(164, 628);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(137, 33);
            this.saveAllButton.TabIndex = 9;
            this.saveAllButton.Text = "Save All";
            this.saveAllButton.UseVisualStyleBackColor = false;
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(19, 628);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 33);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // renameBox
            // 
            this.renameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.renameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.renameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.renameBox.Enabled = false;
            this.renameBox.Font = new System.Drawing.Font("Futura Round", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameBox.ForeColor = System.Drawing.Color.White;
            this.renameBox.Location = new System.Drawing.Point(15, 496);
            this.renameBox.Name = "renameBox";
            this.renameBox.Size = new System.Drawing.Size(290, 18);
            this.renameBox.TabIndex = 7;
            this.renameBox.Text = "[Image Name]";
            this.renameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayBox
            // 
            this.displayBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Image = ((System.Drawing.Image)(resources.GetObject("displayBox.Image")));
            this.displayBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("displayBox.InitialImage")));
            this.displayBox.Location = new System.Drawing.Point(15, 199);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(290, 290);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayBox.TabIndex = 6;
            this.displayBox.TabStop = false;
            // 
            // btn_Slice
            // 
            this.btn_Slice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.btn_Slice.Enabled = false;
            this.btn_Slice.FlatAppearance.BorderSize = 0;
            this.btn_Slice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Slice.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Slice.ForeColor = System.Drawing.Color.White;
            this.btn_Slice.Location = new System.Drawing.Point(142, 149);
            this.btn_Slice.Name = "btn_Slice";
            this.btn_Slice.Size = new System.Drawing.Size(166, 33);
            this.btn_Slice.TabIndex = 5;
            this.btn_Slice.Text = "Slice";
            this.btn_Slice.UseVisualStyleBackColor = false;
            this.btn_Slice.Click += new System.EventHandler(this.btn_Slice_Click);
            // 
            // lab_VerticalImages
            // 
            this.lab_VerticalImages.AutoSize = true;
            this.lab_VerticalImages.Font = new System.Drawing.Font("Futura Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_VerticalImages.ForeColor = System.Drawing.Color.White;
            this.lab_VerticalImages.Location = new System.Drawing.Point(33, 106);
            this.lab_VerticalImages.Name = "lab_VerticalImages";
            this.lab_VerticalImages.Size = new System.Drawing.Size(103, 18);
            this.lab_VerticalImages.TabIndex = 4;
            this.lab_VerticalImages.Text = "Vertical Images";
            // 
            // txt_verticalImages
            // 
            this.txt_verticalImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_verticalImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_verticalImages.Enabled = false;
            this.txt_verticalImages.Font = new System.Drawing.Font("Futura Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verticalImages.ForeColor = System.Drawing.Color.White;
            this.txt_verticalImages.Location = new System.Drawing.Point(142, 104);
            this.txt_verticalImages.MaxLength = 2;
            this.txt_verticalImages.Name = "txt_verticalImages";
            this.txt_verticalImages.Size = new System.Drawing.Size(166, 29);
            this.txt_verticalImages.TabIndex = 3;
            this.txt_verticalImages.Text = "0";
            this.txt_verticalImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_verticalImages.TextChanged += new System.EventHandler(this.txt_verticalImages_TextChanged);
            // 
            // lab_horizontalImages
            // 
            this.lab_horizontalImages.AutoSize = true;
            this.lab_horizontalImages.Font = new System.Drawing.Font("Futura Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_horizontalImages.ForeColor = System.Drawing.Color.White;
            this.lab_horizontalImages.Location = new System.Drawing.Point(15, 61);
            this.lab_horizontalImages.Name = "lab_horizontalImages";
            this.lab_horizontalImages.Size = new System.Drawing.Size(121, 18);
            this.lab_horizontalImages.TabIndex = 2;
            this.lab_horizontalImages.Text = "Horizontal Images";
            // 
            // txt_horizontalImages
            // 
            this.txt_horizontalImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.txt_horizontalImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_horizontalImages.Enabled = false;
            this.txt_horizontalImages.Font = new System.Drawing.Font("Futura Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horizontalImages.ForeColor = System.Drawing.Color.White;
            this.txt_horizontalImages.Location = new System.Drawing.Point(142, 59);
            this.txt_horizontalImages.MaxLength = 2;
            this.txt_horizontalImages.Name = "txt_horizontalImages";
            this.txt_horizontalImages.Size = new System.Drawing.Size(166, 29);
            this.txt_horizontalImages.TabIndex = 1;
            this.txt_horizontalImages.Text = "0";
            this.txt_horizontalImages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_horizontalImages.TextChanged += new System.EventHandler(this.txt_horizontalImages_TextChanged);
            this.txt_horizontalImages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horizontalImages_KeyPress);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.btn_Browse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(0, 0);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(320, 42);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Select Spritesheet";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // sheetBox
            // 
            this.sheetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.sheetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetBox.Location = new System.Drawing.Point(0, 0);
            this.sheetBox.Name = "sheetBox";
            this.sheetBox.Size = new System.Drawing.Size(944, 509);
            this.sheetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sheetBox.TabIndex = 3;
            this.sheetBox.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(944, 42);
            this.infoPanel.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Futura Round", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Gray;
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(944, 42);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "[No Image Selected]";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheetDialog
            // 
            this.sheetDialog.DefaultExt = "png";
            this.sheetDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            this.sheetDialog.FilterIndex = 0;
            this.sheetDialog.InitialDirectory = "@\"D:\\\"";
            this.sheetDialog.ReadOnlyChecked = true;
            this.sheetDialog.RestoreDirectory = true;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.imagePanel.Controls.Add(this.sheetBox);
            this.imagePanel.Controls.Add(this.imageSliderPanel);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 42);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(944, 639);
            this.imagePanel.TabIndex = 5;
            // 
            // imageSliderPanel
            // 
            this.imageSliderPanel.AutoScroll = true;
            this.imageSliderPanel.AutoScrollMinSize = new System.Drawing.Size(944, 0);
            this.imageSliderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.imageSliderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageSliderPanel.HorizontalScrollbar = true;
            this.imageSliderPanel.HorizontalScrollbarBarColor = true;
            this.imageSliderPanel.HorizontalScrollbarHighlightOnWheel = true;
            this.imageSliderPanel.HorizontalScrollbarSize = 10;
            this.imageSliderPanel.Location = new System.Drawing.Point(0, 509);
            this.imageSliderPanel.Name = "imageSliderPanel";
            this.imageSliderPanel.Size = new System.Drawing.Size(944, 130);
            this.imageSliderPanel.Style = MetroFramework.MetroColorStyle.Lime;
            this.imageSliderPanel.TabIndex = 6;
            this.imageSliderPanel.UseCustomBackColor = true;
            this.imageSliderPanel.UseCustomForeColor = true;
            this.imageSliderPanel.UseStyleColors = true;
            this.imageSliderPanel.VerticalScrollbar = true;
            this.imageSliderPanel.VerticalScrollbarBarColor = false;
            this.imageSliderPanel.VerticalScrollbarHighlightOnWheel = false;
            this.imageSliderPanel.VerticalScrollbarSize = 10;
            // 
            // backwardButton
            // 
            this.backwardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.backwardButton.Enabled = false;
            this.backwardButton.FlatAppearance.BorderSize = 0;
            this.backwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backwardButton.ForeColor = System.Drawing.Color.White;
            this.backwardButton.Location = new System.Drawing.Point(17, 531);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(68, 33);
            this.backwardButton.TabIndex = 10;
            this.backwardButton.Text = "Back";
            this.backwardButton.UseVisualStyleBackColor = false;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playPauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.playPauseButton.Enabled = false;
            this.playPauseButton.FlatAppearance.BorderSize = 0;
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPauseButton.ForeColor = System.Drawing.Color.White;
            this.playPauseButton.Location = new System.Drawing.Point(91, 531);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(68, 33);
            this.playPauseButton.TabIndex = 11;
            this.playPauseButton.Text = "Play";
            this.playPauseButton.UseVisualStyleBackColor = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.stopButton.Enabled = false;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(165, 531);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(68, 33);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.forwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.forwardButton.Enabled = false;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Font = new System.Drawing.Font("Futura Round Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.ForeColor = System.Drawing.Color.White;
            this.forwardButton.Location = new System.Drawing.Point(239, 531);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(68, 33);
            this.forwardButton.TabIndex = 13;
            this.forwardButton.Text = "Next";
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 16;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // lab_FPS
            // 
            this.lab_FPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_FPS.AutoSize = true;
            this.lab_FPS.Font = new System.Drawing.Font("Futura Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_FPS.ForeColor = System.Drawing.Color.White;
            this.lab_FPS.Location = new System.Drawing.Point(43, 588);
            this.lab_FPS.Name = "lab_FPS";
            this.lab_FPS.Size = new System.Drawing.Size(128, 18);
            this.lab_FPS.TabIndex = 14;
            this.lab_FPS.Text = "Frames Per Second";
            // 
            // radio30
            // 
            this.radio30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radio30.AutoSize = true;
            this.radio30.Enabled = false;
            this.radio30.Font = new System.Drawing.Font("Futura Round", 12F);
            this.radio30.ForeColor = System.Drawing.Color.White;
            this.radio30.Location = new System.Drawing.Point(180, 586);
            this.radio30.Name = "radio30";
            this.radio30.Size = new System.Drawing.Size(44, 22);
            this.radio30.TabIndex = 15;
            this.radio30.Text = "30";
            this.radio30.UseVisualStyleBackColor = true;
            // 
            // radio60
            // 
            this.radio60.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radio60.AutoSize = true;
            this.radio60.Checked = true;
            this.radio60.Enabled = false;
            this.radio60.Font = new System.Drawing.Font("Futura Round", 12F);
            this.radio60.ForeColor = System.Drawing.Color.White;
            this.radio60.Location = new System.Drawing.Point(230, 586);
            this.radio60.Name = "radio60";
            this.radio60.Size = new System.Drawing.Size(44, 22);
            this.radio60.TabIndex = 16;
            this.radio60.TabStop = true;
            this.radio60.Text = "60";
            this.radio60.UseVisualStyleBackColor = true;
            this.radio60.CheckedChanged += new System.EventHandler(this.radio60_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.sidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Spritesheet Slicer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox sheetBox;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.OpenFileDialog sheetDialog;
        private System.Windows.Forms.Label lab_horizontalImages;
        private System.Windows.Forms.TextBox txt_horizontalImages;
        private System.Windows.Forms.Label lab_VerticalImages;
        private System.Windows.Forms.TextBox txt_verticalImages;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button btn_Slice;
        private MetroFramework.Controls.MetroPanel imageSliderPanel;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.TextBox renameBox;
        private System.Windows.Forms.Button saveAllButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.RadioButton radio60;
        private System.Windows.Forms.RadioButton radio30;
        private System.Windows.Forms.Label lab_FPS;
    }
}

