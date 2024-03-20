namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai8
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
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Tim = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn";
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(185, 33);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(218, 27);
            this.input.TabIndex = 1;
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(196, 361);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(299, 27);
            this.result.TabIndex = 2;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(288, 80);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(115, 56);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(288, 226);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(115, 56);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(28, 226);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(151, 56);
            this.Tim.TabIndex = 6;
            this.Tim.Text = "Tìm món ăn";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(523, 226);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(115, 56);
            this.Thoat.TabIndex = 7;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Món ăn hôm nay là:";
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 22;
            this.list.Location = new System.Drawing.Point(440, 31);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(242, 180);
            this.list.TabIndex = 9;
            // 
            // Lab1_Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 413);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "Lab1_Bai8";
            this.Text = "Lab1_Bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ListBox list;
    }
}