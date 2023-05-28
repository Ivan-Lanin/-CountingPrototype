using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnHandleCollisions : MonoBehaviour
{
    [SerializeField] private Text counterText;


    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Eel")) {
            counterText.text = "Game OVER";
            Time.timeScale = 0f;
        }
    }
}
