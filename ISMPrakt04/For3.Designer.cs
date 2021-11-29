
namespace ISMPrakt04
{
    partial class For3
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
            this.for3Label = new System.Windows.Forms.Label();
            this.holderA = new System.Windows.Forms.Label();
            this.holderN = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // for3Label
            // 
            this.for3Label.AutoSize = true;
            this.for3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for3Label.Location = new System.Drawing.Point(86, 28);
            this.for3Label.Name = "for3Label";
            this.for3Label.Size = new System.Drawing.Size(273, 50);
            this.for3Label.TabIndex = 0;
            this.for3Label.Text = "Введіть дробове число A \r\nі ціле число N (> 0)";
            this.for3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.for3Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // holderA
            // 
            this.holderA.AutoSize = true;
            this.holderA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderA.Location = new System.Drawing.Point(86, 98);
            this.holderA.Name = "holderA";
            this.holderA.Size = new System.Drawing.Size(26, 25);
            this.holderA.TabIndex = 1;
            this.holderA.Text = "A";
            // 
            // holderN
            // 
            this.holderN.AutoSize = true;
            this.holderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderN.Location = new System.Drawing.Point(86, 145);
            this.holderN.Name = "holderN";
            this.holderN.Size = new System.Drawing.Size(26, 25);
            this.holderN.TabIndex = 2;
            this.holderN.Text = "N";
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputA.Location = new System.Drawing.Point(129, 95);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(216, 30);
            this.inputA.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputB.Location = new System.Drawing.Point(129, 142);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(216, 30);
            this.inputB.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(86, 242);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(127, 25);
            this.result.TabIndex = 6;
            this.result.Text = "Результат:";
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(173, 187);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 5;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // For3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(487, 325);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.holderN);
            this.Controls.Add(this.holderA);
            this.Controls.Add(this.for3Label);
            this.Name = "For3";
            this.Text = "A у степені N за допомогою for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label for3Label;
        private System.Windows.Forms.Label holderA;
        private System.Windows.Forms.Label holderN;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button solveRes;
    }
}