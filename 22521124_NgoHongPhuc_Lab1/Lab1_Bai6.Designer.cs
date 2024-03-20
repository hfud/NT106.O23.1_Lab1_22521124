namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.TextBox();
            this.zodiac = new System.Windows.Forms.TextBox();
            this.Tim = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cung hoàng đạo";
            // 
            // birth
            // 
            this.birth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Location = new System.Drawing.Point(254, 53);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(217, 28);
            this.birth.TabIndex = 2;
            // 
            // zodiac
            // 
            this.zodiac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zodiac.Location = new System.Drawing.Point(254, 142);
            this.zodiac.Name = "zodiac";
            this.zodiac.ReadOnly = true;
            this.zodiac.Size = new System.Drawing.Size(217, 28);
            this.zodiac.TabIndex = 3;
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(537, 23);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(90, 50);
            this.Tim.TabIndex = 4;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(537, 101);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(90, 50);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(537, 172);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(90, 50);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Lab1_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 250);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.zodiac);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab1_Bai6";
            this.Text = "Lab1_Bai6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.TextBox zodiac;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}