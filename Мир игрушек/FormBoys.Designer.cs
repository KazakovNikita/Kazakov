namespace Мир_игрушек
{
    partial class FormBoys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoys));
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkTank = new System.Windows.Forms.CheckBox();
            this.checkCar = new System.Windows.Forms.CheckBox();
            this.checkSoldatik = new System.Windows.Forms.CheckBox();
            this.checkRobot = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 245);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // checkTank
            // 
            this.checkTank.AutoSize = true;
            this.checkTank.Location = new System.Drawing.Point(39, 171);
            this.checkTank.Name = "checkTank";
            this.checkTank.Size = new System.Drawing.Size(101, 17);
            this.checkTank.TabIndex = 1;
            this.checkTank.Text = "Танк (150 руб.)";
            this.checkTank.UseVisualStyleBackColor = true;
            this.checkTank.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkCar
            // 
            this.checkCar.AutoSize = true;
            this.checkCar.Location = new System.Drawing.Point(263, 171);
            this.checkCar.Name = "checkCar";
            this.checkCar.Size = new System.Drawing.Size(117, 17);
            this.checkCar.TabIndex = 2;
            this.checkCar.Text = "Машина (200 руб.)";
            this.checkCar.UseVisualStyleBackColor = true;
            // 
            // checkSoldatik
            // 
            this.checkSoldatik.AutoSize = true;
            this.checkSoldatik.Location = new System.Drawing.Point(513, 171);
            this.checkSoldatik.Name = "checkSoldatik";
            this.checkSoldatik.Size = new System.Drawing.Size(130, 17);
            this.checkSoldatik.TabIndex = 3;
            this.checkSoldatik.Text = "Солдатики (100 руб.)";
            this.checkSoldatik.UseVisualStyleBackColor = true;
            this.checkSoldatik.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkRobot
            // 
            this.checkRobot.AutoSize = true;
            this.checkRobot.Location = new System.Drawing.Point(754, 171);
            this.checkRobot.Name = "checkRobot";
            this.checkRobot.Size = new System.Drawing.Size(106, 17);
            this.checkRobot.TabIndex = 4;
            this.checkRobot.Text = "Робот (300 руб.)";
            this.checkRobot.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(471, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(754, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // FormBoys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 303);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkRobot);
            this.Controls.Add(this.checkSoldatik);
            this.Controls.Add(this.checkCar);
            this.Controls.Add(this.checkTank);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormBoys";
            this.Text = "Игрушки для мальчиков";
            this.Load += new System.EventHandler(this.FormBoys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox checkTank;
        private System.Windows.Forms.CheckBox checkCar;
        private System.Windows.Forms.CheckBox checkSoldatik;
        private System.Windows.Forms.CheckBox checkRobot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}