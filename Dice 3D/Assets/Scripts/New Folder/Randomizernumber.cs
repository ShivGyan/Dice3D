using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Randomizernumber : MonoBehaviour
{
    
    public List<string> stringList = new List<string>();
    public Text gametext;
    private string random1;
 
    public string GetRandomItem(List<string>listToRandomize)
    {
        int randomNum = Random.Range(0, listToRandomize.Count);
        
        string printRandom = listToRandomize[randomNum];
       
        random1 = printRandom;
        return printRandom;
    }

    public void randomshow()
    {
     GetRandomItem(stringList);
     gametext.text = random1.ToString(); 


    }
}
