using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class NiceToKnowMono_HashToStorePassword : MonoBehaviour
{
    public string m_passwordGivenByUserAtStart = "J'aime les frites";
    public string m_passwordHashed;

    public string m_tryToGuessPassword;
    public string m_passwordHashedToCompare;


    public void OnValidate()
    {
        m_passwordHashed = HashText(m_passwordGivenByUserAtStart);
        m_passwordHashedToCompare = HashText(m_tryToGuessPassword);
    
    }
    public static string HashText(string text)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }

}
