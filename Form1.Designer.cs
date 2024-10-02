namespace TIC_TAC_TOE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.round_Updater = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_X_score = new System.Windows.Forms.Label();
            this.label_O_score = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 85);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 85);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 85);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 85);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(224, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 85);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 200);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 87);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 200);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 85);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(224, 200);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 85);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(346, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Round :";
            // 
            // round_Updater
            // 
            this.round_Updater.AutoSize = true;
            this.round_Updater.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_Updater.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.round_Updater.Location = new System.Drawing.Point(496, 32);
            this.round_Updater.Name = "round_Updater";
            this.round_Updater.Size = new System.Drawing.Size(39, 44);
            this.round_Updater.TabIndex = 10;
            this.round_Updater.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(377, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(377, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(451, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "O";
            // 
            // label_X_score
            // 
            this.label_X_score.AutoSize = true;
            this.label_X_score.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_X_score.Location = new System.Drawing.Point(380, 212);
            this.label_X_score.Name = "label_X_score";
            this.label_X_score.Size = new System.Drawing.Size(39, 44);
            this.label_X_score.TabIndex = 14;
            this.label_X_score.Text = "0";
            // 
            // label_O_score
            // 
            this.label_O_score.AutoSize = true;
            this.label_O_score.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_O_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_O_score.Location = new System.Drawing.Point(458, 212);
            this.label_O_score.Name = "label_O_score";
            this.label_O_score.Size = new System.Drawing.Size(39, 44);
            this.label_O_score.TabIndex = 15;
            this.label_O_score.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 85);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(561, 305);
            this.Controls.Add(this.label_O_score);
            this.Controls.Add(this.label_X_score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.round_Updater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label round_Updater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_X_score;
        private System.Windows.Forms.Label label_O_score;
        private System.Windows.Forms.Button button3;
    }
}

