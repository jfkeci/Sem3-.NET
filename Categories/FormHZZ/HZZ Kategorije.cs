using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poslovi;

namespace FormHZZ
{
    public partial class HZZ_Kategorije : UserControl
    {
        int position = 0;
        private HZZ FormHZZ{ get; set; }

        public HZZ_Kategorije()
        {
            InitializeComponent();
        }

        public HZZ_Kategorije(HZZ formHZZ) : this()
        {
            FormHZZ = formHZZ;
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
                string podatak = kategorije[i].sUrl;// + kategorije[i].nPosition;
                Button newButton = new Button();
                newButton.Location = new Point(newButton.Width * x * 2 + 5, y);
                newButton.Size = new Size(width, height);
                newButton.Text = kategorije[i].sDescription;
                newButton.AccessibleDescription = podatak;
                newButton.Click += (sender, e) => b_Click(sender, e);
                this.groupBox1.Controls.Add(newButton);
                n++;
                x++;
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button clickedCategoryButton = new Button();
                clickedCategoryButton = (Button)sender;
                FormHZZ.hzZ_Poslovi1.RefreshGrid(clickedCategoryButton.AccessibleDescription,FormHZZ);

                FormHZZ.button7.PerformClick();          
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            CreateCatButtons();
        }
    }
}
