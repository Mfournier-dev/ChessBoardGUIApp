using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    public class Board
    {
        //Propriétés de Board
        public int Size { get; set; }
        public Cell [,] TheGrid { get; set; }

        //Constructeur
        public Board (int s)
        {
            //Size of the board
            Size = s;

            //2 Dimensional
            TheGrid = new Cell[Size, Size];
            
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j <Size; j++)
                {
                    TheGrid[i, j] = new Cell (i,j);
                }
            }
        }
        public void MarkNextLegalMove(Cell currentCell, string chessPiece) //Fonction qui affiche les déplacements légaux d'une pièce
        {
            //On nettoie le Board à chaque fois qu'on veut afficher les déplacements légaux
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    TheGrid[i, j].LegalNextMove = false;
                    TheGrid[i, j].CurrentlyOccupied = false;
                }
            }
            //Switch case pour choisir la pièce
            switch (chessPiece)
            {
                case "Knight":
                    if(IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber - 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber - 2].LegalNextMove = true;
                    break;

                case "Bishop":
                //Ici j'ai laissé tomber l'idée d'utiliser des For Loops pour une approche plus "hard-coding"
                //Mon raisonnement était que chaque boucle demandait 64 traitements (vérifier chaque cellule de l'échiquier),
                //tandis qu'ici, on termine avec 49 traitements(j'ai créé une fonction pour éviter les déplacements qui seraient "Out of bound")
                //C'est plus lourd comme code, mais plus rapide à exécuter
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 3, currentCell.FileNumber + 3))
                        TheGrid[currentCell.RankNumber + 3, currentCell.FileNumber + 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 4, currentCell.FileNumber + 4))
                        TheGrid[currentCell.RankNumber + 4, currentCell.FileNumber + 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 5, currentCell.FileNumber + 5))
                        TheGrid[currentCell.RankNumber + 5, currentCell.FileNumber + 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 6, currentCell.FileNumber + 6))
                        TheGrid[currentCell.RankNumber + 6, currentCell.FileNumber + 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 7, currentCell.FileNumber + 7))
                        TheGrid[currentCell.RankNumber + 7, currentCell.FileNumber + 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 3, currentCell.FileNumber + 3))
                        TheGrid[currentCell.RankNumber - 3, currentCell.FileNumber + 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 4, currentCell.FileNumber + 4))
                        TheGrid[currentCell.RankNumber - 4, currentCell.FileNumber + 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 5, currentCell.FileNumber + 5))
                        TheGrid[currentCell.RankNumber - 5, currentCell.FileNumber + 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 6, currentCell.FileNumber + 6))
                        TheGrid[currentCell.RankNumber - 6, currentCell.FileNumber + 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 7, currentCell.FileNumber + 7))
                        TheGrid[currentCell.RankNumber - 7, currentCell.FileNumber + 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber - 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 3, currentCell.FileNumber - 3))
                        TheGrid[currentCell.RankNumber + 3, currentCell.FileNumber - 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 4, currentCell.FileNumber - 4))
                        TheGrid[currentCell.RankNumber + 4, currentCell.FileNumber - 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 5, currentCell.FileNumber - 5))
                        TheGrid[currentCell.RankNumber + 5, currentCell.FileNumber - 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 6, currentCell.FileNumber - 6))
                        TheGrid[currentCell.RankNumber + 6, currentCell.FileNumber - 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 7, currentCell.FileNumber - 7))
                        TheGrid[currentCell.RankNumber + 7, currentCell.FileNumber - 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber - 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 3, currentCell.FileNumber - 3))
                        TheGrid[currentCell.RankNumber - 3, currentCell.FileNumber - 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 4, currentCell.FileNumber - 4))
                        TheGrid[currentCell.RankNumber - 4, currentCell.FileNumber - 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 5, currentCell.FileNumber - 5))
                        TheGrid[currentCell.RankNumber - 5, currentCell.FileNumber - 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 6, currentCell.FileNumber - 6))
                        TheGrid[currentCell.RankNumber - 6, currentCell.FileNumber - 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 7, currentCell.FileNumber - 7))
                        TheGrid[currentCell.RankNumber - 7, currentCell.FileNumber - 7].LegalNextMove = true;
                    break;

                case "Rook":
                    //Ici j'ai tout de même gardé les For Loops, vu qu'on ne traverse l'échiquier selon la longueur ou la hauteur
                    for(int i = 0; i < Size; i++)
                        TheGrid[i, currentCell.FileNumber].LegalNextMove = true;
                    for(int j = 0; j < Size; j++)
                        TheGrid[currentCell.RankNumber, j].LegalNextMove = true;
                    break;

                case "Queen":
                    for (int i = 0; i < Size; i++)
                        TheGrid[i, currentCell.FileNumber].LegalNextMove = true;
                    for (int j = 0; j < Size; j++)
                        TheGrid[currentCell.RankNumber, j].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 3, currentCell.FileNumber + 3))
                        TheGrid[currentCell.RankNumber + 3, currentCell.FileNumber + 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 4, currentCell.FileNumber + 4))
                        TheGrid[currentCell.RankNumber + 4, currentCell.FileNumber + 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 5, currentCell.FileNumber + 5))
                        TheGrid[currentCell.RankNumber + 5, currentCell.FileNumber + 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 6, currentCell.FileNumber + 6))
                        TheGrid[currentCell.RankNumber + 6, currentCell.FileNumber + 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 7, currentCell.FileNumber + 7))
                        TheGrid[currentCell.RankNumber + 7, currentCell.FileNumber + 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber + 2))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber + 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 3, currentCell.FileNumber + 3))
                        TheGrid[currentCell.RankNumber - 3, currentCell.FileNumber + 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 4, currentCell.FileNumber + 4))
                        TheGrid[currentCell.RankNumber - 4, currentCell.FileNumber + 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 5, currentCell.FileNumber + 5))
                        TheGrid[currentCell.RankNumber - 5, currentCell.FileNumber + 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 6, currentCell.FileNumber + 6))
                        TheGrid[currentCell.RankNumber - 6, currentCell.FileNumber + 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 7, currentCell.FileNumber + 7))
                        TheGrid[currentCell.RankNumber - 7, currentCell.FileNumber + 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 2, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber + 2, currentCell.FileNumber - 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 3, currentCell.FileNumber - 3))
                        TheGrid[currentCell.RankNumber + 3, currentCell.FileNumber - 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 4, currentCell.FileNumber - 4))
                        TheGrid[currentCell.RankNumber + 4, currentCell.FileNumber - 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 5, currentCell.FileNumber - 5))
                        TheGrid[currentCell.RankNumber + 5, currentCell.FileNumber - 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 6, currentCell.FileNumber - 6))
                        TheGrid[currentCell.RankNumber + 6, currentCell.FileNumber - 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 7, currentCell.FileNumber - 7))
                        TheGrid[currentCell.RankNumber + 7, currentCell.FileNumber - 7].LegalNextMove = true;

                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 2, currentCell.FileNumber - 2))
                        TheGrid[currentCell.RankNumber - 2, currentCell.FileNumber - 2].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 3, currentCell.FileNumber - 3))
                        TheGrid[currentCell.RankNumber - 3, currentCell.FileNumber - 3].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 4, currentCell.FileNumber - 4))
                        TheGrid[currentCell.RankNumber - 4, currentCell.FileNumber - 4].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 5, currentCell.FileNumber - 5))
                        TheGrid[currentCell.RankNumber - 5, currentCell.FileNumber - 5].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 6, currentCell.FileNumber - 6))
                        TheGrid[currentCell.RankNumber - 6, currentCell.FileNumber - 6].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 7, currentCell.FileNumber - 7))
                        TheGrid[currentCell.RankNumber - 7, currentCell.FileNumber - 7].LegalNextMove = true;
                    break;

                case "King":
                    if (IsSafe(currentCell.RankNumber, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber))
                        TheGrid[currentCell.RankNumber + 1, currentCell.FileNumber].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber + 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber + 1,  currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber - 1))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber))
                        TheGrid[currentCell.RankNumber - 1, currentCell.FileNumber].LegalNextMove = true;
                    if (IsSafe(currentCell.RankNumber - 1, currentCell.FileNumber + 1))
                        TheGrid[currentCell.RankNumber -1, currentCell.FileNumber + 1].LegalNextMove = true;
                    break;

                default:
                    break;
            }
            TheGrid[currentCell.RankNumber, currentCell.FileNumber].CurrentlyOccupied = true;
        }
        public bool IsSafe(int x, int y) //La fonction pour s'assurer que les déplacements soient à l'intérieur de l'échiquier 
        {
            if (x > Size - 1 || x < 0)
                return false;
            else if (y > Size - 1 || y < 0)
                return false;
            else
                return true;
        }
    }
}
