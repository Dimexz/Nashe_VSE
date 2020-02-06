using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandle : MonoBehaviour
{
   
    public void SetText (string mytext)
    {
       Text txt = transform.Find("Text").GetComponent<Text>();
       txt.text = mytext;
    }

   
}
