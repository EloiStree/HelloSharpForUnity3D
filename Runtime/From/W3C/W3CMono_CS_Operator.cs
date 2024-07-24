using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3CMono_CS_Operator : MonoBehaviour
{


    [Range(-100.0f,100f)]
    public int m_a;
    [Range(-100.0f, 100f)]
    public int m_b;
    public double m_addition;
    public double m_soustraction;
    public double m_multiplication;
    public double m_division;
    public double m_exponent;
    public double m_modulo;
    public int m_divisionAsInt;
    public int m_moduloAsInt;
    public double m_onValidateCounter = 0;

    private void OnValidate()
    {
        // 🐿️ Les opérateurs sont des symboles qui effectuent des opérations sur des variables.
        m_addition = m_a + m_b;
        m_soustraction = m_a - m_b;
        // 🐿️ L'opérateur de multiplication est un astérisque * et non x en dans la plus par des langages de programmation.
        m_multiplication = m_a * m_b;

        // 🐿️ L'opérateur d'exponentiation est Math.Pow en C#.
        m_exponent = System.Math.Pow(m_a, m_b);


        // 🐿️ Attention à la division par zéro.
        // 🐿️ Si vous divisez par zéro, vous obtiendrez une erreur de division par zéro.
        // 🐿️ La programmation ça reste des maths.
        if (m_b != 0) { 

            // 🐿️ / est l'opérateur de division. Rien de bien particulier.
            // 🐿️ % est l'opérateur de modulo. Il retourne le reste de la division. Ce qui est très utile dans beaucoup de calcule.
            

            m_division = m_a / m_b;
            m_modulo = m_a % m_b;
            m_divisionAsInt = m_a / m_b;
            m_moduloAsInt = m_a % m_b;
        }


        // 🐿️ Les opérateurs d'incrémentation et de décrémentation sont des opérateurs unaires.
        m_onValidateCounter = m_onValidateCounter + 1;
        m_onValidateCounter = m_onValidateCounter - 1;
        // 🐿️ De manière plus concise.
        m_onValidateCounter += 1;
        m_onValidateCounter -= 1;
        // 🐿️ De manière encore plus concise si ce n'est que d'une valeur 1.
        m_onValidateCounter++;
        m_onValidateCounter--;
        // Moins fréquent de le voir. Cela permet de faire l'opération avant de retourner la valeur.
        ++m_onValidateCounter;
        --m_onValidateCounter;


    }

   
}
