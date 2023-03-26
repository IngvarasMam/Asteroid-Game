using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float flyingSpeed;
    public float rotationSpeed;
    void Update()
    {
        /// Rotation
        Quaternion rot = transform.rotation; // Get quaternion rotation
        float z = rot.eulerAngles.z; // Z
        z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; // Change Z, based on Input
        rot = Quaternion.Euler(0,0,z);
        transform.rotation = rot; // CHANGE


        /// Movement of the ship
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * flyingSpeed * Time.deltaTime, 0) ;
        pos += rot * velocity;
        transform.position = pos;
    }

}
