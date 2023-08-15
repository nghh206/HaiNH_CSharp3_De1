using DomainClass;
using Service;

namespace hainh
{
    public partial class MahForm : Form
    {
        List<XeMay>? _lstXeMay = null;
        List<LoaiXM>? _lstLoaiXM = null;
        public MahForm()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            _lstXeMay = ServiceXeMay.GetAll();
            HienThi();
        }
        private void HienThi()
        {
            dgvXeMay.DataSource = _lstXeMay;
            dgvXeMay.Columns[0].HeaderText = "STT";
            dgvXeMay.Columns[1].HeaderText = "Tên xe";
            dgvXeMay.Columns[2].HeaderText = "Mô tả";
            dgvXeMay.Columns[3].Visible = false;
            dgvXeMay.Columns[4].HeaderText = "Số lượng";
            dgvXeMay.Columns[5].Visible = false;

            dgvXeMay.Columns.Add("LoaiXe", "Loại xe");

            foreach (DataGridViewRow row in dgvXeMay.Rows)
            {
                XeMay xe = (XeMay)row.DataBoundItem;
                int maLoaiXe = xe.MaLoaiXe;
                LoaiXM? loaiXe = _lstLoaiXM?.FirstOrDefault(x => x.MaLoaiXe == maLoaiXe);
                row.Cells[6].Value = loaiXe != null ? loaiXe.TenLoaiXe : "Xe nhái";
            }


            if (_lstXeMay != null && _lstXeMay.Count > 0)
            {
                dgvXeMay.Columns[0].Selected = true;
            }
        }

        private void dgvXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvXeMay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                txtTenXe.Text = dgvXeMay.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtMoTa.Text = dgvXeMay.Rows[e.RowIndex].Cells[2].Value?.ToString();
                txtGiaNhap.Text = dgvXeMay.Rows[e.RowIndex].Cells[3].Value?.ToString();
                string? soLuong = dgvXeMay.Rows[e.RowIndex].Cells[4].Value?.ToString();
                if (!string.IsNullOrEmpty(soLuong))
                {
                    int selectedIndex;
                    if (int.TryParse(soLuong, out selectedIndex) && selectedIndex >= 0 && selectedIndex < cboSoLuong.Items.Count)
                    {
                        cboSoLuong.SelectedIndex = selectedIndex;
                    }
                }

            }
        }

        private void MahForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cboSoLuong.Items.Add(i.ToString());
            }
            _lstLoaiXM = ServiceLoaiXM.GetAll();
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            XoaForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenXe.Text)
                || string.IsNullOrEmpty(txtMoTa.Text)
                || string.IsNullOrEmpty(txtGiaNhap.Text))
            {
                return;
            }
            XeMay xeMay = new XeMay();
            xeMay.TenXe = txtTenXe.Text;
            xeMay.MoTa = txtMoTa.Text;
            xeMay.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
            xeMay.SoLuong = cboSoLuong.SelectedIndex;
            xeMay = ServiceXeMay.Create(xeMay);
            XoaForm();
            _lstXeMay = ServiceXeMay.GetAll();

            HienThi();
        }
        private void XoaForm()
        {
            txtTenXe.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
            cboSoLuong.SelectedIndex = -1;
            txtTimKiem.Text = "Nhập tên để tìm kiếm";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvXeMay.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int selectedIndex = dgvXeMay.SelectedRows[0].Index;
                XeMay xeMay = _lstXeMay[selectedIndex];

                ServiceXeMay.Delete(xeMay);

                XoaForm();
                _lstXeMay = ServiceXeMay.GetAll();
                MessageBox.Show("Xoá thành công");
                HienThi();
            }

        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                return;
            }
            _lstXeMay = ServiceXeMay.FindByName(txtTimKiem.Text);
            dgvXeMay.DataSource = _lstXeMay;
            HienThi();
        }

        private void txtGiaNhap_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGiaNhap.Text, out int value) || value < 0)
            {
                MessageBox.Show("Phải là số nguuyên và lớn hơn 0.");
                txtGiaNhap.Focus();
                return;
            }
        }
    }
}