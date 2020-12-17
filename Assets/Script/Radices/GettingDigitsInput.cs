using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GettingDigitsInput : MonoBehaviour
{
   public GettingInput gettingInput;
   public Calculator calculator;
   public TMP_InputField digitInput;
   public void GetDigitsInput(){
       calculator.GetComponent<Calculator>().setDigits(gettingInput.GettingUserInput(digitInput));
    }

}
