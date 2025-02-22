using UnityEngine;

public class Tour : Piece
{
    public Tour(int[,] tableau) : base(tableau)
    {
    }

    protected override bool deplacer(int c, int l)
    {// cI colonne initiale, cF colonne finale, lI ligne initiale, lF ligne finale
        if (cF == (cI + getCouleur()))// Pion qui avance d'une case
        {
            return true;
        }
        else if (cF == (cI + 2) && (getCouleur() == 1 && lI == 1 || getCouleur() == -1 && lI == 7))
        {// Pion qui avance de deux cases 
            return true;
        }
        return false;
    }
}
