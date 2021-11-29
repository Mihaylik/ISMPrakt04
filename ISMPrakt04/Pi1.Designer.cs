
namespace ISMPrakt04
{
    partial class Pi1
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
            this.inputIter = new System.Windows.Forms.TextBox();
            this.holderPi1 = new System.Windows.Forms.Label();
            this.solvePi = new System.Windows.Forms.Button();
            this.constPi = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.task)).BeginInit();
            this.SuspendLayout();
            // 
            // inputIter
            // 
            this.inputIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputIter.Location = new System.Drawing.Point(250, 171);
            this.inputIter.Name = "inputIter";
            this.inputIter.Size = new System.Drawing.Size(256, 30);
            this.inputIter.TabIndex = 1;
            // 
            // holderPi1
            // 
            this.holderPi1.AutoSize = true;
            this.holderPi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderPi1.Location = new System.Drawing.Point(46, 174);
            this.holderPi1.Name = "holderPi1";
            this.holderPi1.Size = new System.Drawing.Size(189, 25);
            this.holderPi1.TabIndex = 2;
            this.holderPi1.Text = "Кількість множень";
            // 
            // solvePi
            // 
            this.solvePi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solvePi.Location = new System.Drawing.Point(305, 219);
            this.solvePi.Name = "solvePi";
            this.solvePi.Size = new System.Drawing.Size(157, 44);
            this.solvePi.TabIndex = 3;
            this.solvePi.Text = "Розрахувати";
            this.solvePi.UseVisualStyleBackColor = true;
            this.solvePi.Click += new System.EventHandler(this.solvePi_Click);
            // 
            // constPi
            // 
            this.constPi.AutoSize = true;
            this.constPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constPi.Location = new System.Drawing.Point(133, 271);
            this.constPi.Name = "constPi";
            this.constPi.Size = new System.Drawing.Size(102, 25);
            this.constPi.TabIndex = 4;
            this.constPi.Text = "Число Pi: ";
            // 
            // task
            // 
            this.task.Image = global::ISMPrakt04.Properties.Resources.Screenshot_112;
            this.task.Location = new System.Drawing.Point(35, 71);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(496, 75);
            this.task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.task.TabIndex = 0;
            this.task.TabStop = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(133, 319);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(156, 25);
            this.result.TabIndex = 5;
            this.result.Text = "Результат (pi): \r\n";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Pi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(615, 405);
            this.Controls.Add(this.result);
            this.Controls.Add(this.constPi);
            this.Controls.Add(this.solvePi);
            this.Controls.Add(this.holderPi1);
            this.Controls.Add(this.inputIter);
            this.Controls.Add(this.task);
            this.Name = "Pi1";
            this.Text = "Спосіб Франсуа Вієта";
            this.Load += new System.EventHandler(this.Pi1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox task;
        private System.Windows.Forms.TextBox inputIter;
        private System.Windows.Forms.Label holderPi1;
        private System.Windows.Forms.Button solvePi;
        private System.Windows.Forms.Label constPi;
        private System.Windows.Forms.Label result;
    }
}