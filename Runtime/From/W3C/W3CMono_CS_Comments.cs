using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Comments : MonoBehaviour
{

    [Tooltip("🐿️ Je suis un jolie commentaire en Unity")]
    /// Je suis un jolie commentaire en C#, visible que dans l'IDE et non dans Unity.
    public string m_commentaire = "Place votre curseur sur le nom de la variable pour voir le commentaire.";

    [ContextMenu("🐿️ Tester le code")]
    /// 🐿️ Cette methode permet de tester du code dans le context de l'exercice.
    public void TesterLeCode() { 
   
        Debug.Log(Additionner(1, 3)); // 🐿️ Affiche 2 dans la console.
        Debug.Log(Add(1, 7)); // 🐿️ Affiche 2 dans la console.
    }

    // 🐿️ Utiliser // est un commentaire à retirer une fois l'application finie.
    
    /*
     * 🐿️ Est un commentaire sur plusieurs lignes.
       🐿️ Il est utilisé pour commenter du code sur plusieurs lignes
        Il sera retiré une fois l'application finie.
     */

    // 🐿️ Les /// permettent de documenter le code.
    // 🐿️ Les commentaires documentaires sont utilisés pour générer de la documentation.
    // Ils permettent de décrire le code et d'expliquer son fonctionnement.
    // - Utiliser durant le code si l'on met notre souris sur une méthode ou une variable.
    // - Utiliser pour générer de la documentation via des outils d'exportation.
    // - Utiliser pour expliquer le code à d'autres développeurss
    // - Utiliser pour entrainer les AI à comprendre le code et vous aider à "copiloter" le code.

    /// <summary>🐿️ Cette methode permet d'additionner deux nombres entiers.</summary>
    /// <param name="a">Un chiffre </param>
    /// <param name="b">Un autre chiffre </param>
    /// <returns>Le resultat de deux chiffres additionnés</returns>
    public int Additionner(int a, int b) {
        /// 🐿️ Cette methode permet d'additionner deux nombres entiers.
        /// 🐿️ Elle retourne le resultat de l'addition.
        return a + b;
    }

    // 🐿️ Commenter de préférence en anglais pour faciliter la compréhension des autres développeurs qui ne parlent pas français.
    // 🐿️ Il est très rare de travailler avec un entreprise 100% francophone.
    /// <summary> /// Add two integers together. </summary>
    /// <param name="a">A number</param>
    /// <param name="b">An other number</param>
    /// <returns>The result of the addition</returns>
    public int Add(int a, int b) {
        return a + b; // 🐿️ Noté qu'un commentaire peut être sur la même ligne que le code.

    }
    
}
