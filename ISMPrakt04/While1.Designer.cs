
namespace ISMPrakt04
{
    partial class While1
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
            this.inputH = new System.Windows.Forms.TextBox();
            this.while1Label = new System.Windows.Forms.Label();
            this.holderH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(55, 198);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(127, 25);
            this.result.TabIndex = 13;
            this.result.Text = "Результат:";
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(133, 138);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 12;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // inputH
            // 
            this.inputH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputH.Location = new System.Drawing.Point(99, 91);
            this.inputH.Name = "inputH";
            this.inputH.Size = new System.Drawing.Size(205, 30);
            this.inputH.TabIndex = 11;
            // 
            // while1Label
            // 
            this.while1Label.AutoSize = true;
            this.while1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.while1Label.Location = new System.Drawing.Point(53, 46);
            this.while1Label.Name = "while1Label";
            this.while1Label.Size = new System.Drawing.Size(251, 25);
            this.while1Label.TabIndex = 10;
            this.while1Label.Text = "Введіть ціле число N>0";
            // 
            // holderH
            // 
            this.holderH.AutoSize = true;
            this.holderH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderH.Location = new System.Drawing.Point(53, 91);
            this.holderH.Name = "holderH";
            this.holderH.Size = new System.Drawing.Size(27, 25);
            this.holderH.TabIndex = 14;
            this.holderH.Text = "N";
            // 
            // While1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(375, 305);
            this.Controls.Add(this.holderH);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputH);
            this.Controls.Add(this.while1Label);
            this.Name = "While1";
            this.Text = "Знайти 1^N + 2^N-1 + ... N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.TextBox inputH;
        private System.Windows.Forms.Label while1Label;
        private System.Windows.Forms.Label holderH;
    }
}