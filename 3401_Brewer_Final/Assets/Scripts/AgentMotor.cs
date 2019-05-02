using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMotor : MonoBehaviour
{
    public float movementSpeed = 1;
    public Vector3 targetPosition;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetMouseButtonDown(0))
        {

            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(cameraRay, out hit))
            {
                targetPosition = new Vector3(hit.point.x, 1, hit.point.z);
                transform.position = Vector3.Lerp(transform.position, targetPosition, movementSpeed);
            }
        }







    }
}