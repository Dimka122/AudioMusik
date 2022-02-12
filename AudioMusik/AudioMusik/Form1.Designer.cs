
namespace AudioMusik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.Teal;
            this.LeftButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.ForeColor = System.Drawing.Color.Black;
            this.LeftButton.Location = new System.Drawing.Point(27, 230);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(70, 45);
            this.LeftButton.TabIndex = 1;
            this.LeftButton.Text = "<<<";
            this.LeftButton.UseVisualStyleBackColor = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Cyan;
            this.PlayButton.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.Red;
            this.PlayButton.Location = new System.Drawing.Point(103, 230);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(51, 45);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = ">";
            this.PlayButton.UseVisualStyleBackColor = false;
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.Teal;
            this.RightButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.ForeColor = System.Drawing.Color.Black;
            this.RightButton.Location = new System.Drawing.Point(160, 230);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(67, 45);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = ">>>";
            this.RightButton.UseVisualStyleBackColor = false;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Yellow;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.ForeColor = System.Drawing.Color.Black;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(27, 282);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 95);
            this.listBox.TabIndex = 4;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(27, 384);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(94, 23);
            this.Button.TabIndex = 5;
            this.Button.Text = "button1";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button button2;
    }
}

