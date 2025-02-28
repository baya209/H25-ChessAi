
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

    public override bool[,] isDanger(bool[,] danger)
    {
        for (int i = getColonne(); i < 8 - getColonne(); i++) {
            if(getTableau()[i, getLigne()] != 0)
            {
                if(getCouleur() == -1 *getTableau()[i, getLigne()])
                {
                    danger[i, getLigne()] = true;

                }
                break;
            }
            danger[i, getLigne()] = true;
        }
        for (int i = getColonne()-1; i >= 0; i--)
        {
            if (getTableau()[i, getLigne()] != 0)
            {
                if (getCouleur() == -1 * getTableau()[i, getLigne()])
                {
                    danger[i, getLigne()] = true;
                }
                break;
            }
            danger[i, getLigne()] = true;
        }
        for (int i = getLigne(); i < 8 - getLigne(); i++)
        {
            if (getTableau()[getColonne(), i] != 0)
            {
                if (getCouleur() == -1 * getTableau()[getColonne(), i])
                {
                    danger[getColonne(), i] = true;

                }
                break;
            }
            danger[getColonne(), i] = true;
        }
        for (int i = getLigne() - 1; i >= 0; i--)
        {
            if (getTableau()[getColonne(), i] != 0)
            {
                if (getCouleur() == -1 * getTableau()[getColonne(), i])
                {
                    danger[getColonne(), i] = true;
                }
                break;
            }
            danger[getColonne(), i] = true;
        }

        return danger;
    }
}
