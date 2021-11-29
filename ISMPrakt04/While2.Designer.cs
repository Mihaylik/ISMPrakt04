
namespace ISMPrakt04
{
    partial class While2
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
            this.result = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.inputN = new System.Windows.Forms.TextBox();
            this.while2Label = new System.Windows.Forms.Label();
            this.holderN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(184, 220);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(127, 25);
            this.result.TabIndex = 13;
            this.result.Text = "Результат:";
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(262, 160);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 12;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputN.Location = new System.Drawing.Point(228, 113);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(205, 30);
            this.inputN.TabIndex = 11;
            // 
            // while2Label
            // 
            this.while2Label.AutoSize = true;
            this.while2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.while2Label.Location = new System.Drawing.Point(182, 68);
            this.while2Label.Name = "while2Label";
            this.while2Label.Size = new System.Drawing.Size(251, 25);
            this.while2Label.TabIndex = 10;
            this.while2Label.Text = "Введіть ціле число N>0";
            // 
            // holderN
            // 
            this.holderN.AutoSize = true;
            this.holderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderN.Location = new System.Drawing.Point(184, 116);
            this.holderN.Name = "holderN";
            this.holderN.Size = new System.Drawing.Size(27, 25);
            this.holderN.TabIndex = 14;
            this.holderN.Text = "N";
            // 
            // While2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(672, 358);
            this.Controls.Add(this.holderN);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.while2Label);
            this.Name = "While2";
            this.Text = "Найменше ціле число K, при якому виконується нерівність 3^k > N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Label while2Label;
        private System.Windows.Forms.Label holderN;
    }
}