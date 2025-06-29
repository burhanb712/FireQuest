using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class FirstPersonController : MonoBehaviour
{
    public float SensX;
    public float SensY;
    public Transform playerCamera;
    public float verticalRotationLimit = 60.0f;
    //private CharacterController controller;
    float rotationX = 0;
    float rotationY = 0;
    public bool MoveCamera = false;
   // public float speed = 5.0f;


    void Update()
    {
        // Mouse look
        if (MoveCamera)
        {
            float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * SensX;
            float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * SensY;

            rotationY += mouseX;
            rotationX -= mouseY;

            rotationX = Mathf.Clamp(rotationX, -verticalRotationLimit, verticalRotationLimit);
            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
            playerCamera.rotation = Quaternion.Euler(0, rotationY, 0);
        }

       // float moveDirectionY = controller.velocity.y;
       // Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        //controller.Move(move * speed * Time.deltaTime + Vector3.up * moveDirectionY * Time.deltaTime);


    }
}
