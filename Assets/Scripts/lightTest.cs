using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Light lightComponent = gameObject.GetComponent<Light>();
        transform.Rotate(Vector3.up, 10.0f * Time.deltaTime, Space.Self);



    


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);

        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
    }
}
