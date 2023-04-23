namespace Таблицы1
{
    partial class FormAddAb
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
            this.for_sn = new System.Windows.Forms.TextBox();
            this.for_n = new System.Windows.Forms.TextBox();
            this.for_p = new System.Windows.Forms.TextBox();
            this.for_a = new System.Windows.Forms.TextBox();
            this.for_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.for_d = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // for_sn
            // 
            this.for_sn.Location = new System.Drawing.Point(203, 57);
            this.for_sn.Name = "for_sn";
            this.for_sn.Size = new System.Drawing.Size(100, 20);
            this.for_sn.TabIndex = 0;
            // 
            // for_n
            // 
            this.for_n.Location = new System.Drawing.Point(203, 83);
            this.for_n.Name = "for_n";
            this.for_n.Size = new System.Drawing.Size(100, 20);
            this.for_n.TabIndex = 1;
            // 
            // for_p
            // 
            this.for_p.Location = new System.Drawing.Point(203, 109);
            this.for_p.Name = "for_p";
            this.for_p.Size = new System.Drawing.Size(100, 20);
            this.for_p.TabIndex = 2;
            // 
            // for_a
            // 
            this.for_a.Location = new System.Drawing.Point(203, 135);
            this.for_a.Name = "for_a";
            this.for_a.Size = new System.Drawing.Size(100, 20);
            this.for_a.TabIndex = 3;
            // 
            // for_c
            // 
            this.for_c.Location = new System.Drawing.Point(203, 161);
            this.for_c.Name = "for_c";
            this.for_c.Size = new System.Drawing.Size(100, 20);
            this.for_c.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Комментарий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "День рождения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // for_d
            // 
            this.for_d.Location = new System.Drawing.Point(203, 190);
            this.for_d.Name = "for_d";
            this.for_d.Size = new System.Drawing.Size(200, 20);
            this.for_d.TabIndex = 14;
            // 
            // FormAddAb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 306);
            this.Controls.Add(this.for_d);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.for_c);
            this.Controls.Add(this.for_a);
            this.Controls.Add(this.for_p);
            this.Controls.Add(this.for_n);
            this.Controls.Add(this.for_sn);
            this.Name = "FormAddAb";
            this.Text = "FormAddAb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox for_sn;
        public System.Windows.Forms.TextBox for_n;
        public System.Windows.Forms.TextBox for_p;
        public System.Windows.Forms.TextBox for_a;
        public System.Windows.Forms.TextBox for_c;
        public System.Windows.Forms.DateTimePicker for_d;
    }
}