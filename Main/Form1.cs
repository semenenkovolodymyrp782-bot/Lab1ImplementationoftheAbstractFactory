using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ATableFactory factory;
        ADining_tables aDining_Tables;
        ACoffee_tables aCoffee_Tables;
        AWriting_desks aWriting_Desks;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
