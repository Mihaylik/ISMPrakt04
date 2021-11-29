
namespace ISMPrakt04
{
    partial class Pi4
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
            this.task = new System.Windows.Forms.PictureBox();
            this.constPi = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.holderPi = new System.Windows.Forms.Label();
            this.inputIter = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.task)).BeginInit();
            this.SuspendLayout();
            // 
            // task
            // 
            this.task.Image = global::ISMPrakt04.Properties.Resources.Screenshot_115;
            this.task.Location = new System.Drawing.Point(141, 70);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(228, 50);
            this.task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.task.TabIndex = 0;
            this.task.TabStop = false;
            // 
            // constPi
            // 
            this.constPi.AutoSize = true;
            this.constPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.constPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constPi.Location = new System.Drawing.Point(111, 269);
            this.constPi.Name = "constPi";
            this.constPi.Size = new System.Drawing.Size(102, 25);
            this.constPi.TabIndex = 17;
            this.constPi.Text = "Число Pi: ";
            // 
            // solveRes
            // 
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(316, 212);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(157, 44);
            this.solveRes.TabIndex = 16;
            this.solveRes.Text = "Розрахувати";
            this.solveRes.UseVisualStyleBackColor = true;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // holderPi
            // 
            this.holderPi.AutoSize = true;
            this.holderPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.holderPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderPi.Location = new System.Drawing.Point(26, 167);
            this.holderPi.Name = "holderPi";
            this.holderPi.Size = new System.Drawing.Size(187, 25);
            this.holderPi.TabIndex = 15;
            this.holderPi.Text = "Кількість додавань";
            // 
            // inputIter
            // 
            this.inputIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputIter.Location = new System.Drawing.Point(261, 164);
            this.inputIter.Name = "inputIter";
            this.inputIter.Size = new System.Drawing.Size(256, 30);
            this.inputIter.TabIndex = 14;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(57, 323);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(156, 25);
            this.result.TabIndex = 18;
            this.result.Text = "Результат (pi): \r\n";
            // 
            // Pi4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(565, 445);
            this.Controls.Add(this.result);
            this.Controls.Add(this.constPi);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.holderPi);
            this.Controls.Add(this.inputIter);
            this.Controls.Add(this.task);
            this.Name = "Pi4";
            this.Text = "Спосіб Лейбніца";
            this.Load += new System.EventHandler(this.Pi4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox task;
        private System.Windows.Forms.Label constPi;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.Label holderPi;
        private System.Windows.Forms.TextBox inputIter;
        private System.Windows.Forms.Label result;
    }
}