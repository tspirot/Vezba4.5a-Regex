namespace Vezba4._5a
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxFirst = new TextBox();
            textBoxLast = new TextBox();
            textBoxAdress = new TextBox();
            textBoxZIP = new TextBox();
            textBoxState = new TextBox();
            textBoxCity = new TextBox();
            textBoxPhone = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 19);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Validate user details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 61);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 94);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 127);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 160);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 193);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 5;
            label6.Text = "State";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 226);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 6;
            label7.Text = "ZIP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 259);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "Phone";
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(125, 58);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(222, 27);
            textBoxFirst.TabIndex = 8;
            // 
            // textBoxLast
            // 
            textBoxLast.Location = new Point(125, 91);
            textBoxLast.Name = "textBoxLast";
            textBoxLast.Size = new Size(222, 27);
            textBoxLast.TabIndex = 9;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(125, 124);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(222, 27);
            textBoxAdress.TabIndex = 10;
            // 
            // textBoxZIP
            // 
            textBoxZIP.Location = new Point(125, 223);
            textBoxZIP.Name = "textBoxZIP";
            textBoxZIP.Size = new Size(222, 27);
            textBoxZIP.TabIndex = 13;
            // 
            // textBoxState
            // 
            textBoxState.Location = new Point(125, 190);
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(222, 27);
            textBoxState.TabIndex = 12;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(125, 157);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(222, 27);
            textBoxCity.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(125, 256);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(222, 27);
            textBoxPhone.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(202, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 362);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxZIP);
            Controls.Add(textBoxState);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxLast);
            Controls.Add(textBoxFirst);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxFirst;
        private TextBox textBoxLast;
        private TextBox textBoxAdress;
        private TextBox textBoxZIP;
        private TextBox textBoxState;
        private TextBox textBoxCity;
        private TextBox textBoxPhone;
        private Button button1;
    }
}
