using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruidor : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D coll) {

        GameObject collider = coll.collider.gameObject;
        GameObject.Destroy(collider);

    }

    void OnTriggerEnter2D(Collider2D collider) {
        GameObject.Destroy (collider.gameObject);
    }
    
}
