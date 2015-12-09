using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OfficersInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oficersDataSet.S_dolgn". При необходимости она может быть перемещена или удалена.
            this.s_dolgnTableAdapter.Fill(this.oficersDataSet.S_dolgn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oficersDataSet.Officers". При необходимости она может быть перемещена или удалена.
            this.officersTableAdapter.Fill(this.oficersDataSet.Officers);

        }
    }
}
