
namespace WindowsFormsApp2
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
            this.coke = new System.Windows.Forms.Button();
            this.pepsi = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clr = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.listd = new System.Windows.Forms.Label();
            this.next1 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.ok1 = new System.Windows.Forms.Button();
            this.balan = new System.Windows.Forms.TextBox();
            this.cpay = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coke
            // 
            this.coke.BackColor = System.Drawing.Color.DarkRed;
            this.coke.CausesValidation = false;
            this.coke.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coke.Location = new System.Drawing.Point(279, 64);
            this.coke.Name = "coke";
            this.coke.Size = new System.Drawing.Size(162, 74);
            this.coke.TabIndex = 0;
            this.coke.TabStop = false;
            this.coke.Text = "Coca Cola";
            this.coke.UseVisualStyleBackColor = false;
            this.coke.Click += new System.EventHandler(this.coke_Click);
            // 
            // pepsi
            // 
            this.pepsi.BackColor = System.Drawing.Color.MidnightBlue;
            this.pepsi.CausesValidation = false;
            this.pepsi.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepsi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pepsi.Location = new System.Drawing.Point(57, 64);
            this.pepsi.Name = "pepsi";
            this.pepsi.Size = new System.Drawing.Size(162, 74);
            this.pepsi.TabIndex = 1;
            this.pepsi.TabStop = false;
            this.pepsi.Text = "Pepsi";
            this.pepsi.UseVisualStyleBackColor = false;
            this.pepsi.Click += new System.EventHandler(this.pepsi_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.DarkOrange;
            this.orange.CausesValidation = false;
            this.orange.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orange.Location = new System.Drawing.Point(496, 64);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(162, 74);
            this.orange.TabIndex = 2;
            this.orange.TabStop = false;
            this.orange.Text = "Orange Crush";
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drink Dispenser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(288, 167);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(145, 24);
            this.number.TabIndex = 4;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clr);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.all);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(256, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 158);
            this.panel1.TabIndex = 5;
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.Color.Olive;
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clr.Location = new System.Drawing.Point(148, 116);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 39);
            this.clr.TabIndex = 12;
            this.clr.Text = "C";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(148, 77);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(74, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Black;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(74, 116);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 40);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.Purple;
            this.all.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all.Location = new System.Drawing.Point(0, 116);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(75, 40);
            this.all.TabIndex = 11;
            this.all.Text = "AC";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(74, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(148, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(74, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(148, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(0, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(497, 167);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(145, 39);
            this.clear.TabIndex = 6;
            this.clear.Text = "CLEAR  SELECTION";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // listd
            // 
            this.listd.AutoSize = true;
            this.listd.BackColor = System.Drawing.Color.White;
            this.listd.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listd.ForeColor = System.Drawing.Color.Teal;
            this.listd.Location = new System.Drawing.Point(496, 215);
            this.listd.Name = "listd";
            this.listd.Size = new System.Drawing.Size(146, 19);
            this.listd.TabIndex = 7;
            this.listd.Text = "Selected Quantity";
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.Color.Lime;
            this.next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next1.Location = new System.Drawing.Point(403, 432);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 45);
            this.next1.TabIndex = 8;
            this.next1.Text = "NEXT";
            this.next1.UseVisualStyleBackColor = false;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(493, 321);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(109, 20);
            this.price.TabIndex = 9;
            this.price.Text = "Total Price : ";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.DodgerBlue;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(497, 355);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(76, 42);
            this.pay.TabIndex = 10;
            this.pay.Text = "PAY";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.IndianRed;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(497, 403);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 45);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(330, 369);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 45);
            this.ok.TabIndex = 12;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel1
            // 
            this.cancel1.BackColor = System.Drawing.Color.Red;
            this.cancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel1.Location = new System.Drawing.Point(256, 432);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(75, 45);
            this.cancel1.TabIndex = 13;
            this.cancel1.Text = "CANCEL";
            this.cancel1.UseVisualStyleBackColor = false;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ok1
            // 
            this.ok1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok1.Location = new System.Drawing.Point(12, 418);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(76, 41);
            this.ok1.TabIndex = 15;
            this.ok1.Text = "OK";
            this.ok1.UseVisualStyleBackColor = false;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // balan
            // 
            this.balan.CausesValidation = false;
            this.balan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balan.Location = new System.Drawing.Point(12, 298);
            this.balan.Name = "balan";
            this.balan.Size = new System.Drawing.Size(145, 24);
            this.balan.TabIndex = 16;
            this.balan.TabStop = false;
            this.balan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cpay
            // 
            this.cpay.CausesValidation = false;
            this.cpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpay.Location = new System.Drawing.Point(12, 259);
            this.cpay.Name = "cpay";
            this.cpay.Size = new System.Drawing.Size(145, 24);
            this.cpay.TabIndex = 17;
            this.cpay.TabStop = false;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(12, 331);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(202, 20);
            this.customer.TabIndex = 18;
            this.customer.Text = "Customer Payment   Rs.";
            // 
            // bal
            // 
            this.bal.AutoSize = true;
            this.bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal.Location = new System.Drawing.Point(12, 369);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(201, 20);
            this.bal.TabIndex = 19;
            this.bal.Text = "Balance                    Rs.";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gold;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(608, 411);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 45);
            this.back.TabIndex = 20;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Location = new System.Drawing.Point(215, 418);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(44, 30);
            this.info.TabIndex = 21;
            this.info.Text = "hii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Untitled1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(702, 489);
            this.Controls.Add(this.info);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.cpay);
            this.Controls.Add(this.balan);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.price);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.listd);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.pepsi);
            this.Controls.Add(this.coke);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coke;
        private System.Windows.Forms.Button pepsi;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label listd;
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.TextBox balan;
        private System.Windows.Forms.TextBox cpay;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label bal;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button clr;
    }
}

