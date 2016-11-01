using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WindowsFormsApplication1
{
    public partial class FormEnviar : Form
    {
        public Object json;
        public string url;
        public FormEnviar(Object jsonfile)
        {
            
            this.json = jsonfile;
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void FormEnviar_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

           


            string json_post = "json="+json+"&senha="+senha+"&email="+email;
            string resposta = HTTP_POST("https://paperium/upload/json", json_post);
            if (resposta == "true")
            {
                MessageBox.Show("Acervo Fisico Atualizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visible = true;
            }
            else {
                MessageBox.Show("Erro ao Autenticar! Tente Novamente", "Login",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        

        public static string HTTP_POST(string Url, string Data)
        {
            string Out = String.Empty;
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            try
            {
                req.Method = "POST";
                req.Timeout = 100000;
                req.ContentType = "application/x-www-form-urlencoded";
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                req.ContentLength = sentData.Length;
                using (System.IO.Stream sendStream = req.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();
                }
                System.Net.WebResponse res = req.GetResponse();
                System.IO.Stream ReceiveStream = res.GetResponseStream();
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8))
                {
                    Char[] read = new Char[256];
                    int count = sr.Read(read, 0, 256);

                    while (count > 0)
                    {
                        String str = new String(read, 0, count);
                        Out += str;
                        count = sr.Read(read, 0, 256);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Out = string.Format("HTTP_ERROR :: The second HttpWebRequest object has raised an Argument Exception as 'Connection' Property is set to 'Close' :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                Out = string.Format("HTTP_ERROR :: WebException raised! :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Out = string.Format("HTTP_ERROR :: Exception raised! :: {0}", ex.Message);
            }

            return Out;
          
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
