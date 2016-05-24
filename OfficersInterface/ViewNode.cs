using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfficersInterface
{
    public partial class ViewNode : Form
    {
        public ViewNode()
        {
            InitializeComponent();
        }

        private void NvbTB_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT FIO, Birth_D, Zvan, Dolgn, Stag FROM dbo.Officers where Nvb = @Nvb";
            SqlCommand command = new SqlCommand(query);
            
            officersTableAdapter.
           // officersTableAdapter.GetDataBy(NvbTB.Text);
        }

        private void ViewNode_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officers.S_zvan". При необходимости она может быть перемещена или удалена.
            this.s_zvanTableAdapter.Fill(this.officers.S_zvan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officers._Officers". При необходимости она может быть перемещена или удалена.
            this.officersTableAdapter.Fill(this.officers._Officers);

        }
    }
}
