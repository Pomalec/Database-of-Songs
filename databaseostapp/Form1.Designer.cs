namespace databaseostapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            Add = new Button();
            txt_desc = new TextBox();
            txt_imgurl = new TextBox();
            txt_year = new TextBox();
            txt_artist = new TextBox();
            txt_album = new TextBox();
            txt_vg = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button5 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(293, 20);
            button1.Name = "button1";
            button1.Size = new Size(193, 41);
            button1.TabIndex = 0;
            button1.Text = "Load Album";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(518, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 56);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(944, 22);
            button2.Name = "button2";
            button2.Size = new Size(170, 39);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1080, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(txt_desc);
            groupBox1.Controls.Add(txt_imgurl);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_album);
            groupBox1.Controls.Add(txt_vg);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 325);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // Add
            // 
            Add.Location = new Point(73, 263);
            Add.Name = "Add";
            Add.Size = new Size(123, 46);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(132, 219);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(128, 27);
            txt_desc.TabIndex = 11;
            // 
            // txt_imgurl
            // 
            txt_imgurl.Location = new Point(132, 181);
            txt_imgurl.Name = "txt_imgurl";
            txt_imgurl.Size = new Size(128, 27);
            txt_imgurl.TabIndex = 10;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(132, 145);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(128, 27);
            txt_year.TabIndex = 9;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(132, 106);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(128, 27);
            txt_artist.TabIndex = 8;
            // 
            // txt_album
            // 
            txt_album.Location = new Point(132, 70);
            txt_album.Name = "txt_album";
            txt_album.Size = new Size(128, 27);
            txt_album.TabIndex = 7;
            // 
            // txt_vg
            // 
            txt_vg.Location = new Point(132, 26);
            txt_vg.Name = "txt_vg";
            txt_vg.Size = new Size(128, 27);
            txt_vg.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 219);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 188);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "ImageURL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 152);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 109);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Artist Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 77);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Album Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Videogame";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 10);
            button3.Name = "button3";
            button3.Size = new Size(112, 66);
            button3.TabIndex = 12;
            button3.Text = "Delete Album Selected";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 261);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(298, 397);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 261);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 374);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Tracks";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(986, 362);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 335);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Track";
            // 
            // button4
            // 
            button4.Location = new Point(73, 263);
            button4.Name = "button4";
            button4.Size = new Size(123, 46);
            button4.TabIndex = 12;
            button4.Text = "AddTrack";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(132, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(132, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(132, 26);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(128, 27);
            textBox7.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 188);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 4;
            label9.Text = "AlbumID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 152);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 3;
            label10.Text = "Number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 109);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 2;
            label11.Text = "VideoURL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 77);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 1;
            label12.Text = "Lyrics";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 26);
            label13.Name = "label13";
            label13.Size = new Size(38, 20);
            label13.TabIndex = 0;
            label13.Text = "Title";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(18, 432);
            webView21.Name = "webView21";
            webView21.Size = new Size(254, 245);
            webView21.TabIndex = 16;
            webView21.ZoomFactor = 0.5D;
            // 
            // button5
            // 
            button5.Location = new Point(143, 10);
            button5.Name = "button5";
            button5.Size = new Size(129, 66);
            button5.TabIndex = 17;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 698);
            Controls.Add(button5);
            Controls.Add(webView21);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox txt_desc;
        private TextBox txt_imgurl;
        private TextBox txt_year;
        private TextBox txt_artist;
        private TextBox txt_album;
        private TextBox txt_vg;
        private Button Add;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label7;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button5;
        private ComboBox comboBox1;
    }
}
