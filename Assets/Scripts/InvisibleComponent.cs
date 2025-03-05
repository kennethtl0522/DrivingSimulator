using System;
using TMPro;
using UnityEngine;

public class InvisibleComponent : MonoBehaviour
{
    Renderer rend;
    public TextMeshProUGUI Finish_Text;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        Finish_Text.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Finish_Text.enabled = true;
        }
    }
}
