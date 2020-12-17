using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int baseValue;
    int digit;
    long number;
    long result;
    public void setBase(string baseV){
        baseValue= int.Parse(baseV);
    } 
    public void setDigits(string baseV){
        digit= int.Parse(baseV);
    } 
    public void setNumber(string baseV){
        number= long.Parse(baseV);
    } 
    public long Calculate(){
       long maxDigit, maxNum = 0,  
        digits = digit, num = number; 
        // Largest digit in the number 
        // system with base b 
        maxDigit = baseValue - 1; 
      
        // Largest number in the number 
        // system with base b 
        while((digits--) > 0) 
        { 
            maxNum = maxNum * 10 + maxDigit; 
        } 
        long result = maxNum-num;
        return result; 
    }
/*    Dictionary<char, int> hex_value_of_dec() 
    {
        Dictionary<char, int> m = new Dictionary<char, int>();
        m['0'] = 0;
        m['1'] = 1;
        m['2'] = 2;
        m['3'] = 3;
        m['4'] = 4;
        m['5'] = 5;
        m['6'] = 6;
        m['7'] = 7;
        m['8'] = 8;
        m['9'] = 9;
        m['A'] = 10;
        m['B'] = 11;
        m['C'] = 12;
        m['D'] = 13;
        m['E'] = 14;
        m['F'] = 15;

        return m; 
    }
    Dictionary<int, char> dec_value_of_hex() 
    {
        Dictionary<int, char> m = new Dictionary<int, char>();
        m[0] = '0';
        m[1] = '1';
        m[2] = '2';
        m[3] = '3';
        m[4] = '4';
        m[5] = '5';
        m[6] = '6';
        m[7] = '7';
        m[8] = '8';
        m[9] = '9';
        m[10] = 'A';
        m[11] = 'B';
        m[12] = 'C';
        m[13] = 'D';
        m[14] = 'E';
        m[15] = 'F';
         
        return m; 
    } 
    public string sumBaseB(long result)  
    {
    Dictionary<char, int> m = hex_value_of_dec(); 
    Dictionary<int, char> k = dec_value_of_hex(); 
    Debug.Log(m['0']);
    Debug.Log(k[10]);
    // Check if length of string first is 
    // greater than or equal to string second 
    string a = Convert.ToString(result);
    string b = "1";
  
    // Store length of both strings 
    int l1 = a.Length, l2 = b.Length; 
  
    string ans = ""; 
  
    // Initialize carry as zero 
    int carry = 0, i, j; 
  
    // Traverse till second string 
    // get traversal completely 
    for (i = l1 - 1, j = l2 - 1; 
         j >= 0; i--, j--) { 
  
        // Decimal value of element at a[i] 
        // Decimal value of element at b[i] 
        int sum = m[a[i]] + m[b[j]] + carry; 
  
        // Hexadecimal value of sum%16 
        // to get addition bit 
        int addition_bit = k[sum % baseValue]; 
  
        // Add addition_bit to answer 
        ans+=addition_bit; 
  
        // Update carry 
        carry = sum / baseValue; 
    } 
  
    // Traverse remaining element 
    // of string a 
    while (i >= 0) { 
  
        // Decimal value of element 
        // at a[i] 
        int sum = m[a[i]] + carry; 
  
        // Hexadecimal value of sum%16 
        // to get addition bit 
        int addition_bit = k[sum % baseValue]; 
  
        // Add addition_bit to answer 
        ans+=addition_bit; 
  
        // Update carry 
        carry = sum / baseValue; 
        i--; 
    } 
  
    // Check if still carry remains 
    if (carry!=0) { 
        ans+=k[carry]; 
    } 
  
    // Reverse the final string 
    // for desired output 
  
    // Return the answer 
    return Reverse(ans);
    }
    string Reverse(string s)  
    {  
       // With Inbuilt Method Array.Reverse Method  
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    } */
    public string sumBaseB(long result)  
    {  
        string a = Convert.ToString(result); 
        string b = "1";
        int len_a;  
      
        len_a = a.Length;  
      
        String sum, s;  
        s = "";  
        sum = "";  
      
        int diff;  
        diff = Math.Abs(len_a - 1);  
          
        // Padding 0 in front of the  
        // number to make both numbers equal  
        for (int i = 1; i <= diff; i++)  
            s += "0";  
          
        // Condition to check if the strings  
        // have lengths mis-match  
        if (len_a < 1)  
            a = s + a;  
        else
            b = s + b;  
      
        int curr, carry = 0;  
          
        // Loop to find the find the sum  
        // of two integers of base B  
        for (int i = Math.Max(len_a, 1) - 1;  
                            i > -1; i--) {  
              
            // Current Place value for  
            // the resultant sum  
            curr = carry + (a[i] - '0') +  
                        (b[i] - '0');  
      
            // Update carry  
            Debug.Log(curr+" "+carry+" "+baseValue);
            carry = curr / baseValue;
        
            // Find current digit  
            curr = curr % baseValue;  
            
            // Update sum result  
            sum = (char)(curr + '0') + sum;  
            Debug.Log(sum);
        }  
        if (carry > 0)  
            sum = (char)(carry + '0') + sum;  
        return sum;  
    }
    
}
