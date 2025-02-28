using System.Collections.Generic;


public class Partie 
{
    private Plateau plateau;
    public void creerPartie()
    {
        int[,] tableau = new int[8, 8];
        //Creation du plateau
        for (int i = 0; i < 8; i++)
        {
            tableau[0,i] = 1;
            tableau[1,i] = 1;

            tableau[2, i] = 0;
            tableau[3, i] = 0;
            tableau[4, i] = 0;
            tableau[5, i] = 0;

            tableau[6,i] = -1;
            tableau[7, i] = -1;
        }



        List<Piece> pieces = new List<Piece>();
        //Ajout pions 
        for (int i = 0; i < 8; i++) {
            
            Pion pion1 = new Pion(tableau, i, 1, 1);
            Pion pion3 = new Pion(tableau, i, 6, -1);
            pieces.Add(pion1);
            pieces.Add(pion3);
        }
        plateau = new Plateau(tableau,pieces);
    }
    public bool jouerCoup(int li, int ci, int lf,int cf, int couleur)
    {
        evaluerDanger();
        if (plateau.getTableau()[li,ci] == couleur)
        {
            Piece deplace = plateau.getPieces().Find(p => p.getLigne() == li && p.getColonne() == ci);
            if ((special(li, ci, lf, cf, deplace)))
            {
                return true;
            }
            if (deplace.deplacer(lf, cf))
            {
                deplace.setLigne(lf);
                deplace.setColonne(cf);
                deplace.setFixe();
                if(plateau.getPieces().Find(p => p.getLigne() == lf && p.getColonne() == cf).getCouleur() == deplace.getCouleur() * -1)
                {
                    plateau.getPieces().Remove(plateau.getPieces().Find(p => p.getLigne() == lf && p.getColonne() == cf));
                }
                plateau.getTableau()[li,ci] = 0;
                plateau.getTableau()[lf, cf] = deplace.getCouleur();


            }
            return true;
        }
        return false;
    }
    public void evaluerDanger()
    {
        bool[,] dangerNoir = new bool[8, 8];
        bool[,] dangerBlanc = new bool[8, 8];
        for (int i = plateau.getPieces().Count; i > 0; i--) {
            if (plateau.getPieces()[i].getCouleur() == 1)
            {
                dangerBlanc = plateau.getPieces()[i].isDanger(dangerBlanc);
            }
            else
            {
                dangerNoir = plateau.getPieces()[i].isDanger(dangerNoir);
            }
        }
        plateau.setDangerNoir(dangerNoir);
        plateau.setDangerBlanc(dangerBlanc);
    }
    private bool castling(int li, int ci, int lf, int cf)
    {
        
    }
    private bool special(int li, int ci, int lf, int cf, Piece piece)
    {
        if(piece.GetType() == typeof(Pion))
        {
            if (piece.deplacer(lf,cf) && (cf == 7 || cf == 0)) {
                plateau.getPieces().Add(new Tour(plateau.getTableau(), lf, cf, piece.getCouleur()));
                plateau.getPieces().Remove(piece);
                return true;
            }
        } 
    }


}