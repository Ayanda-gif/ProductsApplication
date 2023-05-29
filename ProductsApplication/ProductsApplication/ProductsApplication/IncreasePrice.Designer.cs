namespace ProductsApplication
{
    partial class IncreasePrice
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
            this.lblProductIC2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProduct2 = new System.Windows.Forms.TextBox();
            this.txtincrease = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductIC2
            // 
            this.lblProductIC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductIC2.Location = new System.Drawing.Point(33, 111);
            this.lblProductIC2.Name = "lblProductIC2";
            this.lblProductIC2.Size = new System.Drawing.Size(100, 23);
            this.lblProductIC2.TabIndex = 0;
            this.lblProductIC2.Text = "Product ID";
            this.lblProductIC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(33, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "% Increase";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct2
            // 
            this.txtProduct2.Location = new System.Drawing.Point(139, 114);
            this.txtProduct2.Name = "txtProduct2";
            this.txtProduct2.Size = new System.Drawing.Size(100, 20);
            this.txtProduct2.TabIndex = 2;
            // 
            // txtincrease
            // 
            this.txtincrease.Location = new System.Drawing.Point(139, 151);
            this.txtincrease.Name = "txtincrease";
            this.txtincrease.Size = new System.Drawing.Size(100, 20);
            this.txtincrease.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(80, 217);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Chnge Price";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // IncreasePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtincrease);
            this.Controls.Add(this.txtProduct2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductIC2);
            this.Name = "IncreasePrice";
            this.Text = "IncreasePrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductIC2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProduct2;
        private System.Windows.Forms.TextBox txtincrease;
        private System.Windows.Forms.Button btnChange;
    }
}