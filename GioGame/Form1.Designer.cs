namespace GioGame
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
            this.components = new System.ComponentModel.Container();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Number3 = new System.Windows.Forms.Label();
            this.Number4 = new System.Windows.Forms.Label();
            this.Number5 = new System.Windows.Forms.Label();
            this.Number6 = new System.Windows.Forms.Label();
            this.Number7 = new System.Windows.Forms.Label();
            this.Number8 = new System.Windows.Forms.Label();
            this.Number9 = new System.Windows.Forms.Label();
            this.MyRes = new System.Windows.Forms.Label();
            this.CompRes = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Bksp = new System.Windows.Forms.Button();
            this.RParen = new System.Windows.Forms.Button();
            this.LParen = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.TimerCountDown = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(227, 351);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(197, 89);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Looking for number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(15, 588);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 72);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your answer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Computer answer:";
            // 
            // CountDown
            // 
            this.CountDown.Interval = 1000;
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(15, 693);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(608, 72);
            this.textBox2.TabIndex = 11;
            // 
            // Number1
            // 
            this.Number1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number1.Font = new System.Drawing.Font("Times New Roman", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(226, 118);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(90, 90);
            this.Number1.TabIndex = 15;
            this.Number1.Text = "#";
            this.Number1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            this.Number2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number2.Font = new System.Drawing.Font("Times New Roman", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Number2.Location = new System.Drawing.Point(322, 118);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(90, 90);
            this.Number2.TabIndex = 16;
            this.Number2.Text = "#";
            this.Number2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number3
            // 
            this.Number3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number3.Font = new System.Drawing.Font("Times New Roman", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Number3.Location = new System.Drawing.Point(418, 118);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(90, 90);
            this.Number3.TabIndex = 17;
            this.Number3.Text = "#";
            this.Number3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // Number4
            // 
            this.Number4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number4.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number4.Location = new System.Drawing.Point(11, 227);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(90, 90);
            this.Number4.TabIndex = 18;
            this.Number4.Text = "#";
            this.Number4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number5
            // 
            this.Number5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number5.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number5.Location = new System.Drawing.Point(117, 227);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(90, 90);
            this.Number5.TabIndex = 19;
            this.Number5.Text = "#";
            this.Number5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number6
            // 
            this.Number6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number6.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number6.Location = new System.Drawing.Point(226, 227);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(90, 90);
            this.Number6.TabIndex = 20;
            this.Number6.Text = "#";
            this.Number6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number7
            // 
            this.Number7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number7.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number7.Location = new System.Drawing.Point(333, 227);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(90, 90);
            this.Number7.TabIndex = 21;
            this.Number7.Text = "#";
            this.Number7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number8
            // 
            this.Number8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number8.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number8.Location = new System.Drawing.Point(442, 227);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(135, 90);
            this.Number8.TabIndex = 22;
            this.Number8.Text = "#";
            this.Number8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number9
            // 
            this.Number9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number9.Font = new System.Drawing.Font("Times New Roman", 34.2F, System.Drawing.FontStyle.Italic);
            this.Number9.Location = new System.Drawing.Point(595, 227);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(135, 90);
            this.Number9.TabIndex = 23;
            this.Number9.Text = "#";
            this.Number9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // MyRes
            // 
            this.MyRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyRes.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.MyRes.Location = new System.Drawing.Point(640, 588);
            this.MyRes.Name = "MyRes";
            this.MyRes.Size = new System.Drawing.Size(90, 72);
            this.MyRes.TabIndex = 24;
            this.MyRes.Text = "       ";
            this.MyRes.Click += new System.EventHandler(this.MyRes_Click);
            // 
            // CompRes
            // 
            this.CompRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompRes.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.CompRes.Location = new System.Drawing.Point(640, 693);
            this.CompRes.Name = "CompRes";
            this.CompRes.Size = new System.Drawing.Size(90, 72);
            this.CompRes.TabIndex = 25;
            this.CompRes.Text = "       ";
            this.CompRes.Click += new System.EventHandler(this.CompRes_Click);
            // 
            // Restart
            // 
            this.Restart.Image = global::GioGame.Properties.Resources.refresh_icon_free_vector;
            this.Restart.Location = new System.Drawing.Point(532, 30);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(90, 90);
            this.Restart.TabIndex = 27;
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Bksp
            // 
            this.Bksp.Image = global::GioGame.Properties.Resources.backspace_icon_symbol_design_illustration_vector;
            this.Bksp.Location = new System.Drawing.Point(640, 459);
            this.Bksp.Name = "Bksp";
            this.Bksp.Size = new System.Drawing.Size(90, 90);
            this.Bksp.TabIndex = 26;
            this.Bksp.UseVisualStyleBackColor = true;
            this.Bksp.Click += new System.EventHandler(this.Bksp_Click);
            // 
            // RParen
            // 
            this.RParen.Image = global::GioGame.Properties.Resources.download1;
            this.RParen.Location = new System.Drawing.Point(533, 459);
            this.RParen.Name = "RParen";
            this.RParen.Size = new System.Drawing.Size(90, 90);
            this.RParen.TabIndex = 13;
            this.RParen.UseVisualStyleBackColor = true;
            this.RParen.Click += new System.EventHandler(this.RParen_Click);
            // 
            // LParen
            // 
            this.LParen.Image = global::GioGame.Properties.Resources.rparen;
            this.LParen.Location = new System.Drawing.Point(432, 459);
            this.LParen.Name = "LParen";
            this.LParen.Size = new System.Drawing.Size(90, 90);
            this.LParen.TabIndex = 12;
            this.LParen.UseVisualStyleBackColor = true;
            this.LParen.Click += new System.EventHandler(this.LParen_Click);
            // 
            // Plus
            // 
            this.Plus.Image = global::GioGame.Properties.Resources.plus_icon_icons;
            this.Plus.Location = new System.Drawing.Point(12, 459);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(90, 90);
            this.Plus.TabIndex = 8;
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Image = global::GioGame.Properties.Resources.free_minus_icon_3108_thumb;
            this.Minus.Location = new System.Drawing.Point(118, 459);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(90, 90);
            this.Minus.TabIndex = 7;
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.button6_Click);
            // 
            // Multiply
            // 
            this.Multiply.Image = global::GioGame.Properties.Resources.download;
            this.Multiply.Location = new System.Drawing.Point(227, 459);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(90, 90);
            this.Multiply.TabIndex = 6;
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Devide
            // 
            this.Devide.Image = global::GioGame.Properties.Resources._10015260;
            this.Devide.Location = new System.Drawing.Point(331, 459);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(90, 90);
            this.Devide.TabIndex = 5;
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.Devide_Click);
            // 
            // Finish
            // 
            this.Finish.Image = global::GioGame.Properties.Resources.check_mark_simple_flat_icon_illustration_check_icon_vector;
            this.Finish.Location = new System.Drawing.Point(639, 30);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(90, 90);
            this.Finish.TabIndex = 4;
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerCountDown.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold);
            this.TimerCountDown.Location = new System.Drawing.Point(595, 351);
            this.TimerCountDown.Name = "TimerCountDown";
            this.TimerCountDown.Size = new System.Drawing.Size(135, 90);
            this.TimerCountDown.TabIndex = 28;
            this.TimerCountDown.Text = "       ";
            this.TimerCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerCountDown.Click += new System.EventHandler(this.TimerCountDown_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Time:";
            // 
            // Computer
            // 
            this.Computer.Image = global::GioGame.Properties.Resources._4372820;
            this.Computer.Location = new System.Drawing.Point(11, 23);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(90, 90);
            this.Computer.TabIndex = 3;
            this.Computer.UseVisualStyleBackColor = true;
            this.Computer.Click += new System.EventHandler(this.Computer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 777);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimerCountDown);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Bksp);
            this.Controls.Add(this.CompRes);
            this.Controls.Add(this.MyRes);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.RParen);
            this.Controls.Add(this.LParen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Name = "Form1";
            this.Text = "MyNumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LParen;
        private System.Windows.Forms.Button RParen;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Number3;
        private System.Windows.Forms.Label Number4;
        private System.Windows.Forms.Label Number5;
        private System.Windows.Forms.Label Number6;
        private System.Windows.Forms.Label Number7;
        private System.Windows.Forms.Label Number8;
        private System.Windows.Forms.Label Number9;
        private System.Windows.Forms.Label MyRes;
        private System.Windows.Forms.Label CompRes;
        private System.Windows.Forms.Button Bksp;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label TimerCountDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Computer;
    }
}

