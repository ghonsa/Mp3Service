using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3PlayerForms
{
    public partial class Form1 : Form
    {
        private string genre = "";
        private string artist = "";
        private ServiceReference1.Mp3ServiceClient mp3Clnt = null; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                mp3Clnt = new ServiceReference1.Mp3ServiceClient();
                string[] genres = mp3Clnt.Generes();
                foreach (string genre in genres) 
                {
                    listBoxGenres.Items.Add(genre);
                } 
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }

        private void listBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre = (string)listBoxGenres.SelectedItem;
            try
            {
                artist = "";
                listBoxArtists.Items.Clear();
                listBoxAlbums.Items.Clear();
                mp3Clnt = new ServiceReference1.Mp3ServiceClient();
                string[] artists = mp3Clnt.Artists(genre);
                foreach (string arts in artists)
                {
                    listBoxArtists.Items.Add(arts);
                }
                string[] albums = mp3Clnt.ALbums(genre,artist);
                foreach (string alb in albums)
                {
                    listBoxAlbums.Items.Add(alb);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

        }

        private void listBoxArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            artist = (string)listBoxArtists.SelectedItem;
            try
            {
              
                listBoxAlbums.Items.Clear();
                mp3Clnt = new ServiceReference1.Mp3ServiceClient();

                string[] albums = mp3Clnt.ALbums(genre, artist);
                foreach (string alb in albums)
                {
                    listBoxAlbums.Items.Add(alb);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

        }

       

       
    }
}
