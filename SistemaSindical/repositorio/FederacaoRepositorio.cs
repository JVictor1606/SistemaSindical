using SistemaSindical.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.repositorio
{
    public class FederacaoRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";

        public void Insert(Federacao fed)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into federacoes (nome, estado, cnpj, endereco, telefone) values (@nome, @estado, @cnpj, @endereco, @telefone)", conn);
            cmd.Parameters.AddWithValue("@nome", fed.nome);
            cmd.Parameters.AddWithValue("@estado", fed.estado);
            cmd.Parameters.AddWithValue("@cnpj", fed.cnpj);
            cmd.Parameters.AddWithValue("@endereco", fed.endereco);
            cmd.Parameters.AddWithValue("@telefone", fed.telefone);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Atualizar(Federacao fed)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("update federacoes set nome = @nome, estado = @estado, cnpj = @cnpj, endereco = @endereco, telefone = @telefone where id = @id", conn);
            cmd.Parameters.AddWithValue("@nome", fed.nome);
            cmd.Parameters.AddWithValue("@estado", fed.estado);
            cmd.Parameters.AddWithValue("@cnpj", fed.cnpj);
            cmd.Parameters.AddWithValue("@endereco", fed.endereco);
            cmd.Parameters.AddWithValue("@telefone", fed.telefone);
            cmd.Parameters.AddWithValue("@id", fed.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Federacao> SelecionarTodosFed()
        {
            List<Federacao> lista = new List<Federacao>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select id,nome,estado,cnpj,endereco,telefone from federacoes  ", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Federacao fed = new Federacao();
                fed.id = Convert.ToInt64(rd[0]);
                fed.nome = Convert.ToString(rd[1]);
                fed.estado = Convert.ToString(rd[2]);
                fed.cnpj = Convert.ToString(rd[3]);
                fed.endereco = Convert.ToString(rd[4]);
                fed.telefone = Convert.ToString(rd[5]);
                lista.Add(fed);
            }
            conn.Close();
            return lista;
        }
        public List<Federacao> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            string comando = "select  nome,estado, cnpj, endereco, telefone from federacoes ";
            List<Federacao> lista = new List<Federacao>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (tipoPesquisa == 0)
            {
                cmd = new SqlCommand(comando + " where nome LIKE @nome", conn);
                cmd.Parameters.AddWithValue("@nome", "%" + textoPesquisa + "%");
            }
            else if (tipoPesquisa == 1)
            {
                cmd.CommandText = comando + " where estado LIKE @estado";
                cmd.Parameters.AddWithValue("@estado", "%" + textoPesquisa + "%");
            }
            conn.Open();
            Console.WriteLine(cmd.CommandText);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Federacao fed = new Federacao();
                //fed.id = Convert.ToInt64(rd[0]);
                fed.nome = Convert.ToString(rd[0]);
                fed.estado = Convert.ToString(rd[1]);
                fed.cnpj = Convert.ToString(rd[2]);
                fed.endereco = Convert.ToString(rd[3]);
                fed.telefone = Convert.ToString(rd[4]);
                lista.Add(fed);
            }
            conn.Close();
            return lista;
        }
    }
}
