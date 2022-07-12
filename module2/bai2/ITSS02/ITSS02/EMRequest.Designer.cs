
namespace ITSS02
{
    partial class EMRequest
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbP = new System.Windows.Forms.ComboBox();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSent = new System.Windows.Forms.Button();
            this.lbDP = new System.Windows.Forms.Label();
            this.lbAN = new System.Windows.Forms.Label();
            this.lbASN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbP
            // 
            this.cmbP.FormattingEnabled = true;
            this.cmbP.Location = new System.Drawing.Point(110, 27);
            this.cmbP.Name = "cmbP";
            this.cmbP.Size = new System.Drawing.Size(315, 21);
            this.cmbP.TabIndex = 9;
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(110, 177);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(315, 20);
            this.txtOC.TabIndex = 8;
            // 
            // txtDE
            // 
            this.txtDE.Location = new System.Drawing.Point(110, 112);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(315, 20);
            this.txtDE.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = " Other Considerations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description of Emergency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbP);
            this.groupBox2.Controls.Add(this.txtOC);
            this.groupBox2.Controls.Add(this.txtDE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(28, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 231);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Report";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(262, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(163, 430);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(79, 23);
            this.btnSent.TabIndex = 8;
            this.btnSent.Text = "Send Report";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // lbDP
            // 
            this.lbDP.AutoSize = true;
            this.lbDP.Location = new System.Drawing.Point(454, 41);
            this.lbDP.Name = "lbDP";
            this.lbDP.Size = new System.Drawing.Size(35, 13);
            this.lbDP.TabIndex = 11;
            this.lbDP.Text = "label9";
            // 
            // lbAN
            // 
            this.lbAN.AutoSize = true;
            this.lbAN.Location = new System.Drawing.Point(263, 41);
            this.lbAN.Name = "lbAN";
            this.lbAN.Size = new System.Drawing.Size(35, 13);
            this.lbAN.TabIndex = 10;
            this.lbAN.Text = "label8";
            // 
            // lbASN
            // 
            this.lbASN.AutoSize = true;
            this.lbASN.Location = new System.Drawing.Point(117, 41);
            this.lbASN.Name = "lbASN";
            this.lbASN.Size = new System.Drawing.Size(35, 13);
            this.lbASN.TabIndex = 9;
            this.lbASN.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AssetName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "AssetSN:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDP);
            this.groupBox1.Controls.Add(this.lbAN);
            this.groupBox1.Controls.Add(this.lbASN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // EMRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSent);
            this.Name = "EMRequest";
            this.Text = "EMRequest";
            this.Load += new System.EventHandler(this.EMRequest_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbP;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label lbDP;
        private System.Windows.Forms.Label lbAN;
        private System.Windows.Forms.Label lbASN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}