using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CubeController : MonoBehaviour
{
    public float speed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 _lastMousePosition = new Vector3();

    public void Touch()
    {
        Vector3 delta = _lastMousePosition - Input.mousePosition;
        _lastMousePosition = Input.mousePosition;
        
        
        Debug.Log("mouse y:" +  Input.mousePosition);
        //if (Input.GetMouseButtonDown(0))
        //{
            var xAngle = -delta.y * speed * 10;
            var yAngle = delta.x * speed * 10;
            float zAngle = 0;
            gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        //}
    }
}
