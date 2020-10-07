using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHZZ
{
    public partial class HZZ_Naslovna : UserControl
    {
        public HZZ_Naslovna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/RadnoMjesto_PosebanOglas.aspx?RadnoMjestoID=1830789");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/RadnoMjesto_PosebanOglas.aspx?RadnoMjestoID=1835147");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/RadnoMjesto_PosebanOglas.aspx?RadnoMjestoID=1812986");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=KONOBAR&top=1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=PRODAVA%c4%8c&top=1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=%c4%8cISTA%c4%8c&top=1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=KUHAR&top=1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=MEDICINSKA+SESTRA&top=1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=VOZA%c4%8c&top=1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=ODGOJITELJ&top=1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=POMO%c4%86NI+KUHAR&top=1");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burzarada.hzz.hr/Posloprimac_RadnaMjesta.aspx?trazi=1&pojam=NJEGOVATELJ&top=1");
        }
    }
}
