﻿
namespace ISMPrakt04
{
    partial class For5
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
            this.holderN = new System.Windows.Forms.Label();
            this.for5Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(50, 218);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(127, 25);
            this.result.TabIndex = 9;
            this.result.Text = "Результат:";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // solveRes
            // 
            this.solveRes.BackColor = System.Drawing.Color.Lavender;
            this.solveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solveRes.Location = new System.Drawing.Point(128, 158);
            this.solveRes.Name = "solveRes";
            this.solveRes.Size = new System.Drawing.Size(137, 37);
            this.solveRes.TabIndex = 8;
            this.solveRes.Text = "Порахувати";
            this.solveRes.UseVisualStyleBackColor = false;
            this.solveRes.Click += new System.EventHandler(this.solveRes_Click);
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputN.Location = new System.Drawing.Point(94, 111);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(205, 30);
            this.inputN.TabIndex = 7;
            this.inputN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // holderN
            // 
            this.holderN.AutoSize = true;
            this.holderN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.holderN.Location = new System.Drawing.Point(50, 111);
            this.holderN.Name = "holderN";
            this.holderN.Size = new System.Drawing.Size(26, 25);
            this.holderN.TabIndex = 6;
            this.holderN.Text = "N";
            this.holderN.Click += new System.EventHandler(this.label2_Click);
            // 
            // for5Label
            // 
            this.for5Label.AutoSize = true;
            this.for5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for5Label.Location = new System.Drawing.Point(48, 66);
            this.for5Label.Name = "for5Label";
            this.for5Label.Size = new System.Drawing.Size(251, 25);
            this.for5Label.TabIndex = 5;
            this.for5Label.Text = "Введіть ціле число N>0";
            this.for5Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // For5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(361, 332);
            this.Controls.Add(this.result);
            this.Controls.Add(this.solveRes);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.holderN);
            this.Controls.Add(this.for5Label);
            this.Name = "For5";
            this.Text = "Cумa 1! + 2! + 3! + … + N! ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button solveRes;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Label holderN;
        private System.Windows.Forms.Label for5Label;
    }
}