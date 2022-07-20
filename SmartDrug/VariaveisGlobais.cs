using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SmartDrug
{
    class conexao
    {
        public SqlConnection connection = new SqlConnection();

        public void conectar()
        {
            connection.ConnectionString = ("Data Source=127.0.0.1;Initial Catalog=DrogariaParana;Integrated Security=True");
            connection.Open();
        }

        public void desconectar()
        {
            connection.Close();
        }
    }

    public class ConexaoUsuario
    {
        static string usuario;
        static string senha;
        static string perfil;

        public static void login(string usuario1, string senha1, string perfil1)
        {
            usuario = usuario1;
            senha = senha1;
            perfil = perfil1;
        }

        public static string _usuario()
        {
            return ("" + usuario);
        }

        public static string _perfil()
        {
            return ("" + perfil);
        }
    }
}
