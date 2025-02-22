using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class Pion : Piece 
{
    public Pion(int[,] tableau) : base(tableau)
    {
    }

    protected override bool deplacer(int c, int l){//  c colonne finale, l ligne finale

        if (getTableau()[c][l] == getCouleur)

        if (c == (getColonne() + getCouleur()))// Pion qui avance d'une case
        {
            return true;
        }
        else if (c == (getColonne() + 2) && (getCouleur() ==1 && getLigne() == 1 || getCouleur() == -1 && getLigne() == 7)) {// Pion qui avance de deux cases 
            return true;
        }
    }
}
