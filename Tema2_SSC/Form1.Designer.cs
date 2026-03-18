namespace Tema2_SSC
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
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.textBoxPlainHex = new System.Windows.Forms.TextBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonEnc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonEncTime = new System.Windows.Forms.Button();
            this.buttonDecTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelEncTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBoxCipher.Location = new System.Drawing.Point(37, 29);
            this.comboBoxCipher.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCipher.TabIndex = 0;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(289, 30);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(174, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(289, 73);
            this.textBoxIV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(174, 20);
            this.textBoxIV.TabIndex = 2;
            this.textBoxIV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(289, 117);
            this.textBoxPlain.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(212, 20);
            this.textBoxPlain.TabIndex = 3;
            this.textBoxPlain.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(289, 202);
            this.textBoxCipherHex.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.Size = new System.Drawing.Size(214, 20);
            this.textBoxCipherHex.TabIndex = 4;
            // 
            // textBoxPlainHex
            // 
            this.textBoxPlainHex.Location = new System.Drawing.Point(289, 142);
            this.textBoxPlainHex.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlainHex.Name = "textBoxPlainHex";
            this.textBoxPlainHex.Size = new System.Drawing.Size(214, 20);
            this.textBoxPlainHex.TabIndex = 5;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(289, 179);
            this.textBoxCipher.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(214, 20);
            this.textBoxCipher.TabIndex = 6;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(37, 68);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(148, 29);
            this.buttonGen.TabIndex = 7;
            this.buttonGen.Text = "Generate Key and IV";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonEnc
            // 
            this.buttonEnc.Location = new System.Drawing.Point(37, 117);
            this.buttonEnc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnc.Name = "buttonEnc";
            this.buttonEnc.Size = new System.Drawing.Size(148, 31);
            this.buttonEnc.TabIndex = 8;
            this.buttonEnc.Text = "Encrypt";
            this.buttonEnc.UseVisualStyleBackColor = true;
            this.buttonEnc.Click += new System.EventHandler(this.buttonEnc_Click_1);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(37, 173);
            this.buttonDec.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(148, 26);
            this.buttonDec.TabIndex = 9;
            this.buttonDec.Text = "Decrypt";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // buttonEncTime
            // 
            this.buttonEncTime.Location = new System.Drawing.Point(37, 236);
            this.buttonEncTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncTime.Name = "buttonEncTime";
            this.buttonEncTime.Size = new System.Drawing.Size(148, 35);
            this.buttonEncTime.TabIndex = 10;
            this.buttonEncTime.Text = "Get Encrypt time";
            this.buttonEncTime.UseVisualStyleBackColor = true;
            this.buttonEncTime.Click += new System.EventHandler(this.buttonEncTime_Click);
            // 
            // buttonDecTime
            // 
            this.buttonDecTime.Location = new System.Drawing.Point(37, 275);
            this.buttonDecTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecTime.Name = "buttonDecTime";
            this.buttonDecTime.Size = new System.Drawing.Size(148, 38);
            this.buttonDecTime.TabIndex = 11;
            this.buttonDecTime.Text = "Get Decrypt time";
            this.buttonDecTime.UseVisualStyleBackColor = true;
            this.buttonDecTime.Click += new System.EventHandler(this.buttonDecTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ascii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Plain text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cypher text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hex";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ascii";
            // 
            // labelEncTime
            // 
            this.labelEncTime.AutoSize = true;
            this.labelEncTime.Location = new System.Drawing.Point(252, 247);
            this.labelEncTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncTime.Name = "labelEncTime";
            this.labelEncTime.Size = new System.Drawing.Size(144, 13);
            this.labelEncTime.TabIndex = 20;
            this.labelEncTime.Text = "Time/message at encryption:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Time/message at decryption:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 576);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEncTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecTime);
            this.Controls.Add(this.buttonEncTime);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonEnc);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.textBoxPlainHex);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.comboBoxCipher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCipher;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.TextBox textBoxPlainHex;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonEnc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonEncTime;
        private System.Windows.Forms.Button buttonDecTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelEncTime;
        private System.Windows.Forms.Label label10;
    }
}

