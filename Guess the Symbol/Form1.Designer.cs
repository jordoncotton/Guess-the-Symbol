namespace MathQuiz
{
    partial class Form1
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Symbol)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(23, 17);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(65, 25);
            this.num1.TabIndex = 0;
            this.num1.Text = "num1";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(271, 17);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(65, 25);
            this.num2.TabIndex = 1;
            this.num2.Text = "num2";
            this.num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(446, 17);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(24, 25);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(566, 17);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(60, 25);
            this.total.TabIndex = 3;
            this.total.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press P for plus, M for minus, X for multiply and D for divide";
            // 
            // Symbol
            // 
            this.Symbol.Image = global::MathQuiz.Properties.Resources.qq;
            this.Symbol.InitialImage = global::MathQuiz.Properties.Resources.plus;
            this.Symbol.Location = new System.Drawing.Point(118, 6);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(100, 50);
            this.Symbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Symbol.TabIndex = 4;
            this.Symbol.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(545, 69);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(33, 13);
            this.score.TabIndex = 6;
            this.score.Text = "score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 107);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.total);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyisDown);
            ((System.ComponentModel.ISupportInitialize)(this.Symbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox Symbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}

