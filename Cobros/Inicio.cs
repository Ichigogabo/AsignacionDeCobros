

using Cobros.BLL.Service;
using System.Windows.Forms;

namespace Cobros
{
    public partial class Inicio : Form
    {
        private Service service = new Service();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.ListarbySP();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}