using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework6;

namespace homework8
{
    public partial class DefaultForm : Form
    {
        public OrderService service { get; set; } = new OrderService();
        public DefaultForm()
        {
            InitializeComponent();
            Product p1 = new Product("1", "10", "toy");
            Product p2 = new Product("2", "20", "cooker");
            Product p3 = new Product("3", "30", "e-card");
            Order order1 = new Order("1");
            Order order2 = new Order("8848");
            Order order3 = new Order("233");
            Order order4 = new Order("13");
            order1.addProduct(p1);
            order1.addProduct(p3);
            order2.addProduct(p2);
            order3.addProduct(p2);
            order3.addProduct(p1);
            order4.addProduct(p3);

            
            service.addOrder(order1);
            service.addOrder(order2);
            service.addOrder(order3);
            service.addOrder(order4);
            orderservicebindingSource.DataSource = service;

        }

        public void DataGridViewEdit(OrderService source)
        {
            orderservicebindingSource.DataSource = source;
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inspectidtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inspectbutton_Click(object sender, EventArgs e)
        {
            OrderService tempservice = new OrderService();
            Order currentorder = service.searchOrder(inspectidtextBox.Text);
            tempservice.addOrder(currentorder);
            orderservicebindingSource.DataSource = tempservice;
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
