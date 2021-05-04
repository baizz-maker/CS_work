
namespace homework9
{
    partial class baseForm
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
            this.target_textBox = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.depth_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // target_textBox
            // 
            this.target_textBox.Location = new System.Drawing.Point(181, 82);
            this.target_textBox.Name = "target_textBox";
            this.target_textBox.Size = new System.Drawing.Size(461, 25);
            this.target_textBox.TabIndex = 0;
            this.target_textBox.TextChanged += new System.EventHandler(this.target_textBox_TextChanged);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(713, 84);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target";
            // 
            // result_FileDialog
            // 
            this.result_FileDialog.FileName = "0";
            // 
            // info_textBox
            // 
            this.info_textBox.Location = new System.Drawing.Point(94, 155);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info_textBox.Size = new System.Drawing.Size(652, 247);
            this.info_textBox.TabIndex = 3;
            // 
            // depth_textBox
            // 
            this.depth_textBox.Location = new System.Drawing.Point(181, 121);
            this.depth_textBox.Name = "depth_textBox";
            this.depth_textBox.Size = new System.Drawing.Size(100, 25);
            this.depth_textBox.TabIndex = 4;
            this.depth_textBox.TextChanged += new System.EventHandler(this.depth_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depth";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depth_textBox);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.target_textBox);
            this.Name = "baseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox target_textBox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog result_FileDialog;
        private System.Windows.Forms.TextBox info_textBox;
        private System.Windows.Forms.TextBox depth_textBox;
        private System.Windows.Forms.Label label2;
    }
}

