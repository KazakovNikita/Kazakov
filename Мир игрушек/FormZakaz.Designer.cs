namespace Мир_игрушек
{
    partial class FormZakaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZakaz));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOplata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 239);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(105, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.Location = new System.Drawing.Point(82, 12);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(135, 61);
            this.buttonZakaz.TabIndex = 1;
            this.buttonZakaz.Text = "Показать сумму заказа";
            this.buttonZakaz.UseVisualStyleBackColor = true;
            this.buttonZakaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(293, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(82, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(178, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Введите ФИО и номер телефона:\r\n";
            // 
            // buttonOplata
            // 
            this.buttonOplata.Location = new System.Drawing.Point(195, 239);
            this.buttonOplata.Name = "buttonOplata";
            this.buttonOplata.Size = new System.Drawing.Size(110, 37);
            this.buttonOplata.TabIndex = 6;
            this.buttonOplata.Text = "Оплатить";
            this.buttonOplata.UseVisualStyleBackColor = true;
            this.buttonOplata.Click += new System.EventHandler(this.buttonOplata_Click);
            // 
            // FormZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 288);
            this.Controls.Add(this.buttonOplata);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormZakaz";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.FormZakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOplata;
    }
}