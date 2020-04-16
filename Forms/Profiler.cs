using Newtonsoft.Json;
using Profiler.Classes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Profiler
{
    public partial class Profiler : Form
    {
        public Profiler()
        {
            InitializeComponent();
        }

        private static string ip = "localhost";
        private static string port = "5001";

        private string apiKey;
        private string username;

        RestClient client;
        RestRequest request;
        IRestResponse response;

        RestClient imageClient;
        RestRequest imageRequest;
        IRestResponse imageResponse;

        RestClient registerClient;
        RestRequest registerRequest;
        IRestResponse registerResponse;

        Pokemon poke;
        Person person;
        User user;
        Image image;

        private void AdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdressWindow popup = new AdressWindow();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
                ip = AdressWindow.ip;
                port = AdressWindow.port;
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }

        // Create Pokemon
        private void Button3_Click(object sender, EventArgs e)
        {
            CreatePokemonWindow popup = new CreatePokemonWindow();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
                poke = new Pokemon() { Name = CreatePokemonWindow.name, Hp = int.Parse(CreatePokemonWindow.hp), Attack = int.Parse(CreatePokemonWindow.attack), Defence = int.Parse(CreatePokemonWindow.defence), Speed = int.Parse(CreatePokemonWindow.speed) };
                client = new RestClient($"https://{ip}:{port}/api/pokemon");
                imageClient = new RestClient($"https://{ip}:{port}/api/pokemon/upload");
                request = new RestRequest();
                imageRequest = new RestRequest();
                request.Method = Method.POST;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(poke);
                imageRequest.Method = Method.POST;
                imageRequest.AddHeader("Content-Type", "multipart/form-data");
                imageRequest.AddParameter("file", CreatePokemonWindow.filePathUri.Segments.Last());
                imageRequest.AddFile("file", CreatePokemonWindow.filePath, contentType: "multipart/form-data");
                response = client.Execute(request);
                imageResponse = imageClient.Execute(imageRequest);
                MessageBox.Show("File: " + response.StatusCode.ToString() + ", Image: " + imageResponse.StatusCode.ToString());
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        //Create Person
        private void Button2_Click(object sender, EventArgs e)
        {
            CreatePersonWindow popup = new CreatePersonWindow();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
                person = new Person() { Name = CreatePersonWindow.name, Age = int.Parse(CreatePersonWindow.age), Klass = CreatePersonWindow.klass, Email = CreatePersonWindow.email, Description = CreatePersonWindow.description };
                client = new RestClient($"https://{ip}:{port}/api/person");
                imageClient = new RestClient($"https://{ip}:{port}/api/person/upload");
                request = new RestRequest();
                imageRequest = new RestRequest();
                request.Method = Method.POST;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(person);
                imageRequest.Method = Method.POST;
                imageRequest.AddHeader("Content-Type", "multipart/form-data");
                imageRequest.AddParameter("file", CreatePersonWindow.filePathUri.Segments.Last());
                imageRequest.AddFile("file", CreatePersonWindow.filePath, contentType: "multipart/form-data");
                response = client.Execute(request);
                imageResponse = imageClient.Execute(imageRequest);
                MessageBox.Show("File: " + response.StatusCode.ToString() + ", Image: " + imageResponse.StatusCode.ToString());
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }
        //Search
        private void Button1_Click_1(object sender, EventArgs e)
        {
            client = new RestClient($"https://{ip}:{port}/api/{TypeBox.SelectedItem.ToString().ToLower()}");
            imageClient = new RestClient($"https://{ip}:{port}/api/{TypeBox.SelectedItem.ToString().ToLower()}/upload");

            request = new RestRequest("?name=" + SearchBox.Text);
            imageRequest = new RestRequest("?name=" + SearchBox.Text);

            response = client.Get(request);
            imageResponse = imageClient.Get(imageRequest);

            MessageBox.Show("File: " + response.StatusCode.ToString() + ", Image: " + imageResponse.StatusCode.ToString());

            ProfilePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                if (TypeBox.SelectedItem.ToString().ToLower() == "pokemon")
                {
                    poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);
                }
                else
                {
                    person = JsonConvert.DeserializeObject<Person>(response.Content);
                }
                image = ByteArrayToImage(imageResponse.RawBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            try
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (TypeBox.SelectedItem.ToString().ToLower() == "pokemon")
                    {
                        PrintPokemonData(); 
                    }
                    else
                    {
                        PrintPersonData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm popup = new RegisterForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                client = new RestClient($"https://{ip}:{port}/api/account");
                request = new RestRequest($"?username={RegisterForm.username}&password={RegisterForm.password}");
                response = client.Post(request);

                MessageBox.Show(response.StatusCode.ToString());

                apiKey = response.Content;
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }

        private void PrintPersonData()
        {
            NameLabel.Text = person.Name;
            ValueLabel1.Text = "Age: " + person.Age.ToString();
            ValueLabel2.Text = "Class: " + person.Klass.ToString();
            ValueLabel3.Text = "Email: " + person.Email.ToString();
            ValueLabel4.Text = "Discription: " + person.Description.ToString();
            ProfilePictureBox.Image = image;
        }
        private void PrintPokemonData()
        {
            NameLabel.Text = poke.Name;
            ValueLabel1.Text = "Hp: " + poke.Hp.ToString();
            ValueLabel2.Text = "Attack: " + poke.Attack.ToString();
            ValueLabel3.Text = "Defence: " + poke.Defence.ToString();
            ValueLabel4.Text = "Speed: " + poke.Speed.ToString();
            ProfilePictureBox.Image = image;
        }

        public Image ByteArrayToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);

            Image image = Image.FromStream(ms, true, true);

            return image;
        }

        public string ByteArrayToString(byte[] stringBytes)
        {
            string apiKey = BitConverter.ToString(stringBytes);

            return apiKey;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Profiler_Load(object sender, EventArgs e)
        {

        }
    }
}
