using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class TouchpadMove : MonoBehaviour
{

    public SteamVR_Action_Vector2 touchPadAction;

    // Movement speed of object
    public float MoveSpeed = 5;

    // change to increase or decrease the rasious in which the one presses on the touchpad
    private float touchpadRadius = 0.3f;

    private GameObject CameraEye;


    private void Start()
    {
        CameraEye = GameObject.Find("Camera");
    }

    void Update()
    {

        // Diagonal movement vectors
        Vector3 forwardRight = (Vector3.forward + Vector3.right).normalized;
        Vector3 forwardLeft = (Vector3.forward + Vector3.left).normalized;
        Vector3 backRight = (Vector3.back + Vector3.right).normalized;
        Vector3 backLeft = (Vector3.back + Vector3.left).normalized;

        // Get touchpad return values
        Vector2 touchpadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);

        // variable to store headset camera rotation values
        Vector3 offsetPosAngle = CameraEye.transform.eulerAngles;



       // set object rotation to player headset rotation
        this.transform.eulerAngles = offsetPosAngle;

        // restrict the object to only move left and right based on where your looking
        // remove the line below to move object rotation to full player head rotation
        this.transform.eulerAngles = new Vector3(0, this.transform.eulerAngles.y, 0);



        // Right
        if (touchpadValue[0] > touchpadRadius & touchpadValue[1] < touchpadRadius & touchpadValue[1] > -touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

        }

        // Left
        if (touchpadValue[0] < -touchpadRadius & touchpadValue[1] < touchpadRadius & touchpadValue[1] > -touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        }

        // Forward
        if (touchpadValue[1] > touchpadRadius & touchpadValue[0] < touchpadRadius & touchpadValue[0] > -touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }

        // Backwards
        if (touchpadValue[1] < -touchpadRadius & touchpadValue[0] < touchpadRadius & touchpadValue[0] > -touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
        }

        // Backwards Right
        if (touchpadValue[0] > touchpadRadius & touchpadValue[1] < - touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(backRight * MoveSpeed * Time.deltaTime);
        }

        // Backwards Left
        if (touchpadValue[0] < -touchpadRadius & touchpadValue[1] < -touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(backLeft * MoveSpeed * Time.deltaTime);
        }

        // Forward Right
        if (touchpadValue[0] > touchpadRadius & touchpadValue[1] > touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(forwardRight * MoveSpeed * Time.deltaTime);
        }

        // Forward Left
        if (touchpadValue[0] < -touchpadRadius & touchpadValue[1] > touchpadRadius)
        {
            Vector3 position = this.transform.position;
            this.transform.Translate(forwardLeft * MoveSpeed * Time.deltaTime);
        }

    }
}
