namespace Project1
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
            this.start = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(705, 145);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Button1_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(269, 119);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(75, 75);
            this.A.TabIndex = 1;
            this.A.Text = "button2";
            this.A.UseVisualStyleBackColor = true;
            this.A.Visible = false;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(350, 119);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(75, 75);
            this.B.TabIndex = 2;
            this.B.Text = "button3";
            this.B.UseVisualStyleBackColor = true;
            this.B.Visible = false;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(437, 119);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 75);
            this.C.TabIndex = 3;
            this.C.Text = "button4";
            this.C.UseVisualStyleBackColor = true;
            this.C.Visible = false;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(518, 119);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(75, 75);
            this.D.TabIndex = 4;
            this.D.Text = "button5";
            this.D.UseVisualStyleBackColor = true;
            this.D.Visible = false;
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(599, 119);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(75, 75);
            this.E.TabIndex = 5;
            this.E.Text = "button6";
            this.E.UseVisualStyleBackColor = true;
            this.E.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(709, 343);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.start);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}