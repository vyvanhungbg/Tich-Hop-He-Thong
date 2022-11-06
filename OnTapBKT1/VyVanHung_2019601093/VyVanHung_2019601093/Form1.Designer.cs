namespace VyVanHung_2019601093
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNhaXB = new System.Windows.Forms.ComboBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbErrorGiaBan = new System.Windows.Forms.Label();
            this.lbErrorTenSach = new System.Windows.Forms.Label();
            this.lbErrorMaSach = new System.Windows.Forms.Label();
            this.lbErrorNXB = new System.Windows.Forms.Label();
            this.dtgrView = new System.Windows.Forms.DataGridView();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = " NHẬT THÔNG TIN SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà XB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tác Giả";
            // 
            // cbbNhaXB
            // 
            this.cbbNhaXB.FormattingEnabled = true;
            this.cbbNhaXB.Location = new System.Drawing.Point(327, 97);
            this.cbbNhaXB.Name = "cbbNhaXB";
            this.cbbNhaXB.Size = new System.Drawing.Size(121, 24);
            this.cbbNhaXB.TabIndex = 6;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(327, 138);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(121, 22);
            this.txtMaSach.TabIndex = 7;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(327, 177);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(121, 22);
            this.txtTenSach.TabIndex = 8;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(327, 216);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(121, 22);
            this.txtGiaBan.TabIndex = 9;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(327, 255);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(121, 22);
            this.txtTacGia.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(657, 94);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(657, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(657, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(657, 253);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.ForeColor = System.Drawing.Color.Red;
            this.lbTacGia.Location = new System.Drawing.Point(487, 260);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(0, 17);
            this.lbTacGia.TabIndex = 19;
            // 
            // lbErrorGiaBan
            // 
            this.lbErrorGiaBan.AutoSize = true;
            this.lbErrorGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lbErrorGiaBan.Location = new System.Drawing.Point(487, 220);
            this.lbErrorGiaBan.Name = "lbErrorGiaBan";
            this.lbErrorGiaBan.Size = new System.Drawing.Size(0, 17);
            this.lbErrorGiaBan.TabIndex = 18;
            // 
            // lbErrorTenSach
            // 
            this.lbErrorTenSach.AutoSize = true;
            this.lbErrorTenSach.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTenSach.Location = new System.Drawing.Point(487, 180);
            this.lbErrorTenSach.Name = "lbErrorTenSach";
            this.lbErrorTenSach.Size = new System.Drawing.Size(0, 17);
            this.lbErrorTenSach.TabIndex = 17;
            // 
            // lbErrorMaSach
            // 
            this.lbErrorMaSach.AutoSize = true;
            this.lbErrorMaSach.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMaSach.Location = new System.Drawing.Point(487, 140);
            this.lbErrorMaSach.Name = "lbErrorMaSach";
            this.lbErrorMaSach.Size = new System.Drawing.Size(0, 17);
            this.lbErrorMaSach.TabIndex = 16;
            // 
            // lbErrorNXB
            // 
            this.lbErrorNXB.AutoSize = true;
            this.lbErrorNXB.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNXB.Location = new System.Drawing.Point(487, 100);
            this.lbErrorNXB.Name = "lbErrorNXB";
            this.lbErrorNXB.Size = new System.Drawing.Size(0, 17);
            this.lbErrorNXB.TabIndex = 15;
            // 
            // dtgrView
            // 
            this.dtgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrView.Location = new System.Drawing.Point(191, 364);
            this.dtgrView.Name = "dtgrView";
            this.dtgrView.RowTemplate.Height = 24;
            this.dtgrView.Size = new System.Drawing.Size(588, 150);
            this.dtgrView.TabIndex = 20;
            this.dtgrView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrView_CellClick);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Blue;
            this.lbError.Location = new System.Drawing.Point(442, 329);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 543);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.dtgrView);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.lbErrorGiaBan);
            this.Controls.Add(this.lbErrorTenSach);
            this.Controls.Add(this.lbErrorMaSach);
            this.Controls.Add(this.lbErrorNXB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.cbbNhaXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNhaXB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbErrorGiaBan;
        private System.Windows.Forms.Label lbErrorTenSach;
        private System.Windows.Forms.Label lbErrorMaSach;
        private System.Windows.Forms.Label lbErrorNXB;
        private System.Windows.Forms.DataGridView dtgrView;
        private System.Windows.Forms.Label lbError;
    }
}

