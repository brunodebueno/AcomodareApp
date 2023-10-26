using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class ProdutosBLL {
        public AcessoHelper db = new AcessoHelper();


        public DataTable Select() {
            try {
                string sql = "SELECT * FROM produtos Where Ativo = 1";
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
                string sql = "SELECT TOP (1) * FROM produtos Where id=@id";
                db.AddParameter("@id", id);
                DbDataReader reader = db.ExecuteReader(sql);
                return reader;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable Select(string pesquisa) {
            try {
                string sql = $"SELECT * FROM produtos Where Ativo = 1 And descricao like '%{pesquisa}%' ";
                DbDataReader reader = db.ExecuteReader(sql);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Insert(string descricao, string tipoUn, string codigoEan, string preco, string quantidade) {
            try {
                string sql = "Insert Into produtos(descricao,tipoUn,codigoEan,preco,quantidade,ativo) " +
                    "values (@descricao,@tipoUn,@codigoEan,@preco,@quantidade,@ativo)";
                db.AddParameter("@descricao", descricao);
                db.AddParameter("@tipoUn", tipoUn);
                db.AddParameter("@codigoEan", codigoEan);
                db.AddParameter("@preco", Convert.ToDecimal(preco, CultureInfo.CurrentCulture));
                db.AddParameter("@quantidade", Convert.ToDecimal(quantidade, CultureInfo.CurrentCulture));
                db.AddParameter("@ativo", true);
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Update(int id, string descricao, string tipoUn, string codigoEan, string preco, string quantidade) {
            try {
                string sql = "Update produtos set descricao=@descricao,tipoUn=@tipoUn,codigoEan=@codigoEan," +
                    "preco=@preco,quantidade=@quantidade WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@descricao", descricao);
                db.AddParameter("@tipoUn", tipoUn);
                db.AddParameter("@codigoEan", codigoEan);
                db.AddParameter("@preco", Convert.ToDecimal(preco, CultureInfo.CurrentCulture));
                db.AddParameter("@quantidade", Convert.ToDecimal(quantidade, CultureInfo.CurrentCulture));
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Delete(int id) {
            try {
                string sql = "Update produtos set ativo=@ativo WHERE id = @id";

                db.AddParameter("@id", id);
                db.AddParameter("@ativo", false);
               
                db.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
