using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Constants : MonoBehaviour
{
    // 🐿️ Les constantes sont des variables qui ne peuvent pas être modifiées.
    // 🐿️ Cette variable ne peut pas être modifiée une fois l'application lancée.
    // 🐿️ Noté: qu'un constante ne sera pas visible dans l'inspecteur d'Unity. (<2024)
    public const int m_sensDeLaVie = 42; 
    

    // 🐿️ Les constantes statiques n'existe pas, il y a une autre manière de les déclarer.
    //public static const int m_sensDeLaVieStatique = 42; // 🐿️ Une constante statique.
    public static readonly int m_sensDeLaVieStatique = 42; // 🐿️ Une constante statique.

    // 🐿️ Les constantes sont souvent en majuscules.
    public readonly float PI = 3.14159f; 

    // 🐿️ Noté que une variable ne peux avoir le même nom entre membre de la classe et variable statique.
    //public const float PI = 3.14159f; 


    // 🐿️ Comme un constant est fixé à la compilation, elle peut être utilisé pour initialiser une variable.
    public Color couleurRouge = Color.red;
    public Color couleurNoir = OdileColorToolbox.COULEUR_NOIR * OdileMathConstToolbox.HALF;

    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode()
    { 
        // 🐿️ Un moyen dérivé de faire une variable constante est de la mettre dans une proprité.
        // 🐿️ C'est un concepte de C# que l'on verra plus tard.
        // 🐿️ Un example que l'on utilise avec C#
        // 🐿️ Aller chercher une variable "constant" prête à être utilisée: le rouge.
        Color couleurRouge= Color.red;
        Color noir = OdileColorToolbox.COULEUR_NOIR * OdileMathConstToolbox.HALF;
    
    }
    
}


// 🐿️ Les constantes sont souvent regroupées dans des classes statiques.
// 🐿️ Cela permet de les regrouper et de les rendre plus facilement accessibles.
public class OdileColorToolbox
{
    public static readonly Color COULEUR_ROUGE = Color.red; 
    public static readonly Color COULEUR_BLEU = Color.blue; 
    public static readonly Color COULEUR_VERT = Color.green; 
    public static readonly Color COULEUR_JAUNE = Color.yellow; 
    public static readonly Color COULEUR_NOIR = Color.black; 
    public static readonly Color COULEUR_BLANC = Color.white; 
    public static readonly Color COULEUR_CYAN = Color.cyan; 
    public static readonly Color COULEUR_MAGENTA = Color.magenta; 
    public static readonly Color COULEUR_GRIS = Color.gray; 
    public static readonly Color COULEUR_GRIS_FONCE = Color.grey; 
    public static readonly Color COULEUR_TRANSPARENT = Color.clear; 
}

// 🐿️ Example de boite à outils pour des constantes mathématiques.
public class OdileMathConstToolbox
{ 
    public static readonly float PI = 3.14159f;
    public static readonly float E = 2.71828f;
    public static readonly float PHI = 1.61803f;
    public static readonly float SENSELAVIE= 42;
    public static readonly float HALF = 0.5f;

}
