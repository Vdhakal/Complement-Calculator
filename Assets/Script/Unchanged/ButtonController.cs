using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public FromOnes fromOnes;
    public void OnClick(){
    fromOnes.GetComponent<FromOnes>().getText();
    }
}
