using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float targetDistance; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Abs(transform.position.z - player.transform.position.z);
        Debug.Log(distance);
        if (distance < targetDistance)
        {
            transform.position -= new Vector3(0f, 0f, Time.deltaTime);
        }
        else
        {
            transform.position += new Vector3(0f, 0f, Time.deltaTime);
        }
        if (transform.position.x > player.transform.position.x + 0.25f)
        {
            transform.position -= new Vector3(Time.deltaTime ,0f, 0f);
        }
        if (transform.position.x < player.transform.position.x - 0.25f)
        {
            transform.position += new Vector3(Time.deltaTime, 0f, 0f);
        }
    }
}
