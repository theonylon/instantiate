using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloneObject ()
    {

        int a = 1;
        while (a < 4)
        {
            Instantiate(objectToClone);

            a++;
        }
    }
}
