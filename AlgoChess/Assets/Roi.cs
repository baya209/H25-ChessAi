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


                if (!isEchec()[l, c])
                {

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
        if (getLigne() > 0)
        {
            if (getColonne() > 0)
            {
                danger[getLigne() - 1, getColonne() - 1] = true;
            }
            if (getColonne() < 8)
            {
                danger[getLigne() - 1, getColonne() + 1] = true;
            }
            danger[getLigne() - 1, getColonne()] = true;
        }
        if (getLigne() < 8)
        {
            if (getColonne() > 0)
            {
                danger[getLigne() +1, getColonne() - 1] = true;
            }
            if (getColonne() < 8)
            {
                danger[getLigne() + 1, getColonne() + 1] = true;
            }
            danger[getLigne() + 1, getColonne()] = true;
        }
        if(getColonne() < 8)
        {
            danger[getLigne(), getColonne()+1] = true;
        }
        if (getColonne() > 0)
        {
            danger[getLigne(), getColonne() -1] = true;
        }

        return danger;
    }
}
