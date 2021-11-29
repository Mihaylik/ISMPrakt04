
namespace ISMPrakt04
{
    partial class DoWhile
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
            this.inputArray = new System.Windows.Forms.TextBox();
            this.doWhileLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputArray
            // 
            this.inputArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputArray.Location = new System.Drawing.Point(56, 73);
            this.inputArray.Multiline = true;
            this.inputArray.Name = "inputArray";
            this.inputArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputArray.Size = new System.Drawing.Size(140, 151);
            this.inputArray.TabIndex = 0;
            this.inputArray.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputArray.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.inputArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.inputArray.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // doWhileLabel
            // 
            this.doWhileLabel.AutoSize = true;
            this.doWhileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doWhileLabel.Location = new System.Drawing.Point(51, 34);
            this.doWhileLabel.Name = "doWhileLabel";
            this.doWhileLabel.Size = new System.Drawing.Size(416, 25);
            this.doWhileLabel.TabIndex = 1;
            this.doWhileLabel.Text = "Вводьте числа через enter. В кінці введіть 0";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(50, 239);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(122, 25);
            this.result.TabIndex = 2;
            this.result.Text = "Результат: ";
            // 
            // DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(512, 289);
            this.Controls.Add(this.result);
            this.Controls.Add(this.doWhileLabel);
            this.Controls.Add(this.inputArray);
            this.Name = "DoWhile";
            this.Text = "Сумма введених чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputArray;
        private System.Windows.Forms.Label doWhileLabel;
        private System.Windows.Forms.Label result;
    }
}