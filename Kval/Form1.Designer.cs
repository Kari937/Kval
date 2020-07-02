namespace Kval
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonMenedzher = new System.Windows.Forms.Button();
            this.buttonFizicheskiyeLitsa = new System.Windows.Forms.Button();
            this.buttonYuridicheskiyeLitsa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenedzher
            // 
            this.buttonMenedzher.BackColor = System.Drawing.Color.White;
            this.buttonMenedzher.Location = new System.Drawing.Point(2, 127);
            this.buttonMenedzher.Name = "buttonMenedzher";
            this.buttonMenedzher.Size = new System.Drawing.Size(265, 48);
            this.buttonMenedzher.TabIndex = 0;
            this.buttonMenedzher.Text = "Менеджеры";
            this.buttonMenedzher.UseVisualStyleBackColor = false;
            this.buttonMenedzher.Click += new System.EventHandler(this.buttonMenedzher_Click);
            // 
            // buttonFizicheskiyeLitsa
            // 
            this.buttonFizicheskiyeLitsa.BackColor = System.Drawing.Color.White;
            this.buttonFizicheskiyeLitsa.Location = new System.Drawing.Point(2, 195);
            this.buttonFizicheskiyeLitsa.Name = "buttonFizicheskiyeLitsa";
            this.buttonFizicheskiyeLitsa.Size = new System.Drawing.Size(265, 48);
            this.buttonFizicheskiyeLitsa.TabIndex = 1;
            this.buttonFizicheskiyeLitsa.Text = "Физические лица";
            this.buttonFizicheskiyeLitsa.UseVisualStyleBackColor = false;
            this.buttonFizicheskiyeLitsa.Click += new System.EventHandler(this.buttonFizicheskiyeLitsa_Click);
            // 
            // buttonYuridicheskiyeLitsa
            // 
            this.buttonYuridicheskiyeLitsa.BackColor = System.Drawing.Color.White;
            this.buttonYuridicheskiyeLitsa.Location = new System.Drawing.Point(2, 258);
            this.buttonYuridicheskiyeLitsa.Name = "buttonYuridicheskiyeLitsa";
            this.buttonYuridicheskiyeLitsa.Size = new System.Drawing.Size(265, 48);
            this.buttonYuridicheskiyeLitsa.TabIndex = 2;
            this.buttonYuridicheskiyeLitsa.Text = "Юридические лица";
            this.buttonYuridicheskiyeLitsa.UseVisualStyleBackColor = false;
            this.buttonYuridicheskiyeLitsa.Click += new System.EventHandler(this.buttonYuridicheskiyeLitsa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(269, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonYuridicheskiyeLitsa);
            this.Controls.Add(this.buttonFizicheskiyeLitsa);
            this.Controls.Add(this.buttonMenedzher);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenedzher;
        private System.Windows.Forms.Button buttonFizicheskiyeLitsa;
        private System.Windows.Forms.Button buttonYuridicheskiyeLitsa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

