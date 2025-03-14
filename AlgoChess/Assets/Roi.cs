using System;
public class Roi : Piece
{
    bool[,] echec;
    public Roi(int[,] tableau, int ligne, int colonne, int couleur, bool[,] echec) : base(tableau, ligne, colonne, couleur)
    {
        this.echec = echec;
    }
    public override bool deplacer(int l, int c)
    {
        if (l >= 0 && l < 8 && c >= 0 && c < 8)
        {
            if (getCouleur() != getTableau()[l, c] && (l != getLigne() || c != getColonne()))
            {
                if (!echec[l,c]) {
                    if (Math.Abs(l - getLigne()) <= 1 && Math.Abs(c - getColonne()) <= 1)
                    {
                        return true;
                    }
                }
                
            }
            
            
        }
        
        return false;

    }

    public override bool[,] isDanger(bool[,] danger)
    {
        
    }
}
