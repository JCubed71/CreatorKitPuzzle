using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickWall : MonoBehaviour
{
    public GameObject wall;
    //private BoxCollider BC;
    // Start is called before the first frame update
    void Start()
    {
        //BC = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (wall.activeInHierarchy == false)
       // {
           // BC.gameObject.SetActive(true);
        //}
         
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            wall.SetActive(false);
        }
       
        
    }
}
