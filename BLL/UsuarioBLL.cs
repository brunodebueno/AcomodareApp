using System;
using System.Data.Common;

namespace BLL {
    public class UsuarioBLL {
        public AcessoHelper db = new AcessoHelper();

        /*
        public void cadastraUsuario(string nome, string email, string senha) {
            try {
                string sql = "Insert Into Usuarios(nome,email,senha) values (@nome,@email,@senha)";
                db.AddParameter("@nome", nome);
                db.AddParameter("@email", email);
                db.AddParameter("@senha", senha);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void alterarUsuario(string nome, string email, string senha, int usuarioid) {
            try {
                string sql = "Update Usuarios set nome=@nome, email=@email, senha=@senha where usuarioid =@usuarioid";
                db.AddParameter("@nome", nome);
                db.AddParameter("@email", email);
                db.AddParameter("@senha", senha);
                db.AddParameter("@usuarioid", usuarioid);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void excluirUsuario(int usuarioid) {
            try {
                string sql = "Delete From Usuarios where usuarioid=@usuarioid";
                db.AddParameter("@usuarioid", usuarioid);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }
        */
        public DbDataReader Procurar(int usuarioid) {
            try {
                string sql = "SELECT * FROM Usuarios WHERE ID=@usuarioid";
                db.AddParameter("@ID", usuarioid);
                return db.ExecuteReader(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool ProcurarPorNome(string nome) {
            DbDataReader dr = null;
            try {
                string sql = "SELECT * FROM Usuarios WHERE nome=@nome";
                db.AddParameter("@nome", nome);
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

        public DbDataReader Selecionar() {
            try {
                string sql = "SELECT * FROM usuarios";
                return db.ExecuteReader(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public string gerarHashSenha(object texto) {
            return db.GerarHash(texto.ToString());
        }
    }
}
