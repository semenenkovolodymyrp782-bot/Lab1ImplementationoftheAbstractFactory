using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Windows.Forms;

namespace Table_FactoryApp
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
            comboBox1.Items.Add("Glass");
            comboBox1.Items.Add("Metal");
            comboBox1.Items.Add("Wood");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: factory = new Glass_Table_Factory(); break;
                case 1: factory = new Metal_Table_Factory(); break;
                case 2: factory = new Wooden_Table_Factory(); break;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (factory != null)
            {
                aDining_Tables = factory.createADining_tables();
                MessageBox.Show(aDining_Tables.GetInfo());
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                aCoffee_Tables = factory.createACoffee_tables();
                MessageBox.Show(aCoffee_Tables.GetInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                aWriting_Desks = factory.createAWriting_desks();
                MessageBox.Show(aWriting_Desks.GetInfo());
            }

        }
    }
}
