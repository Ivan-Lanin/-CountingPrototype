using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eel : MonoBehaviour
{
    public bool IsRed { get { return isRed; } private set { isRed = value; } }
    [SerializeField] private bool isRed;
}
