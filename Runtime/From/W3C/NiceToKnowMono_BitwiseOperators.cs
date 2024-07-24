using System;
using UnityEngine;

public class NiceToKnowMono_BitwiseOperators : MonoBehaviour
{

    public byte m_operatorA;
    public string m_aAs10;
    public byte m_operatorB;
    public string m_bAs10;

    public byte m_or;
    public string m_orAs10;
    public byte m_and;
    public string m_andAs10;

    public int m_operatorAShiftedLeftCount;
    public byte m_operatorAShiftedLeft;
    public string m_operatorAShiftedLeftAs10;

    public byte m_operatorBShiftedRightCount;
    public byte m_operatorBShiftedRight;
    public string m_operatorBShiftedRightAs10;


    public string m_textToByteUsingShift;
    public byte m_byteUsingShift;
    public string m_byteUsingShiftCheck;

    private void OnValidate()
    {
        m_aAs10 = System.Convert.ToString(m_operatorA, 2).PadLeft(8, '0');
        m_bAs10 = System.Convert.ToString(m_operatorB, 2).PadLeft(8, '0');

        m_or = (byte)(m_operatorA | m_operatorB);
        m_orAs10 = System.Convert.ToString(m_or, 2).PadLeft(8, '0');
        m_and = (byte)(m_operatorA & m_operatorB);
        m_andAs10 = System.Convert.ToString(m_and, 2).PadLeft(8, '0');

        m_operatorAShiftedLeft = (byte)(m_operatorA << m_operatorAShiftedLeftCount);
        m_operatorAShiftedLeftAs10 = System.Convert.ToString(m_operatorAShiftedLeft, 2).PadLeft(8, '0');

        m_operatorBShiftedRight = (byte)(m_operatorB >> m_operatorBShiftedRightCount);
        m_operatorBShiftedRightAs10 = System.Convert.ToString(m_operatorBShiftedRight, 2).PadLeft(8, '0');

        m_byteUsingShift = 0;

        for (int i = 0; i < m_textToByteUsingShift.Length; i++)
        {
            m_byteUsingShift <<= 1;
            if (m_textToByteUsingShift[i] == '1')
            {
                m_byteUsingShift |= 1;
            }
        }
        m_byteUsingShiftCheck= System.Convert.ToString(m_byteUsingShift, 2).PadLeft(8, '0');


    }
}
