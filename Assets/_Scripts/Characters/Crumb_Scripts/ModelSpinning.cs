using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSpinning : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Rotate(0f, 20 * Time.deltaTime, 0f, Space.Self);
    }
}
