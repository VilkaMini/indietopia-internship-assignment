using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float cameraSpeed;
    [SerializeField]
    private float movementSpeed;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    public Camera cam;
    CharacterController characterController;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState= CursorLockMode.Locked;
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * cameraSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * cameraSpeed;  
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float vertical = Input.GetAxis("Vertical") * movementSpeed;

        // Addition of marginal changes in rotations
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;

        // Rotation of vertical camera and horizontal body
        cam.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        transform.eulerAngles = new Vector3(0.0f, yRotation, 0.0f);

        // Movement of character and fly prevention
        Vector3 moveDirection = cam.transform.right * horizontal + cam.transform.forward * vertical;
        moveDirection.y = 0.0f;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
