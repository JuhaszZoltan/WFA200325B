using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200325B
{
    struct Tetel
    {
        public DateTime Datum;
        public string Nev;
        public int Osszeg;
    }
    public partial class FrmMain : Form
    {
        List<Tetel> koltsegvetes;
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.finIco;
            Beolvas();
        }

        private void Beolvas()
        {
            koltsegvetes = new List<Tetel>();

            if (!File.Exists(@"..\..\Resources\koltsegvetes.txt"))
                File.Create(@"..\..\Resources\koltsegvetes.txt").Close();
            else
            {
                var sr = new StreamReader(@"..\..\Resources\koltsegvetes.txt");
                while (!sr.EndOfStream)
                {
                    var t = sr.ReadLine().Split(';');
                    koltsegvetes.Add(new Tetel()
                    {
                        Datum = DateTime.Parse(t[0]),
                        Nev = t[1],
                        Osszeg = int.Parse(t[2]),
                    });

                    lbTetelek.Items.Add(t[2] + " Ft");
                }


                sr.Close();
            }
        }

        private void btnTetelRogzitese_Click(object sender, EventArgs e)
        {
            if (tbTetelNev.Text != "" && int.TryParse(tbTetelOsszeg.Text, out int osszeg))
            {
                osszeg *= rbBevetel.Checked ? 1 : -1;

                koltsegvetes.Add(new Tetel()
                {
                    Datum = DateTime.Now,
                    Nev = tbTetelNev.Text,
                    Osszeg = osszeg,
                });

                var sw = new StreamWriter(@"..\..\Resources\koltsegvetes.txt", true, Encoding.UTF8);
                sw.WriteLine($"{DateTime.Now};{tbTetelNev.Text};{osszeg}");
                sw.Close();

                lbTetelek.Items.Add(osszeg + " Ft");

            }
        }

        private void lbTetelek_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                int osszeg = int.Parse(lbTetelek.Items[e.Index].ToString().Split(' ')[0]);
                Brush szin = osszeg < 0 ? Brushes.Red : Brushes.Green;

                e.DrawBackground();

                e.Graphics.DrawString(
                    lbTetelek.Items[e.Index].ToString(),
                    lbTetelek.Font,
                    szin,
                    e.Bounds);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var sum = 0;

            foreach (var i in koltsegvetes)
            {
                sum += i.Osszeg;
            }

            lblSum.Text = $"{sum} Ft";
        }
    }
}
