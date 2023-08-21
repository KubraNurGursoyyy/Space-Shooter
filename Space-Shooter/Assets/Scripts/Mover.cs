using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody pyhsic;

    [SerializeField] float speed;
    void Start()
    {
        pyhsic = GetComponent<Rigidbody>();

        pyhsic.velocity = transform.forward * speed;
    }

}
