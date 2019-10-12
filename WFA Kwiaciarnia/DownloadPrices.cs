using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
//using System.Windows.Forms;


namespace WFA_Kwiaciarnia
{
    public class DownloadPrices
    {
        HtmlAgilityPack.HtmlDocument html_;
        private string notowania_url = "http://renk.pl/notowania/#tab-1";
        HtmlWeb ha_web = new HtmlWeb();

        public Dictionary<string, string> mydictionary = new Dictionary<string, string>();

        private void Get_name_price(int rowcount)
        {

            for (int i = 1; i <= rowcount; i++)
            {
                string name = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[1]").InnerText;
                string quan_pr = html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[3]").InnerText + " " + html_.DocumentNode.SelectSingleNode($"//*[@id=\"tab-1\"]/div[2]/table/tbody/tr[{i}]/td[4]").InnerText;

                AddtoDictionary(name, quan_pr);
            }
        }



        private void AddtoDictionary(string nameOFproduct, string quantity_price)
        {
            mydictionary.Add(nameOFproduct, quantity_price);

        }

        ////*[@id="tab-1"]/div[2]
        /////*[@id="tab-1"]/div[2]/table/tbody
        /////*[@id="tab-1"]/div[2]/table/tbody/tr[1]
        private int GetTableRowCount()
        {
            return html_.DocumentNode.SelectNodes("//*[@id=\"tab-1\"]/div[2]//table//tbody//tr").Count;
            /// //*[@id="tab-1"]/div[2]/table/tbody/tr[1]

            //MessageBox.Show($"{count}");
            //return (count);
        }



        public DownloadPrices()
        {
            html_ = ha_web.Load(notowania_url);
            Get_name_price(GetTableRowCount());
        }
    }
}
