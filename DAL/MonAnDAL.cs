using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MonAnDAL
    {
        public SqlConnection conn;
        
        public MonAnDAL()
        {
            conn = new SqlConnection("Data Source=LAPTOP-ASUSTUFF\\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True");
        }
        //Hien thi mon an
        public DataTable DSMonAn()
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DSMonAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally { conn.Close(); }
            return null;
        }
        //Them mon an
        public int ThemMon(MonAnET monAn)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ThemMonAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaMon = new SqlParameter("@MaMon", monAn.MaMonAn);
                SqlParameter paTenMon = new SqlParameter("@TenMon", monAn.TenMonAn);
                SqlParameter paDonGia = new SqlParameter("@DonGia", monAn.DonGia);
                SqlParameter paTrangThai = new SqlParameter("@TrangThai", monAn.TrangThai);
                cmd.Parameters.Add(paMaMon);
                cmd.Parameters.Add(paTenMon);
                cmd.Parameters.Add(paDonGia);
                cmd.Parameters.Add(paTrangThai);
                int row = cmd.ExecuteNonQuery();
                return row;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return 0;
        }
        //Xoa mon
        public int XoaMon(MonAnET monAn)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_XoaMon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaMon = new SqlParameter("@MaMon", monAn.MaMonAn);
                cmd.Parameters.Add(paMaMon);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { conn.Close(); }
            return 0;
        }
        //Sua mon
        public int SuaMon(MonAnET monAn)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SuaMon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaMon = new SqlParameter("@MaMon", monAn.MaMonAn);
                SqlParameter paTenMon = new SqlParameter("@TenMon", monAn.TenMonAn);
                SqlParameter paDonGia = new SqlParameter("@DonGia", monAn.DonGia);
                SqlParameter paTrangThai = new SqlParameter("@TrangThai", monAn.TrangThai);
                cmd.Parameters.Add(paMaMon);
                cmd.Parameters.Add(paTenMon);
                cmd.Parameters.Add(paDonGia);
                cmd.Parameters.Add(paTrangThai);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return 0;
        }
    }
}
