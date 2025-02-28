using System;
public class Roi : Piece
{
    public Roi(int[,] tableau, int ligne, int colonne, int couleur) : base(tableau, ligne, colonne, couleur)
    {
    }
    public override bool deplacer(int l, int c)
    {
        if (l >= 0 && l < 8 && c >= 0 && c < 8)
        {
            if (getCouleur() != getTableau()[l, c] && (l != getLigne() || c != getColonne()))
            {
                if (Math.Abs(l - getLigne()) <= 1 && Math.Abs(c - getColonne()) <= 1)
                {
                    return true;
                }
            }
            else if (isFixe() && c == getColonne() && Math.Abs(getLigne() - l) == 2)// Castling
            {

            }
        }
        
        return false;

    }

    public override bool[,] isDanger(bool[,] danger)
    {
        throw new System.NotImplementedException();
    }
}
