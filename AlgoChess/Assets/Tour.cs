
public class Tour : Piece
{
    public Tour(int[,] tableau, int ligne, int colonne, int couleur) : base(tableau, ligne, colonne, couleur) 
    {
    }

    public override bool deplacer(int l, int c)
    {
        if(getTableau()[l, c] == 0 || getTableau()[l, c] == (-1*getCouleur()))//Verifie que la case est vide 
        {
            if (c != getColonne() && l == getLigne())
            {
                if (c > getColonne())
                {
                    for (int i = getColonne()+1; i <= c; i++)
                    {
                        if (getTableau()[i, l] != 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int i = c-1; i > getColonne(); i--)
                    {
                        if (getTableau()[i, l] != 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }

            }
            if (l != getLigne() && c == getColonne())
            {
                if (l > getLigne())
                {
                    for (int i = getLigne()+1; i <= l; i++)
                    {
                        if (getTableau()[c, i] != 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int i = l-1; i > getLigne(); i--)
                    {
                        if (getTableau()[c, i] != 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

        }
        return false;
    }
    
}
