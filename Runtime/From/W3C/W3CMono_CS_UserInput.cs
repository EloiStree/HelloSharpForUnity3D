using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class W3CMono_CS_UserInput : MonoBehaviour
{

    public InputField m_inputField;
    public Text m_text;
    public Slider m_slider;
    public Toggle m_toggle;
    public Dropdown m_dropdown;
    public Scrollbar m_scrollbar;
    public ScrollRect m_scrollRect;


    public InputActionReference m_actionJump;
    public InputActionReference m_actionMoveLeftRight;
    public bool m_isJumping = false;
    public float m_horizontal = 0;

    [TextArea(0,5)]
    public string m_debugUI = "";
    public string m_debugInputOld = "";
    private void OnValidate()
    {
        if( m_inputField != null && m_text!=null)
            m_text.text = m_inputField.text;
    }

    private void Awake()
    {
        if (m_actionMoveLeftRight!=null)
        {
            m_actionMoveLeftRight.action.Enable();
            m_actionMoveLeftRight.action.performed += ctx => m_horizontal = ctx.ReadValue<float>();
            m_actionMoveLeftRight.action.canceled += ctx => m_horizontal = 0;

            
        }
        if(m_actionJump != null)
        {
            m_actionJump.action.Enable();
            m_actionJump.action.performed += ctx => m_isJumping = ctx.ReadValueAsButton();
            m_actionJump.action.canceled += ctx => m_isJumping = false;
        }
    }

    public void Update()
    {

        // 🐿️ In C# console, you can use Console.ReadLine() to get user input.
        // Type your username and press enter
        /**
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        **/

        // 🐿️ Dans l'ancien systeme de Unity, vous pouviez utiliser Input.GetKey() pour obtenir l'input de l'utilisateur.
        bool isFiring =Input.GetButton("Fire1"); // 🐿️ GetButton retourne true tant que le bouton est appuyé
        bool isJumping = Input.GetButtonDown("Jump"); // 🐿️ GetButtonDown retourne true une seule fois quand le bouton est appuyé
        float horizontal = Input.GetAxis("Horizontal"); // 🐿️ GetAxis retourne un float entre -1 et 1 pour les touches horizontales
        float vertical = Input.GetAxis("Vertical"); // 🐿️ GetAxis retourne un float entre -1 et 1 pour les touches verticales

        // 🐿️ Hormis le fait que leur code était pourrit de fou car il a été écrit durant Unity <3.5
        // 🐿️ Vous pouvez aussi manquer des inputs si le joueur appuie trop vite.

        // 🐿️ Pour les téléphones
        int touchCount = Input.touchCount; // 🐿️ Retourne le nombre de touch sur l'écran

        Vector2 touchPosition;
        if(touchCount > 0)
             touchPosition = Input.GetTouch(0).position; // 🐿️ Retourne la position du premier touch
        else 
            touchPosition = Vector2.zero;
        Vector2 mousePosition = Input.mousePosition; // 🐿️ Retourne la position de la souris
        string inputString = Input.inputString; // 🐿️ Retourne les touches appuyées par l'utilisateur

        m_debugInputOld = "";
        m_debugInputOld += "isFiring: " + isFiring + "\n";
        m_debugInputOld += "isJumping: " + isJumping + "\n";
        m_debugInputOld += "horizontal: " + horizontal + "\n";
        m_debugInputOld += "vertical: " + vertical + "\n";
        m_debugInputOld += "touchCount: " + touchCount + "\n";
        m_debugInputOld += "touchPosition: " + touchPosition + "\n";
        m_debugInputOld += "mousePosition: " + mousePosition + "\n";
        m_debugInputOld += "inputString: " + inputString + "\n";


        // 🐿️ Si vous utilisez des UI, vous pouvez utiliser les InputField et Text, Slider, Toggle, Dropdown, Scrollbar, ScrollRect, etc.

        m_debugUI = "";
        if( m_inputField != null) m_debugUI += "InputField: " + m_inputField.text + "\n";
        if( m_text != null) m_debugUI += "Text: " + m_text.text + "\n";
        if( m_slider != null) m_debugUI += "Slider: " + m_slider.value + "\n";
        if( m_toggle != null) m_debugUI += "Toggle: " + m_toggle.isOn + "\n";
        if( m_dropdown != null) m_debugUI += "Dropdown: " + m_dropdown.value + "\n";
        if( m_scrollbar != null) m_debugUI += "Scrollbar: " + m_scrollbar.value + "\n";
        if( m_scrollRect != null) m_debugUI += "ScrollRect: " + m_scrollRect.verticalNormalizedPosition + "\n";



        // 🐿️ vous pourriez lire les valeurs ainsi.
        //  Mais ce serait manquer l'avantage de s'abonner à un valeur .
        // Regarder dans Awake() comment s'abonner à une valeur.
        bool use = false;
        if (use) { 
            if (m_actionJump != null) { 
                m_isJumping = m_actionJump.action.ReadValue<bool>();
            }

            if (m_actionMoveLeftRight != null) { 
                m_horizontal = m_actionMoveLeftRight.action.ReadValue<float>();
            }
        }
    }
}
