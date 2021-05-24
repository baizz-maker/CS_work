
namespace homework11
{
    partial class DefaultForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderreviewdataGridView = new System.Windows.Forms.DataGridView();
            this.orderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.switchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inspectbutton = new System.Windows.Forms.Button();
            this.inspectidtextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderreviewdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderreviewdataGridView
            // 
            this.orderreviewdataGridView.AllowUserToOrderColumns = true;
            this.orderreviewdataGridView.AutoGenerateColumns = false;
            this.orderreviewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderreviewdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderreviewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderreviewdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderreviewdataGridView.DataSource = this.orderbindingSource;
            this.orderreviewdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderreviewdataGridView.Location = new System.Drawing.Point(0, 104);
            this.orderreviewdataGridView.Name = "orderreviewdataGridView";
            this.orderreviewdataGridView.RowHeadersWidth = 60;
            this.orderreviewdataGridView.RowTemplate.Height = 27;
            this.orderreviewdataGridView.Size = new System.Drawing.Size(800, 346);
            this.orderreviewdataGridView.TabIndex = 0;
            this.orderreviewdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderbindingSource
            // 
            this.orderbindingSource.DataSource = typeof(homework11.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.switchbutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inspectbutton);
            this.panel1.Controls.Add(this.inspectidtextBox);
            this.panel1.Controls.Add(this.orderreviewdataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // switchbutton
            // 
            this.switchbutton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchbutton.Location = new System.Drawing.Point(655, 25);
            this.switchbutton.Name = "switchbutton";
            this.switchbutton.Size = new System.Drawing.Size(106, 41);
            this.switchbutton.TabIndex = 4;
            this.switchbutton.Text = "Edit Order";
            this.switchbutton.UseVisualStyleBackColor = true;
            this.switchbutton.Click += new System.EventHandler(this.switchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "InspectID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inspectbutton
            // 
            this.inspectbutton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectbutton.Location = new System.Drawing.Point(371, 25);
            this.inspectbutton.Name = "inspectbutton";
            this.inspectbutton.Size = new System.Drawing.Size(113, 41);
            this.inspectbutton.TabIndex = 2;
            this.inspectbutton.Text = "Search!";
            this.inspectbutton.UseVisualStyleBackColor = true;
            this.inspectbutton.Click += new System.EventHandler(this.inspectbutton_Click);
            // 
            // inspectidtextBox
            // 
            this.inspectidtextBox.Location = new System.Drawing.Point(12, 33);
            this.inspectidtextBox.Name = "inspectidtextBox";
            this.inspectidtextBox.Size = new System.Drawing.Size(338, 25);
            this.inspectidtextBox.TabIndex = 1;
            this.inspectidtextBox.TextChanged += new System.EventHandler(this.inspectidtextBox_TextChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn7.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DefaultForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orderreviewdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource orderbindingSource;
        private System.Windows.Forms.DataGridView orderreviewdataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inspectbutton;
        private System.Windows.Forms.TextBox inspectidtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button switchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}

