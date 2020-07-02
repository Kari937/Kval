namespace Kval
{
    partial class FormYuridicheskoyeLitso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYuridicheskoyeLitso));
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.labelAddres = new System.Windows.Forms.Label();
            this.labelMen = new System.Windows.Forms.Label();
            this.comboBoxMen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewYuridicheskoyeLitso = new System.Windows.Forms.ListView();
            this.labelSokrashchennoyeNaimenovaniye = new System.Windows.Forms.Label();
            this.labelKPP = new System.Windows.Forms.Label();
            this.labelINN = new System.Windows.Forms.Label();
            this.textBoxKPP = new System.Windows.Forms.TextBox();
            this.textBoxSokrashchennoyeNaimenovaniye = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Location = new System.Drawing.Point(12, 141);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(151, 20);
            this.textBoxAddres.TabIndex = 65;
            // 
            // labelAddres
            // 
            this.labelAddres.AutoSize = true;
            this.labelAddres.Location = new System.Drawing.Point(9, 125);
            this.labelAddres.Name = "labelAddres";
            this.labelAddres.Size = new System.Drawing.Size(38, 13);
            this.labelAddres.TabIndex = 64;
            this.labelAddres.Text = "Адрес";
            // 
            // labelMen
            // 
            this.labelMen.AutoSize = true;
            this.labelMen.Location = new System.Drawing.Point(9, 241);
            this.labelMen.Name = "labelMen";
            this.labelMen.Size = new System.Drawing.Size(60, 13);
            this.labelMen.TabIndex = 63;
            this.labelMen.Text = "Менеджер";
            // 
            // comboBoxMen
            // 
            this.comboBoxMen.FormattingEnabled = true;
            this.comboBoxMen.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBoxMen.Location = new System.Drawing.Point(12, 257);
            this.comboBoxMen.Name = "comboBoxMen";
            this.comboBoxMen.Size = new System.Drawing.Size(151, 21);
            this.comboBoxMen.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 61;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(505, 325);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 45);
            this.buttonDel.TabIndex = 60;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(399, 325);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 45);
            this.buttonEdit.TabIndex = 59;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(293, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 45);
            this.buttonAdd.TabIndex = 58;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewYuridicheskoyeLitso
            // 
            this.listViewYuridicheskoyeLitso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewYuridicheskoyeLitso.FullRowSelect = true;
            this.listViewYuridicheskoyeLitso.GridLines = true;
            this.listViewYuridicheskoyeLitso.HideSelection = false;
            this.listViewYuridicheskoyeLitso.Location = new System.Drawing.Point(169, 81);
            this.listViewYuridicheskoyeLitso.MultiSelect = false;
            this.listViewYuridicheskoyeLitso.Name = "listViewYuridicheskoyeLitso";
            this.listViewYuridicheskoyeLitso.Size = new System.Drawing.Size(563, 238);
            this.listViewYuridicheskoyeLitso.TabIndex = 57;
            this.listViewYuridicheskoyeLitso.UseCompatibleStateImageBehavior = false;
            this.listViewYuridicheskoyeLitso.View = System.Windows.Forms.View.Details;
            this.listViewYuridicheskoyeLitso.SelectedIndexChanged += new System.EventHandler(this.listViewYuridicheskoyeLitso_SelectedIndexChanged);
            // 
            // labelSokrashchennoyeNaimenovaniye
            // 
            this.labelSokrashchennoyeNaimenovaniye.AutoSize = true;
            this.labelSokrashchennoyeNaimenovaniye.Location = new System.Drawing.Point(9, 88);
            this.labelSokrashchennoyeNaimenovaniye.Name = "labelSokrashchennoyeNaimenovaniye";
            this.labelSokrashchennoyeNaimenovaniye.Size = new System.Drawing.Size(154, 13);
            this.labelSokrashchennoyeNaimenovaniye.TabIndex = 55;
            this.labelSokrashchennoyeNaimenovaniye.Text = "Сокращенное наименование";
            // 
            // labelKPP
            // 
            this.labelKPP.AutoSize = true;
            this.labelKPP.Location = new System.Drawing.Point(9, 203);
            this.labelKPP.Name = "labelKPP";
            this.labelKPP.Size = new System.Drawing.Size(30, 13);
            this.labelKPP.TabIndex = 54;
            this.labelKPP.Text = "КПП";
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(9, 164);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(31, 13);
            this.labelINN.TabIndex = 53;
            this.labelINN.Text = "ИНН";
            // 
            // textBoxKPP
            // 
            this.textBoxKPP.Location = new System.Drawing.Point(12, 219);
            this.textBoxKPP.Name = "textBoxKPP";
            this.textBoxKPP.Size = new System.Drawing.Size(151, 20);
            this.textBoxKPP.TabIndex = 51;
            // 
            // textBoxSokrashchennoyeNaimenovaniye
            // 
            this.textBoxSokrashchennoyeNaimenovaniye.Location = new System.Drawing.Point(12, 101);
            this.textBoxSokrashchennoyeNaimenovaniye.Name = "textBoxSokrashchennoyeNaimenovaniye";
            this.textBoxSokrashchennoyeNaimenovaniye.Size = new System.Drawing.Size(151, 20);
            this.textBoxSokrashchennoyeNaimenovaniye.TabIndex = 50;
            // 
            // textBoxINN
            // 
            this.textBoxINN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxINN.Location = new System.Drawing.Point(12, 180);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(151, 20);
            this.textBoxINN.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Имя и Отчество менеджера";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Сокр название";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Адрес";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ИНН";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "КПП";
            // 
            // FormYuridicheskoyeLitso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.labelAddres);
            this.Controls.Add(this.labelMen);
            this.Controls.Add(this.comboBoxMen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewYuridicheskoyeLitso);
            this.Controls.Add(this.labelSokrashchennoyeNaimenovaniye);
            this.Controls.Add(this.labelKPP);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.textBoxKPP);
            this.Controls.Add(this.textBoxSokrashchennoyeNaimenovaniye);
            this.Controls.Add(this.textBoxINN);
            this.Name = "FormYuridicheskoyeLitso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Юридическое лицо";
            this.Load += new System.EventHandler(this.FormYuridicheskoyeLitso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Label labelAddres;
        private System.Windows.Forms.Label labelMen;
        private System.Windows.Forms.ComboBox comboBoxMen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewYuridicheskoyeLitso;
        private System.Windows.Forms.Label labelSokrashchennoyeNaimenovaniye;
        private System.Windows.Forms.Label labelKPP;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.TextBox textBoxKPP;
        private System.Windows.Forms.TextBox textBoxSokrashchennoyeNaimenovaniye;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}