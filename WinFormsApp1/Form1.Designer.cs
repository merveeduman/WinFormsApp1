﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            buton3 = new Button();
            böl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(51, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "topla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 261);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "çıkar";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buton3
            // 
            buton3.DialogResult = DialogResult.TryAgain;
            buton3.Location = new Point(314, 261);
            buton3.Name = "buton3";
            buton3.Size = new Size(94, 29);
            buton3.TabIndex = 4;
            buton3.Text = "çarp";
            buton3.UseVisualStyleBackColor = true;
            buton3.Click += button3_Click;
            // 
            // böl
            // 
            böl.Location = new Point(458, 261);
            böl.Name = "böl";
            böl.Size = new Size(94, 29);
            böl.TabIndex = 5;
            böl.Text = "böl";
            böl.UseVisualStyleBackColor = true;
            böl.Click += böl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 370);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Sonuç";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 117);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "1.Sayıyı Giriniz:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 171);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 8;
            label3.Text = "2.Sayıyı Giriniz:";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 492);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(böl);
            Controls.Add(buton3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button buton3;
        private Button böl;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
