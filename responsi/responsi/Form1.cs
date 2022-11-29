using Npgsql;
using System.Data;
using System.Windows.Forms;


namespace responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=2022; Username=postgres; Password=informatika; Database=HR";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void dropdownDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            //masukin id departemen 
            //HR = HR
            // ENG = ENGINEER
            //dev = developer
            //pm = product manager
            // fin = finance

        }

        private void btInsert_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                sql = @"select*from hr_insert(:_nama_dep, :_nama)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama_dep", tbNama.Text);
                cmd.Parameters.AddWithValue("_nama", dropdownDep.Text);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diinput "/*, MessageBoxButtons.OK, MessageBoxIcon.Information*/);
                    conn.Close();
                    btnLoadData.PerformClick();
                    tbNama.Text = dropdownDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris yang ingin diupdate"/*, MessageBoxButtons.OK, MessageBoxIcon.Information*/);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from hr_update(:_id_karyawan, :_nama,:_id_dep,:_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_nama_dep", dropdownDep.Text);
                cmd.Parameters.AddWithValue("_id_dep", r.Cells["_id_dep"].Value.ToString());
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil update!");
                    conn.Close();
                    btnLoadData.PerformClick();
                    tbNama.Text = dropdownDep.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris!");
                return;
            }
            if (MessageBox.Show("Benar hapus data " + r.Cells["_nama"].Value.ToString() + "?", "Hapus berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"select * from hr_delete (:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar == 1)
                    {
                        MessageBox.Show("Berhasil dihapus!");
                        conn.Close();
                        btnLoadData.PerformClick();
                        tbNama.Text = dropdownDep.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();            }
            try
            {
                conn.Open();
                dgv.DataSource = null;
                sql = @"select * from hr_select";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgv.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
     
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dgv.Show();
        }
    }
}