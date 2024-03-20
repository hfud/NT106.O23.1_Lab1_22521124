namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai7
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
            this.Xuat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.fail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.Thoat = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập danh sách";
            // 
            // Xuat
            // 
            this.Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xuat.Location = new System.Drawing.Point(95, 104);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(138, 54);
            this.Xuat.TabIndex = 3;
            this.Xuat.Text = "Xuất điểm";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(415, 104);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(138, 54);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ và tên";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(213, 180);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(591, 27);
            this.name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Danh sách điểm";
            // 
            // point
            // 
            this.point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(213, 231);
            this.point.Multiline = true;
            this.point.Name = "point";
            this.point.ReadOnly = true;
            this.point.Size = new System.Drawing.Size(591, 79);
            this.point.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điểm trung bình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điểm cao nhất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Điểm thấp nhất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(610, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số môn đậu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(786, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số môn rớt";
            // 
            // avg
            // 
            this.avg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg.Location = new System.Drawing.Point(26, 369);
            this.avg.Name = "avg";
            this.avg.ReadOnly = true;
            this.avg.Size = new System.Drawing.Size(123, 27);
            this.avg.TabIndex = 23;
            this.avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // max
            // 
            this.max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(222, 369);
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Size = new System.Drawing.Size(108, 27);
            this.max.TabIndex = 16;
            this.max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // min
            // 
            this.min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(415, 369);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(108, 27);
            this.min.TabIndex = 17;
            this.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(600, 369);
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(108, 27);
            this.pass.TabIndex = 18;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fail
            // 
            this.fail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fail.Location = new System.Drawing.Point(778, 369);
            this.fail.Name = "fail";
            this.fail.ReadOnly = true;
            this.fail.Size = new System.Drawing.Size(108, 27);
            this.fail.TabIndex = 19;
            this.fail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Xếp loại";
            // 
            // type
            // 
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(367, 450);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(200, 34);
            this.type.TabIndex = 21;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(705, 104);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(138, 54);
            this.Thoat.TabIndex = 22;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(213, 21);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(591, 77);
            this.input.TabIndex = 0;
            // 
            // Lab1_Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 502);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Xuat);
            this.Controls.Add(this.label1);
            this.Name = "Lab1_Bai7";
            this.Text = "Lab1_Bai7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox avg;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox fail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox input;
    }
}