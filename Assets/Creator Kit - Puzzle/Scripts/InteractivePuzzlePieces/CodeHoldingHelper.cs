using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeHoldingHelper : MonoBehaviour
{
    public GameObject otherWall1;
    public GameObject otherWall2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void checkActive()
    {
        otherWall1.SetActive(true);
        
    }
    private void checkActive2()
    {
        otherWall2.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (otherWall1.activeInHierarchy == false)
        {
            Invoke(nameof(checkActive), 2.0f); //Delays 2 seconds before checkActive is called
        }
        if (otherWall2.activeInHierarchy == false)
        {
            Invoke(nameof(checkActive2), 2.0f); //Delays 2 seconds before checkActive is called
        }
    }
}
