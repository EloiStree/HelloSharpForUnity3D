using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Identifiers : MonoBehaviour
{

    // 🐿️ Les identifiants sont des noms que vous donnez à vos variables, fonctions, classes, etc.
    // 🐿️ Les identifiants doivent commencer par une lettre ou un underscore.
    // 🐿️ Les identifiants peuvent contenir des lettres, des chiffres et des underscores.
    // 🐿️ Les identifiants sont sensibles à la casse.
    // 🐿️ Les identifiants ne peuvent pas contenir d'espaces.
    // 🐿️ Les identifiants ne peuvent pas être des mots réservés.
    // 🐿️ Les identifiants ne peuvent pas commencer par un chiffre.
    // 🐿️ Les identifiants ne peuvent pas contenir de caractères spéciaux.


    // 🐿️ Pour la propreté du code, il est important de ne pas être paresseux.
    // 🐿️ L'autocoplétion des IDEs modernes vous permet d'aller vite du bout des doigts.
    // 🐿️ Il y a une vidéo d'un heure sur ce seul sujet sur une vidéo Youtube.
    // 🐿️ https://www.youtube.com/watch?v=HZJxjlvBbVA

    // 🐿️ Exemple de variables avec des identifiants propres.
    public int m_secondesPastSinceStart;

    public string m_lienVersUneVideoCleanCode= "https://www.youtube.com/watch?v=HZJxjlvBbVA";



    // 🐿️  Je vous montre quelque example d'identifiants vraiment mauvais mais souvent recontrés
    // 🐿️  Car Temperature ?
    public string ct;
    // 🐿️  Ok c'est un text... Mais c'est quoi, pour qui, pour quoi ? m_tutorialDisplayToPlayer
    public string text;
    // 🐿️  On s'attends à un text... L'on a un int ? Que fait cette variable.
    public int abc;
    // 🐿️  Quoi ? Pourquoi ? Ca fait quoi ?
    public int def;
    // 🐿️  Je suppose que c'est un commentaire ? Pourquoi pas: m_commentDisplayOnCar ?
    public string cmt;
    // 🐿️  Je suppose qeu c'est une position  ? Pourquoi ne pas nommer la variable localPositionOfCar ?
    public Vector3 pos;
    // 🐿️  C'est une rotation ? De quoi ? Pourquoi ? Par rapport à quoi ? 
    public Quaternion rot;

    // 🐿️ Une liste possède des ints ? Mais la liste servira à quoi ? Pourquoi ne pas nommer la liste.
    public List<int> m_list;


    // 🐿️  Notez qu'en Unity, une classe non sérialisable ne sera pas visible dans l'inspecteur.
    // 🐿️  Et en C# pure, une variable doit être initialisée avant d'être utilisée.
    // 🐿️  Dans ce résulat, la variable sera égale à null si elle n'est pas initialisée.
    public List<Bonbon> m_bonbonDisponibleEnJeu; // = new List<Bonbon>(); devrait être initialisé pour éviter les erreurs.
    public class Bonbon { 
    
        public string m_nomDuBonbon;
    }

    // 🐿️  Voici un example en Unity qui est sérialisable.
    // 🐿️  Il sera donc initialisé par défaut en Unity3D
    public List<BonbonSerialized> m_bonbonDisponibleEnJeuSerialized;
    [System.Serializable]
    public class BonbonSerialized
    {
        public string m_nomDuBonbon;
        public int m_grammeDeSucre;
        public string m_vendeurId;
    }


    // 🐿️  Si vous vous reconnaissez dans c'est nom de méthode.
    // 🐿️  Je vous invite à regarder cette vidéo: https://www.youtube.com/watch?v=HZJxjlvBbVA



    // 🐿️  The m_ est une convention de nommage pour les variables membres.
    // 🐿️  Cela permet de savoir que la variable est une variable membre de la classe.
    // 🐿️  Cela permet de ne pas confondre les variables membres avec les variables locales.
    // 🐿️  Cela vous permettra par example de trouver plus rapidement vos variables dans l'IDE
    // 🐿️  Cela vous permettre aussi de savoir que la toucher à une variable directement sans utiliser une méthode.
    public string m_displayAtStartOfGame = "Let's play";

    // 🐿️ En tant que développeur de prototype. Cela me permet aussi de savoir que j'accède à une variable qui plus tard sera privée.
    // 🐿️ Je sais que le code cassera plus tard. Et qu'une méthode sera nécessaire plus tard.



    // 🐿️ Text area est un attribut qui permet d'afficher un champ de texte dans l'éditeur Unity.
    // 🐿️ Cela permet de donner un peu de volume à votre texte dans l'inspecteur de Unity3D.
    [TextArea(2,10)]
    // 🐿️ Les mots réservés sont des mots qui ont une signification spéciale pour le compilateur.
    // 🐿️ Vous ne pouvez pas utiliser ces mots comme identifiants.
    public string m_reservedWordsInCSharp = "abstract as base bool break byte case catch char checked class const continue decimal default delegate do double else enum  event explicit extern false finally fixed float for foreach goto if implicit in int interface internal is lock long  namespace new null object operator out override params private protected public readonly ref return sbyte sealed short sizeof stackalloc  static string struct switch this throw true try typeof uint ulong unchecked unsafe ushort using virtual void volatile while";
    public string m_reservedWordsInCSharpLink = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/";

    private void Awake()
    {
        Debug.Log(m_displayAtStartOfGame);

    }

    void Update()
    {
        m_secondesPastSinceStart =(int) Time.time;
        
    }
    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode()
    {
        Debug.Log("List de bonbons:"+ m_bonbonDisponibleEnJeu);
    }
    
}
