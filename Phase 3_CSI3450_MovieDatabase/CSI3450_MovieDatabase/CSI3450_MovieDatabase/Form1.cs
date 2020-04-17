using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSI3450_MovieDatabase
{
    public partial class Form1 : Form
    {
        static String stddetails = "{0,-30} {1, -30}{2,-30}{3,-30}{4,-30}{5,-30}";
        public static String searchInput;
        public static int addMovieId;
        public static String addTitle;
        public static String addDesc;
        public static String date;
        public static int addLength ;
        public static int addDirectorID;
        public static String delete;
        public static int updateIDvalue;
        public static int detailInfoValue;
        
        public Form1()
        {
            InitializeComponent();
            Movies.initializeDB();
            testBox.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
        }

        private void LoadAll()
        {
            List<Movies> movies = Movies.GetMovies();

            testBox.Items.Clear();
            testBox.Items.Add(String.Format(stddetails, "ID", "Title", "Description", "Release", "Length", "DirectorID"));
            
            foreach (Movies m in movies)
            {
                testBox.Items.Add(String.Format(stddetails, m.id_Movie, m.title_Movie, m.description_Movie, m.releaseDate_Movie, m.length_Movie, m.Director_id_Movie));
            }
        }
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //searchBox and btnSearch
            searchInput = searchBox.Text;
            List<Movies> movies = Movies.GetSearch();

            testBox.Items.Clear();
            testBox.Items.Add(String.Format(stddetails, "ID", "Title", "Description", "Release", "Length", "DirectorID"));

            foreach (Movies m in movies)
            {
                testBox.Items.Add(String.Format(stddetails, m.id_Movie, m.title_Movie, m.description_Movie, m.releaseDate_Movie, m.length_Movie, m.Director_id_Movie));
            }


        }
       
        /*
         * The btnAdd_Click is an event that 
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMovieId = int.Parse(movieId.Text);
            addTitle = title.Text;
            addDesc = description.Text;
            date = dateBox.Text;
            addLength = int.Parse(length.Text);
            addDirectorID = int.Parse(directorID.Text);

            Movies.AddMovies();
            LoadAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete = (deleteBox.Text).ToString();
            Movies.DeleteMovies();
            LoadAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (testBox.SelectedItem == null)
            {
                MessageBox.Show("You didn't select a record");
            }
            else { 
                String str = testBox.SelectedItem.ToString();
                String[] strIDArray = str.Split(' ');
                var strIdString = strIDArray[0].ToString();
                var updateID = Convert.ToInt32(strIdString);
                updateIDvalue = updateID;
                UpdateForm f2 = new UpdateForm();
                f2.ShowDialog();
            }
            
            LoadAll();
        }
        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.testBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                String str = testBox.SelectedItem.ToString();
                String[] strIDArray = str.Split(' ');
                var strIdString = strIDArray[0].ToString();
                var updateID = Convert.ToInt32(strIdString);
                detailInfoValue = updateID;
            }
            DoubleClickInfo d2 = new DoubleClickInfo();
            d2.ShowDialog();
        }
        
    }
}
