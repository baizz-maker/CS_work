using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace homework11
{
    public partial class DefaultForm : Form
    {
        public OrderService service { get; set; } = new OrderService();
        public DefaultForm()
        {
            InitializeComponent();
            
            

        }

        public void DataGridViewEdit(OrderService source)
        {
            service = source;
            orderbindingSource.DataSource = service.Orders;
            orderbindingSource.ResetBindings(false);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inspectidtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inspectbutton_Click(object sender, EventArgs e)
        {
            List<Order> currentorders = service.searchOrderByProduct(inspectidtextBox.Text);
            orderbindingSource.DataSource = currentorders;
            orderbindingSource.ResetBindings(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void switchbutton_Click(object sender, EventArgs e)
        {
            OrderEdit form2 = new OrderEdit(service, this);
            form2.Show();

        }
    }
}
