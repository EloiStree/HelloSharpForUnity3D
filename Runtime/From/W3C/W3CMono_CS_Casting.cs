using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Casting : MonoBehaviour
{


    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode()
    {

        /////// Impricit casting
        // 🐿️ char -> int -> long -> float -> double

        // 🐿️  
        double doubleValue = 4; // 🐿️ 4 est un entier, il est converti en double implicitement.
        Debug.Log(doubleValue); // 🐿️ double et converti en string pour l'affichage implicitement



        /////// Explicit casting
        // 🐿️ double -> float -> long -> int -> char
        //int intValue = doubleValue; // 🐿️ double ne peut être converti en int implicitement car il y a un perte de donnée
        int intValue = (int)doubleValue; // 🐿️ Mais le développeur peut forcer la conversion en int avec une perte de donnée

        // 🐿️ Vous pouvez aussi utiliser la boite à outil convert
        int unInteger= System.Convert.ToInt32(doubleValue);
        double unDouble = System.Convert.ToDouble(intValue);



        /////// Avec les class et interface
        // 🐿️ Si vous avez déjà travaillé avec des class et des interfaces.
        
        Linux linux = new Linux();
        Window window = new Window();
        Mac mac = new Mac();
        Ordinateur unOrdinateur = new Ordinateur();

        // 🐿️ Comme un window est un ordinateur, on peut le convertir en ordinateur implicitement car il est une enfant de ordinateur
        unOrdinateur = window; // 🐿️ B est un AA

        // 🐿️ Mais on ne peut pas faire l'inverse, car unordinateur n'est pas forcément un window
        // 🐿️ Ici l(on force la conversion de ordinateur vers window
        // Si il ne l'est pas, une exception sera levée
        Window castWindowReference = (Window)unOrdinateur; 

        // 🐿️ Vous pourriez vérifier l'ordinateur est un window avant de convertir
        if ( unOrdinateur is Window)
        {
            castWindowReference = (Window)unOrdinateur; 
        }

        // 🐿️ Si vous ne voulez pas devoir vérifier, vous pouvez utiliser "as"
        // 🐿️ Si la conversion n'est pas possible, la variable sera retourner en "null"
        Window casted2 = unOrdinateur as Window; 
    }
    public class Ordinateur { }
    public class Window : Ordinateur { }
    public class Linux : Ordinateur { }
    public class Mac : Ordinateur { }


}
