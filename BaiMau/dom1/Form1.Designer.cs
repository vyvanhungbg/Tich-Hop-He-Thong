
namespace dom1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Them = new System.Windows.Forms.Button();
            this.Button_Sua = new System.Windows.Forms.Button();
            this.Button_Xoa = new System.Windows.Forms.Button();
            this.Button_Thoat = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.ListView();
            this.stt = new System.Windows.Forms.ColumnHeader();
            this.hoten = new System.Windows.Forms.ColumnHeader();
            this.monhoc = new System.Windows.Forms.ColumnHeader();
            this.diem1 = new System.Windows.Forms.ColumnHeader();
            this.diem2 = new System.Windows.Forms.ColumnHeader();
            this.cbbMa = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm lần 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(272, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "CẬP NHẬT KẾT QUẢ HỌC TẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm lần 2";
            // 
            // Button_Them
            // 
            this.Button_Them.Location = new System.Drawing.Point(98, 179);
            this.Button_Them.Name = "Button_Them";
            this.Button_Them.Size = new System.Drawing.Size(75, 23);
            this.Button_Them.TabIndex = 5;
            this.Button_Them.Text = "Thêm";
            this.Button_Them.UseVisualStyleBackColor = true;
            this.Button_Them.Click += new System.EventHandler(this.Button_Them_Click);
            // 
            // Button_Sua
            // 
            this.Button_Sua.Location = new System.Drawing.Point(272, 179);
            this.Button_Sua.Name = "Button_Sua";
            this.Button_Sua.Size = new System.Drawing.Size(75, 23);
            this.Button_Sua.TabIndex = 6;
            this.Button_Sua.Text = "Sửa";
            this.Button_Sua.UseVisualStyleBackColor = true;
            this.Button_Sua.Click += new System.EventHandler(this.Button_Sua_Click);
            // 
            // Button_Xoa
            // 
            this.Button_Xoa.Location = new System.Drawing.Point(419, 178);
            this.Button_Xoa.Name = "Button_Xoa";
            this.Button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.Button_Xoa.TabIndex = 7;
            this.Button_Xoa.Text = "Xóa";
            this.Button_Xoa.UseVisualStyleBackColor = true;
            this.Button_Xoa.Click += new System.EventHandler(this.Button_Xoa_Click);
            // 
            // Button_Thoat
            // 
            this.Button_Thoat.Location = new System.Drawing.Point(553, 179);
            this.Button_Thoat.Name = "Button_Thoat";
            this.Button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.Button_Thoat.TabIndex = 8;
            this.Button_Thoat.Text = "Thoát";
            this.Button_Thoat.UseVisualStyleBackColor = true;
            this.Button_Thoat.Click += new System.EventHandler(this.Button_Thoat_Click);
            // 
            // dataList
            // 
            this.dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.hoten,
            this.monhoc,
            this.diem1,
            this.diem2});
            this.dataList.HideSelection = false;
            this.dataList.Location = new System.Drawing.Point(150, 241);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(396, 155);
            this.dataList.TabIndex = 9;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.View = System.Windows.Forms.View.Details;
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.dataList_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // hoten
            // 
            this.hoten.Text = "Họ tên SV";
            // 
            // monhoc
            // 
            this.monhoc.Text = "Môn học";
            // 
            // diem1
            // 
            this.diem1.Text = "Điểm lần 1";
            // 
            // diem2
            // 
            this.diem2.Text = "Điểm lần 2";
            // 
            // cbbMa
            // 
            this.cbbMa.FormattingEnabled = true;
            this.cbbMa.Location = new System.Drawing.Point(193, 71);
            this.cbbMa.Name = "cbbMa";
            this.cbbMa.Size = new System.Drawing.Size(121, 23);
            this.cbbMa.TabIndex = 10;
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(451, 71);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 23);
            this.cbbMon.TabIndex = 11;
            // 
            // txtDiem1
            // 
            this.txtDiem1.Location = new System.Drawing.Point(193, 101);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(121, 23);
            this.txtDiem1.TabIndex = 12;
            // 
            // txtDiem2
            // 
            this.txtDiem2.Location = new System.Drawing.Point(451, 100);
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(121, 23);
            this.txtDiem2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiem2);
            this.Controls.Add(this.txtDiem1);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbMa);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.Button_Thoat);
            this.Controls.Add(this.Button_Xoa);
            this.Controls.Add(this.Button_Sua);
            this.Controls.Add(this.Button_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Them;
        private System.Windows.Forms.Button Button_Sua;
        private System.Windows.Forms.Button Button_Xoa;
        private System.Windows.Forms.Button Button_Thoat;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.ComboBox cbbMa;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtDiem2;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader monhoc;
        private System.Windows.Forms.ColumnHeader diem1;
        private System.Windows.Forms.ColumnHeader diem2;
    }
}

