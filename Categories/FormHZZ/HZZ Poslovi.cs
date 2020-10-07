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
using System.Net;
using System.Xml;
using System.Data.Common;
using System.Data.SqlClient;

namespace FormHZZ
{
    public partial class HZZ_Poslovi : UserControl
    {
        public List<Job> poslovi;
        public List<Job> posloviDB;
        public BindingSource _tableBindingSource1;
        public BindingSource _tableBindingSource2;
        private CategoryRepository _categoryRepository;

        //public string sUrl = "";

        public HZZ_Poslovi()
        {
            InitializeComponent();
            poslovi = new List<Job>();
            posloviDB = new List<Job>();

            _categoryRepository = new CategoryRepository();

            _tableBindingSource1 = new BindingSource();
            _tableBindingSource2 = new BindingSource();

            posloviDB = _categoryRepository.GetDbJobs();

            _tableBindingSource2.DataSource = _categoryRepository.GetDbJobs();
            dataGridView2.DataSource = _tableBindingSource2;

            //stupacPosaoUrl.Visible = false;
            //bazaPosaoUrl.Visible = false;

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                System.Diagnostics.Process.Start((dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString()));
            }

        }

        public void RefreshGrid(string url, HZZ formHZZ)
        {
            poslovi = _categoryRepository.GetJobs(url);
            _tableBindingSource1.DataSource = _categoryRepository.GetJobs(url);
            dataGridView1.DataSource = _tableBindingSource1;

            formHZZ.SetPrimaryProgressBarConfig(poslovi.Count());

            foreach (var posao in poslovi)
            {
                _categoryRepository.CreateJobs(posao);
                formHZZ.apiProgressBar.PerformStep();
            }
            //dataGridView1.Refresh();
            //dataGridView1.Update();
            //sUrl = url;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sortiranje A-Ž
            poslovi.Sort(delegate (Job x, Job y)
            {
                if (x.sJobNaziv == null && y.sJobNaziv == null) return 0;
                else if (x.sJobNaziv == null) return -1;
                else if (y.sJobNaziv == null) return 1;
                else return x.sJobNaziv.CompareTo(y.sJobNaziv);
            });
            _tableBindingSource1.DataSource = poslovi;
            dataGridView1.DataSource = _tableBindingSource1;

            posloviDB.Sort(delegate (Job x, Job y)
            {
                if (x.sJobNaziv == null && y.sJobNaziv == null) return 0;
                else if (x.sJobNaziv == null) return -1;
                else if (y.sJobNaziv == null) return 1;
                else return x.sJobNaziv.CompareTo(y.sJobNaziv);
            });
            _tableBindingSource2.DataSource = posloviDB;
            dataGridView2.DataSource = _tableBindingSource2;            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Sortiranje Ž-A
            List<Job> posloviZA = new List<Job>();

            poslovi.Sort(delegate (Job x, Job y)
            {
                if (x.sJobNaziv == null && y.sJobNaziv == null) return 0;
                else if (x.sJobNaziv == null) return -1;
                else if (y.sJobNaziv == null) return 1;
                else return x.sJobNaziv.CompareTo(y.sJobNaziv);
            });
            for (int i = (poslovi.Count() - 1); i >= 0; i--)
            {
                posloviZA.Add(poslovi[i]);
            }

            List<Job> posloviDbZA = new List<Job>();
            posloviDB.Sort(delegate (Job x, Job y)
            {
                if (x.sJobNaziv == null && y.sJobNaziv == null) return 0;
                else if (x.sJobNaziv == null) return -1;
                else if (y.sJobNaziv == null) return 1;
                else return x.sJobNaziv.CompareTo(y.sJobNaziv);
            });
            for (int i = (posloviDB.Count() - 1); i >= 0; i--)
            {
                posloviDbZA.Add(posloviDB[i]);
            }
            _tableBindingSource2.DataSource = posloviDbZA;
            dataGridView2.DataSource = _tableBindingSource2;

            _tableBindingSource1.DataSource = posloviZA;
            dataGridView1.DataSource = _tableBindingSource1;
        }

        private void button6_Click(object sender, EventArgs e) //DateSort
        {
            var poDatumu = poslovi.OrderByDescending(x => x.sJobPubDate).ToList();
            var poDatumuDB = posloviDB.OrderByDescending(x => x.sJobPubDate).ToList();

            _tableBindingSource1.DataSource = poDatumu;
            dataGridView1.DataSource = _tableBindingSource1;
            _tableBindingSource2.DataSource = poDatumuDB;
            dataGridView2.DataSource = _tableBindingSource2;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TRAŽI NAZIV
            List<Job> Pretraga = new List<Job>();
            List<Job> PretragaDB = new List<Job>();

            string textGrad = textBox2.Text;
            textGrad = textGrad.ToLower();

            foreach (Job job in poslovi)
            {
                string posaoGrad = job.sJobGrad;
                posaoGrad = posaoGrad.ToLower();

                if (posaoGrad.Contains(textGrad) is true)
                {
                    Pretraga.Add(job);
                }
            }

            foreach (Job job in posloviDB)
            {
                string posaoGrad = job.sJobGrad;
                posaoGrad = posaoGrad.ToLower();

                if (posaoGrad.Contains(textGrad) is true)
                {
                    PretragaDB.Add(job);
                }
            }

            _tableBindingSource2.DataSource = PretragaDB;
            dataGridView2.DataSource = _tableBindingSource2;
            _tableBindingSource1.DataSource = Pretraga;
            dataGridView1.DataSource = _tableBindingSource1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TRAŽI NAZIV
            List<Job> Pretraga = new List<Job>();
            List<Job> PretragaDB = new List<Job>();

            string textNaziv = textBox1.Text;
            textNaziv = textNaziv.ToLower();

            foreach (Job job in poslovi)
            {
                string posaoNaziv = job.sJobNaziv;
                posaoNaziv = posaoNaziv.ToLower();

                if (posaoNaziv.Contains(textNaziv) is true)
                {
                    Pretraga.Add(job);
                }
            }

            foreach (Job job in posloviDB)
            {
                string posaoNaziv = job.sJobNaziv;
                posaoNaziv = posaoNaziv.ToLower();

                if (posaoNaziv.Contains(textNaziv) is true)
                {
                    PretragaDB.Add(job);
                }
            }

            _tableBindingSource2.DataSource = PretragaDB;
            dataGridView2.DataSource = _tableBindingSource2;
            _tableBindingSource1.DataSource = Pretraga;
            dataGridView1.DataSource = _tableBindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tableBindingSource1.DataSource = poslovi;
            dataGridView1.DataSource = _tableBindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

