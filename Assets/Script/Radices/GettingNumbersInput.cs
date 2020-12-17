using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GettingNumbersInput : MonoBehaviour
{
    public Calculator calculator;
   public GettingInput gettingInput;
   public TMP_InputField numberInput;
   public void GetNumbersInput(){
       calculator.GetComponent<Calculator>().setNumber(gettingInput.GettingUserInput(numberInput));
   }
}
