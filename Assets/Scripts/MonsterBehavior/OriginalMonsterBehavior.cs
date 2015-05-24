using UnityEngine;
using System.Collections;

public class OriginalMonsterBehavior : MonoBehaviour
{

    public float speed;

    public float closeEnough;

    private Vector3 wanderDir;
    private static Transform target;

    void Start()
    {
        target = GameObject.Find("Player 1").transform;
        wanderDir = new Vector3(Random.Range(0f, 1f), 0.0f, Random.Range(0f, 1f));
        transform.Rotate(wanderDir);
    }

    void Update()
    {
        if (targetIsVisible() || closeToTarget())
            moveTowardTarget();
        else
            wander();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player")) ;
            //Destroy(gameObject);
    }

    bool targetIsVisible()
    {
        Vector3 dir = target.position - transform.position;
        RaycastHit hit;
        return Physics.Raycast(transform.position, dir, out hit) && hit.transform == target;
    }

    bool closeToTarget()
    {
        return closeEnough > Vector3.Distance(transform.position, target.position);
    }

    void moveTowardTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void wander()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
