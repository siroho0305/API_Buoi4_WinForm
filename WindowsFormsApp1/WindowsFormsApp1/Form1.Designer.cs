namespace WindowsFormsApp1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.StudentRecordData = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTenSV = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbSBD = new System.Windows.Forms.Label();
            this.lbHoSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(899, 180);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 52);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // StudentRecordData
            // 
            this.StudentRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordData.Location = new System.Drawing.Point(32, 251);
            this.StudentRecordData.Margin = new System.Windows.Forms.Padding(4);
            this.StudentRecordData.Name = "StudentRecordData";
            this.StudentRecordData.RowHeadersWidth = 51;
            this.StudentRecordData.Size = new System.Drawing.Size(1033, 249);
            this.StudentRecordData.TabIndex = 46;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(674, 180);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 52);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(463, 180);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 52);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(258, 180);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(139, 53);
            this.btnCapNhat.TabIndex = 43;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 180);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 52);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(699, 59);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 22);
            this.txtSDT.TabIndex = 41;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(699, 6);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(201, 22);
            this.txtTenSV.TabIndex = 40;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(180, 107);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(215, 22);
            this.txtDiaChi.TabIndex = 39;
            // 
            // txtSBD
            // 
            this.txtSBD.Location = new System.Drawing.Point(180, 61);
            this.txtSBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(215, 22);
            this.txtSBD.TabIndex = 38;
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(180, 8);
            this.txtHoSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(215, 22);
            this.txtHoSV.TabIndex = 37;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(554, 64);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(91, 17);
            this.lbSDT.TabIndex = 36;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbTenSV
            // 
            this.lbTenSV.AutoSize = true;
            this.lbTenSV.Location = new System.Drawing.Point(554, 11);
            this.lbTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(97, 17);
            this.lbTenSV.TabIndex = 35;
            this.lbTenSV.Text = "Tên Sinh Viên";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(46, 111);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(51, 17);
            this.lbDiachi.TabIndex = 34;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // lbSBD
            // 
            this.lbSBD.AutoSize = true;
            this.lbSBD.Location = new System.Drawing.Point(46, 64);
            this.lbSBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSBD.Name = "lbSBD";
            this.lbSBD.Size = new System.Drawing.Size(89, 17);
            this.lbSBD.TabIndex = 33;
            this.lbSBD.Text = "Số báo danh";
            // 
            // lbHoSV
            // 
            this.lbHoSV.AutoSize = true;
            this.lbHoSV.Location = new System.Drawing.Point(46, 11);
            this.lbHoSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoSV.Name = "lbHoSV";
            this.lbHoSV.Size = new System.Drawing.Size(90, 17);
            this.lbHoSV.TabIndex = 32;
            this.lbHoSV.Text = "Họ Sinh Viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 507);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.StudentRecordData);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSBD);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTenSV);
            this.Controls.Add(this.lbDiachi);
            this.Controls.Add(this.lbSBD);
            this.Controls.Add(this.lbHoSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView StudentRecordData;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTenSV;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbSBD;
        private System.Windows.Forms.Label lbHoSV;
    }
}

