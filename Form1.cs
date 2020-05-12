using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERO_AND_DIAMOND
{
    public partial class Form1 : Form
    {
        public int hero, nominal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //COMBOBOX HERO
            cmbhero.Items.Add("Marksman");
            cmbhero.Items.Add("Assasins");
            cmbhero.Items.Add("Tank");

            //COMBOBOX DIAMOND
            cmbdm.Items.Add("Paket A");
            cmbdm.Items.Add("Paket B");
            cmbdm.Items.Add("Paket C");
            cmbdm.Items.Add("Paket Premium");
        }

        private void cmbhero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbhero.Text == "Marksman")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Miya");
                cmbnama.Items.Add("Layla");
            }
            else if (cmbhero.Text == "Assasins")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Saber");
                cmbnama.Items.Add("Alucard");
            }
            else if (cmbhero.Text == "Tank")
            {
                cmbnama.Items.Clear();
                cmbnama.Text = "";
                cmbnama.Items.Add("Balmond");
                cmbnama.Items.Add("Tigreal");
            }
        }

        private void cmbnama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnama.Text == "Miya")
            {
                hero = 15000;
                txtharga.Text = "Rp." + hero;
            }
            else if (cmbnama.Text == "Layla")
            {
                hero = 20000;
                txtharga.Text = "Rp." + hero;
            }
            else if (cmbnama.Text == "Saber")
            {
                hero = 24000;
                txtharga.Text = "Rp." + hero;
            }
            else if (cmbnama.Text == "Alucard")
            {
                hero = 32000;
                txtharga.Text = "Rp." + hero;
            }
            else if (cmbnama.Text == "Balmond")
            {
                hero = 15000;
                txtharga.Text = "Rp." + hero;
            }
            else if (cmbnama.Text == "Tigreal")
            {
                hero = 24000;
                txtharga.Text = "Rp." + hero;
            }
        }

        private void cmbdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdm.Text == "Paket A")
            {
                cmbdiamond.Items.Clear();
                cmbdiamond.Text = "";
                cmbdiamond.Items.Add("11 Diamond");
                cmbdiamond.Items.Add("50 Diamond");

            }
            else if (cmbdm.Text == "Paket B")
            {
                cmbdiamond.Items.Clear();
                cmbdiamond.Text = "";
                cmbdiamond.Items.Add("100 Diamond");
                cmbdiamond.Items.Add("150 Diamond");
            }
            else if (cmbdm.Text == "Paket C")
            {
                cmbdiamond.Items.Clear();
                cmbdiamond.Text = "";
                cmbdiamond.Items.Add("300 Diamond");
                cmbdiamond.Items.Add("500 Diamond");
            }
            else if (cmbdm.Text == "Paket Premium")
            {
                cmbdiamond.Items.Clear();
                cmbdiamond.Text = "";
                cmbdiamond.Items.Add("1000 Diamond");
                cmbdiamond.Items.Add("2000 Diamond");
            }
        }

        private void cmbdiamond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdiamond.Text == "11 Diamond")
            {
                nominal = 3000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "50 Diamond")
            {
                nominal = 15000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "100 Diamond")
            {
                nominal = 25000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "150 Diamond")
            {
                nominal = 40000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "300 Diamond")
            {
                nominal = 100000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "500 Diamond")
            {
                nominal = 200000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "1000 Diamond")
            {
                nominal = 350000;
                txthargadm.Text = "Rp." + nominal;
            }
            else if (cmbdiamond.Text == "2000 Diamond")
            {
                nominal = 650000;
                txthargadm.Text = "Rp." + nominal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i<=3)
            if (txtuser.Text == "12345" && txtzona.Text == "12345")
            {
                int total = 0;
                int admin = 0;
                int pembayaran = 0;
                total = hero + nominal;
                txttotalbayar.Text = "Rp." + total;
                admin = total * 10 / 100;
                txtadmin.Text = "Rp. " + admin;
                pembayaran = total + admin;
                txttotalpembayaran.Text = "Rp. " + pembayaran;
                    break;
            }
            else
            {
                    MessageBox.Show("User ID atau ID zona salah " + i);i++;               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtharga.Clear();
            txthargadm.Clear();
            txtadmin.Clear();
            txttotalbayar.Clear();
            txttotalpembayaran.Clear();
        }
    }
}
