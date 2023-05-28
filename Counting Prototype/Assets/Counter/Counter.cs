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

    [SerializeField] private EelSpawner eelSpawner;

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
                if (eel.GetComponent<Eel>().IsRed) { 
                    CounterText.text = "Game OVER";
                    Time.timeScale = 0f;
                }
                Count += 1;
                CounterText.text = "Count : " + Count;
                Destroy(eel);
            }

            if (eelsInNet.Count > 0) { 
                eelSpawner.SpawnEel();
                eelsInNet = new List<GameObject>();
            }
        }
        if (other.CompareTag("Eel")) {
            eelsInNet.Remove(other.gameObject);
        }
    }
}
