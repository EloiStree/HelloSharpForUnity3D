using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_MultipleVariables : MonoBehaviour
{

    public Vector3 m_xyzPositions;
    public Vector3 m_abcPositions;
    public Vector2 m_xhjPosition;

    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode()
    {

        // 🐿️ L'on pourrait écrire les variables de cette manière.
        int lx;
        int ly;
        int lz;
        lx = 1;
        ly = 2;
        lz = 3;
        m_xyzPositions = new Vector3(lx, ly, lz);
        // 🐿️ Mais vous comprendrez que c'est un peu long.


        // 🐿️ En C# l'on peu déclarer plusieurs variables en même temps.
        int x=1, y=2, z=3; 
        m_xyzPositions = new Vector3(x, y, z);
        
        // 🐿️ Déclarer plusieurs variables en même temps en deux temps.
        int a, b, c; // 🐿️ Déclarer plusieurs variables sans les initialiser.
        a = 1; b = 2; c = 3; // 🐿️ Initialiser les variables.
        m_abcPositions = new Vector3(a, b, c);

        int w, h,j;
        w = h = j = 50;
        // 🐿️ Que donnerait w h j ?
        m_xhjPosition.x = m_xhjPosition.y = m_xhjPosition.y = 50;
        Debug.Log("w: " + w + " h: " + h + " j: " + j);
        // 🐿️ w: 50 h: 50 j: 50


        // 🐿️ Attention à bien initialiser les variables avant de les utiliser.
        int nombreDeFrites;
        // 🐿️ Commenter la lignre suivante pour voir l'erreur.
        nombreDeFrites = 122;
        Debug.Log("nombreDeFrites: " + nombreDeFrites);





    }
}
