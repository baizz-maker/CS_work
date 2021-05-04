using System;
using System.Threading;
using System.Windows.Forms;

namespace homework9
{
    public partial class baseForm : Form
    {


        Crawler myCrawler = new Crawler();
        string startUrl = "https://www.baidu.com";

        public baseForm()
        {
            InitializeComponent();
            myCrawler.InfoTextChange += PrintInfo;
        }

        private void PrintInfo(string info)
        {
            Action action = () => info_textBox.AppendText(info);
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }



        private void start_btn_Click(object sender, EventArgs e)
        {

            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
            result_FileDialog.InitialDirectory = @"C:\Users\86187\source\repos\homework9\homework9\bin\Debug";
            result_FileDialog.ShowDialog();
        }

        private void target_textBox_TextChanged(object sender, EventArgs e)
        {

            startUrl = target_textBox.Text;
        }

        private void depth_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myCrawler.depth = int.Parse(depth_textBox.Text);
            }

            catch(Exception ex)
            {
                MessageBox.Show("DEPTH INPUT ERROR");
            }
        }
    }
}
