using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    float boundx =0;
    float size = 0;
    float boundy = 0;
    float speed = 1.28f*5;
    // Use this for initialization
    void Start()
    {
        float height =2* Camera.main.orthographicSize;
        Debug.Log(height);
        float width = height * Camera.main.aspect;
        Debug.Log((width/2)/1.28);
        boundy = (30/ 2) * 1.28f - height/2+.64f;
        boundx= (30/2) * 1.28f - width/2+.64f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if(Mathf.Abs(transform.position.x)> boundx)
        {
            transform.position = new Vector3(Mathf.Sign(transform.position.x)*boundx, transform.position.y, transform.position.z);
        }
        if(Mathf.Abs(transform.position.y) > boundy)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Sign(transform.position.y) * boundy, transform.position.z);

        }
    }
}