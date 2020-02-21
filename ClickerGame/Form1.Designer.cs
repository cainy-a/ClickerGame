namespace ClickerGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonMakeMoney = new System.Windows.Forms.Button();
            this.button10xMultiplier = new System.Windows.Forms.Button();
            this.buttonAutoClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneys";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoney.Location = new System.Drawing.Point(12, 41);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.ReadOnly = true;
            this.textBoxMoney.Size = new System.Drawing.Size(158, 36);
            this.textBoxMoney.TabIndex = 1;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMakeMoney
            // 
            this.buttonMakeMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeMoney.Location = new System.Drawing.Point(176, 41);
            this.buttonMakeMoney.Name = "buttonMakeMoney";
            this.buttonMakeMoney.Size = new System.Drawing.Size(221, 36);
            this.buttonMakeMoney.TabIndex = 2;
            this.buttonMakeMoney.Text = "Make a Money!";
            this.buttonMakeMoney.UseVisualStyleBackColor = true;
            this.buttonMakeMoney.Click += new System.EventHandler(this.ButtonMakeMoney_Click);
            // 
            // button10xMultiplier
            // 
            this.button10xMultiplier.Location = new System.Drawing.Point(13, 84);
            this.button10xMultiplier.Name = "button10xMultiplier";
            this.button10xMultiplier.Size = new System.Drawing.Size(157, 71);
            this.button10xMultiplier.TabIndex = 3;
            this.button10xMultiplier.Text = "10x Multiplier\r\n50 moneys";
            this.button10xMultiplier.UseVisualStyleBackColor = true;
            this.button10xMultiplier.Click += new System.EventHandler(this.Button10xMultiplier_Click);
            // 
            // buttonAutoClick
            // 
            this.buttonAutoClick.Location = new System.Drawing.Point(177, 84);
            this.buttonAutoClick.Name = "buttonAutoClick";
            this.buttonAutoClick.Size = new System.Drawing.Size(220, 71);
            this.buttonAutoClick.TabIndex = 4;
            this.buttonAutoClick.Text = "Auto Clicker: 3 clicks / second\r\n200 moneys";
            this.buttonAutoClick.UseVisualStyleBackColor = true;
            this.buttonAutoClick.Click += new System.EventHandler(this.ButtonAutoClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 167);
            this.Controls.Add(this.buttonAutoClick);
            this.Controls.Add(this.button10xMultiplier);
            this.Controls.Add(this.buttonMakeMoney);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Clicker Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonMakeMoney;
        private System.Windows.Forms.Button button10xMultiplier;
        private System.Windows.Forms.Button buttonAutoClick;
    }
}

