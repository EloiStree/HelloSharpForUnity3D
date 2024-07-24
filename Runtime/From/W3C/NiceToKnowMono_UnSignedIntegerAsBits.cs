using System;
using UnityEngine;

public class NiceToKnowMono_UnSignedIntegerAsBits  : MonoBehaviour{

    public uint m_valueInt;
    public string m_valueAs32Bits;
    public uint m_valueAsUint;

    private void OnValidate()
    {
        m_valueAs32Bits = System.Convert.ToString(m_valueInt, 2).PadLeft(32, '0');
        string v = "";
        string v2 = "";
        for (int i = 0; i < 32; i++)
        {
            bool isOne = m_valueAs32Bits[m_valueAs32Bits.Length - 1 - i] == '1';
            m_valueToAdds[i] = (isOne) ? ((uint)Math.Pow(2,i)) : 0;
            if (isOne) { 
                v = (" + 2^" + i) + v; 
                v2 = " + "+(m_valueToAdds[i]) + v2;
            }
        }
        m_equation = v+"\n"+v2;
        m_valueAsUint = 0;
        for (int i = 0; i < 32; i++)
        {
            m_valueAsUint += m_valueToAdds[i];
        }
    }



    public uint[] m_valueToAdds= new uint[32];

    [TextArea(2,5)]
    public string m_equation;


}