using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    int hp;
    public PizzaSteve steve;
    public static int points;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        hp = 2;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (points >= 6) {
            steve.moving = true;
            Destroy(player);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            hp -= 1;
            if (hp <= 0) {
                steve.moving = true;
                Destroy(player);
                Destroy(gameObject);
            } else {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
