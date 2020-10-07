using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poslovi;

namespace Form_tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateCatButtons();
        }
        public void CreateCatButtons()
        {
            int width, height;
            width = 120;
            height = 75;
            int n = 0;
            int x = 0;
            int y = 35;

            CategoryRepository Kategorija = new CategoryRepository();
            List<Category> kategorije = Kategorija.GetDbCategories();

            Kategorija.CreateCategory();

            for (int i = 0; i < kategorije.Count(); i++)
            {
                if (n == 5)
                {
                    x = 0;
                    y += 100;
                    n = 0;
                }
                Button newButton = new Button();
                newButton.Location = new Point(newButton.Width * x * 2 + 5, y);
                newButton.Size = new Size(width, height);
                newButton.Text = kategorije[i].sDescription;
                string sUrl = kategorije[i].sUrl;
                newButton.Click += (sender, e) => b_Click(sender, e, sUrl);
                this.groupBox1.Controls.Add(newButton);
                n++;
                x++;
            }
        }
        protected void b_Click(object sender, EventArgs e, string sUrl)
        {
            //Debug.WriteLine(sUrl);

        }
    }
}
