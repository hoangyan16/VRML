using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    // Start is called before the first frame update
    public void Change()
    {
        transform.localScale= transform.localScale + new Vector3(1f,1f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
