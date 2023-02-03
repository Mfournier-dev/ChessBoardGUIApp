using Chessboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        //Propriétés
        const int SIZE = 8;
        static Board chessBoard = new Board(SIZE);
        public Button[,] btnGrid = new Button[chessBoard.Size, chessBoard.Size];
        public string pieceSelected = "";
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }


        private void populateGrid() //Fonction pour générer l'échiquier
        {
            int buttonSize = pnlBoard.Width / chessBoard.Size;
            pnlBoard.Height = pnlBoard.Width;

            for (int i = 0; i < chessBoard.Size; i++)
            {
                for (int j = 0; j < chessBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    btnGrid[i, j].Click += Grid_Button_Click;

                    pnlBoard.Controls.Add(btnGrid[i, j]);

                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);

                }
            }
        }
        private void Grid_Button_Click(object sender, EventArgs e) //Fonction qui appelle la fonction MarkLegalNextMove et va afficher les déplacements possibles
        {
            Button clickedButton = (Button)sender;
            while (pieceSelected == "") //Pour s'assurer qu'une pièce ait été sélectionnée avant de cliquer sur l'échiquier
            {
                MessageBox.Show("Please select a piece before clicking");
                return;
            }
            Point location = (Point)clickedButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = chessBoard.TheGrid[x, y];

            chessBoard.MarkNextLegalMove(currentCell, pieceSelected);

            for (int i = 0; i < chessBoard.Size; i++)
            {
                for (int j = 0; j < chessBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (chessBoard.TheGrid[i, j].LegalNextMove == true)
                        btnGrid[i, j].Text = "Legal";
                    if (chessBoard.TheGrid[i, j].CurrentlyOccupied == true)
                    {
                        btnGrid[i, j].Text = pieceSelected;
                    }
                }
            }
        }

        private void cbPiece_SelectedIndexChanged(object sender, EventArgs e) //Récupère l'info qui se trouve dans la ComboBox et store la valeur dans une variable pour la fonctione MarkLegalNextMove()
        {
            pieceSelected = Convert.ToString(cbPiece.SelectedItem);
        }
    }
}
