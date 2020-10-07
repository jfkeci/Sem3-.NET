using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormHZZ
{
    public partial class HZZ : Form
    {
        public string Url { get; set; }
        public HZZ()
        {
            InitializeComponent();
            GetKategorijeUserControl();
            hzZ_Naslovna1.BringToFront();

        }

        private void GetKategorijeUserControl()
        {
            this.hzZ_Kategorije1 = new FormHZZ.HZZ_Kategorije(this);
            this.hzZ_Kategorije1.Location = new System.Drawing.Point(217, 150);
            this.hzZ_Kategorije1.Name = "hzZ_Kategorije1";
            this.hzZ_Kategorije1.Size = new System.Drawing.Size(890, 460);
            this.hzZ_Kategorije1.TabIndex = 7;
            this.Controls.Add(this.hzZ_Kategorije1);
            this.hzZ_Kategorije1.CreateCatButtons();
        }

        public void SetPrimaryProgressBarConfig(int brojPoslova)
        {
            apiProgressBar.Value = 0;
            apiProgressBar.Maximum = brojPoslova;
            apiProgressBar.Step = 1;
        }
        private void HZZ_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/HrvatskiZavodZaZaposljavanje");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/hzz_hr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/hrvatski-zavod-za-zapo-ljavanje-hzz---croatian-employment-service-ces-");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCzpi28kLfsfYljcV324LHog");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hzZ_Naslovna1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hzZ_Kategorije1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hzZ_Poslovi1.BringToFront();
        }
    }
}
