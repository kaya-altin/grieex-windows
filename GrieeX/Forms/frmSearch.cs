using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace GrieeX.Forms
{
    public partial class frmSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TMDbClient client = new TMDbClient("APIKey");
            SearchContainer<SearchMovie> results = client.SearchMovieAsync("matrix").Result;

            Console.WriteLine("Got {0} of {1} results", results.Results.Count, results.TotalResults);
            foreach (SearchMovie result in results.Results)
                Console.WriteLine(result.Title);
        }
    }
}