using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class PetsBLL {
        public AcessoHelper db = new AcessoHelper();


        public DataTable Select() {
            try {
                string sql = "SELECT * FROM animais Where Ativo = 1";
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
                string sql = "SELECT TOP (1) * FROM animais Where id=@id";
                db.AddParameter("@id", id);
                DbDataReader reader = db.ExecuteReader(sql);
                return reader;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable Select(string pesquisa) {
            try {
                string sql = $"SELECT * FROM animais Where Ativo = 1 And Nome like '%{pesquisa}%' ";
                DbDataReader reader = db.ExecuteReader(sql);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Insert(string nome, string raca, string proprietario, string cor, string pelagem, string tamanho, string observacoes) {
            try {
                string sql = "Insert Into animais(nome,raca,proprietario,cor,pelagem,tamanho,observacoes,ativo) " +
                    "values (@nome,@raca,@proprietario,@cor,@pelagem,@tamanho,@observacoes,@ativo)";
                db.AddParameter("@nome", nome);
                db.AddParameter("@raca", raca);
                db.AddParameter("@proprietario", proprietario);
                db.AddParameter("@cor", cor);
                db.AddParameter("@pelagem", pelagem);
                db.AddParameter("@tamanho", tamanho);
                //db.AddParameter("@peso", peso);
                db.AddParameter("@observacoes", observacoes);
                db.AddParameter("@ativo", true);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Update(int id, string nome, string raca, string proprietario, string cor, string pelagem, string tamanho, string observacoes) {
            try {
                string sql = "Update animais set nome=@nome,raca=@raca,proprietario=@proprietario," +
                    "cor=@cor,pelagem=@pelagem,tamanho=@tamanho,observacoes=@observacoes WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@nome", nome);
                db.AddParameter("@raca", raca);
                db.AddParameter("@proprietario", proprietario);
                db.AddParameter("@cor", cor);
                db.AddParameter("@pelagem", pelagem);
                db.AddParameter("@tamanho", tamanho);
                //db.AddParameter("@peso", peso);
                db.AddParameter("@observacoes", observacoes);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Delete(int id) {
            try {
                string sql = "Update animais set ativo=@ativo WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@ativo", false);
               
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
