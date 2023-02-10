using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesComplete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public Text objective1;
    public Text objective2;
    public Text objective3;
    public Text objective4;

    public static ObjectivesComplete occurence;

    private void Awake()
    {
        occurence = this;
    }

    public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4)
    {
        if(obj1 == true)
        {
            objective1.text = "1. Completed";
            objective1.color = Color.green;
        }
        else
        {
            objective1.text = "01. FIND THE RIFLE";
            objective1.color = Color.white;
        }


        if(obj2 == true)
        {
            objective2.text = "2. Completed";
            objective2.color = Color.green;
        }
        else
        {
            objective2.text = "02. LOCATE THE VILLAGERS";
            objective2.color = Color.white;
        }


        if(obj3 == true)
        {
            objective3.text = "3. Completed";
            objective3.color = Color.green;
        }
        else
        {
            objective3.text = "03. FIND VEHICLE";
            objective3.color = Color.white;
        }

        if(obj4 == true)
        {
            objective4.text = "4. Completed";
            objective4.color = Color.green;
        }
        else
        {
            objective4.text = "04. GET ALL  VILLAGERS INTO VEHICLE";
            objective4.color = Color.white;
        }
    }
}
