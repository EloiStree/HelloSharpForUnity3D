using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Output : MonoBehaviour
{

    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode() {

        // 🐿️ En C# pour dans une console, nous aurions utiliser System.Console.WriteLine("Hello from HelloStaticTool!");
        // 🐿️ En Unity3D, nous utilisons Debug.Log pour afficher des messages dans la console par default fournit en Unity3D.
        Debug.Log("Hello from HelloStaticTool!");

        // 🐿️ Debug est une classe static appelée par son nom de n'importe ou dans le code.
        // 🐿️ Log est une méthode de la classe Debug qui permet d'afficher un message dans la console.
        // 🐿️ Log prend un argument de type string qui est le message à afficher.

        // 🐿️ Debug.Log(1+1); // 🐿️ Affiche 2 dans la console.
        // Car Debug Log attend un string en argument.
        // C# comprendre que 1+1 est un calcul qui donne 2. 
        // Comme 2 est un nombre il est convertissable en texte que l'on appelle string.
        Debug.Log(1+1); // 🐿️ Affiche 2 dans la console.

        // 🐿️ Debug.Log(1+1.ToString()); // 🐿️ Affiche 11 dans la console.
        // Cette example montre ce que l'on appel la concaténation et la priorité des opérations.
        // Es ce 1+1 puis ToString() ?
        // Ou est 1 + "1",  1 puis 1.ToString() 
        Debug.Log(1+1.ToString()); // 🐿️ Affiche 11 dans la console.

        // 🐿️ si vous avez un doute, vous pouvez utiliser des parenthèses pour forcer l'ordre des opérations.
        Debug.Log((1+1).ToString()); // 🐿️ Affiche 2 dans la console.

    }
}
