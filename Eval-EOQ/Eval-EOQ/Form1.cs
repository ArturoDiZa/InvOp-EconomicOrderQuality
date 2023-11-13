using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eval_EOQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void Q()
        {
            nudQ.Value = Math.Ceiling((decimal)Math.Sqrt(2 * (double)nudD.Value * (double)nudK.Value / (double)nudH.Value));
        }
        public void N()
        {
            Q();
            nudN.Value=Math.Ceiling((nudD.Value / nudQ.Value));
        }
        public void Dd()
        {
           nudDd.Value=Math.Ceiling(nudD.Value / nudDias.Value);
        }
        public void T()
        {
            N();
            nudT.Value=nudDias.Value / nudN.Value;
        }
        public void R()
        {
            Dd();
            nudR.Value = nudDd.Value*nudL.Value;
        }
        public void TC()
        {
            Q();
            nudTC.Value = nudD.Value * nudC.Value + (nudD.Value / nudQ.Value) * nudK.Value + (nudQ.Value / 2) * nudH.Value;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            nudD.Value = nudD.Minimum; 
            nudC.Value = nudC.Minimum;
            nudK.Value = nudK.Minimum;
            nudL.Value = nudL.Minimum;
            nudH.Value = nudH.Minimum;
            nudDias.Value = 360;
            nudDd.Value = nudN.Value= nudQ.Value=nudR.Value=nudT.Value=nudTC.Value=0;
        }

        private void btnCalcularQ_Click(object sender, EventArgs e)
        {
            Q();
        }

        private void btnCalcularD_Click(object sender, EventArgs e)
        {
            Dd() ;
        }

        private void btnCalcularN_Click(object sender, EventArgs e)
        {
            N() ;
        }

        private void btnCalcularR_Click(object sender, EventArgs e)
        {
            R();
        }

        private void btnCalcularT_Click(object sender, EventArgs e)
        {
            T();
        }

        private void btnCalcularTodo_Click(object sender, EventArgs e)
        {
            R();
            T();
            TC();
        }

        private void btnCalcularTC_Click(object sender, EventArgs e)
        {
            TC();
        }
    }
}
