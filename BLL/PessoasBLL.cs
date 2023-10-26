using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class PessoasBLL {
        public AcessoHelper db = new AcessoHelper();


        public DataTable Select() {
            try {
                string sql = "SELECT * FROM pessoas Where Ativo = 1";
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
                string sql = "SELECT TOP (1) * FROM pessoas Where id=@id";
                db.AddParameter("@id", id);
                DbDataReader reader = db.ExecuteReader(sql);
                return reader;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable Select(string pesquisa) {
            try {
                string sql = $"SELECT * FROM pessoas Where Ativo = 1 And Nome like '%{pesquisa}%' ";
                DbDataReader reader = db.ExecuteReader(sql);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Insert(string nome, string cpf, string genero, DateTime dataNasc,
            string endereco, string telefone, string bairro, string cidade, string cep, string UF) { 
            try {
                string sql = "Insert Into pessoas(nome,cpf,genero,dataNascimento,endereco,telefone,bairro,cidade,cep,uf,ativo) " +
                    "values (@nome,@cpf,@genero,@dataNasc,@endereco,@telefone,@bairro,@cidade,@cep,@uf,@ativo)";

                db.AddParameter("@nome", nome);
                db.AddParameter("@cpf", cpf);
                db.AddParameter("@genero", genero);
                db.AddParameter("@dataNasc", dataNasc);
                db.AddParameter("@endereco", endereco);
                db.AddParameter("@telefone", telefone);
                db.AddParameter("@bairro", bairro);
                db.AddParameter("@cidade", cidade);
                db.AddParameter("@cep", cep);
                db.AddParameter("@uf", UF);
                db.AddParameter("@ativo", true);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Update(int id, string nome, string cpf, string genero, DateTime dataNasc,
            string endereco, string telefone, string bairro, string cidade, string cep, string UF) {
            try {
                string sql = "Update pessoas set nome=@nome,cpf=@cpf," +
                    "genero=@genero,dataNasc=@dataNasc,endereco=@endereco,telefone=@telefone," +
                    "bairro=@bairro,cidade=@cidade,cep=@cep,uf=@uf WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@nome", nome);
                db.AddParameter("@cpf", cpf);
                db.AddParameter("@genero", genero);
                db.AddParameter("@dataNasc", dataNasc);
                db.AddParameter("@endereco", endereco);
                db.AddParameter("@telefone", telefone);
                db.AddParameter("@bairro", bairro);
                db.AddParameter("@cidade", cidade);
                db.AddParameter("@cep", cep);
                db.AddParameter("@uf", UF);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Delete(int id) {
            try {
                string sql = "Update pessoas set ativo=@ativo WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@ativo", false);
               
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
