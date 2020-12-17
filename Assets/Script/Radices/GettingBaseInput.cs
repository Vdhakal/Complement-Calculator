using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GettingBaseInput : MonoBehaviour
{
     public Calculator calculator;
     public GettingInput gettingInput;
     public TMP_InputField baseInput;
     public void GetBaseInput(){
          calculator.GetComponent<Calculator>().setBase(gettingInput.GettingUserInput(baseInput));
          
          }
}
