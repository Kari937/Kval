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
    public partial class FormYuridicheskoyeLitso : Form
    {
        public FormYuridicheskoyeLitso()
        {
            InitializeComponent();
            ShowMen();
            Showt();
        }
        void ShowMen()
        {
            comboBoxMen.Items.Clear();
            foreach (MenedzherSet menedzherSet in Program.kontragenty.MenedzherSet)
            {
                string[] item = { menedzherSet.Id.ToString() + ". ", menedzherSet.MiddleName, menedzherSet.FirstName, menedzherSet.LastName, };
                comboBoxMen.Items.Add(string.Join(" ", item));
            }
        }
        void Showt()
        {
            listViewYuridicheskoyeLitso.Items.Clear();
            foreach (YuridicheskoyeLitsoSet yuridicheskoyeLitsoSet in Program.kontragenty.YuridicheskoyeLitsoSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    yuridicheskoyeLitsoSet.Id_men.ToString(), yuridicheskoyeLitsoSet.MenedzherSet. FirstName   + " " + yuridicheskoyeLitsoSet.MenedzherSet. LastName, yuridicheskoyeLitsoSet.SokrashchennoyeNaimenovaniye, yuridicheskoyeLitsoSet.Addres, yuridicheskoyeLitsoSet.INN,  yuridicheskoyeLitsoSet.KPP

                });
                item.Tag = yuridicheskoyeLitsoSet;
                listViewYuridicheskoyeLitso.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMen.SelectedItem != null)
            {
                YuridicheskoyeLitsoSet yuridicheskoyeLitsoSet = new YuridicheskoyeLitsoSet();
                yuridicheskoyeLitsoSet.SokrashchennoyeNaimenovaniye = textBoxSokrashchennoyeNaimenovaniye.Text;
                yuridicheskoyeLitsoSet.Addres = textBoxAddres.Text;
                yuridicheskoyeLitsoSet.INN = textBoxINN.Text;
                yuridicheskoyeLitsoSet.KPP = textBoxKPP.Text;



                yuridicheskoyeLitsoSet.Id_men = Convert.ToInt32(comboBoxMen.SelectedItem.ToString().Split('.')[0]);


                Program.kontragenty.YuridicheskoyeLitsoSet.Add(yuridicheskoyeLitsoSet);
                Program.kontragenty.SaveChanges();
                Showt();
            }
        }


        private void FormYuridicheskoyeLitso_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewYuridicheskoyeLitso.SelectedItems.Count == 1)
            {
                YuridicheskoyeLitsoSet yuridicheskoyeLitsoSet = listViewYuridicheskoyeLitso.SelectedItems[0].Tag as YuridicheskoyeLitsoSet;
                yuridicheskoyeLitsoSet.SokrashchennoyeNaimenovaniye = textBoxSokrashchennoyeNaimenovaniye.Text;

                yuridicheskoyeLitsoSet.Addres = textBoxAddres.Text;
                yuridicheskoyeLitsoSet.INN = textBoxINN.Text;
                yuridicheskoyeLitsoSet.KPP = textBoxKPP.Text;



                Program.kontragenty.SaveChanges();
                Showt();
            }
        }

        private void listViewYuridicheskoyeLitso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewYuridicheskoyeLitso.SelectedItems.Count == 1)
            {
                YuridicheskoyeLitsoSet yuridicheskoyeLitsoSet = listViewYuridicheskoyeLitso.SelectedItems[0].Tag as YuridicheskoyeLitsoSet;
                textBoxSokrashchennoyeNaimenovaniye.Text = yuridicheskoyeLitsoSet.SokrashchennoyeNaimenovaniye;
                textBoxAddres.Text = yuridicheskoyeLitsoSet.Addres;
                textBoxINN.Text = yuridicheskoyeLitsoSet.INN;
                textBoxKPP.Text = yuridicheskoyeLitsoSet.KPP;

            }
            else
            {
                textBoxSokrashchennoyeNaimenovaniye.Text = "";
                textBoxAddres.Text = "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewYuridicheskoyeLitso.SelectedItems.Count == 1)
                {
                    YuridicheskoyeLitsoSet yuridicheskoyeLitsoSet = listViewYuridicheskoyeLitso.SelectedItems[0].Tag as YuridicheskoyeLitsoSet;
                    Program.kontragenty.YuridicheskoyeLitsoSet.Remove(yuridicheskoyeLitsoSet);
                    Program.kontragenty.SaveChanges();
                    Showt();
                }
                textBoxSokrashchennoyeNaimenovaniye.Text = "";
                textBoxAddres.Text = "";
                textBoxINN.Text = "";
                textBoxKPP.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

