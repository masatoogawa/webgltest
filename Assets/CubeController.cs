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
    
    public void Touch() {
        int touchCount = Input.touches.Count(t => t.phase != TouchPhase.Ended && t.phase != TouchPhase.Canceled);
        if (touchCount == 1)
        {
            var t = Input.touches.First();
            switch (t.phase)
            {
                case TouchPhase.Moved:
                {
                    var xAngle = t.deltaPosition.y * speed * 10;
                    var yAngle = -t.deltaPosition.x * speed * 10;
                    float zAngle = 0;
                    
                    gameObject.transform.Rotate(xAngle,yAngle,zAngle,Space.World);

                    break;
                }
            }
        }
    }
}
