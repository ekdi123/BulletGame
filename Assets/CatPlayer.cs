using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("앞으로~");
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("뒤로~");
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z - 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("옆으로 가라");
            transform.position = new Vector3(
                transform.position.x - 3f * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 가라");
            transform.position = new Vector3(
                transform.position.x + 3f * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }
    }
}
