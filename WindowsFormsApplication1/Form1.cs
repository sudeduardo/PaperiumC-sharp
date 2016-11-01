using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using MARC4J;
using System.IO;
using MARC4J.Net;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Collection<Livro> livros = new Collection<Livro>();
        public  Object fileJson;
        public Form1()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string host = txtHost.Text;
            string senha = txtSenha.Text;
            NpgsqlConnection Conexao = new NpgsqlConnection("Server=" + host + ";User Id=" + user + "; " +
           "Password=" + senha + ";Database=biblivre4;");
            Conexao.Open();
            NpgsqlCommand sql = new NpgsqlCommand("select iso2709 from single.biblio_records", Conexao);
            NpgsqlDataReader result = sql.ExecuteReader();
            System.IO.StreamWriter file = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "Livro.mrc");




            while (result.Read())
            {
                for (int i = 0; i < result.FieldCount; i++) {
                    file.Write(result[i].ToString());
                }
            }
            file.Close();

            using (var fs = new FileStream(Directory.GetCurrentDirectory() + "Livro.mrc", FileMode.Open))
            {
                using (IMarcReader reader = new MarcStreamReader(fs, "UTF-8"))
                {
                    foreach (var record in reader)
                    {
                    
                        Livro livro = new Livro();
                        try {
                            livro.autor =(string) ((record.GetVariableField("100").ToString()).Split(new string[] { "$a" }, StringSplitOptions.None)[1]).Split(new string[] { "$b" }, StringSplitOptions.None)[0];
                        }
                        catch {
                            livro.autor = "";
                        }

                        try
                        {
                            livro.data = ((record.GetVariableField("260").ToString()).Split(new string[] { "$g" }, StringSplitOptions.None)[1]);
                          
                        }
                        catch
                        {
                            livro.data = "";
                        }
                        try
                        {
                            livro.nome = ((record.GetVariableField("130").ToString()).Split(new string[] { "$a" }, StringSplitOptions.None)[1]).Split(new string[] { "$d" }, StringSplitOptions.None)[0];
                        }
                        catch
                        {
                            livro.nome = "";
                        }

                        livros.Add(livro);
                    }
                }
            }


            dGVResult.DataSource = livros ;
            var json = JsonConvert.SerializeObject(livros);
            System.IO.StreamWriter json_file = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "livros.json");
            json_file.Write(json);
            json_file.Close();

           fileJson = json;

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if ((dGVResult.DataSource == null))
            {
                MessageBox.Show("Conecte ao banco de dados primeiro!", "Banco de Dados");
            }
            else if ((livros.Count != 0))
            {

                FormEnviar f = new FormEnviar(fileJson);
                f.Show();
            }
            else { MessageBox.Show("Não há dados disponiveis!", "Banco de Dados"); }
        }

        private void dGVResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

