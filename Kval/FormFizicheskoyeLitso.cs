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
    public partial class FormFizicheskoyeLitso : Form
    {
        public FormFizicheskoyeLitso()
        {
            InitializeComponent();
            ShowFizicheskoyeLitso();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FizicheskoyeLitsoSet fizicheskoyeLitsoSet = new FizicheskoyeLitsoSet();
            fizicheskoyeLitsoSet.MiddleName = textBoxMiddleName.Text;
            fizicheskoyeLitsoSet.Sex = comboBoxSex.Text;
            fizicheskoyeLitsoSet.FirstName = textBoxFirstName.Text;
            fizicheskoyeLitsoSet.LastName = textBoxLastName.Text;
            fizicheskoyeLitsoSet.Addres = textBoxData.Text;
            fizicheskoyeLitsoSet.Data = textBoxData.Text;
            Program.kontragenty.FizicheskoyeLitsoSet.Add(fizicheskoyeLitsoSet);
            Program.kontragenty.SaveChanges();
            ShowFizicheskoyeLitso();
        }
        void ShowFizicheskoyeLitso()
        {
            listViewFizicheskoyeLitso.Items.Clear();
            foreach (FizicheskoyeLitsoSet fizicheskoyeLitso in Program.kontragenty.FizicheskoyeLitsoSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
fizicheskoyeLitso.Id_face.ToString(), fizicheskoyeLitso.MiddleName, fizicheskoyeLitso.Sex, fizicheskoyeLitso.FirstName,  fizicheskoyeLitso.LastName, fizicheskoyeLitso.Addres, fizicheskoyeLitso.Data,
                });
                item.Tag = fizicheskoyeLitso;
                listViewFizicheskoyeLitso.Items.Add(item);
            }
            listViewFizicheskoyeLitso.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFizicheskoyeLitso.SelectedItems.Count == 1)
            {
                FizicheskoyeLitsoSet fizicheskoyeLitso = listViewFizicheskoyeLitso.SelectedItems[0].Tag as FizicheskoyeLitsoSet;
                fizicheskoyeLitso.MiddleName = textBoxMiddleName.Text;
                fizicheskoyeLitso.Sex = comboBoxSex.Text;
                fizicheskoyeLitso.FirstName = textBoxFirstName.Text;
                fizicheskoyeLitso.LastName = textBoxLastName.Text;
                fizicheskoyeLitso.Addres = textBoxAddres.Text;
                fizicheskoyeLitso.Data = textBoxData.Text;
                Program.kontragenty.SaveChanges();
                ShowFizicheskoyeLitso();
            }
        }

        private void listViewFizicheskoyeLitso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFizicheskoyeLitso.SelectedItems.Count == 1)
            {
                FizicheskoyeLitsoSet fizicheskoyeLitso = listViewFizicheskoyeLitso.SelectedItems[0].Tag as FizicheskoyeLitsoSet;
                textBoxMiddleName.Text = fizicheskoyeLitso.MiddleName;
                comboBoxSex.Text = fizicheskoyeLitso.Sex;
                textBoxFirstName.Text = fizicheskoyeLitso.FirstName;
                textBoxLastName.Text = fizicheskoyeLitso.LastName;
                textBoxAddres.Text = fizicheskoyeLitso.Addres;
                textBoxData.Text = fizicheskoyeLitso.Data;
            }
            else
            {
                textBoxMiddleName.Text = "";
                comboBoxSex.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddres.Text = "";
                textBoxData.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFizicheskoyeLitso.SelectedItems.Count == 1)
                {
                    FizicheskoyeLitsoSet fizicheskoyeLitso = listViewFizicheskoyeLitso.SelectedItems[0].Tag as FizicheskoyeLitsoSet;
                    Program.kontragenty.FizicheskoyeLitsoSet.Remove(fizicheskoyeLitso);
                    Program.kontragenty.SaveChanges();
                    ShowFizicheskoyeLitso();
                }
                textBoxMiddleName.Text = "";
                comboBoxSex.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxAddres.Text = "";
                textBoxData.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

