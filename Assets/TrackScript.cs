using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TrackScript : MonoBehaviour
{
    public GameObject PinsPrefab;
    VRControls vrc;

    // Start is called before the first frame update
    void Awake()
    {
        vrc = new VRControls();
        vrc.VRactionmap.ResetPins.performed += ctx => ResetPins();

        Instantiate(PinsPrefab, new Vector3(-13, 3.5f, 2), Quaternion.identity, this.transform);
    }

    void ResetPins()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        Instantiate(PinsPrefab, new Vector3(-13, 3.5f, 2), Quaternion.identity, this.transform);
    }

    private void OnEnable()
    {
        vrc.VRactionmap.Enable();
    }


    private void OnDisable()
    {
        vrc.VRactionmap.Disable();
    }
}
