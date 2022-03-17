using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGametime : MonoBehaviour
{
    [Range(0.1f,2)]
    
    public float modifiedScale;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = modifiedScale;
    }
}
