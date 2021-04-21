
namespace homework8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.TextBox();
            this.create_done_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "订单ID:";
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(259, 153);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(306, 25);
            this.order_id.TabIndex = 8;
            // 
            // create_done_button
            // 
            this.create_done_button.Location = new System.Drawing.Point(524, 239);
            this.create_done_button.Name = "create_done_button";
            this.create_done_button.Size = new System.Drawing.Size(75, 23);
            this.create_done_button.TabIndex = 13;
            this.create_done_button.Text = "Done";
            this.create_done_button.UseVisualStyleBackColor = true;
            this.create_done_button.Click += new System.EventHandler(this.create_done_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 331);
            this.Controls.Add(this.create_done_button);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.Button create_done_button;
    }
}