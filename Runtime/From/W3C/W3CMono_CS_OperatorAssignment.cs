using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_OperatorAssignment : MonoBehaviour
{

    public int m_valueToApply;
    public int m_addition;
    public int m_soustraction;
    public int m_multiplication;
    public int m_division;
    public int m_modulo;
    public int m_or;
    public int m_and;

    int m_valueToShift = 0;

    [ContextMenu("🐿️ Test Code")]
    public void TestCode() {

        //= x = 5   x = 5
        //+= x += 3  x = x + 3
        //-= x -= 3  x = x - 3
        //*= x *= 3  x = x * 3
        ///= x /= 3  x = x / 3
        //%= x %= 3  x = x % 3
        //&= x &= 3  x = x & 3
        //|= x |= 3  x = x | 3
        //^= x ^= 3  x = x ^ 3
        //>>= x >>= 3 x = x >> 3
        //<<= x <<= 3 x = x << 3

    }

}
  