using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace WFA_Kwiaciarnia
{
    public partial class Prepare_order : Form
    {
        // Mogłabym tu zrobić funkcje drukuj która zamienia tabelę w np plik tekstowy, exel lub pdf.
        // Dodać możliwość ręcznej modyfikacji listy.
        // Każdy kwiat powinien mieć różną ilość od której można robić zamówienie (dodatkowe pole w tabeli?)
        //("select * from MAGAZYN where M_quantity <= ilość od której dany kwiat wpada do listy zamówienia"
        public Form1 form1_Po_ref;

        HtmlAgilityPack.HtmlDocument html_;
        private string notowania_url = "http://renk.pl/notowania/#tab-1";
        HtmlWeb ha_web = new HtmlWeb();

        public Dictionary<string, List<Opakowanie_cena>> mydictionary = new Dictionary<string, List<Opakowanie_cena>>();


        public void show_order()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("select M_name from MAGAZYN where M_quantity <= 60;", form1_Po_ref.conn);
            DataTable dT_prepare_order = new DataTable();

            if (adpt.Fill(dT_prepare_order) == 0)
            {
                no_oreder_l.Visible = true;
                no_oreder_l.Text = "W chwili obecniej\nnie musisz pzygotowywać\nzamówienia.";
                order_dGV.Visible = false;
                panel1.Visible = true;
                panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
            }
            else
            {
                Get_name_price(GetTableRowCount());
                panel1.Visible = false;
                order_dGV.Visible = true; 
                order_dGV.DataSource = dT_prepare_order;
                order_dGV.Columns["quan_column"].DisplayIndex = 2; // <--- coś tu jest nie tak
                order_dGV.Columns["pr_column"].DisplayIndex = 2;


                foreach (DataGridViewRow row in order_dGV.Rows)
                {
                    string nazwa = (string)row.Cells["M_name"].Value;

                    if (mydictionary.TryGetValue($"{nazwa}", out List<Opakowanie_cena> list))
                    {
                        row.Cells["quan_column"].Value = list[0].Opakowanie;
                        row.Cells["pr_column"].Value = list[0].Cena;
                    }

                }
            }

        }


        private void Get_name_price(int rowcount)
        {

            for (int i = 1; i <= rowcount; i++)
            {
                string name = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[1]").InnerText;
                string quantity = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[3]").InnerText;
                string price = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[4]").InnerText;

                //Type t = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[4]").GetType();

                AddtoDictionary(name, quantity, price);
            }
        }

        private void AddtoDictionary(string nameOFproduct, string quan, string pr)
        {
            List<Opakowanie_cena> list = new List<Opakowanie_cena>();
            list.Add(new Opakowanie_cena() { Opakowanie = $"{quan}", Cena = $"{pr}" });

            mydictionary.Add(nameOFproduct, list);
        }

        private int GetTableRowCount()
        {
            return html_.DocumentNode.SelectNodes("//*[@id=\"tab-1\"]/div[2]//table//tbody//tr").Count;
        }

        public Prepare_order()
        {
            InitializeComponent();
            html_ = ha_web.Load(notowania_url);

        }

    }

    public class Opakowanie_cena
    {
        public string Opakowanie { get; set; }
        public string Cena { get; set; }
    }



}
