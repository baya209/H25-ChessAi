amespace DefaultNamespace;

public class Fou : Piece 
{
    public override bool deplacer(int l, int c)
    {
        // ok so ca c'est pour get la position initiale du fou
        int ligneDepart = getLigne();
        int colonneDepart = getColonne();
        // savoir s'il se déplace en haut ou en bas
        int diffColonne = c - colonneDepart;
        // savoir s'il se déplace à gauche ou à droite
        int diffLigne = l - ligneDepart;
        
        // variable pour la direction colonne et ligne 
        int dirColonne;
        int dirLigne;
        
       
        
        // vérifier s'il est en diagonale 
        if (Math.abs(diffColonne) != Math.abs(diffLigne))
        {
            return false;
            
        }
        else
        {
            // verifier s'il va à gauche ou à droite
            if (l > ligneDepart)
            {
                return dirLigne = 1;
            }
            else
            {
                return dirLigne = -1;
            }

            // verifier s'il va en haut ou en bas; 
            if (c > colonneDepart)
            {
                return dirColonne = 1;
            }
            else
            {
                return dirColonne = -1;
            }
            
            // variables pour vérifier le chemain s'il est libre ou pas 
            int x = colonneDepart + dirColonne;
            int y = ligneDepart + dirLigne;
            
            // vérifier si le chemain est libre 
            while (x != c && y != l )
            {
                if (getTableau()[y, x] != 0)
                {
                    return false;
                   x += dirColonne;
                   y += dirLigne;
                }
            }
           
            
            // verifier si la case choisie est libre 
            if (getTableau()[l, c] == 0 || getTableau()[l, c] == (-1 * getCouleur())) //Verifie que la case est vide 
            {
                return true;
            }



        }


        // vérifier si le déplacement se fait en diagonale gauche et droite haut bas
        // vérifier si le chemain est libre 


    }
    
    
}