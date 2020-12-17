using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GettingBaseInput gettingBaseInput;
    public GettingDigitsInput gettingDigitsInput;
    public GettingNumbersInput gettingNumbersInput;
    public Calculator calculator;
    public TwosCalculator twosCalculator;
    public DisplayText displayText;


    public void OnClick(){
        gettingBaseInput.GetComponent<GettingBaseInput>().GetBaseInput();
        gettingDigitsInput.GetComponent<GettingDigitsInput>().GetDigitsInput();
        gettingNumbersInput.GetComponent<GettingNumbersInput>().GetNumbersInput();
        long value1 = calculator.GetComponent<Calculator>().Calculate();
        string value2 = calculator.GetComponent<Calculator>().sumBaseB(value1);
        displayText.GetComponent<DisplayText>().displayText(value1, value2);
    }
    
}
