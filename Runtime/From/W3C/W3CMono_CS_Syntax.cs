using System.Collections;
using System.Collections.Generic;

// 🐿️ Using permet d'importer des librairies de code de Unity3D qui est préparé pour nous aider à développer des jeux.
using UnityEngine;


// 🐿️ C'est un espace ou Odile va stocker ses outils. 
// 🐿️ Si un outil à le même nom qu'un autre, l'on pourrait décider d'utiliser le namespace pour les différencier.
namespace OdileToolbox {

    // 🐿️ C'est un outil qui dit bonjour accessible partour dans l'application.
    // 🐿️ L'outil est dit static car il n'a pas besoin d'être instancié pour être utilisé.
    // 🐿️ On a pas besoin de réserver de la mémoire RAM pour utiliser l'outil.
    public class HelloStaticTool {

        // 🐿️ C'est une méthode qui dit bonjour. si on l'appelle.
        public static void SayHello() {

            // 🐿️ C'est l'équivalent de console.log en C#
            // 🐿️ System.Console.WriteLine("Hello from HelloStaticTool!");
            Debug.Log("Hello from HelloStaticTool!");
        }
    }
}

// 🐿️ Une classe est une zone mémoire réserver dans la RAM pour stocker des données.
// 🐿️ C'est un peu comme une boite qui contient des objets.
// 🐿️ Les classes contiennent aussi la description des objets qu'elles peuvent contenir.
// 🐿️ Les classes peuvent contenir des méthodes qui sont des fonctions qui peuvent être appelées.
// 🐿️ Les classes peuvent contenir des propriétés qui sont des variables qui peuvent être lues ou modifiées.
// 🐿️ Les classes peuvent contenir des événements qui sont des signaux qui peuvent être écoutés.
// 🐿️ En Résumé, elle contient des données et leur description.
public class W3CMono_CS_Syntax : MonoBehaviour
{

    // 🐿️ C'est une méthode qui dit bonjour.
    // 🐿️ On peut l'appeler depuis l'éditeur Unity3D en cliquant sur le bouton "Say Hello".
    // 🐿️ Cela grace à l'attribut ContextMenu.
    [ContextMenu("Say Hello")]
    public void SayHello() {

        // 🐿️ On utilise l'outil HelloStaticTool pour dire bonjour.
        OdileToolbox.HelloStaticTool.SayHello();
        // 🐿️ N'oubliez pas les ; à la fin des instructions.
    }

}
