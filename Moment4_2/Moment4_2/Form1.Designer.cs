namespace Moment4_2
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
            this.lblTal = new System.Windows.Forms.Label();
            this.tBoxTal = new System.Windows.Forms.TextBox();
            this.tBoxOut = new System.Windows.Forms.TextBox();
            this.tboxColor = new System.Windows.Forms.TextBox();
            this.btnKor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTal.Location = new System.Drawing.Point(42, 43);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(50, 25);
            this.lblTal.TabIndex = 0;
            this.lblTal.Text = "Tal:";
            // 
            // tBoxTal
            // 
            this.tBoxTal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxTal.Location = new System.Drawing.Point(119, 38);
            this.tBoxTal.Name = "tBoxTal";
            this.tBoxTal.Size = new System.Drawing.Size(182, 30);
            this.tBoxTal.TabIndex = 1;
            // 
            // tBoxOut
            // 
            this.tBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxOut.Location = new System.Drawing.Point(47, 101);
            this.tBoxOut.Multiline = true;
            this.tBoxOut.Name = "tBoxOut";
            this.tBoxOut.Size = new System.Drawing.Size(700, 239);
            this.tBoxOut.TabIndex = 2;
            // 
            // tboxColor
            // 
            this.tboxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxColor.Location = new System.Drawing.Point(376, 38);
            this.tboxColor.Name = "tboxColor";
            this.tboxColor.Size = new System.Drawing.Size(371, 30);
            this.tboxColor.TabIndex = 3;
            // 
            // btnKor
            // 
            this.btnKor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKor.Location = new System.Drawing.Point(576, 363);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(171, 62);
            this.btnKor.TabIndex = 4;
            this.btnKor.Text = "Kör";
            this.btnKor.UseVisualStyleBackColor = false;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKor);
            this.Controls.Add(this.tboxColor);
            this.Controls.Add(this.tBoxOut);
            this.Controls.Add(this.tBoxTal);
            this.Controls.Add(this.lblTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.TextBox tBoxTal;
        private System.Windows.Forms.TextBox tBoxOut;
        private System.Windows.Forms.TextBox tboxColor;
        private System.Windows.Forms.Button btnKor;
    }
}

