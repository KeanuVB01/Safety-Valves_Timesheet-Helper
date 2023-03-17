namespace JVBTimeApp
{
    partial class Form1
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
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxLunch = new System.Windows.Forms.CheckBox();
            this.cbxOpen = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cbxFriday = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtStartH = new System.Windows.Forms.TextBox();
            this.txtStartMin = new System.Windows.Forms.TextBox();
            this.txtEndH = new System.Windows.Forms.TextBox();
            this.txtEndM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(111, 207);
            this.label17.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 39);
            this.label17.TabIndex = 48;
            this.label17.Text = "Start";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(315, 207);
            this.label18.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 39);
            this.label18.TabIndex = 49;
            this.label18.Text = "End";
            // 
            // cbxLunch
            // 
            this.cbxLunch.AutoSize = true;
            this.cbxLunch.Checked = true;
            this.cbxLunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLunch.Location = new System.Drawing.Point(18, 22);
            this.cbxLunch.Margin = new System.Windows.Forms.Padding(9);
            this.cbxLunch.Name = "cbxLunch";
            this.cbxLunch.Size = new System.Drawing.Size(159, 35);
            this.cbxLunch.TabIndex = 50;
            this.cbxLunch.Text = "Lunch (-1)";
            this.cbxLunch.UseVisualStyleBackColor = true;
            // 
            // cbxOpen
            // 
            this.cbxOpen.AutoSize = true;
            this.cbxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOpen.Location = new System.Drawing.Point(18, 62);
            this.cbxOpen.Margin = new System.Windows.Forms.Padding(9);
            this.cbxOpen.Name = "cbxOpen";
            this.cbxOpen.Size = new System.Drawing.Size(158, 35);
            this.cbxOpen.TabIndex = 81;
            this.cbxOpen.Text = "Open (+2)";
            this.cbxOpen.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(37, 409);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(704, 282);
            this.txtOutput.TabIndex = 88;
            this.txtOutput.Text = "";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(37, 345);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(454, 58);
            this.btnCalc.TabIndex = 89;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cbxFriday
            // 
            this.cbxFriday.AutoSize = true;
            this.cbxFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFriday.Location = new System.Drawing.Point(18, 103);
            this.cbxFriday.Margin = new System.Windows.Forms.Padding(9);
            this.cbxFriday.Name = "cbxFriday";
            this.cbxFriday.Size = new System.Drawing.Size(112, 35);
            this.cbxFriday.TabIndex = 90;
            this.cbxFriday.Text = "Friday";
            this.cbxFriday.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(588, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 58);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtStartH
            // 
            this.txtStartH.Location = new System.Drawing.Point(89, 262);
            this.txtStartH.Name = "txtStartH";
            this.txtStartH.Size = new System.Drawing.Size(43, 55);
            this.txtStartH.TabIndex = 92;
            // 
            // txtStartMin
            // 
            this.txtStartMin.Location = new System.Drawing.Point(153, 262);
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(43, 55);
            this.txtStartMin.TabIndex = 93;
            // 
            // txtEndH
            // 
            this.txtEndH.Location = new System.Drawing.Point(308, 262);
            this.txtEndH.Name = "txtEndH";
            this.txtEndH.Size = new System.Drawing.Size(43, 55);
            this.txtEndH.TabIndex = 94;
            // 
            // txtEndM
            // 
            this.txtEndM.Location = new System.Drawing.Point(367, 262);
            this.txtEndM.Name = "txtEndM";
            this.txtEndM.Size = new System.Drawing.Size(43, 55);
            this.txtEndM.TabIndex = 95;
            this.txtEndM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 39);
            this.label1.TabIndex = 96;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 39);
            this.label2.TabIndex = 97;
            this.label2.Text = ":";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JVBTimeApp.Properties.Resources.jvb_logo;
            this.pictureBox1.Location = new System.Drawing.Point(265, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.cbxFriday);
            this.panel1.Controls.Add(this.cbxOpen);
            this.panel1.Controls.Add(this.cbxLunch);
            this.panel1.Location = new System.Drawing.Point(537, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 157);
            this.panel1.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 29);
            this.label3.TabIndex = 100;
            this.label3.Text = "*This software was built for Safety and Control Valves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 29);
            this.label4.TabIndex = 101;
            this.label4.Text = "*It does not represent the final product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 102;
            this.label5.Text = "Created by: Keanu Ver Burgh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(781, 727);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStartMin);
            this.Controls.Add(this.txtStartH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndM);
            this.Controls.Add(this.txtEndH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbxLunch;
        private System.Windows.Forms.CheckBox cbxOpen;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.CheckBox cbxFriday;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStartH;
        private System.Windows.Forms.TextBox txtStartMin;
        private System.Windows.Forms.TextBox txtEndH;
        private System.Windows.Forms.TextBox txtEndM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

