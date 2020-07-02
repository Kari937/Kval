using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kval
{
    public partial class FormMenedzher : System.Windows.Forms.Form
    {
        public FormMenedzher()
        {
            InitializeComponent();
            ShowMenedzher();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MenedzherSet menedzherSet = new MenedzherSet();
            menedzherSet.FirstName = textBoxFirstName.Text;
            menedzherSet.MiddleName = textBoxMiddleName.Text;
            menedzherSet.LastName = textBoxLastName.Text;
            menedzherSet.Email = textBoxEmail.Text;
            Program.kontragenty.MenedzherSet.Add(menedzherSet);
            Program.kontragenty.SaveChanges();
            ShowMenedzher();
        }
        void ShowMenedzher()
        {
            listViewMenedzher.Items.Clear();
            foreach (MenedzherSet menedzherSet in Program.kontragenty.MenedzherSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
menedzherSet.Id.ToString(), menedzherSet.FirstName, menedzherSet.MiddleName, menedzherSet.LastName,  menedzherSet.Email
                });
                item.Tag = menedzherSet;
                listViewMenedzher.Items.Add(item);
            }
            listViewMenedzher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewMenedzher.SelectedItems.Count == 1)
            {
                MenedzherSet menedzherSet = listViewMenedzher.SelectedItems[0].Tag as MenedzherSet;
                menedzherSet.FirstName = textBoxFirstName.Text;
                menedzherSet.MiddleName = textBoxMiddleName.Text;
                menedzherSet.LastName = textBoxLastName.Text;
                menedzherSet.Email = textBoxEmail.Text;
                Program.kontragenty.SaveChanges();
                ShowMenedzher();
            }
        }

        private void listViewMenedzher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMenedzher.SelectedItems.Count == 1)
            {
                MenedzherSet menedzherSet = listViewMenedzher.SelectedItems[0].Tag as MenedzherSet;
                textBoxFirstName.Text = menedzherSet.FirstName;
                textBoxMiddleName.Text = menedzherSet.MiddleName;
                textBoxLastName.Text = menedzherSet.LastName;
                textBoxEmail.Text = menedzherSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMenedzher.SelectedItems.Count == 1)
                {
                    MenedzherSet menedzherSet = listViewMenedzher.SelectedItems[0].Tag as MenedzherSet;
                    Program.kontragenty.MenedzherSet.Remove(menedzherSet);
                    Program.kontragenty.SaveChanges();
                    ShowMenedzher();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMenedzher_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
