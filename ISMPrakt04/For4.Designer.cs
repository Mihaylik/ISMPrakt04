
namespace ISMPrakt04
{
    partial class For4
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
            this.for4Label = new System.Windows.Forms.Label();
            this.holderA = new System.Windows.Forms.Label();
            this.holderB = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // for4Label
            // 
            this.for4Label.AutoSize = true;
            this.for4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for4Label.Location = new System.Drawing.Point(73, 49);
            this.for4Label.Name = "for4Label";
            this.for4Label.Size = new System.Drawing.Size(352, 25);
            this.for4Label.TabIndex = 0;
            this.for4Label.Text = " Введіть два цілих числа A і B (A < B)";
            this.for4Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // holderA
            // 
            this.holderA.AutoSize = true;
            this.holderA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderA.Location = new System.Drawing.Point(73, 104);
            this.holderA.Name = "holderA";
            this.holderA.Size = new System.Drawing.Size(26, 25);
            this.holderA.TabIndex = 1;
            this.holderA.Text = "A";
            // 
            // holderB
            // 
            this.holderB.AutoSize = true;
            this.holderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderB.Location = new System.Drawing.Point(73, 161);
            this.holderB.Name = "holderB";
            this.holderB.Size = new System.Drawing.Size(25, 25);
            this.holderB.TabIndex = 2;
            this.holderB.Text = "B";
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputA.Location = new System.Drawing.Point(125, 101);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(286, 30);
            this.inputA.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputB.Location = new System.Drawing.Point(125, 158);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(286, 30);
            this.inputB.TabIndex = 4;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(73, 252);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(117, 25);
            this.res.TabIndex = 8;
            this.res.Text = "Результат:";
            // 
            // solveRes
            // 
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(191, 203);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(152, 38);
            this.solveRes.TabIndex = 7;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = true;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // For4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(519, 365);
            this.Controls.Add(this.res);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.holderB);
            this.Controls.Add(this.holderA);
            this.Controls.Add(this.for4Label);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "For4";
            this.Text = "Cумa квадратів усіх цілих чисел від A до B включно";
            this.Load += new System.EventHandler(this.For4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label for4Label;
        private System.Windows.Forms.Label holderA;
        private System.Windows.Forms.Label holderB;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button solveRes;
    }
}