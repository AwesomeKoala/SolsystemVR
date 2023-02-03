using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMover : MonoBehaviour
{
    [SerializeField]
    private float timeCounter = 0;

    [SerializeField]
    private float width;
    [SerializeField]
    private float height;
    [SerializeField]
    private float speed;

    [SerializeField]
    private float transformScaler;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x * transformScaler,transform.localScale.y * transformScaler,transform.localScale.z * transformScaler);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Sin(timeCounter) * width;
        float y = 0;
        float z = Mathf.Cos(timeCounter) * height;

        transform.position = new Vector3(x, y, z);
    }
}
