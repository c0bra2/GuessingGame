namespace GuessingGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndP1 = new System.Windows.Forms.RadioButton();
            this.rndP2 = new System.Windows.Forms.RadioButton();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndP2);
            this.groupBox1.Controls.Add(this.rndP1);
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How many players";
            // 
            // rndP1
            // 
            this.rndP1.AutoSize = true;
            this.rndP1.Location = new System.Drawing.Point(7, 20);
            this.rndP1.Name = "rndP1";
            this.rndP1.Size = new System.Drawing.Size(77, 17);
            this.rndP1.TabIndex = 0;
            this.rndP1.TabStop = true;
            this.rndP1.Text = "One Player";
            this.rndP1.UseVisualStyleBackColor = true;
            this.rndP1.CheckedChanged += new System.EventHandler(this.rndP1_CheckedChanged);
            // 
            // rndP2
            // 
            this.rndP2.AutoSize = true;
            this.rndP2.Location = new System.Drawing.Point(7, 44);
            this.rndP2.Name = "rndP2";
            this.rndP2.Size = new System.Drawing.Size(97, 17);
            this.rndP2.TabIndex = 1;
            this.rndP2.TabStop = true;
            this.rndP2.Text = "Two Player (AI)";
            this.rndP2.UseVisualStyleBackColor = true;
            this.rndP2.CheckedChanged += new System.EventHandler(this.rndP2_CheckedChanged);
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(117, 133);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(151, 20);
            this.txtP1.TabIndex = 1;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(117, 177);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(151, 20);
            this.txtP2.TabIndex = 2;
            this.txtP2.Visible = false;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(30, 136);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(81, 13);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "Player 1 Guess:";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(30, 180);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(81, 13);
            this.lblP2.TabIndex = 4;
            this.lblP2.Text = "Player 2 Guess:";
            this.lblP2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Enabled = false;
            this.cmdSubmit.Location = new System.Drawing.Point(274, 131);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(47, 23);
            this.cmdSubmit.TabIndex = 6;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(43, 220);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(261, 13);
            this.lblGame.TabIndex = 7;
            this.lblGame.Text = "What is the number I\'m guessing between 0 and 100?";
            this.lblGame.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 255);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rndP2;
        private System.Windows.Forms.RadioButton rndP1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label lblGame;
    }
}

