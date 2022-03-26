using SistemaSindical.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.repositorio
{
    public class RegionaisRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";
        public void Insert(Regionais reg)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into regionais (nome) values (@nome)", conn);
            cmd.Parameters.AddWithValue("@nome", reg.nome);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Atualizar(Regionais reg)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("update regionais set nome = @nome where id = @id", conn);
            cmd.Parameters.AddWithValue("nome",reg.nome);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Int64 id)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("delete from regionais where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Regionais> SelecionarTodos()
        {
            //select id, nome from regionais
             List<Regionais> lista = new List<Regionais>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select  A.nome , B.nome from sindicatos A RIGHT JOIN Regionais B on A.id = B.id; ", conn); 
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Regionais reg = new Regionais();
                //reg.id = Convert.ToInt64(rd[0]);
                reg.nome = Convert.ToString(rd[2]);
                lista.Add(reg);
            }
            conn.Close();
            return lista;
        }
        public List<Regionais>Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            string comando = "select nome from regionais";
            List<Regionais> lista = new List<Regionais>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (tipoPesquisa == 1)
            {
                cmd = new SqlCommand(comando + " where nome LIKE @nome", conn);
                cmd.Parameters.AddWithValue("@nome", "%" + textoPesquisa + "%");
            }
            conn.Open();
            Console.WriteLine(cmd.CommandText);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Regionais reg = new Regionais();
                reg.nome = Convert.ToString(rd[1]);
                lista.Add(reg);
            }
            conn.Close();
            return lista;
        }
    }
}
