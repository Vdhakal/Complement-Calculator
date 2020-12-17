using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerToComp : MonoBehaviour
{
    public ToComplements toComplements;
    public void OnClick(){
    toComplements.GetComponent<ToComplements>().getText();
    }
}
