using System;
using System.Data;
using System.Data.Common;
using System.Globalization;

namespace BLL {
    public class UsuarioBLL {
        public AcessoHelper db = new AcessoHelper();

        public DataTable Select() {
            try {
                string sql = "SELECT * FROM Usuarios Where Ativo = 1";
                DbDataReader reader = db.ExecuteReader(sql);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public DbDataReader Select(int id) {
            try {
                string sql = "SELECT TOP (1) * FROM Usuarios Where id=@id";
                db.AddParameter("@id", id);
                DbDataReader reader = db.ExecuteReader(sql);
                return reader;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable Select(string pesquisa) {
            try {
                string sql = $"SELECT * FROM Usuarios Where Ativo = 1 And login like '%{pesquisa}%' ";
                DbDataReader reader = db.ExecuteReader(sql);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Insert(string login, string senha) {
            try {
                string sql = "Insert Into Usuarios(login,senha,ativo) " +
                    "values (@login,@senha,@ativo)";

                db.AddParameter("@login", login);
                db.AddParameter("@senha", senha);               
                db.AddParameter("@ativo", true);

                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Update(int id, string login, string senha) {
            try {
                string sql = "Update Usuarios set login=@login,senha=@senha WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@login", login);
                db.AddParameter("@senha", senha);

                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Delete(int id) {
            try {
                string sql = "Update Usuarios set ativo=@ativo WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@ativo", false);

                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }


        public bool ProcurarPorLogin(string login, string senha) {
            DbDataReader dr = null;
            try {
                string sql = "SELECT * FROM Usuarios WHERE Login=@login AND Senha=@senha AND Ativo=1";
                db.AddParameter("@login", login);
                db.AddParameter("@senha", senha);
                dr = db.ExecuteReader(sql);
                if (dr.HasRows)
                    return true;
                else
                    return false;
            } catch (Exception ex) {
                throw ex;
            } finally {
                dr.Close();
            }
        }

        public string gerarHashSenha(object texto) {
            return db.GerarHash(texto.ToString());
        }
    }
}
