using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Movement Parameters")]
    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("Movement Positions")]
    public Vector3 startPos;
    public Vector3 endPos;
    public Vector3 negEnd;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        // the direction of movement
        direction = movementAxis.normalized;

        // precompute position
        startPos = transform.position;
        endPos = transform.position + (direction * movementDistance);
        negEnd = transform.position - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if we reach bounds of movement, reverse direction vector
        if (Vector3.Distance(transform.position, endPos) <= 1 || Vector3.Distance(transform.position, negEnd) <= 1)
            direction *= -1;

        //move the platform
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
