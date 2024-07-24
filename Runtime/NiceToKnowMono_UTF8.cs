using UnityEngine;

public class NiceToKnowMono_UTF8 : MonoBehaviour { 

    // 🐿️  UTF-8 est un encodage de caractères.
    // 🐿️  Il est le plus utilisé quand Unicode n'est pas nécessaire.
    // 🐿️  La raison est qu'il est socké sur 1 bytes ce qui le rend "légé".
    // 🐿️  Voici la liste de ces caractères.
    public char[] m_all255Char = new char[256];

    // 🐿️  Ce qui nous intéresse le plus ici est que les caractères alphanumériques sont contigus.
    public char[] m_alpahNumeric = new char[62];
    private void Reset()
    {
        for (int i = 0; i < 256; i++)
        {
            m_all255Char[i] = (char)i;
        }

        for (int i = 0; i < 26; i++)
        {
            m_alpahNumeric[i] = (char)(i + 65);
        }
        for (int i = 0; i < 26; i++)
        {
            m_alpahNumeric[i + 26] = (char)(i + 97);
        }
        for (int i = 0; i < 10; i++)
        {
            m_alpahNumeric[i + 52] = (char)(i + 48);
        }
    
    }
}
