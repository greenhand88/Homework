
namespace homework8
{
    partial class Success
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
            this.success1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // success1
            // 
            this.success1.AutoSize = true;
            this.success1.Location = new System.Drawing.Point(73, 44);
            this.success1.Name = "success1";
            this.success1.Size = new System.Drawing.Size(37, 15);
            this.success1.TabIndex = 0;
            this.success1.Text = "成功";
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 104);
            this.Controls.Add(this.success1);
            this.Name = "Success";
            this.Text = "Success";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label success1;
    }
}