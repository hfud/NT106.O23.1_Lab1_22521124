namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai5
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
            this.numA = new System.Windows.Forms.TextBox();
            this.option = new System.Windows.Forms.ComboBox();
            this.numB = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // numA
            // 
            this.numA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numA.Location = new System.Drawing.Point(119, 24);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(158, 28);
            this.numA.TabIndex = 2;
            this.numA.TextChanged += new System.EventHandler(this.numA_TextChanged);
            // 
            // option
            // 
            this.option.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.option.Location = new System.Drawing.Point(214, 79);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(229, 33);
            this.option.TabIndex = 9;
            // 
            // numB
            // 
            this.numB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numB.Location = new System.Drawing.Point(458, 22);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(159, 28);
            this.numB.TabIndex = 4;
            this.numB.TextChanged += new System.EventHandler(this.numB_TextChanged);
            // 
            // Tinh
            // 
            this.Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinh.Location = new System.Drawing.Point(29, 129);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(168, 60);
            this.Tinh.TabIndex = 5;
            this.Tinh.Text = "Tính các giá trị";
            this.Tinh.UseVisualStyleBackColor = true;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(269, 129);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(132, 60);
            this.Xoa.TabIndex = 6;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(485, 129);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(132, 60);
            this.Thoat.TabIndex = 7;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(29, 230);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(588, 157);
            this.Result.TabIndex = 10;
            // 
            // Lab1_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.option);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Name = "Lab1_Bai5";
            this.Text = "Lab1_Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numA;
        private System.Windows.Forms.ComboBox option;
        private System.Windows.Forms.TextBox numB;
        private System.Windows.Forms.Button Tinh;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result;
    }
}