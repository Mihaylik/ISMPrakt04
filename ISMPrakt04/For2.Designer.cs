
namespace ISMPrakt04
{
    partial class For2
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
            this.for2Label = new System.Windows.Forms.Label();
            this.holderN = new System.Windows.Forms.Label();
            this.inputN = new System.Windows.Forms.TextBox();
            this.solveRes = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // for2Label
            // 
            this.for2Label.AutoSize = true;
            this.for2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for2Label.Location = new System.Drawing.Point(72, 55);
            this.for2Label.Name = "for2Label";
            this.for2Label.Size = new System.Drawing.Size(251, 25);
            this.for2Label.TabIndex = 0;
            this.for2Label.Text = "Введіть ціле число N>0";
            // 
            // holderN
            // 
            this.holderN.AutoSize = true;
            this.holderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderN.Location = new System.Drawing.Point(74, 100);
            this.holderN.Name = "holderN";
            this.holderN.Size = new System.Drawing.Size(26, 25);
            this.holderN.TabIndex = 1;
            this.holderN.Text = "N";
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputN.Location = new System.Drawing.Point(118, 100);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(205, 30);
            this.inputN.TabIndex = 2;
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(152, 147);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 3;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(74, 207);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(127, 25);
            this.result.TabIndex = 4;
            this.result.Text = "Результат:";
            // 
            // For2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(424, 363);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.holderN);
            this.Controls.Add(this.for2Label);
            this.Name = "For2";
            this.Text = "Знайти суму 1 + 1/2 + 1/3 + … + 1/N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label for2Label;
        private System.Windows.Forms.Label holderN;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.Label result;
    }
}