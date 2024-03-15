namespace VendettaLoader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlexeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBox = new System.Windows.Forms.RichTextBox();
            this.buildBtn = new System.Windows.Forms.Button();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.afterPayload_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimazeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // urlexeBox
            // 
            this.urlexeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.urlexeBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlexeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.urlexeBox.Location = new System.Drawing.Point(132, 26);
            this.urlexeBox.Multiline = true;
            this.urlexeBox.Name = "urlexeBox";
            this.urlexeBox.Size = new System.Drawing.Size(244, 25);
            this.urlexeBox.TabIndex = 3;
            this.urlexeBox.Text = "http://cobaltc2.com/artifact.exe";
            this.urlexeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILE URL (exe)";
            // 
            // cmdBox
            // 
            this.cmdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBox.ForeColor = System.Drawing.Color.LightGreen;
            this.cmdBox.Location = new System.Drawing.Point(457, 46);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.ReadOnly = true;
            this.cmdBox.Size = new System.Drawing.Size(203, 182);
            this.cmdBox.TabIndex = 5;
            this.cmdBox.Text = "Vendetta Loader: Ready";
            // 
            // buildBtn
            // 
            this.buildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.buildBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildBtn.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.buildBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.buildBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildBtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.buildBtn.Location = new System.Drawing.Point(80, 138);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(204, 38);
            this.buildBtn.TabIndex = 6;
            this.buildBtn.Text = "BUILD";
            this.buildBtn.UseVisualStyleBackColor = false;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // filenameBox
            // 
            this.filenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.filenameBox.Font = new System.Drawing.Font("Nirmala UI", 8.75F);
            this.filenameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.filenameBox.Location = new System.Drawing.Point(140, 64);
            this.filenameBox.Multiline = true;
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(235, 22);
            this.filenameBox.TabIndex = 7;
            this.filenameBox.Text = "loader.exe";
            this.filenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "OUT-FILENAME";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.statusLabel.Location = new System.Drawing.Point(4, 237);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status Build: Idle";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(683, 15);
            this.topPanel.TabIndex = 11;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "PAYLOAD-NAME";
            // 
            // afterPayload_Name
            // 
            this.afterPayload_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.afterPayload_Name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterPayload_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.afterPayload_Name.Location = new System.Drawing.Point(144, 99);
            this.afterPayload_Name.Multiline = true;
            this.afterPayload_Name.Name = "afterPayload_Name";
            this.afterPayload_Name.Size = new System.Drawing.Size(231, 25);
            this.afterPayload_Name.TabIndex = 12;
            this.afterPayload_Name.Text = "afterDownloadPayloadName.exe";
            this.afterPayload_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.afterPayload_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buildBtn);
            this.groupBox1.Controls.Add(this.urlexeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filenameBox);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(69, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 191);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Settings";
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.Transparent;
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.Image = global::VendettaLoader.Properties.Resources.Info;
            this.infoBtn.Location = new System.Drawing.Point(654, 231);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(24, 22);
            this.infoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoBtn.TabIndex = 10;
            this.infoBtn.TabStop = false;
            this.infoBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VendettaLoader.Properties.Resources.hunter;
            this.pictureBox1.Location = new System.Drawing.Point(11, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimazeBtn
            // 
            this.minimazeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimazeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimazeBtn.Image = global::VendettaLoader.Properties.Resources.Horizontal_Line;
            this.minimazeBtn.Location = new System.Drawing.Point(630, 16);
            this.minimazeBtn.Name = "minimazeBtn";
            this.minimazeBtn.Size = new System.Drawing.Size(18, 24);
            this.minimazeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimazeBtn.TabIndex = 1;
            this.minimazeBtn.TabStop = false;
            this.minimazeBtn.Click += new System.EventHandler(this.minimazeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::VendettaLoader.Properties.Resources.Close;
            this.closeBtn.Location = new System.Drawing.Point(654, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(683, 257);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimazeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ VENDETTA-LOADER ] - [ MAIN ]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimazeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox urlexeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cmdBox;
        private System.Windows.Forms.Button buildBtn;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox infoBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox afterPayload_Name;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

