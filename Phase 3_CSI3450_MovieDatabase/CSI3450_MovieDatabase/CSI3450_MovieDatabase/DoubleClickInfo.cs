using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI3450_MovieDatabase
{
    public partial class DoubleClickInfo : Form
    {
        public DoubleClickInfo()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoubleClickInfo_Load(object sender, EventArgs e)
        {
            List<Movies> movies = Movies.GetDetailedInfo();

            foreach (Movies m in movies)
            {
                detailedTitle.Text = m.title_Movie.ToString();
                detailedDescription.Text = m.description_Movie.ToString();
                detailedRunTime.Text = m.length_Movie.ToString();
                detailedReleaseDate.Text = m.releaseDate_Movie.ToString();
                var wholename = m.director_fname + " " + m.director_lname;
                detailedDirectorName.Text = wholename.ToString();
                detailedDirectorAge.Text = m.director_age.ToString();
            }
        }
    }
}
