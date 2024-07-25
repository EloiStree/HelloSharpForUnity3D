using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MustKnowMono_ComponentStateMachine : MonoBehaviour
{

    public bool m_pauseGameAtEndFrame = true;

    public bool m_displayOnUpdate = false;
    public bool m_displayOnFixedUpdate = false;
    public bool m_displayOnLateUpdate = false;
    public bool m_displayOnGUI = false;
    public bool m_displayOnWillRenderObject = false;
    public bool m_displayOnValidate = false;
    public bool m_displayWaitEndFrame = false;
    public float m_waitForSeconds = 1.0f;

    // 🐿️ Les coroutines sont des méthodes qui fonction un peu comme des threads mais de maninière plus limitée et protégée.
    // 🐿️ Mais elle s'arrête si OnDisable ou OnDestroy est appelé.
    // 🐿️ Il faut dont les relancé si besoin dans OnEnable.
    public bool m_relaunchCoroutineOnEnable = false;
    public void Reset()
    {
        // 🐿️ Reset est appelé lorsque vous cliquez sur le bouton Reset dans l'inspecteur.
        // 🐿️ Reset est appelé lorsque vous ajoutez un composant à un GameObject.
        // 🐿️ Cette méthode permet d'initialiser les valeurs avec du code.
        // Example trouver les enfants d'un GameObject avec un script Rigidbody quand le script est ajouté ou reset.
        Debug.Log("Reset");
    }
    public void OnValidate()
    {
        if (m_displayOnValidate)
        Debug.Log("OnValidate");
    }

    public void Awake()
    {
        // 🐿️ Awake appelé à la création de l'objet dans la scène même si le script est désactivé (enabled = false).
        Debug.Log("Awake");
    }
    public void OnEnable()
    {
        // 🐿️ OnEnable est appelé lorsque le script est activé (enabled = true) et active dans la héarchie.
        Debug.Log("OnEnable");
        if (m_relaunchCoroutineOnEnable)
            LaunchCoroutine();
    }
    public void Start()
    {
        // 🐿️ Start est appelé une fois que tous les objets sont initialisés.
        // 🐿️ Start est appelé après Awake.
        // 🐿️ Start est appelé si la case enable est à true.

        Debug.Log("Start");
        // 🐿️ Les coroutines sont des méthodes qui fonction un peu comme des threads mais de maninière plus limitée et protégée.
        // 🐿️ Les coroutines sont très utiles pour ne pas bloquer le jeu pendant une tache de fond ou une tache sur la durée
        // 🐿️ Note that coroutine die when object is disabled or destroyed.
        LaunchCoroutine();
    }

    private void LaunchCoroutine()
    {
        StartCoroutine(YieldWaitFixedUpdate());
        StartCoroutine(YieldWaitForSeconds());
        StartCoroutine(YieldWaitForEndFrame());
    }


    public void FixedUpdate()
    {
        // 🐿️ FixedUpdate est appelé à chaque frame mais à une fréquence fixe.
        // 🐿️ FixedUpdate est appelé à une fréquence fixe indépendamment de la fréquence de rendu.
        // 🐿️ Si le fixed update est de 20ms et que la frame rate est de 60fps, FixedUpdate sera appelé 3 fois par frame.
        if (m_displayOnFixedUpdate)
        Debug.Log("FixedUpdate");
    }
    private IEnumerator YieldWaitFixedUpdate()
    {
        // 🐿️ Cette coroutine est appelée à chaque FixedUpdate.
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (m_displayOnFixedUpdate)
            Debug.Log("FixedUpdate Coroutine");
        }

    }
    public void Update()
    {
        // 🐿️ Update est appelé à chaque frame.
        // 🐿️ Update est appelé après FixedUpdate.
        // 🐿️ Update est appelé si la case enable est à true.
        if (m_displayOnUpdate)
        Debug.Log("Update");
    }

   
    private IEnumerator YieldWaitForSeconds()
    {

        // 🐿️ Cette coroutine est appelée après Update si le wait for seconds est atteint.
        // 🐿️ Attention cette méthode fait partie de l'engine, si vous devez avoir une précision de 1ms, il faudra utiliser des vrai threads.
        while (true)
        {
            yield return new WaitForSeconds(m_waitForSeconds);
            Debug.Log("WaitForSeconds");
        }
    }
  

    public void LateUpdate()
    {
        // 🐿️ LateUpdate Souvent appelé pour suivre la caméra ou les animations.
        // 🐿️ LateUpdate est appelé après que tous les objets aient été mis à jour.
        // 🐿️ LateUpdate est appelé avant le rendu graphique des de la frame
        if (m_displayOnLateUpdate)
            Debug.Log("LateUpdate");
    }

    public void OnWillRenderObject()
    {
        // 🐿️ OnWillRenderObject est appelé lorsque l'objet sera rendu.
        // 🐿️ OnWillRenderObject est appelé pour chaque caméra qui rend l'objet.
        // 🐿️ OnWillRenderObject est appelé seulement si le script est activé et que l'objet est visible par la caméra.
        if (m_displayOnWillRenderObject)
           Debug.Log("OnWillRenderObject");
    }

    public void OnGUI()
    {
        // 🐿️ Je n'ai jamais utiliser sauf à de rare occasion.
        // Je peux donc peu en parler.
        // 🐿️ OnGUI est appelé pour le rendu de l'interface graphique.
        if (m_displayOnGUI)
            Debug.Log("OnGUI");
    }
    private IEnumerator YieldWaitForEndFrame()
    {
        // 🐿️ Cette coroutine est appelée quand tout à terminer just avant de commencer la frame suivante.
        // Attention cette méthode est pratique mais peut créé des bugs si mal utilisée.
        while (true)
        {
            yield return new WaitForEndOfFrame();
            if (m_displayWaitEndFrame)
            Debug.Log("WaitForEndOfFrame");
            if(m_pauseGameAtEndFrame)
                Debug.Break();
        }

    }

    public void OnDisable()
    {
        // 🐿️ OnDisable est si l'objet est désactivé dans la hiérarchie de la scène.
        // 🐿️ OnDisable et OnEnable permet par example de s'abonner et de se désabonner à des événements.
        Debug.Log("OnDisable");
    }

    public void OnDestroy()
    {
        // 🐿️ OnDestroy est appelé lorsque l'objet est détruit.
        // 🐿️ Un destructeur est utilisé pour nettoyer les ressources avant que l'objet ne soit détruit. 
        Debug.Log("OnDestroy");
    }   
}
