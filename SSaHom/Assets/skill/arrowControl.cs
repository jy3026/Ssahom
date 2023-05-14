using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowControl : MonoBehaviour
{

    public SA_Unit _target;
    [SerializeField] float speed = 2f, rotSpeed = 2f;

    Quaternion rotTarget;
    Vector3 dir;
    Rigidbody2D rb;

    private SA_Unit target;

    // Start is called before the first frame update
    void Start()
    {
        SA_Unit sA_Unit = GameObject.Find("Unit001").GetComponent<SA_Unit>();

        rb = GetComponent<Rigidbody2D>();
        target = sA_Unit._target;
    }



    // Update is called once per frame
    /*void Update()
    {
        GuidedMissile();
    }

    public void GuidedMissile()
    {
        dir = (_target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rotTarget = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotTarget, Time.deltaTime * rotSpeed);
        rb.velocity = new Vector2(dir.x * speed, dir.y * speed);
    }*/
    private void FixedUpdate()
    {
        Vector2 direction = target.transform.position - transform.position;
        rb.velocity = direction.normalized * speed;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    
}
