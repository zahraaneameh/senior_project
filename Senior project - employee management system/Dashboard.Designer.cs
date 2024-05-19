namespace Senior_project___employee_management_system
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboard_TE = new System.Windows.Forms.Label();
            this.dashboard_DA = new System.Windows.Forms.Label();
            this.dashboard_WD = new System.Windows.Forms.Label();
            this.dashboard_DB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 172);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(21, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 334);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.dashboard_TE);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(28, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 119);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.dashboard_DA);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(217, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 119);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel5.Controls.Add(this.dashboard_WD);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(410, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 119);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel6.Controls.Add(this.dashboard_DB);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(598, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 119);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " Total Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Analytics Trainers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Web Development Trainers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Base Trainers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dashboard_TE
            // 
            this.dashboard_TE.AutoSize = true;
            this.dashboard_TE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TE.ForeColor = System.Drawing.Color.White;
            this.dashboard_TE.Location = new System.Drawing.Point(73, 24);
            this.dashboard_TE.Name = "dashboard_TE";
            this.dashboard_TE.Size = new System.Drawing.Size(18, 19);
            this.dashboard_TE.TabIndex = 2;
            this.dashboard_TE.Text = "0";
            // 
            // dashboard_DA
            // 
            this.dashboard_DA.AutoSize = true;
            this.dashboard_DA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_DA.ForeColor = System.Drawing.Color.White;
            this.dashboard_DA.Location = new System.Drawing.Point(66, 89);
            this.dashboard_DA.Name = "dashboard_DA";
            this.dashboard_DA.Size = new System.Drawing.Size(18, 19);
            this.dashboard_DA.TabIndex = 3;
            this.dashboard_DA.Text = "0";
            // 
            // dashboard_WD
            // 
            this.dashboard_WD.AutoSize = true;
            this.dashboard_WD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_WD.ForeColor = System.Drawing.Color.White;
            this.dashboard_WD.Location = new System.Drawing.Point(76, 86);
            this.dashboard_WD.Name = "dashboard_WD";
            this.dashboard_WD.Size = new System.Drawing.Size(18, 19);
            this.dashboard_WD.TabIndex = 4;
            this.dashboard_WD.Text = "0";
            // 
            // dashboard_DB
            // 
            this.dashboard_DB.AutoSize = true;
            this.dashboard_DB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_DB.ForeColor = System.Drawing.Color.White;
            this.dashboard_DB.Location = new System.Drawing.Point(75, 86);
            this.dashboard_DB.Name = "dashboard_DB";
            this.dashboard_DB.Size = new System.Drawing.Size(18, 19);
            this.dashboard_DB.TabIndex = 5;
            this.dashboard_DB.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(855, 565);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashboard_DB;
        private System.Windows.Forms.Label dashboard_WD;
        private System.Windows.Forms.Label dashboard_DA;
        private System.Windows.Forms.Label dashboard_TE;
    }
}
