namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai1
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
            this.SoThu1 = new System.Windows.Forms.Label();
            this.SoThu2 = new System.Windows.Forms.Label();
            this.Tong = new System.Windows.Forms.Label();
            this.Tinh = new System.Windows.Forms.Button();
            this.FirstNumValue = new System.Windows.Forms.TextBox();
            this.SecondNumValue = new System.Windows.Forms.TextBox();
            this.SumValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SoThu1
            // 
            this.SoThu1.AutoSize = true;
            this.SoThu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoThu1.Location = new System.Drawing.Point(67, 61);
            this.SoThu1.Name = "SoThu1";
            this.SoThu1.Size = new System.Drawing.Size(100, 29);
            this.SoThu1.TabIndex = 0;
            this.SoThu1.Text = "Số thứ 1";
            // 
            // SoThu2
            // 
            this.SoThu2.AutoSize = true;
            this.SoThu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoThu2.Location = new System.Drawing.Point(67, 152);
            this.SoThu2.Name = "SoThu2";
            this.SoThu2.Size = new System.Drawing.Size(100, 29);
            this.SoThu2.TabIndex = 1;
            this.SoThu2.Text = "Số thứ 2";
            // 
            // Tong
            // 
            this.Tong.AutoSize = true;
            this.Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tong.Location = new System.Drawing.Point(67, 305);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(70, 29);
            this.Tong.TabIndex = 2;
            this.Tong.Text = "Tổng";
            // 
            // Tinh
            // 
            this.Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinh.Location = new System.Drawing.Point(284, 228);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(124, 44);
            this.Tinh.TabIndex = 3;
            this.Tinh.Text = "Tính";
            this.Tinh.UseVisualStyleBackColor = true;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // FirstNumValue
            // 
            this.FirstNumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumValue.Location = new System.Drawing.Point(203, 61);
            this.FirstNumValue.Name = "FirstNumValue";
            this.FirstNumValue.Size = new System.Drawing.Size(269, 27);
            this.FirstNumValue.TabIndex = 4;
            this.FirstNumValue.TextChanged += new System.EventHandler(this.FirstNumValue_TextChanged);
            // 
            // SecondNumValue
            // 
            this.SecondNumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumValue.Location = new System.Drawing.Point(203, 156);
            this.SecondNumValue.Name = "SecondNumValue";
            this.SecondNumValue.Size = new System.Drawing.Size(269, 27);
            this.SecondNumValue.TabIndex = 5;
            this.SecondNumValue.TextChanged += new System.EventHandler(this.SecondNumValue_TextChanged);
            // 
            // SumValue
            // 
            this.SumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumValue.Location = new System.Drawing.Point(203, 312);
            this.SumValue.Name = "SumValue";
            this.SumValue.ReadOnly = true;
            this.SumValue.Size = new System.Drawing.Size(269, 27);
            this.SumValue.TabIndex = 6;
            // 
            // Lab1_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 405);
            this.Controls.Add(this.SumValue);
            this.Controls.Add(this.SecondNumValue);
            this.Controls.Add(this.FirstNumValue);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.SoThu2);
            this.Controls.Add(this.SoThu1);
            this.Name = "Lab1_Bai1";
            this.Text = "Lab1_Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoThu1;
        private System.Windows.Forms.Label SoThu2;
        private System.Windows.Forms.Label Tong;
        private System.Windows.Forms.Button Tinh;
        private System.Windows.Forms.TextBox FirstNumValue;
        private System.Windows.Forms.TextBox SecondNumValue;
        private System.Windows.Forms.TextBox SumValue;
    }
}