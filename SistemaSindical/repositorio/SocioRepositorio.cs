using SistemaSindical.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSindical.repositorio
{
    public class SocioRepositorio
    {
        string conex = @"Server=DESKTOP-0QN57TB\SQL;Database=joaodb;User Id=sa;Password=jvictor10";

        public void Insert(Socio socio)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("insert into socios (nome, cpf, dataNascimento, sexo, telefone, idSindicato) values (@nome, @cpf, @dataNascimento, @sexo, @telefone, @idSindicato)", conn);
            cmd.Parameters.AddWithValue("@nome", socio.nome);
            cmd.Parameters.AddWithValue("@cpf", socio.cpf);
            cmd.Parameters.AddWithValue("@dataNascimento", socio.dataNascimento);
            cmd.Parameters.AddWithValue("@sexo", socio.sexo);
            cmd.Parameters.AddWithValue("@telefone", socio.telefone);
            cmd.Parameters.AddWithValue("@idSindicato", socio.idSindicato);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update (Socio socio)
        {
            SqlConnection conn = new SqlConnection (conex);
            SqlCommand cmd = new SqlCommand("update socio set nome = @nome, cpf = @cpf, dataNascimento = @dataNascimento, sexo = @sexo, telefone = @telefone, idSindicato = @idSindicato where id = @id", conn);
            cmd.Parameters.AddWithValue("@nome", socio.nome);
            cmd.Parameters.AddWithValue("@cpf", socio.cpf);
            cmd.Parameters.AddWithValue("@dataNascimento", socio.dataNascimento);
            cmd.Parameters.AddWithValue("@sexo", socio.sexo);
            cmd.Parameters.AddWithValue("@telefone", socio.telefone);
            cmd.Parameters.AddWithValue("@idSindicato", socio.idSindicato);
            cmd.Parameters.AddWithValue("@id", socio.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Int64 id)
        {
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("delete from socio where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Socio> SelecionarTodos()
        {
            List<Socio> lista = new List<Socio>();
            SqlConnection conn = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand("select  A.nome,A.cpf, A.dataNascimento, A.sexo, A.telefone FROM socios A LEFT JOIN sindicatos B On A.idSindicato = B.id where B.id = A.idSindicato", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Socio socio = new Socio();
                //socio.id = Convert.ToInt64(rd[0]);
                socio.nome = Convert.ToString(rd[0]);
                socio.cpf = Convert.ToString(rd[1]);
                socio.dataNascimento = Convert.ToDateTime(rd[2]);
                socio.sexo = Convert.ToChar(rd[3]);
                socio.telefone = Convert.ToString(rd[4]);
                lista.Add(socio);
            }
            conn.Close();
            return lista;
        }
        public List<Socio> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            string comando = "select  nome, cpf, dataNascimento, sexo, telefone from socios ";
            List<Socio> lista = new List<Socio>();
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
                cmd.CommandText = comando + " where cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf",Convert.ToString(textoPesquisa) );
            }
            else
            {
                cmd.CommandText = comando + " where dataNascimento = @dataNascimento";
                cmd.Parameters.AddWithValue("@dataNascimento", Convert.ToDateTime(textoPesquisa).ToString("yyyy-MM-dd"));
            }
            conn.Open();
            Console.WriteLine(cmd.CommandText);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Socio socio = new Socio();
                //socio.id = Convert.ToInt64(rd[0]);
                socio.nome = Convert.ToString(rd[0]);
                socio.cpf = Convert.ToString(rd[1]);
                socio.dataNascimento = Convert.ToDateTime(rd[2]);
                socio.sexo = Convert.ToChar(rd[3]);
                socio.telefone = Convert.ToString(rd[4]);
                lista.Add(socio);
            }
            conn.Close();
            return lista;
        }
    }
}
