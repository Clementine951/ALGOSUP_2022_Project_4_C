using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuritySystem : MonoBehaviour
{
    public GameObject Door;
    public GameObject Handler1;
    public GameObject Handler2;
    public GameObject Grabable1;
    public GameObject Grabable2;
    public Level AccesLevel;

    public enum Level
    {
        Student,
        Prof,
        Admin
    }

    // Start is called before the first frame update
    void Start()
    {
        Door.isStatic = true;
        Handler1.isStatic = true;
        Handler2.isStatic = true;
        Grabable1.isStatic = true;
        Grabable2.isStatic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        var card = collision.collider.GetComponent<AccesLevel>();

        if (card != null)
        {
            if ((int)card.Level >= (int)AccesLevel)
            {
                Door.isStatic = false;
                Handler1.isStatic = false;
                Handler2.isStatic = false;
                Grabable1.isStatic = false;
                Grabable2.isStatic = false;
                Debug.Log("Access Granted");

            }
            else
            {
                Debug.Log("Ratio");
                Door.isStatic = true;
                Handler1.isStatic = true;
                Handler2.isStatic = true;
                Grabable1.isStatic = true;
                Grabable2.isStatic = true;
            }
        }
        
    }

}
