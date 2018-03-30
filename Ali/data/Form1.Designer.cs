﻿namespace data
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkWz15 = new System.Windows.Forms.CheckBox();
            this.checkWz20 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkWz25 = new System.Windows.Forms.CheckBox();
            this.checkWz30 = new System.Windows.Forms.CheckBox();
            this.checkWz35 = new System.Windows.Forms.CheckBox();
            this.checkWzT = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnGraphiek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 249);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1625, 479);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Huisprijzen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Werkzoekende";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Weereffecten";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkWz15
            // 
            this.checkWz15.AutoSize = true;
            this.checkWz15.Location = new System.Drawing.Point(1643, 307);
            this.checkWz15.Name = "checkWz15";
            this.checkWz15.Size = new System.Drawing.Size(123, 21);
            this.checkWz15.TabIndex = 4;
            this.checkWz15.Text = "15-25 jaar oud";
            this.checkWz15.UseVisualStyleBackColor = true;
            this.checkWz15.CheckedChanged += new System.EventHandler(this.checkWz15_CheckedChanged);
            // 
            // checkWz20
            // 
            this.checkWz20.AutoSize = true;
            this.checkWz20.Location = new System.Drawing.Point(1643, 334);
            this.checkWz20.Name = "checkWz20";
            this.checkWz20.Size = new System.Drawing.Size(123, 21);
            this.checkWz20.TabIndex = 5;
            this.checkWz20.Text = "25-35 jaar oud";
            this.checkWz20.UseVisualStyleBackColor = true;
            this.checkWz20.CheckedChanged += new System.EventHandler(this.checkWz20_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1643, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Leeftijd";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkWz25
            // 
            this.checkWz25.AutoSize = true;
            this.checkWz25.Location = new System.Drawing.Point(1643, 361);
            this.checkWz25.Name = "checkWz25";
            this.checkWz25.Size = new System.Drawing.Size(123, 21);
            this.checkWz25.TabIndex = 7;
            this.checkWz25.Text = "35-45 jaar oud";
            this.checkWz25.UseVisualStyleBackColor = true;
            this.checkWz25.CheckedChanged += new System.EventHandler(this.checkWz25_CheckedChanged);
            // 
            // checkWz30
            // 
            this.checkWz30.AutoSize = true;
            this.checkWz30.Location = new System.Drawing.Point(1643, 388);
            this.checkWz30.Name = "checkWz30";
            this.checkWz30.Size = new System.Drawing.Size(123, 21);
            this.checkWz30.TabIndex = 8;
            this.checkWz30.Text = "45-55 jaar oud";
            this.checkWz30.UseVisualStyleBackColor = true;
            this.checkWz30.CheckedChanged += new System.EventHandler(this.checkWz30_CheckedChanged);
            // 
            // checkWz35
            // 
            this.checkWz35.AutoSize = true;
            this.checkWz35.Location = new System.Drawing.Point(1643, 415);
            this.checkWz35.Name = "checkWz35";
            this.checkWz35.Size = new System.Drawing.Size(123, 21);
            this.checkWz35.TabIndex = 9;
            this.checkWz35.Text = "55-65 jaar oud";
            this.checkWz35.UseVisualStyleBackColor = true;
            this.checkWz35.CheckedChanged += new System.EventHandler(this.checkWz35_CheckedChanged);
            // 
            // checkWzT
            // 
            this.checkWzT.AutoSize = true;
            this.checkWzT.Location = new System.Drawing.Point(1643, 280);
            this.checkWzT.Name = "checkWzT";
            this.checkWzT.Size = new System.Drawing.Size(139, 21);
            this.checkWzT.TabIndex = 15;
            this.checkWzT.Text = "Totaal overvallen";
            this.checkWzT.UseVisualStyleBackColor = true;
            this.checkWzT.CheckedChanged += new System.EventHandler(this.checkWzT_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 220);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(33, 23);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(51, 220);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(33, 23);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(90, 220);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(33, 23);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(129, 220);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(33, 23);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(168, 220);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 23);
            this.btn5.TabIndex = 22;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(285, 220);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(33, 23);
            this.btn8.TabIndex = 25;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(246, 220);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 23);
            this.btn7.TabIndex = 24;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(207, 220);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(33, 23);
            this.btn6.TabIndex = 23;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(13, 191);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(110, 23);
            this.btnZoom.TabIndex = 26;
            this.btnZoom.Text = "Zoom uit";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click_1);
            // 
            // btnGraphiek
            // 
            this.btnGraphiek.Location = new System.Drawing.Point(129, 191);
            this.btnGraphiek.Name = "btnGraphiek";
            this.btnGraphiek.Size = new System.Drawing.Size(111, 23);
            this.btnGraphiek.TabIndex = 27;
            this.btnGraphiek.Text = "Graphiek";
            this.btnGraphiek.UseVisualStyleBackColor = true;
            this.btnGraphiek.Click += new System.EventHandler(this.btnGraphiek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.btnGraphiek);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.checkWzT);
            this.Controls.Add(this.checkWz35);
            this.Controls.Add(this.checkWz30);
            this.Controls.Add(this.checkWz25);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkWz20);
            this.Controls.Add(this.checkWz15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkWz15;
        private System.Windows.Forms.CheckBox checkWz20;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkWz25;
        private System.Windows.Forms.CheckBox checkWz30;
        private System.Windows.Forms.CheckBox checkWz35;
        private System.Windows.Forms.CheckBox checkWzT;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnGraphiek;
    }
}

