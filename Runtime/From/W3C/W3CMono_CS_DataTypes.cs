using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class W3CMono_CS_DataTypes : MonoBehaviour
{
    // 🐿️  Les variables primitives sont des variables qui stockent des valeurs simples.
    // 🐿️  Elle ont une taille fixe et sont stockées dans la mémoire de l'ordinateur.
    // 🐿️  Regardons leur min max et la taille en octet que celle-ci prennent en mémoire.
    public AllMinMaxPrimitiveValue m_allMinMaxPrimitiveValue = new AllMinMaxPrimitiveValue();
    [System.Serializable]
    public class AllMinMaxPrimitiveValue { 
        // 🐿️  Stockons les types primitives dans des variables pour voir à quoi elle ressemble.
        public DataTypeInfoWithMinMax<byte> m_bytes = new DataTypeInfoWithMinMax<byte>(byte.MinValue, byte.MaxValue);
        public DataTypeInfoWithMinMax<sbyte> m_sbytes = new DataTypeInfoWithMinMax<sbyte>(sbyte.MinValue, sbyte.MaxValue);
        public DataTypeInfoWithMinMax<short> m_shorts = new DataTypeInfoWithMinMax<short>(short.MinValue, short.MaxValue);
        public DataTypeInfoWithMinMax<ushort> m_ushorts = new DataTypeInfoWithMinMax<ushort>(ushort.MinValue, ushort.MaxValue);
        public DataTypeInfoWithMinMax<int> m_ints = new DataTypeInfoWithMinMax<int>(int.MinValue, int.MaxValue);
        public DataTypeInfoWithMinMax<uint> m_uints = new DataTypeInfoWithMinMax<uint>(uint.MinValue, uint.MaxValue);
        public DataTypeInfoWithMinMax<long> m_longs = new DataTypeInfoWithMinMax<long>(long.MinValue, long.MaxValue);
        public DataTypeInfoWithMinMax<ulong> m_ulongs = new DataTypeInfoWithMinMax<ulong>(ulong.MinValue, ulong.MaxValue);
        public DataTypeInfoWithMinMax<float> m_floats = new DataTypeInfoWithMinMax<float>(float.MinValue, float.MaxValue);
        public DataTypeInfoWithMinMax<double> m_doubles = new DataTypeInfoWithMinMax<double>(double.MinValue, double.MaxValue);
        public DataTypeInfoWithMinMax<decimal> m_decimals = new DataTypeInfoWithMinMax<decimal>(decimal.MinValue, decimal.MaxValue);
        public DataTypeInfoWithMinMax<char> m_chars = new DataTypeInfoWithMinMax<char>(char.MinValue, char.MaxValue);
        public DataTypeInfoWithMinMax<bool> m_bools = new DataTypeInfoWithMinMax<bool>(false, true);
    }

    // 🐿️  Les variables complexes sont des variables qui stockent plusieurs variables
    // 🐿️  Voyons combien de mémoire elles prennent en octet.

    // 🐿️  Les Vector3 fait 12 bytes. Car elle contien 3 float de 4 bytes.
    public DataTypeInfo<Vector3> m_vector3 = new DataTypeInfo<Vector3>();
    // 🐿️  Les Quaternion fait 16 bytes. Car elle contien 4 float de 4 bytes.
    public DataTypeInfo<Quaternion> m_quaternion = new DataTypeInfo<Quaternion>();
    // 🐿️  Les Matrix4x4 fait 64 bytes. Car elle contien 16 float de 4 bytes.
    public DataTypeInfo<Matrix4x4> m_rotationEnMatrice = new DataTypeInfo<Matrix4x4>();



    // 🐿️  Dans le jeu civilisation, si vous allez à une valeur inférieure à 0, vous pouvez rendre l'Gandhi le pacifique 
    // 🐿️  en un monstre qui va vous détruire à l'aide de bombes nucléaires.
    // 🐿️  La raison est que si la valeur est inférieur à 0 , elle revient à 255.
    // 🐿️  Et inversément, si la valeur est supérieure à 255, elle revient à 0.
    // 🐿️  Cela est dû à la taille de la variable qui est de 8 bits. 11111111 = 255
    // 🐿️  Si vous êtes à 1 11111111. La valeur ne peux dépaser la zone et revien à 00000000.
    // https://www.youtube.com/watch?v=1glsS-MFM3c

    public byte m_gandiBug = 253; //0-2 =253
    // 🐿️  C'est ce qui est bien avec C#, le compilateur et l'IDE vous défent de faire des erreurs.
    // 🐿️  Si vous essayez de mettre une valeur supérieure à 255, vous aurez une erreur de compilation.
    //public byte m_gandiBug = (byte)-2;


    [ContextMenu("🐿️ Tester le code")]
    public void TesterLeCode()
    {
        m_gandiBug = 0;
        // 🐿️  Le compilateur vous protège des erreurs qu'il peut détecter.
        // 🐿️  Mais il a c'est limite.
        m_gandiBug-=10;
    }


    // 🐿️  Pour comprendre le code Suivant, il vous faut d'abord comprendre les données génériques et l'héritage.

    // 🐿️  L'on demande à Unity de pouvoir afficher les données dans l'inspecteur.
    [System.Serializable]
    // 🐿️  On créé une classe qui ne sait pas encore ce qu'elle va stocker.
    public class DataTypeInfo <T>{
    
        // 🐿️  On stocke le nom du type de donnée en utilisant le mot clé typeof.
        // Type of donne le type de l'object stocké dans la variable.
        public string m_name= typeof(T).ToString();
        // 🐿️  On stocke la taille en octet de l'object stocké dans la variable.
        // 🐿️  A bit c'est 1 0, un bytes/octet c'est 8 bits. 4 bytes = 32 bits.
        // 🐿️  168 bits c'est 21 octets ou 21 bytes.
        public int m_sizeInBytes= System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));

        // 🐿️  Si elle est serialisable, elle aura une valeur par défaut.
        // 🐿️  Si elle n'est pas serialisable, elle sera null pour un class.
        public T m_defaultValue;

    }
    // 🐿️  Il y a des objets qui on un minimum et un maximum.
    // 🐿️  Comme le code est différent pour chaqu'un.
    // 🐿️  On laisse le future développeur le faire (nous dans ce cas ci).
    [System.Serializable]
    public class DataTypeInfoWithMinMax<T> : DataTypeInfo<T>
    {
        // 🐿️ Vous n'avez pas encore vu les constructeurs. Mais cette méthode initialise les variables à sa création.
        public DataTypeInfoWithMinMax(T min, T max)
        {
            m_minValue = min;
            m_maxValue = max;
            m_minValueAsString = m_minValue.ToString();
            m_maxValueAsString = m_maxValue.ToString();
        }
        public T m_minValue;
        public T m_maxValue;
        public string m_minValueAsString;
        public string m_maxValueAsString;
    }
}
