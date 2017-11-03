using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using API_Results;
using System.IO;

namespace LeekWarsGUI
{
    enum IsLogedIn
    {
        No,
        LoginOk,
        PassWordOk
    }

    public partial class LoginLW : Form
    {
        private IsLogedIn LoginContext = IsLogedIn.No;
        public RestClient Client = new RestClient("http://www.leekwars.com/api/");
        
        public LoginLW()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            switch (LoginContext)
            {
                case IsLogedIn.No:
                    if (LoginBox.Text == "" || LoginBox.Text == "Entrez un identifiant")
                    {
                        LoginBox.Text = "Entrez un identifiant";
                        LoginBox.Focus();
                    }
                    else
                    {
                        RestRequest Request = new RestRequest($"ranking/search/{LoginBox.Text}/false/true/false");
                        Request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                        ConnectButton.Text = "...";
                        var SearchResponse = Client.Execute<SearchResults>(Request).Data;
                        if (SearchResponse.success)
                        {
                            if (SearchResponse.results.Count == 0)
                                MessageBox.Show("Aucun compte ne correspond à cet identifiant");
                            else
                            {
                                LoginBox.Text = SearchResponse.results[0].name;
                                Size = new Size(400, 350);
                                LoginBox.Enabled = false;
                                LoginBox.Font = new Font(LoginBox.Font, FontStyle.Bold);
                                LoginBox.Size = new Size(LoginBox.PreferredSize.Width - 5, LoginBox.PreferredSize.Height);
                                LoginBox.Location = new Point((Size.Width - LoginBox.Size.Width) / 2, 225);
                                LoginContext = IsLogedIn.LoginOk;

                                label1.Text = "Mot de passe :";
                                label1.Location = new Point(12, 278);
                                PasswordBox.Show();

                                File.WriteAllBytes(Path.Combine(Directory.GetCurrentDirectory(), LoginBox.Text + "_image.jpg"), new RestClient((SearchResponse.results[0].image.StartsWith("http") ? "" : "http://www.leekwars.com/") + SearchResponse.results[0].image).DownloadData(new RestRequest()));
                                ImageBox.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), LoginBox.Text + "_image.jpg");
                                ImageBox.Show();
                                ConnectButton.Location = new Point(200, 315);
                                ChangeButton.Show();
                                TokenCheckbox.Show();
                                PasswordBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Une erreur est survenue");
                        }
                        ConnectButton.Text = "Connexion";
                    }
                    break;

                case IsLogedIn.LoginOk:
                    if (PasswordBox.Text == "" || PasswordBox.Text == "Entrez un mot de passe")
                    {
                        PasswordBox.Text = "Entrez un mot de passe";
                        PasswordBox.Focus();
                    }
                    else
                    {
                        RestRequest Request = new RestRequest($"farmer/login-token/{LoginBox.Text}/{PasswordBox.Text}");
                        Request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                        ConnectButton.Text = "...";
                        var LoginResponse = Client.Execute<Login>(Request).Data;
                        if (LoginResponse.success)
                        {
                            if (TokenCheckbox.Checked)
                            {
                                MessageBox.Show(LoginResponse.token, "Token");
                            }

                            LoginContext = IsLogedIn.PassWordOk;
                            var GUI = new GUI(LoginResponse);
                            GUI.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mauvais mot de passe");
                            PasswordBox.Focus();
                        }
                    }
                    ConnectButton.Text = "Connexion";
                    break;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (LoginContext == IsLogedIn.LoginOk)
            {
                LoginBox.Text = "";
                Size = new Size(400, 150);
                LoginBox.Enabled = true;
                LoginBox.Font = new Font(LoginBox.Font, FontStyle.Regular);
                LoginBox.Size = new Size(300, 20);
                LoginBox.Location = new Point(88, 38);
                LoginContext = IsLogedIn.No;

                label1.Text = "Identifiant :";
                label1.Location = new Point(12, 41);
                PasswordBox.Hide();

                ImageBox.Hide();
                ConnectButton.Location = new Point(150, 100);
                ChangeButton.Hide();
                TokenCheckbox.Hide();
            }
        }
    }
}
