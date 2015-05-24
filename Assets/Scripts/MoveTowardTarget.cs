using UnityEngine;
using System.Collections;

public class MoveTowardTarget : MonoBehaviour {

    public Transform target;
    public float speed;

    void Update()
    {
        move();
    }

    void move()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
