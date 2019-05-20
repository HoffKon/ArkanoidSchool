using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_destroy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}

