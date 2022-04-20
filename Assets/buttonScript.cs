using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;


public class buttonScript : MonoBehaviour
{

   public Text mytext = null;
    public int counter = 0;
    public void changeText()
    {
        counter++;
        mytext.text="You Clicked "+ counter.ToString() +" Times";
    }
}
