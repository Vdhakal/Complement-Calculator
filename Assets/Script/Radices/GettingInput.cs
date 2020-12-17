using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GettingInput : MonoBehaviour
{
    public string GettingUserInput(TMP_InputField inputField){
        return inputField.text;
    }
}
