namespace StudentPerformanceTracker
{
    partial class SignIn
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
            this.userName_lbl = new System.Windows.Forms.Label();
            this.studentName_tb = new System.Windows.Forms.TextBox();
            this.login_title_lml = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.Location = new System.Drawing.Point(367, 264);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(112, 20);
            this.userName_lbl.TabIndex = 0;
            this.userName_lbl.Text = "Student Name";
            this.userName_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentName_tb
            // 
            this.studentName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_tb.Location = new System.Drawing.Point(307, 297);
            this.studentName_tb.Name = "studentName_tb";
            this.studentName_tb.Size = new System.Drawing.Size(234, 26);
            this.studentName_tb.TabIndex = 1;
            // 
            // login_title_lml
            // 
            this.login_title_lml.AutoSize = true;
            this.login_title_lml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_title_lml.Location = new System.Drawing.Point(257, 171);
            this.login_title_lml.Name = "login_title_lml";
            this.login_title_lml.Size = new System.Drawing.Size(328, 20);
            this.login_title_lml.TabIndex = 2;
            this.login_title_lml.Text = "University Student Performance Tracker";
            this.login_title_lml.Click += new System.EventHandler(this.yh_Click);
            // 
            // signIn_btn
            // 
            this.signIn_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.signIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_btn.Location = new System.Drawing.Point(370, 338);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(102, 29);
            this.signIn_btn.TabIndex = 3;
            this.signIn_btn.Text = "Sign in";
            this.signIn_btn.UseVisualStyleBackColor = false;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.login_title_lml);
            this.Controls.Add(this.studentName_tb);
            this.Controls.Add(this.userName_lbl);
            this.Name = "SignIn";
            this.Text = "Sign in | University Student performance Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.TextBox studentName_tb;
        private System.Windows.Forms.Label login_title_lml;
        private System.Windows.Forms.Button signIn_btn;
    }
}

