using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;
    private List<GameObject> eelsInNet = new List<GameObject>();

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Eel")) {
            eelsInNet.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "Water") {
            foreach (GameObject eel in eelsInNet) {
                Count += 1;
                CounterText.text = "Count : " + Count;
                Destroy(eel);
            }
        }
        if (other.CompareTag("Eel")) {
            eelsInNet.Remove(other.gameObject);
        }
    }
}
