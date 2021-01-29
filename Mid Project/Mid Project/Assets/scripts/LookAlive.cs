using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Yam
 * Date: 11/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class LookAlive : MonoBehaviour
{
    public float rotationSpeed;
    public float range;
    public float speed;
    private bool hover;
    private float start;
    private float end;

    private float x, z;
    // Start is called before the first frame update
    void Start()
    {
        hover = true;
        start = transform.localPosition.y;
        end = start + range;
        x = transform.localPosition.x;
        z = transform.localPosition.z;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        // spining
        transform.RotateAroundLocal(Vector3.up, rotationSpeed);
        // going up and down
        if (hover) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(x, end, z), speed);
        } else {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(x, start, z), speed);
        }
        if (transform.localPosition.y.Equals(end) || transform.position.y.Equals(start))
            {
                hover = !hover;             
            }
    }
}
