using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winning
{
    public partial class Form1 : Form
    {
        Piece playerOne = null;
        Piece playerTwo = null;
        List<string> winlist = null;
        List<Board> boardlist = null;

        Color defaultColor = Color.LightSlateGray;
        Color colorPlayerOne = Color.Orange;
        Color colorPlayerTwo = Color.Aqua;
        PictureBox currentPicturebox = null;
        Board currentBoard = null;

        int horizontal = 0; 
        int vertical = 0;
        string currentTurn = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestGame();
            playerOne = new Piece(colorPlayerOne);
            playerTwo = new Piece(colorPlayerTwo);

            //Those all the optional winning rows
            winlist = new List<string>();
            winlist.Add("012");
            winlist.Add("345");
            winlist.Add("678");
            winlist.Add("036");
            winlist.Add("147");
            winlist.Add("258");
            winlist.Add("246");
            winlist.Add("048");

        }
    }
}
