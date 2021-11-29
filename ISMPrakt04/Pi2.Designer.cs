
namespace ISMPrakt04
{
    partial class Pi2
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
            this.backBox1 = new System.Windows.Forms.TextBox();
            this.backBox2 = new System.Windows.Forms.TextBox();
            this.constPi = new System.Windows.Forms.Label();
            this.solveRes = new System.Windows.Forms.Button();
            this.holderPi = new System.Windows.Forms.Label();
            this.inputIter = new System.Windows.Forms.TextBox();
            this.task = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.task)).BeginInit();
            this.SuspendLayout();
            // 
            // backBox1
            // 
            this.backBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backBox1.Location = new System.Drawing.Point(1, 0);
            this.backBox1.Multiline = true;
            this.backBox1.Name = "backBox1";
            this.backBox1.ReadOnly = true;
            this.backBox1.Size = new System.Drawing.Size(578, 189);
            this.backBox1.TabIndex = 0;
            // 
            // backBox2
            // 
            this.backBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBox2.BackColor = System.Drawing.Color.Yellow;
            this.backBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backBox2.Location = new System.Drawing.Point(1, 186);
            this.backBox2.Multiline = true;
            this.backBox2.Name = "backBox2";
            this.backBox2.ReadOnly = true;
            this.backBox2.Size = new System.Drawing.Size(578, 224);
            this.backBox2.TabIndex = 1;
            this.backBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // constPi
            // 
            this.constPi.AutoSize = true;
            this.constPi.BackColor = System.Drawing.Color.Yellow;
            this.constPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.constPi.Location = new System.Drawing.Point(99, 232);
            this.constPi.Name = "constPi";
            this.constPi.Size = new System.Drawing.Size(102, 25);
            this.constPi.TabIndex = 8;
            this.constPi.Text = "Число Pi: ";
            // 
            // solveRes
            // 
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(271, 180);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(157, 44);
            this.solveRes.TabIndex = 7;
            this.solveRes.Text = "Розрахувати";
            this.solveRes.UseVisualStyleBackColor = true;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // holderPi
            // 
            this.holderPi.AutoSize = true;
            this.holderPi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.holderPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderPi.Location = new System.Drawing.Point(12, 135);
            this.holderPi.Name = "holderPi";
            this.holderPi.Size = new System.Drawing.Size(189, 25);
            this.holderPi.TabIndex = 6;
            this.holderPi.Text = "Кількість множень";
            // 
            // inputIter
            // 
            this.inputIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputIter.Location = new System.Drawing.Point(216, 132);
            this.inputIter.Name = "inputIter";
            this.inputIter.Size = new System.Drawing.Size(256, 30);
            this.inputIter.TabIndex = 5;
            // 
            // task
            // 
            this.task.Image = global::ISMPrakt04.Properties.Resources.Screenshot_113;
            this.task.Location = new System.Drawing.Point(142, 60);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(298, 50);
            this.task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.task.TabIndex = 2;
            this.task.TabStop = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Yellow;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(45, 279);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(156, 25);
            this.result.TabIndex = 9;
            this.result.Text = "Результат (pi): \r\n";
            // 
            // Pi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.result);
            this.Controls.Add(this.constPi);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.holderPi);
            this.Controls.Add(this.inputIter);
            this.Controls.Add(this.task);
            this.Controls.Add(this.backBox1);
            this.Controls.Add(this.backBox2);
            this.Name = "Pi2";
            this.Text = "Спосіб Джона Уоллиса";
            this.Load += new System.EventHandler(this.Pi2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backBox1;
        private System.Windows.Forms.TextBox backBox2;
        private System.Windows.Forms.PictureBox task;
        private System.Windows.Forms.Label constPi;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.Label holderPi;
        private System.Windows.Forms.TextBox inputIter;
        private System.Windows.Forms.Label result;
    }
}