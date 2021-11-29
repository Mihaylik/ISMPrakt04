
namespace ISMPrakt04
{
    partial class While3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(While3));
            this.holderP = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.inputP = new System.Windows.Forms.TextBox();
            this.while3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // holderP
            // 
            this.holderP.AutoSize = true;
            this.holderP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderP.Location = new System.Drawing.Point(41, 177);
            this.holderP.Name = "holderP";
            this.holderP.Size = new System.Drawing.Size(26, 25);
            this.holderP.TabIndex = 19;
            this.holderP.Text = "P";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(41, 281);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 25);
            this.result.TabIndex = 18;
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(119, 221);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 17;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // inputP
            // 
            this.inputP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputP.Location = new System.Drawing.Point(85, 174);
            this.inputP.Name = "inputP";
            this.inputP.Size = new System.Drawing.Size(205, 30);
            this.inputP.TabIndex = 16;
            // 
            // while3Label
            // 
            this.while3Label.AutoSize = true;
            this.while3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.while3Label.Location = new System.Drawing.Point(30, 21);
            this.while3Label.Name = "while3Label";
            this.while3Label.Size = new System.Drawing.Size(844, 125);
            this.while3Label.TabIndex = 15;
            this.while3Label.Text = resources.GetString("while3Label.Text");
            // 
            // While3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(872, 359);
            this.Controls.Add(this.holderP);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputP);
            this.Controls.Add(this.while3Label);
            this.Name = "While3";
            this.Text = "Знайти кількість дня і відстань";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label holderP;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.TextBox inputP;
        private System.Windows.Forms.Label while3Label;
    }
}