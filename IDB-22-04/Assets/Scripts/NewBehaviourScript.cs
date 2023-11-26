using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Testobj;
    bool a = true;
    public Text x;
   public int c=0;

    public void Deactive()
    {
        if (a == true)
        {
            Testobj.SetActive(false);
            a = false;
        }
        else
        {
            Testobj.SetActive(true);
            a = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        c--;
        x.text = c.ToString();
    }
}

