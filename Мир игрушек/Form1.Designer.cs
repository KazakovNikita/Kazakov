namespace Мир_игрушек
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonBoys = new System.Windows.Forms.Button();
            this.buttonGirls = new System.Windows.Forms.Button();
            this.buttonBaby = new System.Windows.Forms.Button();
            this.buttonConstructors = new System.Windows.Forms.Button();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBoys
            // 
            this.buttonBoys.Location = new System.Drawing.Point(71, 13);
            this.buttonBoys.Name = "buttonBoys";
            this.buttonBoys.Size = new System.Drawing.Size(159, 45);
            this.buttonBoys.TabIndex = 0;
            this.buttonBoys.Text = "Игрушки для мальчиков";
            this.buttonBoys.UseVisualStyleBackColor = true;
            this.buttonBoys.Click += new System.EventHandler(this.buttonBoys_Click);
            // 
            // buttonGirls
            // 
            this.buttonGirls.Location = new System.Drawing.Point(71, 64);
            this.buttonGirls.Name = "buttonGirls";
            this.buttonGirls.Size = new System.Drawing.Size(159, 45);
            this.buttonGirls.TabIndex = 1;
            this.buttonGirls.Text = "Игрушки для девочек";
            this.buttonGirls.UseVisualStyleBackColor = true;
            this.buttonGirls.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBaby
            // 
            this.buttonBaby.Location = new System.Drawing.Point(313, 13);
            this.buttonBaby.Name = "buttonBaby";
            this.buttonBaby.Size = new System.Drawing.Size(159, 45);
            this.buttonBaby.TabIndex = 2;
            this.buttonBaby.Text = "Игрушки для малышей";
            this.buttonBaby.UseVisualStyleBackColor = true;
            this.buttonBaby.Click += new System.EventHandler(this.buttonBaby_Click);
            // 
            // buttonConstructors
            // 
            this.buttonConstructors.Location = new System.Drawing.Point(313, 64);
            this.buttonConstructors.Name = "buttonConstructors";
            this.buttonConstructors.Size = new System.Drawing.Size(159, 45);
            this.buttonConstructors.TabIndex = 3;
            this.buttonConstructors.Text = "Конструкторы";
            this.buttonConstructors.UseVisualStyleBackColor = true;
            this.buttonConstructors.Click += new System.EventHandler(this.buttonConstructors_Click);
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.Location = new System.Drawing.Point(71, 222);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(159, 45);
            this.buttonZakaz.TabIndex = 4;
            this.buttonZakaz.Text = "Оформить заказ";
            this.buttonZakaz.UseVisualStyleBackColor = true;
            this.buttonZakaz.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(313, 222);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(159, 45);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(155, 273);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(230, 23);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 313);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.buttonConstructors);
            this.Controls.Add(this.buttonBaby);
            this.Controls.Add(this.buttonGirls);
            this.Controls.Add(this.buttonBoys);
            this.Name = "FormMain";
            this.Text = "Мир игрушек";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBoys;
        private System.Windows.Forms.Button buttonGirls;
        private System.Windows.Forms.Button buttonBaby;
        private System.Windows.Forms.Button buttonConstructors;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
    }
}

