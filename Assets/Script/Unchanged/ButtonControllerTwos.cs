using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerTwos : MonoBehaviour
{
    public FromTwos fromTows;
    public void OnClick(){
    fromTows.GetComponent<FromTwos>().getText();
    }
}
