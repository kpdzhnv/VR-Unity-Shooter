using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAreaScript : MonoBehaviour
{
    private float minX = -0.45f;
    private float maxX = 0.45f;
    private float minY = 4.0f;
    private float maxY = 7.0f;
    private float minZ = -4.0f;
    private float maxZ = 4.0f;

    private int maxAimsCount = 5;
    private int curAimsCount = 0;
    public GameObject AimPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curAimsCount = 0;
        foreach (Transform child in this.transform)
        {
            if (child.tag == "Aim")
                curAimsCount++;
        }

        if (curAimsCount < maxAimsCount)
        {
            for (int i = 0; i < maxAimsCount - curAimsCount; i++)
            {
                Instantiate(AimPrefab, RandomPosition(), Quaternion.identity);
                curAimsCount++;
            }
        }
    }

    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
    }

}
