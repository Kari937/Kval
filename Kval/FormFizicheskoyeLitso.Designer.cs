namespace Kval
{
    partial class FormFizicheskoyeLitso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFizicheskoyeLitso));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewFizicheskoyeLitso = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отчество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Почта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelData = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelAddres = new System.Windows.Forms.Label();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 44;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(460, 325);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 45);
            this.buttonDel.TabIndex = 43;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(354, 325);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 45);
            this.buttonEdit.TabIndex = 42;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(248, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 45);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewFizicheskoyeLitso
            // 
            this.listViewFizicheskoyeLitso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Имя,
            this.Фамилия,
            this.Отчество,
            this.Почта,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFizicheskoyeLitso.FullRowSelect = true;
            this.listViewFizicheskoyeLitso.GridLines = true;
            this.listViewFizicheskoyeLitso.HideSelection = false;
            this.listViewFizicheskoyeLitso.Location = new System.Drawing.Point(139, 81);
            this.listViewFizicheskoyeLitso.MultiSelect = false;
            this.listViewFizicheskoyeLitso.Name = "listViewFizicheskoyeLitso";
            this.listViewFizicheskoyeLitso.Size = new System.Drawing.Size(563, 238);
            this.listViewFizicheskoyeLitso.TabIndex = 40;
            this.listViewFizicheskoyeLitso.UseCompatibleStateImageBehavior = false;
            this.listViewFizicheskoyeLitso.View = System.Windows.Forms.View.Details;
            this.listViewFizicheskoyeLitso.SelectedIndexChanged += new System.EventHandler(this.listViewFizicheskoyeLitso_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 32;
            // 
            // Имя
            // 
            this.Имя.Text = "Фамилия";
            this.Имя.Width = 72;
            // 
            // Фамилия
            // 
            this.Фамилия.Text = "Пол";
            this.Фамилия.Width = 88;
            // 
            // Отчество
            // 
            this.Отчество.Text = "Имя";
            this.Отчество.Width = 59;
            // 
            // Почта
            // 
            this.Почта.Text = "Отчество";
            this.Почта.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата рождения";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес";
            this.columnHeader2.Width = 82;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(9, 235);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(86, 13);
            this.labelData.TabIndex = 39;
            this.labelData.Text = "Дата рождения";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 38;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(9, 196);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 37;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 157);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 36;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(12, 251);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(121, 20);
            this.textBoxData.TabIndex = 35;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 212);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastName.TabIndex = 34;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 94);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(121, 20);
            this.textBoxMiddleName.TabIndex = 33;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 173);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFirstName.TabIndex = 32;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBoxSex.Location = new System.Drawing.Point(12, 133);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 45;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(9, 117);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(27, 13);
            this.labelSex.TabIndex = 46;
            this.labelSex.Text = "Пол";
            // 
            // labelAddres
            // 
            this.labelAddres.AutoSize = true;
            this.labelAddres.Location = new System.Drawing.Point(9, 274);
            this.labelAddres.Name = "labelAddres";
            this.labelAddres.Size = new System.Drawing.Size(38, 13);
            this.labelAddres.TabIndex = 47;
            this.labelAddres.Text = "Адрес";
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Location = new System.Drawing.Point(12, 290);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddres.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // FormFizicheskoyeLitso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(713, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.labelAddres);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewFizicheskoyeLitso);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormFizicheskoyeLitso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Физическое лицо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewFizicheskoyeLitso;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Отчество;
        private System.Windows.Forms.ColumnHeader Почта;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelAddres;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}