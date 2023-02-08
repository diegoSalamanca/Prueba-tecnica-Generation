using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioSource;

    public TMPro.TextMeshProUGUI textMeshProUGUI;

   

    public void SetMessage(string message)
    {
        audioSource = GetComponent<AudioSource>();
        gameObject.SetActive(true);
        textMeshProUGUI.text = message;
        audioSource.Play();
    }

    public void DisableWindow()
    {
        gameObject.SetActive(false);
    }
}
