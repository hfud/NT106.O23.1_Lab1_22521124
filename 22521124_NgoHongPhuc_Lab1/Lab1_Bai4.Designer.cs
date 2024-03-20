namespace _22521124_NgoHongPhuc_Lab1
{
    partial class Lab1_Bai4
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
            this.film = new System.Windows.Forms.ComboBox();
            this.theater = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.HangGhe = new System.Windows.Forms.CheckedListBox();
            this.DatVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rạp";
            // 
            // film
            // 
            this.film.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film.FormattingEnabled = true;
            this.film.Items.AddRange(new object[] {
            "Đào, phở và piano",
            "Mai",
            "Gặp lại chị bầu",
            "Tarot"});
            this.film.Location = new System.Drawing.Point(75, 18);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(285, 28);
            this.film.TabIndex = 2;
            this.film.SelectedIndexChanged += new System.EventHandler(this.film_SelectedIndexChanged);
            // 
            // theater
            // 
            this.theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theater.FormattingEnabled = true;
            this.theater.Location = new System.Drawing.Point(75, 68);
            this.theater.Name = "theater";
            this.theater.Size = new System.Drawing.Size(285, 28);
            this.theater.TabIndex = 3;
            this.theater.SelectedIndexChanged += new System.EventHandler(this.theater_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ và Tên";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(131, 125);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(229, 27);
            this.name.TabIndex = 5;
            // 
            // HangGhe
            // 
            this.HangGhe.BackColor = System.Drawing.Color.White;
            this.HangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangGhe.FormattingEnabled = true;
            this.HangGhe.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.HangGhe.Location = new System.Drawing.Point(409, 18);
            this.HangGhe.Name = "HangGhe";
            this.HangGhe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HangGhe.Size = new System.Drawing.Size(121, 356);
            this.HangGhe.TabIndex = 6;
            // 
            // DatVe
            // 
            this.DatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatVe.Location = new System.Drawing.Point(99, 204);
            this.DatVe.Name = "DatVe";
            this.DatVe.Size = new System.Drawing.Size(163, 58);
            this.DatVe.TabIndex = 7;
            this.DatVe.Text = "Đặt vé";
            this.DatVe.UseVisualStyleBackColor = true;
            this.DatVe.Click += new System.EventHandler(this.DatVe_Click);
            // 
            // Lab1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.DatVe);
            this.Controls.Add(this.HangGhe);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.theater);
            this.Controls.Add(this.film);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab1_Bai4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Lab1_Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox film;
        private System.Windows.Forms.ComboBox theater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckedListBox HangGhe;
        private System.Windows.Forms.Button DatVe;
    }
}