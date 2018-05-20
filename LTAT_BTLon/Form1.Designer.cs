namespace LTAT_BTLon
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
            this.txb_TextBoxShowA = new System.Windows.Forms.TextBox();
            this.txb_TextBoxShowB = new System.Windows.Forms.TextBox();
            this.txb_TextBoxA = new System.Windows.Forms.TextBox();
            this.txb_TextBoxB = new System.Windows.Forms.TextBox();
            this.btn_ASendText = new System.Windows.Forms.Button();
            this.btn_BSendText = new System.Windows.Forms.Button();
            this.txb_PrivateKeyA = new System.Windows.Forms.TextBox();
            this.btn_GetKeyA = new System.Windows.Forms.Button();
            this.btn_GetKeyB = new System.Windows.Forms.Button();
            this.txb_PrivateKeyB = new System.Windows.Forms.TextBox();
            this.btn_NoiseA = new System.Windows.Forms.Button();
            this.btn_NoiseB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_PublicKeyA = new System.Windows.Forms.TextBox();
            this.txb_CommonKeyA = new System.Windows.Forms.TextBox();
            this.txb_CommonKeyB = new System.Windows.Forms.TextBox();
            this.txb_PublicKeyB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_ivA = new System.Windows.Forms.TextBox();
            this.txb_PaddingA = new System.Windows.Forms.TextBox();
            this.txb_LengthPaddingA = new System.Windows.Forms.TextBox();
            this.txb_LengthPaddingB = new System.Windows.Forms.TextBox();
            this.txb_PaddingB = new System.Windows.Forms.TextBox();
            this.txb_ivB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ASendKeyToB = new System.Windows.Forms.Button();
            this.btn_BSendKeyToA = new System.Windows.Forms.Button();
            this.txb_BoxA = new System.Windows.Forms.TextBox();
            this.txb_BoxB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_TimeB = new System.Windows.Forms.Label();
            this.lbl_TimeA = new System.Windows.Forms.Label();
            this.btn_HashA = new System.Windows.Forms.Button();
            this.btn_HashB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_TextBoxShowA
            // 
            this.txb_TextBoxShowA.Location = new System.Drawing.Point(15, 34);
            this.txb_TextBoxShowA.Multiline = true;
            this.txb_TextBoxShowA.Name = "txb_TextBoxShowA";
            this.txb_TextBoxShowA.Size = new System.Drawing.Size(332, 200);
            this.txb_TextBoxShowA.TabIndex = 0;
            // 
            // txb_TextBoxShowB
            // 
            this.txb_TextBoxShowB.Location = new System.Drawing.Point(408, 34);
            this.txb_TextBoxShowB.Multiline = true;
            this.txb_TextBoxShowB.Name = "txb_TextBoxShowB";
            this.txb_TextBoxShowB.Size = new System.Drawing.Size(332, 200);
            this.txb_TextBoxShowB.TabIndex = 1;
            // 
            // txb_TextBoxA
            // 
            this.txb_TextBoxA.Location = new System.Drawing.Point(15, 240);
            this.txb_TextBoxA.Multiline = true;
            this.txb_TextBoxA.Name = "txb_TextBoxA";
            this.txb_TextBoxA.Size = new System.Drawing.Size(251, 61);
            this.txb_TextBoxA.TabIndex = 2;
            // 
            // txb_TextBoxB
            // 
            this.txb_TextBoxB.Location = new System.Drawing.Point(408, 240);
            this.txb_TextBoxB.Multiline = true;
            this.txb_TextBoxB.Name = "txb_TextBoxB";
            this.txb_TextBoxB.Size = new System.Drawing.Size(251, 61);
            this.txb_TextBoxB.TabIndex = 3;
            // 
            // btn_ASendText
            // 
            this.btn_ASendText.Location = new System.Drawing.Point(272, 240);
            this.btn_ASendText.Name = "btn_ASendText";
            this.btn_ASendText.Size = new System.Drawing.Size(75, 23);
            this.btn_ASendText.TabIndex = 4;
            this.btn_ASendText.Text = "Send";
            this.btn_ASendText.UseVisualStyleBackColor = true;
            this.btn_ASendText.Click += new System.EventHandler(this.btn_ASendText_Click);
            // 
            // btn_BSendText
            // 
            this.btn_BSendText.Location = new System.Drawing.Point(665, 238);
            this.btn_BSendText.Name = "btn_BSendText";
            this.btn_BSendText.Size = new System.Drawing.Size(75, 23);
            this.btn_BSendText.TabIndex = 5;
            this.btn_BSendText.Text = "Send";
            this.btn_BSendText.UseVisualStyleBackColor = true;
            this.btn_BSendText.Click += new System.EventHandler(this.btn_BSendText_Click);
            // 
            // txb_PrivateKeyA
            // 
            this.txb_PrivateKeyA.Location = new System.Drawing.Point(77, 344);
            this.txb_PrivateKeyA.Name = "txb_PrivateKeyA";
            this.txb_PrivateKeyA.Size = new System.Drawing.Size(189, 20);
            this.txb_PrivateKeyA.TabIndex = 6;
            // 
            // btn_GetKeyA
            // 
            this.btn_GetKeyA.Location = new System.Drawing.Point(272, 316);
            this.btn_GetKeyA.Name = "btn_GetKeyA";
            this.btn_GetKeyA.Size = new System.Drawing.Size(75, 23);
            this.btn_GetKeyA.TabIndex = 7;
            this.btn_GetKeyA.Text = "Key";
            this.btn_GetKeyA.UseVisualStyleBackColor = true;
            this.btn_GetKeyA.Click += new System.EventHandler(this.btn_KeyA_Click);
            // 
            // btn_GetKeyB
            // 
            this.btn_GetKeyB.Location = new System.Drawing.Point(665, 316);
            this.btn_GetKeyB.Name = "btn_GetKeyB";
            this.btn_GetKeyB.Size = new System.Drawing.Size(75, 23);
            this.btn_GetKeyB.TabIndex = 9;
            this.btn_GetKeyB.Text = "Key";
            this.btn_GetKeyB.UseVisualStyleBackColor = true;
            this.btn_GetKeyB.Click += new System.EventHandler(this.btn_KeyB_Click);
            // 
            // txb_PrivateKeyB
            // 
            this.txb_PrivateKeyB.Location = new System.Drawing.Point(470, 344);
            this.txb_PrivateKeyB.Name = "txb_PrivateKeyB";
            this.txb_PrivateKeyB.Size = new System.Drawing.Size(189, 20);
            this.txb_PrivateKeyB.TabIndex = 8;
            // 
            // btn_NoiseA
            // 
            this.btn_NoiseA.Location = new System.Drawing.Point(272, 278);
            this.btn_NoiseA.Name = "btn_NoiseA";
            this.btn_NoiseA.Size = new System.Drawing.Size(75, 23);
            this.btn_NoiseA.TabIndex = 10;
            this.btn_NoiseA.Text = "Noise";
            this.btn_NoiseA.UseVisualStyleBackColor = true;
            this.btn_NoiseA.Click += new System.EventHandler(this.btn_NoiseA_Click);
            // 
            // btn_NoiseB
            // 
            this.btn_NoiseB.Location = new System.Drawing.Point(665, 278);
            this.btn_NoiseB.Name = "btn_NoiseB";
            this.btn_NoiseB.Size = new System.Drawing.Size(75, 23);
            this.btn_NoiseB.TabIndex = 11;
            this.btn_NoiseB.Text = "Noise";
            this.btn_NoiseB.UseVisualStyleBackColor = true;
            this.btn_NoiseB.Click += new System.EventHandler(this.btn_NoiseB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Private :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Public :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Common :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Common :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Public :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Private :";
            // 
            // txb_PublicKeyA
            // 
            this.txb_PublicKeyA.Location = new System.Drawing.Point(77, 318);
            this.txb_PublicKeyA.Name = "txb_PublicKeyA";
            this.txb_PublicKeyA.Size = new System.Drawing.Size(189, 20);
            this.txb_PublicKeyA.TabIndex = 18;
            // 
            // txb_CommonKeyA
            // 
            this.txb_CommonKeyA.Location = new System.Drawing.Point(77, 398);
            this.txb_CommonKeyA.Name = "txb_CommonKeyA";
            this.txb_CommonKeyA.Size = new System.Drawing.Size(189, 20);
            this.txb_CommonKeyA.TabIndex = 19;
            // 
            // txb_CommonKeyB
            // 
            this.txb_CommonKeyB.Location = new System.Drawing.Point(470, 398);
            this.txb_CommonKeyB.Name = "txb_CommonKeyB";
            this.txb_CommonKeyB.Size = new System.Drawing.Size(189, 20);
            this.txb_CommonKeyB.TabIndex = 21;
            // 
            // txb_PublicKeyB
            // 
            this.txb_PublicKeyB.Location = new System.Drawing.Point(470, 318);
            this.txb_PublicKeyB.Name = "txb_PublicKeyB";
            this.txb_PublicKeyB.Size = new System.Drawing.Size(189, 20);
            this.txb_PublicKeyB.TabIndex = 20;
            this.txb_PublicKeyB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "IV : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Padding :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Length Padding : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Length Padding : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Padding :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "IV : ";
            // 
            // txb_ivA
            // 
            this.txb_ivA.Location = new System.Drawing.Point(108, 425);
            this.txb_ivA.Name = "txb_ivA";
            this.txb_ivA.Size = new System.Drawing.Size(158, 20);
            this.txb_ivA.TabIndex = 28;
            // 
            // txb_PaddingA
            // 
            this.txb_PaddingA.Location = new System.Drawing.Point(108, 450);
            this.txb_PaddingA.Name = "txb_PaddingA";
            this.txb_PaddingA.Size = new System.Drawing.Size(158, 20);
            this.txb_PaddingA.TabIndex = 29;
            // 
            // txb_LengthPaddingA
            // 
            this.txb_LengthPaddingA.Location = new System.Drawing.Point(108, 476);
            this.txb_LengthPaddingA.Name = "txb_LengthPaddingA";
            this.txb_LengthPaddingA.Size = new System.Drawing.Size(158, 20);
            this.txb_LengthPaddingA.TabIndex = 30;
            // 
            // txb_LengthPaddingB
            // 
            this.txb_LengthPaddingB.Location = new System.Drawing.Point(501, 476);
            this.txb_LengthPaddingB.Name = "txb_LengthPaddingB";
            this.txb_LengthPaddingB.Size = new System.Drawing.Size(158, 20);
            this.txb_LengthPaddingB.TabIndex = 33;
            // 
            // txb_PaddingB
            // 
            this.txb_PaddingB.Location = new System.Drawing.Point(501, 450);
            this.txb_PaddingB.Name = "txb_PaddingB";
            this.txb_PaddingB.Size = new System.Drawing.Size(158, 20);
            this.txb_PaddingB.TabIndex = 32;
            // 
            // txb_ivB
            // 
            this.txb_ivB.Location = new System.Drawing.Point(501, 425);
            this.txb_ivB.Name = "txb_ivB";
            this.txb_ivB.Size = new System.Drawing.Size(158, 20);
            this.txb_ivB.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Time : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(662, 401);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Time : ";
            // 
            // btn_ASendKeyToB
            // 
            this.btn_ASendKeyToB.Location = new System.Drawing.Point(272, 368);
            this.btn_ASendKeyToB.Name = "btn_ASendKeyToB";
            this.btn_ASendKeyToB.Size = new System.Drawing.Size(75, 23);
            this.btn_ASendKeyToB.TabIndex = 40;
            this.btn_ASendKeyToB.Text = "Send Key";
            this.btn_ASendKeyToB.UseVisualStyleBackColor = true;
            this.btn_ASendKeyToB.Click += new System.EventHandler(this.btn_ASendKeyToB_Click);
            // 
            // btn_BSendKeyToA
            // 
            this.btn_BSendKeyToA.Location = new System.Drawing.Point(665, 369);
            this.btn_BSendKeyToA.Name = "btn_BSendKeyToA";
            this.btn_BSendKeyToA.Size = new System.Drawing.Size(75, 23);
            this.btn_BSendKeyToA.TabIndex = 41;
            this.btn_BSendKeyToA.Text = "Send Key";
            this.btn_BSendKeyToA.UseVisualStyleBackColor = true;
            this.btn_BSendKeyToA.Click += new System.EventHandler(this.btn_BSendKeyToA_Click);
            // 
            // txb_BoxA
            // 
            this.txb_BoxA.Location = new System.Drawing.Point(77, 370);
            this.txb_BoxA.Name = "txb_BoxA";
            this.txb_BoxA.Size = new System.Drawing.Size(189, 20);
            this.txb_BoxA.TabIndex = 42;
            // 
            // txb_BoxB
            // 
            this.txb_BoxB.Location = new System.Drawing.Point(470, 370);
            this.txb_BoxB.Name = "txb_BoxB";
            this.txb_BoxB.Size = new System.Drawing.Size(189, 20);
            this.txb_BoxB.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(404, 373);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Box A :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Box B :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Person A :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Person B :";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_TimeB
            // 
            this.lbl_TimeB.AutoSize = true;
            this.lbl_TimeB.Location = new System.Drawing.Point(707, 401);
            this.lbl_TimeB.Name = "lbl_TimeB";
            this.lbl_TimeB.Size = new System.Drawing.Size(25, 13);
            this.lbl_TimeB.TabIndex = 49;
            this.lbl_TimeB.Text = "(    )";
            // 
            // lbl_TimeA
            // 
            this.lbl_TimeA.AutoSize = true;
            this.lbl_TimeA.Location = new System.Drawing.Point(317, 401);
            this.lbl_TimeA.Name = "lbl_TimeA";
            this.lbl_TimeA.Size = new System.Drawing.Size(25, 13);
            this.lbl_TimeA.TabIndex = 48;
            this.lbl_TimeA.Text = "(    )";
            // 
            // btn_HashA
            // 
            this.btn_HashA.Location = new System.Drawing.Point(272, 423);
            this.btn_HashA.Name = "btn_HashA";
            this.btn_HashA.Size = new System.Drawing.Size(75, 23);
            this.btn_HashA.TabIndex = 50;
            this.btn_HashA.Text = "Hash";
            this.btn_HashA.UseVisualStyleBackColor = true;
            this.btn_HashA.Click += new System.EventHandler(this.btn_HashA_Click);
            // 
            // btn_HashB
            // 
            this.btn_HashB.Location = new System.Drawing.Point(665, 423);
            this.btn_HashB.Name = "btn_HashB";
            this.btn_HashB.Size = new System.Drawing.Size(75, 23);
            this.btn_HashB.TabIndex = 51;
            this.btn_HashB.Text = "Hash";
            this.btn_HashB.UseVisualStyleBackColor = true;
            this.btn_HashB.Click += new System.EventHandler(this.btn_HashB_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ASendText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.btn_HashB);
            this.Controls.Add(this.btn_HashA);
            this.Controls.Add(this.lbl_TimeB);
            this.Controls.Add(this.lbl_TimeA);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txb_BoxB);
            this.Controls.Add(this.txb_BoxA);
            this.Controls.Add(this.btn_BSendKeyToA);
            this.Controls.Add(this.btn_ASendKeyToB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_LengthPaddingB);
            this.Controls.Add(this.txb_PaddingB);
            this.Controls.Add(this.txb_ivB);
            this.Controls.Add(this.txb_LengthPaddingA);
            this.Controls.Add(this.txb_PaddingA);
            this.Controls.Add(this.txb_ivA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_CommonKeyB);
            this.Controls.Add(this.txb_PublicKeyB);
            this.Controls.Add(this.txb_CommonKeyA);
            this.Controls.Add(this.txb_PublicKeyA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NoiseB);
            this.Controls.Add(this.btn_NoiseA);
            this.Controls.Add(this.btn_GetKeyB);
            this.Controls.Add(this.txb_PrivateKeyB);
            this.Controls.Add(this.btn_GetKeyA);
            this.Controls.Add(this.txb_PrivateKeyA);
            this.Controls.Add(this.btn_BSendText);
            this.Controls.Add(this.btn_ASendText);
            this.Controls.Add(this.txb_TextBoxB);
            this.Controls.Add(this.txb_TextBoxA);
            this.Controls.Add(this.txb_TextBoxShowB);
            this.Controls.Add(this.txb_TextBoxShowA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_TextBoxShowA;
        private System.Windows.Forms.TextBox txb_TextBoxShowB;
        private System.Windows.Forms.TextBox txb_TextBoxA;
        private System.Windows.Forms.TextBox txb_TextBoxB;
        private System.Windows.Forms.Button btn_ASendText;
        private System.Windows.Forms.Button btn_BSendText;
        private System.Windows.Forms.TextBox txb_PrivateKeyA;
        private System.Windows.Forms.Button btn_GetKeyA;
        private System.Windows.Forms.Button btn_GetKeyB;
        private System.Windows.Forms.TextBox txb_PrivateKeyB;
        private System.Windows.Forms.Button btn_NoiseA;
        private System.Windows.Forms.Button btn_NoiseB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_PublicKeyA;
        private System.Windows.Forms.TextBox txb_CommonKeyA;
        private System.Windows.Forms.TextBox txb_CommonKeyB;
        private System.Windows.Forms.TextBox txb_PublicKeyB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_ivA;
        private System.Windows.Forms.TextBox txb_PaddingA;
        private System.Windows.Forms.TextBox txb_LengthPaddingA;
        private System.Windows.Forms.TextBox txb_LengthPaddingB;
        private System.Windows.Forms.TextBox txb_PaddingB;
        private System.Windows.Forms.TextBox txb_ivB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_ASendKeyToB;
        private System.Windows.Forms.Button btn_BSendKeyToA;
        private System.Windows.Forms.TextBox txb_BoxA;
        private System.Windows.Forms.TextBox txb_BoxB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_TimeB;
        private System.Windows.Forms.Label lbl_TimeA;
        private System.Windows.Forms.Button btn_HashA;
        private System.Windows.Forms.Button btn_HashB;
    }
}

