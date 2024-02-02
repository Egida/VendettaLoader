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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimazeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // urlexeBox
            // 
            this.urlexeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.urlexeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlexeBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlexeBox.ForeColor = System.Drawing.Color.White;
            this.urlexeBox.Location = new System.Drawing.Point(75, 96);
            this.urlexeBox.Multiline = true;
            this.urlexeBox.Name = "urlexeBox";
            this.urlexeBox.Size = new System.Drawing.Size(231, 25);
            this.urlexeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(118, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
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
            this.cmdBox.Location = new System.Drawing.Point(79, 216);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.ReadOnly = true;
            this.cmdBox.Size = new System.Drawing.Size(231, 99);
            this.cmdBox.TabIndex = 5;
            this.cmdBox.Text = "Vendetta Loader: Ready";
            // 
            // buildBtn
            // 
            this.buildBtn.BackColor = System.Drawing.Color.White;
            this.buildBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buildBtn.FlatAppearance.BorderSize = 0;
            this.buildBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buildBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildBtn.ForeColor = System.Drawing.Color.Black;
            this.buildBtn.Location = new System.Drawing.Point(113, 334);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(143, 38);
            this.buildBtn.TabIndex = 6;
            this.buildBtn.Text = "BUILD";
            this.buildBtn.UseVisualStyleBackColor = false;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // filenameBox
            // 
            this.filenameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.filenameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filenameBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameBox.ForeColor = System.Drawing.Color.White;
            this.filenameBox.Location = new System.Drawing.Point(76, 171);
            this.filenameBox.Multiline = true;
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(231, 25);
            this.filenameBox.TabIndex = 7;
            this.filenameBox.Text = "loader.exe";
            this.filenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(138, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "FILENAME";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.statusLabel.Location = new System.Drawing.Point(3, 383);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status Build: Idle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::VendettaLoader.Properties.Resources.github;
            this.pictureBox2.Location = new System.Drawing.Point(348, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VendettaLoader.Properties.Resources.hunter;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 58);
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
            this.minimazeBtn.Location = new System.Drawing.Point(340, 18);
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
            this.closeBtn.Location = new System.Drawing.Point(364, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 10);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(7)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(392, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlexeBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimazeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendetta Loader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

