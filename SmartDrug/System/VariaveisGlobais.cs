using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace SmartDrug
{
    class conexao
    {
        public SqlConnection connection = new SqlConnection();

        public void conectar()
        {
            connection.ConnectionString = ("Data Source=(local);Initial Catalog=DrogariaParana;Integrated Security=True");
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

    public class VerificarHaver
    {
        static string cliente;

        public static void haver(string cliente1)
        {
            cliente = cliente1;
        }

        public static string _verificado()
        {
            return ("" + cliente);
        }
    }

    public class VerificarProduto
    {
        static string produtos;

        public static void produto(string produtos1)
        {
            produtos = produtos1;
        }

        public static string _ProdutoVerificado()
        {
            return ("" + produtos);
        }
    }

    public class CabecalhoReceber
    {
        static string total;
        static string valorpago;

        public static void cabecalho(string total1, string valorpago1)
        {
            total = total1;
            valorpago = valorpago1;
        }

        public static string _total()
        {
            return ("" + total);
        }

        public static string _valorpago()
        {
            return ("" + valorpago);
        }
    }

    public class CabecalhoReceberId
    {
        static string idSituacao;

        public static void cabecalho(string idSituacao1)
        {
            idSituacao = idSituacao1;
        }

        public static string _idSituacao()
        {
            return ("" + idSituacao);
        }
    }
}

