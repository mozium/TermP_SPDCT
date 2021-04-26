using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{

    public Sprite replacement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = replacement;
        }
    }
}
