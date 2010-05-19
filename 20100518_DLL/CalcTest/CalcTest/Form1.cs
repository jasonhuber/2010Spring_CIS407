using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SimpleDLL.Calc myCalc = new SimpleDLL.Calc();
            MessageBox.Show(myCalc.Divide(3,0).ToString());

//            Calcws.CalcWS myCalcWS = new Calcws.CalcWS();
  //          MessageBox.Show(myCalcWS.Add(5, 3));
        }
    }
}
