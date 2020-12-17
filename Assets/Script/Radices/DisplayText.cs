using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayText : MonoBehaviour
{
    public TMP_InputField dimRadixComp;
    public TMP_InputField radixComp;

    public void displayText(long text1, string text2){
        dimRadixComp.GetComponent<TMP_InputField>().text = Convert.ToString(text1);
        radixComp.GetComponent<TMP_InputField>().text = text2;
    }
}
