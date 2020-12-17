using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FromOnes : MonoBehaviour
{
    
    public TMP_InputField inputFieldOnes;
    public TMP_InputField inputFieldDec;
    public TMP_InputField inputFieldTwos;
    
     public void getText(){
        string numtext = inputFieldOnes.text;
        if(numtext!=""){
        long binary = long.Parse(numtext);
            if (!inputValidator(binary)){
                inputFieldOnes.text = "";
                inputFieldOnes.placeholder.GetComponent<TextMeshProUGUI>().color = Color.blue;
                inputFieldOnes.placeholder.GetComponent<TextMeshProUGUI>().fontSize = 20;
                inputFieldOnes.placeholder.GetComponent<TextMeshProUGUI>().text = "Hmm.. that does not look binary.";
                return;
            }
            displayDecimal(toDecimal(numtext).ToString());
        }
    }
    public long toDecimal(string binaryInt){
        if (binaryInt[0] == '1') {
        //Call our invert digits method
        string invertedInt = invertDigits(binaryInt);
        //Change this to decimal format.
        long decimalValue = Convert.ToInt64(invertedInt, 2);
        //Add 1 to the curernt decimal and multiply it by -1
        //because we know it's a negative number
        decimalValue = (decimalValue) * -1;
        //return the final result
        return decimalValue;
    } else {
        //Else we know it's a positive number, so just convert
        //the number to decimal base.
        return Convert.ToInt64(binaryInt, 2);
        //return Convert.ToString(binary, 2).PadLeft(8, '0');
    }
    }
    string invertDigits(string binaryInt) {
    string result = binaryInt;
    result = result.Replace("0", " "); //temp replace 0s
    result = result.Replace("1", "0"); //replace 1s with 0s
    result = result.Replace(" ", "1"); //put the 1s back in
    return result;
    }
    public bool inputValidator(long num) 
    { 
       /* if (num == 0 || num == 1
            || num < 0) { 
            return false; 
        } */
  
        while (num != 0) { 
  
            if (num % 10 > 1) { 
                return false; 
            } 
            num = num / 10; 
        }

        return true; 
    } 
    
    void displayDecimal(string result){
        inputFieldDec.text = result;
    }
    void displayDecimalTwos(string result){
        inputFieldTwos.text = result;
    }
} 

