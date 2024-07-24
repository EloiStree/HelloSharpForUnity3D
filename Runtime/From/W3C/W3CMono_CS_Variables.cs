using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class W3CMono_CS_Variables : MonoBehaviour
{

    // 🐿️ Unity permet un travail de groupe.
    // 🐿️ C'est une discussion entre le coder et les restes de l'équipe:
    // 🐿️ Designer, Sound Designer, Game Designer, etc


    // 🐿️ Je vous invite à regarder dans l'éditeur d'Unity les variables ci-dessous.
    public int m_entier = int.MaxValue; // 🐿️ Un nombre sans virgule.
    public float m_flottant = int.MaxValue; // 🐿️ Un nombre à virgule.
    public double m_double = int.MaxValue; // 🐿️ Un nombre à virgule 2 fois plus précis que le float.

    // 🐿️ Un string est un text composer de caractères.
    public string m_chaine = "Je suis une chaine de caractère"; // 🐿️ Une chaine de caractère.
    public char m_char = 'a'; // 🐿️ Un seul caractère.
    // 🐿️ Nous verons les tableaux plus tard. Mais voici un exemple.
    public char[] m_chars = { 'a', 'b', 'c' }; // 🐿️ Un tableau de caractères.
    public bool m_booleen = true; // 🐿️ Un booléen est une variable qui peut être vrai ou faux.


    // 🐿️ Des fois le développeur veut utiliser une zone mémoire.
    // 🐿️ Mais il ne veut pas la partager avec les autres développeurs ou designers du jeu.
    // 🐿️ Il peut utiliser le mot clé "private" pour cacher la variable.
    private string m_chainePrivee = "Vous ne devriez pas voir cette chaine"; // 🐿️ Une chaine de caractère privée.

    // 🐿️ Des fois le développeur va vouloir laisser seulement le designer modifier la variable.
    // 🐿️ Il peut utiliser le mot clé "SerializeField" pour rendre la variable visible dans l'inspecteur d'Unity.
    [SerializeField]
    private string m_chaineSerializee = "Vous devriez voir cette chaine dans l'inspecteur d'Unity"; // 🐿️ Une chaine de caractère privée visible dans l'inspecteur d'Unity.



    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode() {

        // 🐿️  Les variables hors de la méthode sont appellées des variables membres.
        // Les font partie de la classe et peuvent être utilisées dans toutes les méthodes de la classe.
        // Les variables suivantes sont des variables locales.
        // Elles n'existeront que le temps de l'exécution de la méthode.

        int unChiffre = 1; // 🐿️ Un chiffre.
        int unAutreChiffre = 3; // 🐿️ Un autre chiffre.
        int uneMultiplication = unChiffre * unAutreChiffre; // 🐿️ Une multiplication.
        float uneDivision = unChiffre / unAutreChiffre;       

        // 🐿️ Affiche les résultats dans la console.
        // 🐿️ Les résultats sont 3 et 0.3333333.
        Debug.Log("Multiplication: "+uneMultiplication+" Division:"+ uneDivision);

        // 🐿️ Notez que la façon de concaténer les variables ici est assez lourde.
        // 🐿️ Concaténer signifie de mettre bout à bout.
        // Il y a différente manière de le faire plus proprement.

        // 🐿️ La première manière est d'utiliser la méthode string.Format.
        string resultatFormat= string.Format("Multiplication: {0} Division: {1}", uneMultiplication, uneDivision);
        // 🐿️ La deuxième manière est d'utiliser le signe $ devant la chaine de caractère.
        // 🐿️ C'est la manière la plus récente et la plus "propre".
        // 🐿️ En tout cas plus rapide à écrire et lisible pour les autres développeurs.
        string resultatFormatRaccourci = $"Multiplication: {uneMultiplication} Division: {uneDivision}";
        Debug.Log(resultatFormat);
        Debug.Log(resultatFormatRaccourci);

        // 🐿️ N'est rien d'autres qu'un petite zone mémoire, un tiroir, pour stocker des valeurs.
        int a = 1;
        int b = a;
        int c = b;
        Debug.Log(a); // 🐿️ Affiche 1 dans la console.

        // 🐿️ C'est tiroir sont détruit à la fin de ce code par un outil dit "Garbedge collector"
        // Le Garbedge collector est un outil qui nettoie la mémoire de tout ce qui n'est plus utilisé.

        // 🐿️ m_variable les variables de la classe au dessus eux ne sont pas détruites que lorsque l'objet ne sera plus en jeu.


        // 🐿️ Voici un example pour tout les types de variables de C#
        // 🐿️ Elles sont appelées les types primitifs.
        // 🐿️ Elles sont les plus basiques et les plus utilisées.
        double myDoubleNum = 5.99D;
        bool myBool = true;
        byte myByte = 255;
        short myShort = 32000;
        ushort myUShort = 65000;
        int myNum = 5;
        uint myUInt = 4000000000;
        long myLong = 9223372036854775807;
        ulong myULong = 18446744073709551615;
        float myFloat = 5.75F;
        double myDouble = 5.75D;
        decimal myDecimal = 1234567890123456789012345678.12345678M;
        string myText = "Hello";
        char myLetter = 'D';
        AfficherDansLaConsoleToutLesVariables();
    }


    public void AfficherDansLaConsoleToutLesVariables() { 
    
        // 🐿️ Affiche les variables dans la console une a une.
        Debug.Log("m_entier: "+m_entier);
        Debug.Log("m_flottant: "+m_flottant);
        Debug.Log("m_double: "+m_double);
        Debug.Log("m_chaine: "+m_chaine);
        Debug.Log("m_char: "+m_char);
        Debug.Log("m_chars: "+m_chars);
        Debug.Log("m_booleen: "+m_booleen);
        Debug.Log("m_chainePrivee: "+m_chainePrivee);
        Debug.Log("m_chaineSerializee: "+m_chaineSerializee);


        // 🐿️ L'on devrait utiliser format $ pour concaténer les variables.
        // 🐿️ C'est plus propre et plus rapide à écrire.
        // 🐿️ Mais il y a une autre classe que l'on vera ensemble plus tard: StringBuilder.
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("m_entier: ").Append(m_entier).Append("\n");
        stringBuilder.Append("m_flottant: ").Append(m_flottant).Append("\n");
        stringBuilder.Append("m_double: ").Append(m_double).Append("\n");
        stringBuilder.Append("m_chaine: ").Append(m_chaine).Append("\n");
        stringBuilder.Append("m_char: ").Append(m_char).Append("\n");
        stringBuilder.Append("m_chars: ").Append(m_chars).Append("\n");
        stringBuilder.Append("m_booleen: ").Append(m_booleen).Append("\n");
        stringBuilder.Append("m_chainePrivee: ").Append(m_chainePrivee).Append("\n");
        stringBuilder.Append("m_chaineSerializee: ").Append(m_chaineSerializee).Append("\n");
        Debug.Log(stringBuilder.ToString());
        // 🐿️ StringBuilder est une classe qui permet de concaténer des chaines de caractères au fure et à mesure.

    }

}
