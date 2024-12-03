using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;

namespace DAL
{
    public class BanDAL
    {
        public SqlConnection Connection;
        public BanDAL() { 
            Connection = new SqlConnection("Data Source=LAPTOP-ASUSTUFF\\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True");
        }
        //hien thi ban an
        public DataTable DanhSachBan()
        {
                DataTable dt = new DataTable();
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DanhSachBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Connection.Close(); }
            return dt;
        }
        //them ban
        public int ThemBan(TableET ban)
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ThemBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaBan = new SqlParameter("@MaBan",ban.MaBan);
                SqlParameter paTenBan = new SqlParameter("@TenBan",ban.TenBan);
                SqlParameter paViTri = new SqlParameter("@ViTri",ban.Tang);
                SqlParameter paTrangThai = new SqlParameter("@TrangThai",ban.TrangThai);
                cmd.Parameters.Add(paMaBan);
                cmd.Parameters.Add(paTenBan);
                cmd.Parameters.Add(paViTri);
                cmd.Parameters.Add(paTrangThai);
                int row = cmd.ExecuteNonQuery();
                return row;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { Connection.Close(); }
            return 0;
        }
        public int  SuaBan(TableET ban)
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SuaBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaBan = new SqlParameter("@MaBan", ban.MaBan);
                SqlParameter paTenBan = new SqlParameter("@TenBan", ban.TenBan);
                SqlParameter paViTri = new SqlParameter("@ViTri", ban.Tang);
                SqlParameter paTrangThai = new SqlParameter("@TrangThai", ban.TrangThai);
                cmd.Parameters.Add(paMaBan);
                cmd.Parameters.Add(paTenBan);
                cmd.Parameters.Add(paViTri);
                cmd.Parameters.Add(paTrangThai);
                int row = cmd.ExecuteNonQuery();
                return row;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
            return 0;
        }

        public int SuaTrangThaiBan(TableET ban)
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SuaTrangThaiBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaBan = new SqlParameter("@MaBan", ban.MaBan);
                SqlParameter paTrangThai = new SqlParameter("@TrangThai", ban.TrangThai);
                cmd.Parameters.Add(paMaBan);
                cmd.Parameters.Add(paTrangThai);
                int row = cmd.ExecuteNonQuery();
                return row;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
            return 0;
        }
        //xoa ban
        public int XoaBan(TableET ban)
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_XoaBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paMaBan = new SqlParameter("@MaBan", ban.MaBan);
                cmd.Parameters.Add(paMaBan);
                int row = cmd.ExecuteNonQuery();
                return row;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
            return 0;
        }
        //Tong ban
        public object TongSoBan()
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_TongSoBan", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                object row = cmd.ExecuteScalar();
                return row;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
            return 0;
        }
    }
}
