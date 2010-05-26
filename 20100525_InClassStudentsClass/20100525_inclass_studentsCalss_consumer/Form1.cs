using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20100525_inclass_studentsCalss_consumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                _20100525_InClassStudentsClass.Student[] mystudents = new _20100525_InClassStudentsClass.Student[10];
                _20100525_InClassStudentsClass.Course myCourse = new _20100525_InClassStudentsClass.Course();
                mystudents = myCourse.students;

                mystudents[0].dnumber = "Jason was where?";
                MessageBox.Show(mystudents[0].dnumber);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
