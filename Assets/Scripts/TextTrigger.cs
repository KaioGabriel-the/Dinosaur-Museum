using UnityEngine;
using TMPro; // MUDANÇA: Necessário para TextMeshPro
using System.Collections;

public class TextTrigger : MonoBehaviour
{
    [Header("Configurações de UI")]
    public GameObject textObject; 
    public string message = "Você encontrou um item!";
    public float displayTime = 3.0f;

    // MUDANÇA: Tipo alterado de Text para TextMeshProUGUI
    private TextMeshProUGUI uiText; 
    private Coroutine displayCoroutine;

    void Start()
    {
        if (textObject != null)
        {
            // MUDANÇA: Agora busca o componente correto
            uiText = textObject.GetComponent<TextMeshProUGUI>();
            
            // Se ainda assim for nulo, tenta o Legacy (só por garantia)
            if (uiText == null)
            {
                Debug.LogWarning("TextMeshPro não encontrado no objeto. Verifique se criou 'UI > Text - TextMeshPro'.");
            }

            textObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (displayCoroutine != null) StopCoroutine(displayCoroutine);
            displayCoroutine = StartCoroutine(ShowTextRoutine());
        }
    }

    IEnumerator ShowTextRoutine()
    {
        // Atualiza o texto antes de mostrar
        if (uiText != null) 
        {
            uiText.text = message;
        }
        
        textObject.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        textObject.SetActive(false);
        displayCoroutine = null;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (textObject != null) textObject.SetActive(false);
            if (displayCoroutine != null) StopCoroutine(displayCoroutine);
        }
    }
}