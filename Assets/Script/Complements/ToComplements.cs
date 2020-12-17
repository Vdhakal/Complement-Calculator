using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToComplements : MonoBehaviour
{
    
    public TMP_InputField inputFieldDec;
    public TMP_InputField inputFieldOnes;
    public TMP_InputField inputFieldTwos;
    public TMP_InputField noOfbits;
    public void getText(){
        string numtext = inputFieldDec.text;
        string numberBits = noOfbits.text;
        bool negative = false;
        if(numtext.Substring(0, 1) == "-"){
            numtext = numtext.Substring(1);
            negative = true;
            }
        if(numtext!=""){
            if(numtext.Contains(".")){
                int found = numtext.IndexOf('.');
                string afterDeci = numtext.Substring(found+1);
                numtext = numtext.Substring(0,found);
                afterDeciCalculate(afterDeci);
            }else{
            long deci = long.Parse(numtext);
            string binary = Convert.ToString(deci, 2);
            Debug.Log(binary);
            string binaryTwos = Convert.ToString(deci-1, 2);
            if(!negative){
                
                if(numberBits!=""){
                displayOnes(binary.PadLeft(int.Parse(numberBits),'0'));
                displayTwos(binary.PadLeft(int.Parse(numberBits),'0'));
                 }else{
                displayOnes(binary.PadLeft(binary.Length+1,'0'));
                displayTwos(binary.PadLeft(binary.Length+1,'0'));
                 }
            }
            else{
                string flippedBits = invertDigits(binary); 
                string flippedBitsTwos = invertDigits(binaryTwos); 
                if(numberBits!=""){
                displayOnes(flippedBits.PadLeft(int.Parse(numberBits),'1'));
                displayTwos(flippedBitsTwos.PadLeft(int.Parse(numberBits),'1'));
                }else{
                displayOnes(flippedBits.PadLeft(flippedBits.Length+1,'1'));
                displayTwos(flippedBitsTwos.PadLeft(flippedBitsTwos.Length+1,'1'));
                }
            }
            }
            //toDecimal(deci, numtext);
        }
    }
    public void afterDeciCalculate(string s){

    }
  /* public string getTextOnes(string numtext){
        bool negative = false;
         if(numtext!=""){
        if(numtext.Substring(0, 1) == "-"){
            numtext = numtext.Substring(1);
                string flippedBits = invertDigits(binary); 
                return flippedBits.PadLeft(flippedBits.Length+1,'1');
            }
            long deci = long.Parse(numtext);
            string binary = Convert.ToString(deci, 2);
            string binaryTwos = Convert.ToString(deci-1, 2);
            if(!negative){
                return binary.PadLeft(binary.Length+1,'0');
            }
            //toDecimal(deci, numtext);
        }
    }*/
    string invertDigits(string binaryInt) {
    string result = binaryInt;
    result = result.Replace("0", " "); //temp replace 0s
    result = result.Replace("1", "0"); //replace 1s with 0s
    result = result.Replace(" ", "1"); //put the 1s back in
    return result;
    }
    void displayOnes(string result){
        inputFieldOnes.text = result;
    }
    void displayTwos(string result){
        inputFieldTwos.text = result;
    }
    static long binaryToDecimal(long n) 
    { 
        long num = n; 
        long dec_value = 0; 
  
        // Initializing base 
        // value to 1, i.e 2^0 
        long baseNumber = 1; 
  
        long temp = num; 
        while (temp > 0) { 
            long last_digit = temp % 10; 
            temp = temp / 10; 
  
            dec_value += last_digit * baseNumber; 
  
            baseNumber = baseNumber * 2; 
        } 
  
        return dec_value; 
    }
  /*  long flipbits(long n, long b) 
    { 
        long maxDigit, maxNum = 0,  
            digits = 0, num = n; 
      
        // Calculate number of digits  
        // in the given number 
        while(n != 0) 
        { 
            digits++; 
            n = n / 10; 
        } 
      
        // Largest digit in the number 
        // system with base b 
        maxDigit = b - 1; 
      
        // Largest number in the number 
        // system with base b 
        while((digits--) > 0) 
        { 
            maxNum = maxNum * 10 + maxDigit; 
        } 
      
        // return Complement 
        return maxNum - num; 
    } 
  
    /*public bool inputValidator(long num) 
    { 
        if (num == 0 || num == 1
            || num < 0) { 
            return false; 
        } 
  
        while (num != 0) { 
  
            if (num % 10 > 1) { 
                return false; 
            } 
            num = num / 10; 
        }

        return true; 
    } */
  
} 

