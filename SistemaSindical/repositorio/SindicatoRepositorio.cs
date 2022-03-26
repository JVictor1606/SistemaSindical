using SistemaSindical.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.repositorio
{
    public class SindicatoRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";

        public void Insert(Sindicato sind)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into sindicatos (nome,cnpj, municipio,email,telefone, idFederacao) values (@nome, @cnpj, @municipio, @email, @telefone, @idFederacao)", conn);
            cmd.Parameters.AddWithValue("@nome",sind.nome);
            cmd.Parameters.AddWithValue("@cnpj", sind.cnpj);
            cmd.Parameters.AddWithValue("@municipio", sind.municipio);
            cmd.Parameters.AddWithValue("@email", sind.email);
            cmd.Parameters.AddWithValue("@telefone", sind.telefone);
            cmd.Parameters.AddWithValue("@idFederacao", sind.idFederacao);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(Sindicato sind)
        { 
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("update sindicatos set nome = @nome, cnpj = @cnpj, municipio = @municipio, email = @email, telefone = @telefone, idFederacao = @idFederacao where id = @id", conn);
            cmd.Parameters.AddWithValue("@nome", sind.nome);
            cmd.Parameters.AddWithValue("@cnpj", sind.cnpj);
            cmd.Parameters.AddWithValue("@municipio", sind.municipio);
            cmd.Parameters.AddWithValue("@email", sind.email);
            cmd.Parameters.AddWithValue("@telefone", sind.telefone);
            cmd.Parameters.AddWithValue("@id", sind.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Int64 id)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("delete from sindicato where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Sindicato> Selecionar()
        {
            List<Sindicato> lista = new List<Sindicato>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select A.id, A.nome , B.nome  from sindicatos A RIGHT JOIN Regionais B on A.id = B.id;", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                // A.idFederacao
                Sindicato sind = new Sindicato();
                Regionais reg = new Regionais();
                sind.id = Convert.ToInt64(rd[0]);
                sind.nome = Convert.ToString(rd[1]);
                reg.nome = Convert.ToString(rd[2]);
                lista.Add(sind);
            }
            conn.Close();
            return lista;
        }
        public List<Sindicato> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            string comando = "select nome from sindicatos";
            List<Sindicato> lista = new List<Sindicato>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (tipoPesquisa == 0)
            {
                cmd = new SqlCommand(comando + " where nome LIKE @nome", conn);
                cmd.Parameters.AddWithValue("@nome", "%" + textoPesquisa + "%");
            }
            conn.Open();
            Console.WriteLine(cmd.CommandText);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Sindicato sind = new Sindicato();
                sind.nome = Convert.ToString(rd[1]);
                lista.Add(sind);
            }
            conn.Close();
            return lista;
        }
    }
}
