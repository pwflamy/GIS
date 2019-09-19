namespace KursGIS
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNoiseImage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRestoreImage = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.grBoxStat = new System.Windows.Forms.GroupBox();
            this.lblMaxDmgPix = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.lblRestore = new System.Windows.Forms.Label();
            this.lblDamageNum = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelImage1 = new System.Windows.Forms.Panel();
            this.panelImage2 = new System.Windows.Forms.Panel();
            this.panelImage3 = new System.Windows.Forms.Panel();
            this.lblNumRestore = new System.Windows.Forms.Label();
            this.lblProcentRestore = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblTrackStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBtn.SuspendLayout();
            this.grBoxStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelImage1.SuspendLayout();
            this.panelImage2.SuspendLayout();
            this.panelImage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(11, 11);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(105, 39);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Загрузить изображение";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 480);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnNoiseImage
            // 
            this.btnNoiseImage.Location = new System.Drawing.Point(11, 86);
            this.btnNoiseImage.Name = "btnNoiseImage";
            this.btnNoiseImage.Size = new System.Drawing.Size(105, 39);
            this.btnNoiseImage.TabIndex = 3;
            this.btnNoiseImage.Text = "Зашуметь изображение";
            this.btnNoiseImage.UseVisualStyleBackColor = true;
            this.btnNoiseImage.Click += new System.EventHandler(this.btnNoiseImage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(640, 480);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnRestoreImage
            // 
            this.btnRestoreImage.Location = new System.Drawing.Point(11, 174);
            this.btnRestoreImage.Name = "btnRestoreImage";
            this.btnRestoreImage.Size = new System.Drawing.Size(105, 39);
            this.btnRestoreImage.TabIndex = 5;
            this.btnRestoreImage.Text = "Восстановить изображение";
            this.btnRestoreImage.UseVisualStyleBackColor = true;
            this.btnRestoreImage.Click += new System.EventHandler(this.btnRestoreImage_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBtn.Controls.Add(this.label2);
            this.panelBtn.Controls.Add(this.label1);
            this.panelBtn.Controls.Add(this.lblTrackStat);
            this.panelBtn.Controls.Add(this.trackBar2);
            this.panelBtn.Controls.Add(this.grBoxStat);
            this.panelBtn.Controls.Add(this.btnStat);
            this.panelBtn.Controls.Add(this.lblRestore);
            this.panelBtn.Controls.Add(this.lblDamageNum);
            this.panelBtn.Controls.Add(this.lblTrack);
            this.panelBtn.Controls.Add(this.trackBar1);
            this.panelBtn.Controls.Add(this.btnLoadImage);
            this.panelBtn.Controls.Add(this.btnNoiseImage);
            this.panelBtn.Controls.Add(this.btnRestoreImage);
            this.panelBtn.Location = new System.Drawing.Point(3, 488);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(642, 482);
            this.panelBtn.TabIndex = 8;
            // 
            // grBoxStat
            // 
            this.grBoxStat.Controls.Add(this.lblProcentRestore);
            this.grBoxStat.Controls.Add(this.lblNumRestore);
            this.grBoxStat.Controls.Add(this.lblMaxDmgPix);
            this.grBoxStat.Location = new System.Drawing.Point(297, 261);
            this.grBoxStat.Name = "grBoxStat";
            this.grBoxStat.Size = new System.Drawing.Size(292, 100);
            this.grBoxStat.TabIndex = 11;
            this.grBoxStat.TabStop = false;
            this.grBoxStat.Text = "Статистика";
            // 
            // lblMaxDmgPix
            // 
            this.lblMaxDmgPix.AutoSize = true;
            this.lblMaxDmgPix.Location = new System.Drawing.Point(6, 21);
            this.lblMaxDmgPix.Name = "lblMaxDmgPix";
            this.lblMaxDmgPix.Size = new System.Drawing.Size(172, 13);
            this.lblMaxDmgPix.TabIndex = 0;
            this.lblMaxDmgPix.Text = "Количество сбойных пикселей - ";
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(11, 279);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(105, 51);
            this.btnStat.TabIndex = 10;
            this.btnStat.Text = "Получить статистику восстановления";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(139, 187);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(0, 13);
            this.lblRestore.TabIndex = 9;
            // 
            // lblDamageNum
            // 
            this.lblDamageNum.AutoSize = true;
            this.lblDamageNum.Location = new System.Drawing.Point(294, 99);
            this.lblDamageNum.Name = "lblDamageNum";
            this.lblDamageNum.Size = new System.Drawing.Size(0, 13);
            this.lblDamageNum.TabIndex = 8;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(201, 80);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(13, 13);
            this.lblTrack.TabIndex = 7;
            this.lblTrack.Text = "1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(142, 96);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panelImage1
            // 
            this.panelImage1.AutoScroll = true;
            this.panelImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage1.Controls.Add(this.pictureBox1);
            this.panelImage1.Location = new System.Drawing.Point(3, 2);
            this.panelImage1.Name = "panelImage1";
            this.panelImage1.Size = new System.Drawing.Size(642, 482);
            this.panelImage1.TabIndex = 9;
            // 
            // panelImage2
            // 
            this.panelImage2.AutoScroll = true;
            this.panelImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage2.Controls.Add(this.pictureBox2);
            this.panelImage2.Location = new System.Drawing.Point(649, 2);
            this.panelImage2.Name = "panelImage2";
            this.panelImage2.Size = new System.Drawing.Size(642, 482);
            this.panelImage2.TabIndex = 10;
            // 
            // panelImage3
            // 
            this.panelImage3.AutoScroll = true;
            this.panelImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage3.Controls.Add(this.pictureBox3);
            this.panelImage3.Location = new System.Drawing.Point(649, 488);
            this.panelImage3.Name = "panelImage3";
            this.panelImage3.Size = new System.Drawing.Size(642, 482);
            this.panelImage3.TabIndex = 11;
            // 
            // lblNumRestore
            // 
            this.lblNumRestore.AutoSize = true;
            this.lblNumRestore.Location = new System.Drawing.Point(6, 40);
            this.lblNumRestore.Name = "lblNumRestore";
            this.lblNumRestore.Size = new System.Drawing.Size(219, 13);
            this.lblNumRestore.TabIndex = 1;
            this.lblNumRestore.Text = "Количество восстановленных пикселей - ";
            // 
            // lblProcentRestore
            // 
            this.lblProcentRestore.AutoSize = true;
            this.lblProcentRestore.Location = new System.Drawing.Point(6, 59);
            this.lblProcentRestore.Name = "lblProcentRestore";
            this.lblProcentRestore.Size = new System.Drawing.Size(146, 13);
            this.lblProcentRestore.TabIndex = 2;
            this.lblProcentRestore.Text = "Всего восстановлено в % - ";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(142, 282);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(136, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblTrackStat
            // 
            this.lblTrackStat.AutoSize = true;
            this.lblTrackStat.Location = new System.Drawing.Point(201, 266);
            this.lblTrackStat.Name = "lblTrackStat";
            this.lblTrackStat.Size = new System.Drawing.Size(13, 13);
            this.lblTrackStat.TabIndex = 13;
            this.lblTrackStat.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите количество строк";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Допустимое отклонение \r\nяркости пикселей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 974);
            this.Controls.Add(this.panelImage3);
            this.Controls.Add(this.panelImage1);
            this.Controls.Add(this.panelImage2);
            this.Controls.Add(this.panelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Курсовой проект по ГИС. Восстановление изображения, искаженного пакетной помехой." +
    " Спиряев А.Ю.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            this.grBoxStat.ResumeLayout(false);
            this.grBoxStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelImage1.ResumeLayout(false);
            this.panelImage2.ResumeLayout(false);
            this.panelImage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNoiseImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRestoreImage;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Panel panelImage1;
        private System.Windows.Forms.Panel panelImage2;
        private System.Windows.Forms.Panel panelImage3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label lblDamageNum;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.GroupBox grBoxStat;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label lblMaxDmgPix;
        private System.Windows.Forms.Label lblNumRestore;
        private System.Windows.Forms.Label lblProcentRestore;
        private System.Windows.Forms.Label lblTrackStat;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

