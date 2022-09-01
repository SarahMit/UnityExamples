using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    [Header("Put this script on the objects that should be rotated")]
    [SerializeField] float rotSpeed = 20;
    [Header("Optional, use if two objects should rotate together:")]
    [SerializeField] GameObject rotateTogetherObject; //only put an object here, if you want to synchronously rotate 2 objects


    public void Start()
    {
    }

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX); //rotates around up-axis
        transform.Rotate(Vector3.right, rotY); //rotates around right-axes

        if (rotateTogetherObject)
        {
            rotateTogetherObject.transform.Rotate(Vector3.up, -rotX);
            rotateTogetherObject.transform.Rotate(Vector3.right, rotY);
        }

    }


}