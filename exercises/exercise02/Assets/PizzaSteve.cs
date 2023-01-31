using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSteve : MonoBehaviour {
    public Vector3 target;
    public float speed;
    public bool moving;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (moving) {
            transform.position = transform.position + (Vector3.Normalize(target - transform.position) * speed * Time.deltaTime);
            if (Vector3.Distance(target, transform.position) < 0.1f) {
                moving = false;
            }
        }
    }
}
