
namespace homework8
{
    partial class number
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.output_order_button = new System.Windows.Forms.Button();
            this.input_order_button = new System.Windows.Forms.Button();
            this.search_order_button = new System.Windows.Forms.Button();
            this.change_details_button = new System.Windows.Forms.Button();
            this.delete_order_button = new System.Windows.Forms.Button();
            this.creat_order_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goods_id = new System.Windows.Forms.TextBox();
            this.goods_name = new System.Windows.Forms.TextBox();
            this.goods_price = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.telenumber = new System.Windows.Forms.TextBox();
            this.numer = new System.Windows.Forms.NumericUpDown();
            this.show_all_order_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.output_order_button);
            this.panel1.Controls.Add(this.input_order_button);
            this.panel1.Controls.Add(this.search_order_button);
            this.panel1.Controls.Add(this.change_details_button);
            this.panel1.Controls.Add(this.delete_order_button);
            this.panel1.Controls.Add(this.creat_order_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // output_order_button
            // 
            this.output_order_button.Location = new System.Drawing.Point(41, 381);
            this.output_order_button.Name = "output_order_button";
            this.output_order_button.Size = new System.Drawing.Size(104, 40);
            this.output_order_button.TabIndex = 5;
            this.output_order_button.Text = "Output Order";
            this.output_order_button.UseVisualStyleBackColor = true;
            this.output_order_button.Click += new System.EventHandler(this.output_order_button_Click);
            // 
            // input_order_button
            // 
            this.input_order_button.Location = new System.Drawing.Point(41, 312);
            this.input_order_button.Name = "input_order_button";
            this.input_order_button.Size = new System.Drawing.Size(104, 46);
            this.input_order_button.TabIndex = 4;
            this.input_order_button.Text = "Input Order";
            this.input_order_button.UseVisualStyleBackColor = true;
            this.input_order_button.Click += new System.EventHandler(this.input_order_button_Click);
            // 
            // search_order_button
            // 
            this.search_order_button.Location = new System.Drawing.Point(41, 242);
            this.search_order_button.Name = "search_order_button";
            this.search_order_button.Size = new System.Drawing.Size(104, 38);
            this.search_order_button.TabIndex = 3;
            this.search_order_button.Text = "Search";
            this.search_order_button.UseVisualStyleBackColor = true;
            this.search_order_button.Click += new System.EventHandler(this.search_order_button_Click);
            // 
            // change_details_button
            // 
            this.change_details_button.Location = new System.Drawing.Point(41, 167);
            this.change_details_button.Name = "change_details_button";
            this.change_details_button.Size = new System.Drawing.Size(104, 38);
            this.change_details_button.TabIndex = 2;
            this.change_details_button.Text = "Change Details";
            this.change_details_button.UseVisualStyleBackColor = true;
            this.change_details_button.Click += new System.EventHandler(this.change_details_button_Click);
            // 
            // delete_order_button
            // 
            this.delete_order_button.Location = new System.Drawing.Point(41, 102);
            this.delete_order_button.Name = "delete_order_button";
            this.delete_order_button.Size = new System.Drawing.Size(104, 38);
            this.delete_order_button.TabIndex = 1;
            this.delete_order_button.Text = "Delete Order";
            this.delete_order_button.UseVisualStyleBackColor = true;
            this.delete_order_button.Click += new System.EventHandler(this.delete_order_button_Click);
            // 
            // creat_order_button
            // 
            this.creat_order_button.Location = new System.Drawing.Point(41, 37);
            this.creat_order_button.Name = "creat_order_button";
            this.creat_order_button.Size = new System.Drawing.Size(104, 38);
            this.creat_order_button.TabIndex = 0;
            this.creat_order_button.Text = "Creat Order";
            this.creat_order_button.UseVisualStyleBackColor = true;
            this.creat_order_button.Click += new System.EventHandler(this.creat_order_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "订单ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "顾客姓名:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(237, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "手机号:";
            // 
            // goods_id
            // 
            this.goods_id.Location = new System.Drawing.Point(358, 46);
            this.goods_id.Name = "goods_id";
            this.goods_id.Size = new System.Drawing.Size(306, 25);
            this.goods_id.TabIndex = 7;
            // 
            // goods_name
            // 
            this.goods_name.Location = new System.Drawing.Point(358, 104);
            this.goods_name.Name = "goods_name";
            this.goods_name.Size = new System.Drawing.Size(202, 25);
            this.goods_name.TabIndex = 8;
            // 
            // goods_price
            // 
            this.goods_price.Location = new System.Drawing.Point(358, 167);
            this.goods_price.Name = "goods_price";
            this.goods_price.Size = new System.Drawing.Size(67, 25);
            this.goods_price.TabIndex = 9;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(358, 325);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(76, 25);
            this.customer_name.TabIndex = 11;
            // 
            // telenumber
            // 
            this.telenumber.Location = new System.Drawing.Point(358, 391);
            this.telenumber.Name = "telenumber";
            this.telenumber.Size = new System.Drawing.Size(306, 25);
            this.telenumber.TabIndex = 12;
            // 
            // numer
            // 
            this.numer.Location = new System.Drawing.Point(358, 243);
            this.numer.Name = "numer";
            this.numer.Size = new System.Drawing.Size(76, 25);
            this.numer.TabIndex = 13;
            this.numer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // show_all_order_button
            // 
            this.show_all_order_button.Location = new System.Drawing.Point(626, 205);
            this.show_all_order_button.Name = "show_all_order_button";
            this.show_all_order_button.Size = new System.Drawing.Size(151, 63);
            this.show_all_order_button.TabIndex = 14;
            this.show_all_order_button.Text = "Show All Order";
            this.show_all_order_button.UseVisualStyleBackColor = true;
            this.show_all_order_button.Click += new System.EventHandler(this.show_all_order_button_Click);
            // 
            // number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_all_order_button);
            this.Controls.Add(this.numer);
            this.Controls.Add(this.telenumber);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.goods_price);
            this.Controls.Add(this.goods_name);
            this.Controls.Add(this.goods_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "number";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button input_order_button;
        private System.Windows.Forms.Button search_order_button;
        private System.Windows.Forms.Button change_details_button;
        private System.Windows.Forms.Button delete_order_button;
        private System.Windows.Forms.Button creat_order_button;
        private System.Windows.Forms.Button output_order_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox goods_id;
        private System.Windows.Forms.TextBox goods_name;
        private System.Windows.Forms.TextBox goods_price;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.TextBox telenumber;
        private System.Windows.Forms.NumericUpDown numer;
        private System.Windows.Forms.Button show_all_order_button;
    }
}

