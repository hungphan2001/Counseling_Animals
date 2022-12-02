using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HeChuyenGia_Nhom2
{
    public partial class tuvan1 : Form
    {
        private List<string> ListMadiadiem = new List<string>();
        private List<string> ListTendiadiem = new List<string>();
        private ketnoi kn = new ketnoi();
        private bool run = false;
        public tuvan1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-O4T8056\SQLEXPRESS;Initial Catalog=Animals;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select masukien,motasukien from tblsukien WHERE loaisukien NOT LIKE '%convat%'";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dgvsukien.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void tuvan1_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            string qr = "select masukien,motasukien from tblsukien where loaisukien='convat'";
            DataTable tbTruong = kn.getTable(qr);
            for (int i = 0; i < tbTruong.Rows.Count; i++)
            {
                ListMadiadiem.Add(tbTruong.Rows[i][0].ToString());
                ListTendiadiem.Add(tbTruong.Rows[i][1].ToString());
            }
        }
      
        private void dgvsukien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvsukien = (DataGridView)this.Controls["dgvsukien"];
            DataGridView dgvtuvan = (DataGridView)this.Controls["dgvtuvan"];
            DataGridViewRow ThemMoi = dgvsukien.CurrentRow;//Dòng chuẩn bị thêm
            dgvtuvan.Rows.Add(new DataGridViewRow()); //Thêm dòng vào dgv muốn thêm
            for (Int32 i = 0; i < ThemMoi.Cells.Count; i++)
                dgvtuvan.Rows[dgvtuvan.Rows.Count - 2].Cells[i].Value = ThemMoi.Cells[i].Value;//nếu như dgv2.AllowUserToAddRows = true; thì Rows.Count - 2 ngược lại nếu dgv2.AllowUserToAddRows = false; thì Rows.Count - 1
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            suydientien sd = new suydientien();
            sd.DocLuatTuFfile();
            run = true;
            int i = 0;
            List<string> gt = new List<string>();
            ricKQ.Text = "";
            for(i=0; i < dgvtuvan.Rows.Count - 1; i++)
            {
                string mask = dgvtuvan.Rows[i].Cells[0].Value.ToString();
                gt.Add(mask);
            }
            int d = 0;
            progressBar.Maximum = ListMadiadiem.Count - 1;
            progressBar.Minimum = 0;
            if (gt.Count > 0)
            {
                int dem = 0;
                foreach (string s in ListMadiadiem)
                {
                    if (!run)
                    {
                        btnReset.Enabled = false;
                        break;
                    }
                    progressBar.Value = dem;
                    List<string> kl = new List<string>();
                    kl.Add(s);

                    if (sd.SuyDien(gt, kl) == true)
                    {
                        ricKQ.Text += ListTendiadiem.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d == 0 && run != false)
                {
                    ricKQ.Text = "Không có địa điểm nào phù hợp!!!\nXin vui lòng chọn lại!!";
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn đầy đủ thông tin!");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ricKQ.Text = "";
            dgvtuvan.Rows.Clear();
            dgvtuvan.Refresh();
        }
    }
}
