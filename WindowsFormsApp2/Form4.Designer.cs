namespace WindowsFormsApp2
{
    partial class Form4
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
            this.X1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LX2 = new System.Windows.Forms.TextBox();
            this.LY2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(105, 93);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(130, 22);
            this.X1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(304, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(463, 93);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(130, 22);
            this.Y1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LX2
            // 
            this.LX2.Location = new System.Drawing.Point(105, 177);
            this.LX2.Name = "LX2";
            this.LX2.Size = new System.Drawing.Size(130, 22);
            this.LX2.TabIndex = 5;
            // 
            // LY2
            // 
            this.LY2.Location = new System.Drawing.Point(463, 177);
            this.LY2.Name = "LY2";
            this.LY2.Size = new System.Drawing.Size(130, 22);
            this.LY2.TabIndex = 6;
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(102, 157);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(25, 17);
            this.X2.TabIndex = 7;
            this.X2.Text = "X2";
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(460, 157);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(25, 17);
            this.Y2.TabIndex = 8;
            this.Y2.Text = "Y2";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.LY2);
            this.Controls.Add(this.LX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Y1;
        public System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.Label Y2;
        public System.Windows.Forms.TextBox LX2;
        public System.Windows.Forms.TextBox LY2;
    }
}