using UnityEngine;

public class MustKnowMono_StringToCharArray :MonoBehaviour{

    // 🐿️  Un text en string n'est rien d'autre q'un tableau de char l'un derrière l'autre.
    // 🐿️  Un char est un caractère.
    //  Un caractère est un nombre d'un byte (11111111) de 0 à 255 qui correspond à un caractère en UTF8 (si non Unicode).

    [Header("Ca ressemble à quoi un char ?")]
    public string m_charAsString = "A";
    public char m_char = 'A';
    public byte m_charAsByte = (byte)'A';
    public string m_charAsBits;//= System.Convert.ToString(m_charAsByte, 2).PadLeft(8, '0');

    // 🐿️ Notez que 🐿️ 🔨 🧰 ne sont pas des caractères UTF8.
    // 🐿️ Ils ne sont pas dans la table ASCII.
    // 🐿️ Ils sont des caractères Unicode.
    // 🐿️ Comme C# n'as pas été designer pour avoir du Unicode à l'époque.
    // 🐿️ Avoir de l'Unicode dans une application peu casser le programme.
    // 🐿️ Car un "c" peux valoir deux chars 'cc'. Ce qui n'a pas de sens, mais fonctionne.
    // 🐿️  String "🐿️" = à une taille différent que sont tableau de char.


    [Header("Unicode Hell in C#")]
    public string m_squirrelOfHell= "🐿️";
    // 🐿️  vaut 1 dans le code, 2 dans unity et 3 char en réalité.
    // 🐿️  En gros, fait attention à l'unicode dans les string si vous en manipuler souvent.
    public int m_squirrelOfHellLength = 0;
    public char[] m_squirrelOfHellCharArray;
    public int m_squirrelOfHellCharArrayLength = 0;


    [Header("Si UTF8 (non Unicode ou autres)")]
    public string m_stringIn = "Hello World 🐿️ 🔨 🧰 ";
    public char[] m_charArrayIn;
    public byte[] m_charArrayAsBytes;
    public char[] m_charOut;
    public string m_stringOut;

    private void OnValidate()
    {
        m_charArrayIn = m_stringIn.ToCharArray();
        m_charArrayAsBytes = System.Text.Encoding.UTF8.GetBytes(m_stringIn);
        m_charOut = System.Text.Encoding.UTF8.GetChars(m_charArrayAsBytes);
        m_stringOut = new string(m_charOut);

        if (m_charAsString.Length == 0)
            m_charAsString = " ";
        m_char= m_charAsString[0];
        m_charAsByte = (byte)m_char;
        m_charAsBits = System.Convert.ToString(m_charAsByte, 2).PadLeft(8, '0');

        m_squirrelOfHellLength = m_squirrelOfHell.Length;
        m_squirrelOfHellCharArray = m_squirrelOfHell.ToCharArray();
        m_squirrelOfHellCharArrayLength = m_squirrelOfHellCharArray.Length;

    }


}
