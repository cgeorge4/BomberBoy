using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public Vector3 tossVel;

    // Start is called before the first frame update
    void Start()
    {
        toss();
    }

    public void toss()
        {
            Rigidbody r = gameObject.AddComponent<Rigidbody>();
            r.constraints = RigidbodyConstraints.FreezeRotation;
            r.velocity = tossVel;
        }
}
    

