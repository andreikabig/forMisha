namespace GameMisha
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(776, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Деньги:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(71, 9);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 17);
            this.lblMoney.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбери спелый фрукт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Уровень:";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(252, 9);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(0, 17);
            this.lblLvl.TabIndex = 5;
            // 
            // pcb1
            // 
            this.pcb1.Location = new System.Drawing.Point(61, 124);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(128, 128);
            this.pcb1.TabIndex = 6;
            this.pcb1.TabStop = false;
            this.pcb1.Click += new System.EventHandler(this.pcb1_Click);
            // 
            // pcb2
            // 
            this.pcb2.Location = new System.Drawing.Point(232, 124);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(128, 128);
            this.pcb2.TabIndex = 7;
            this.pcb2.TabStop = false;
            this.pcb2.Click += new System.EventHandler(this.pcb2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Label label1;
        private Label lblMoney;
        private Label label2;
        private Label label3;
        private Label lblLvl;
        private PictureBox pcb1;
        private PictureBox pcb2;
    }
}