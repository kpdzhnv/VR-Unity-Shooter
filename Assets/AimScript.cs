using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
    private float minZ = -4.0f;
    private float maxZ = 4.0f;

    private Vector3 dir;
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z == maxZ)
            dir = new Vector3(this.transform.position.x, this.transform.position.y, minZ);
        if (this.transform.position.z == minZ)
            dir = new Vector3(this.transform.position.x, this.transform.position.y, maxZ);
        Vector3.MoveTowards(this.transform.position, dir, 0.1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
