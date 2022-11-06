namespace VyVanHung_2019601093_Bai7_Phieu1
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
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindSTK = new System.Windows.Forms.Button();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgrView = new System.Windows.Forms.DataGridView();
            this.lbErrorSoTien = new System.Windows.Forms.Label();
            this.lbErrorDienThoai = new System.Windows.Forms.Label();
            this.lbErrorDiaChi = new System.Windows.Forms.Label();
            this.lbErrorTenTaiKhoan = new System.Windows.Forms.Label();
            this.lbErrorSTK = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.cbbDiaChi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngân Hàng";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(359, 78);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(100, 22);
            this.txtSTK.TabIndex = 6;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(359, 126);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(100, 22);
            this.txtTenTaiKhoan.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(359, 222);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 22);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(359, 270);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(100, 22);
            this.txtSoTien.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(710, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(710, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(710, 234);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 13;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(710, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(829, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnFindSTK
            // 
            this.btnFindSTK.Location = new System.Drawing.Point(829, 91);
            this.btnFindSTK.Name = "btnFindSTK";
            this.btnFindSTK.Size = new System.Drawing.Size(75, 23);
            this.btnFindSTK.TabIndex = 16;
            this.btnFindSTK.Text = "Tìm  STK";
            this.btnFindSTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFindSTK.UseVisualStyleBackColor = true;
            this.btnFindSTK.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(829, 185);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(75, 23);
            this.btnFindName.TabIndex = 19;
            this.btnFindName.Text = "Tìm Tên";
            this.btnFindName.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(829, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // dtgrView
            // 
            this.dtgrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrView.Location = new System.Drawing.Point(311, 355);
            this.dtgrView.Name = "dtgrView";
            this.dtgrView.RowTemplate.Height = 24;
            this.dtgrView.Size = new System.Drawing.Size(593, 150);
            this.dtgrView.TabIndex = 20;
            this.dtgrView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrView_CellClick);
            // 
            // lbErrorSoTien
            // 
            this.lbErrorSoTien.AutoSize = true;
            this.lbErrorSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorSoTien.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSoTien.Location = new System.Drawing.Point(506, 278);
            this.lbErrorSoTien.Name = "lbErrorSoTien";
            this.lbErrorSoTien.Size = new System.Drawing.Size(0, 17);
            this.lbErrorSoTien.TabIndex = 25;
            // 
            // lbErrorDienThoai
            // 
            this.lbErrorDienThoai.AutoSize = true;
            this.lbErrorDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorDienThoai.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDienThoai.Location = new System.Drawing.Point(506, 228);
            this.lbErrorDienThoai.Name = "lbErrorDienThoai";
            this.lbErrorDienThoai.Size = new System.Drawing.Size(0, 17);
            this.lbErrorDienThoai.TabIndex = 24;
            // 
            // lbErrorDiaChi
            // 
            this.lbErrorDiaChi.AutoSize = true;
            this.lbErrorDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorDiaChi.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDiaChi.Location = new System.Drawing.Point(506, 178);
            this.lbErrorDiaChi.Name = "lbErrorDiaChi";
            this.lbErrorDiaChi.Size = new System.Drawing.Size(0, 17);
            this.lbErrorDiaChi.TabIndex = 23;
            // 
            // lbErrorTenTaiKhoan
            // 
            this.lbErrorTenTaiKhoan.AutoSize = true;
            this.lbErrorTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorTenTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lbErrorTenTaiKhoan.Location = new System.Drawing.Point(506, 128);
            this.lbErrorTenTaiKhoan.Name = "lbErrorTenTaiKhoan";
            this.lbErrorTenTaiKhoan.Size = new System.Drawing.Size(0, 17);
            this.lbErrorTenTaiKhoan.TabIndex = 22;
            // 
            // lbErrorSTK
            // 
            this.lbErrorSTK.AutoSize = true;
            this.lbErrorSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorSTK.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSTK.Location = new System.Drawing.Point(506, 78);
            this.lbErrorSTK.Name = "lbErrorSTK";
            this.lbErrorSTK.Size = new System.Drawing.Size(0, 17);
            this.lbErrorSTK.TabIndex = 21;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(541, 320);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 26;
            // 
            // cbbDiaChi
            // 
            this.cbbDiaChi.FormattingEnabled = true;
            this.cbbDiaChi.Location = new System.Drawing.Point(359, 175);
            this.cbbDiaChi.Name = "cbbDiaChi";
            this.cbbDiaChi.Size = new System.Drawing.Size(100, 24);
            this.cbbDiaChi.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 531);
            this.Controls.Add(this.cbbDiaChi);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbErrorSoTien);
            this.Controls.Add(this.lbErrorDienThoai);
            this.Controls.Add(this.lbErrorDiaChi);
            this.Controls.Add(this.lbErrorTenTaiKhoan);
            this.Controls.Add(this.lbErrorSTK);
            this.Controls.Add(this.dtgrView);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindSTK);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtSTK);
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
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindSTK;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgrView;
        private System.Windows.Forms.Label lbErrorSoTien;
        private System.Windows.Forms.Label lbErrorDienThoai;
        private System.Windows.Forms.Label lbErrorDiaChi;
        private System.Windows.Forms.Label lbErrorTenTaiKhoan;
        private System.Windows.Forms.Label lbErrorSTK;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.ComboBox cbbDiaChi;
    }
}

