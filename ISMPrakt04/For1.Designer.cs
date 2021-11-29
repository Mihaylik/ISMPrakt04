
namespace ISMPrakt04
{
    partial class For1
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
            this.for1Label = new System.Windows.Forms.Label();
            this.holderA = new System.Windows.Forms.Label();
            this.holderB = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.solveRes = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // for1Label
            // 
            this.for1Label.AutoSize = true;
            this.for1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for1Label.Location = new System.Drawing.Point(86, 38);
            this.for1Label.Name = "for1Label";
            this.for1Label.Size = new System.Drawing.Size(237, 25);
            this.for1Label.TabIndex = 0;
            this.for1Label.Text = "Введіть 2 числа (A<B)";
            // 
            // holderA
            // 
            this.holderA.AutoSize = true;
            this.holderA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderA.Location = new System.Drawing.Point(87, 82);
            this.holderA.Name = "holderA";
            this.holderA.Size = new System.Drawing.Size(78, 20);
            this.holderA.TabIndex = 1;
            this.holderA.Text = "Число А";
            // 
            // holderB
            // 
            this.holderB.AutoSize = true;
            this.holderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderB.Location = new System.Drawing.Point(87, 129);
            this.holderB.Name = "holderB";
            this.holderB.Size = new System.Drawing.Size(78, 20);
            this.holderB.TabIndex = 2;
            this.holderB.Text = "Число В";
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputA.Location = new System.Drawing.Point(171, 75);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(152, 30);
            this.inputA.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputB.Location = new System.Drawing.Point(171, 122);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(152, 30);
            this.inputB.TabIndex = 4;
            // 
            // solveRes
            // 
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(171, 170);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(152, 38);
            this.solveRes.TabIndex = 5;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = true;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(48, 228);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(117, 25);
            this.res.TabIndex = 6;
            this.res.Text = "Результат:";
            // 
            // For1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(483, 334);
            this.Controls.Add(this.res);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.holderB);
            this.Controls.Add(this.holderA);
            this.Controls.Add(this.for1Label);
            this.Name = "For1";
            this.Text = "Добуток усіх цілих чисел від A до B включно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label for1Label;
        private System.Windows.Forms.Label holderA;
        private System.Windows.Forms.Label holderB;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.Label res;
    }
}