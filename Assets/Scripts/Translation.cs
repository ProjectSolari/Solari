using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Rotate(transform.rotation.x, speed * Time.deltaTime, transform.rotation.z);

		if (Input.GetKeyDown(KeyCode.F))
		{
            GetComponentInChildren<TrailRenderer>().enabled = !GetComponentInChildren<TrailRenderer>().enabled;

        }
        GetComponentInChildren<TrailRenderer>().time = 360 / speed;
    }

}
