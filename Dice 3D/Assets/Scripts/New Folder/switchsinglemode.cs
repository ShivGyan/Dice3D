using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchsinglemode : MonoBehaviour
{
  
  public void switch1()
  {
      SceneManager.LoadScene("1 Dice");
  }
public void switch2()
{
    SceneManager.LoadScene("2 Dices");
}
public void switchmenu()
{
    SceneManager.LoadScene("2 Dices");
}

}
