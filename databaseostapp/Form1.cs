using Org.BouncyCastle.Asn1.Cmp;

namespace databaseostapp
{
    public partial class Form1 : Form
    {
        BindingSource albumbin = new BindingSource();
        BindingSource trackbin = new BindingSource();
        List<Album> albums = new List<Album>();
        public int idtodelete = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            //conecct list  to the grid view control
            albums = albumsDAO.getallalbums();
            albumbin.DataSource = albumsDAO.getallalbums();

            dataGridView1.DataSource = albumbin;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            //conecct list  to the grid view control
            albumbin.DataSource = albumsDAO.searchtitles(textBox1.Text);

            dataGridView1.DataSource = albumbin;
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgd = (DataGridView)sender;

            //get row clicked
            int rowc = dgd.CurrentRow.Index;

            String imgurl = dgd.Rows[rowc].Cells[5].Value.ToString();

            if (imgurl.StartsWith("https://"))
            {
                pictureBox1.Load(imgurl);
            }



            trackbin.DataSource = albums[rowc].Tracks;

            dataGridView2.DataSource = trackbin;
            idtodelete = (int)dataGridView1.Rows[rowc].Cells[0].Value;
            // MessageBox.Show(idtodelete.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Add_Click(object sender, EventArgs e)
        {
            //add a new item
            int n; bool checkyear;
            if (int.TryParse(txt_year.Text, out n))
            {
                checkyear = true;
            }
            else { n = 2000; }
            Album album = new Album
            {
                Videogame = txt_vg.Text,
                Albumname = txt_album.Text,
                Artistname = txt_artist.Text,
                Year = n,
                ImageURL = txt_imgurl.Text,
                Description = txt_desc.Text

            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addonealbum(album);
            MessageBox.Show(result + "new rows inserted");
            txt_vg.Text = "";
            txt_album.Text = "";
            txt_artist.Text = "";
            txt_year.Text = "";
            txt_imgurl.Text = "";
            txt_desc.Text = "";
            albumbin.DataSource = albumsDAO.getallalbums();

            dataGridView1.DataSource = albumbin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            if (idtodelete != 0)
            {
                MessageBox.Show("deleted" + idtodelete.ToString());
                albumsDAO.deletealbum(idtodelete);
            }
            dataGridView1.DataSource = null;
            albumbin.DataSource = albumsDAO.getallalbums();

            dataGridView1.DataSource = albumbin;
        }

        private void button5_Click(object sender, EventArgs e)
        {


            //get row clicked
            int rowc = dataGridView2.CurrentRow.Index;
            int trackid = (int)dataGridView2.Rows[rowc].Cells[0].Value;
            MessageBox.Show(trackid.ToString());
            AlbumsDAO albumsdao = new AlbumsDAO();

            int result = albumsdao.deletetrack(trackid);

            MessageBox.Show("resut" + result.ToString());
            dataGridView2.DataSource = null;
            albums = albumsdao.getallalbums();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgd = (DataGridView)sender;

            //get row clicked
            int rowc = dgd.CurrentRow.Index;

            String vidurl = dgd.Rows[rowc].Cells[3].Value.ToString();
            if (vidurl.StartsWith("https://"))
            {
                webView21.Source = new Uri(vidurl);
            }




            // MessageBox.Show(idtodelete.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //add a new item
            int n; bool checkyear;
            if (int.TryParse(txt_year.Text, out n))
            {
                checkyear = true;
            }
            else { n = 2000; }
            Album album = new Album
            {
                Videogame = txt_vg.Text,
                Albumname = txt_album.Text,
                Artistname = txt_artist.Text,
                Year = n,
                ImageURL = txt_imgurl.Text,
                Description = txt_desc.Text

            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addonealbum(album);
            MessageBox.Show(result + "new rows inserted");
            txt_vg.Text = "";
            txt_album.Text = "";
            txt_artist.Text = "";
            txt_year.Text = "";
            txt_imgurl.Text = "";
            txt_desc.Text = "";
            albumbin.DataSource = albumsDAO.getallalbums();

            dataGridView1.DataSource = albumbin;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            albumbin.DataSource = albumsDAO.getallalbums();

            comboBox1.DataSource = albumbin;

        }
    }
}
