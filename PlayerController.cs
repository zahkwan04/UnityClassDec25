using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 5f;
    public float horizontalInput;
    public float verticalInput;
    public float rotationSpeed = 100f; // degrees per second for Q/E rotation



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // move vehicle forward
        //transform.Translate(0, 0, 0.2f); //use x,y,z
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //use vector

        //turn vehicle
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // rotate left / right using Q and E (yaw)
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime , Space.Self);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime , Space.Self);
        }





    }
}
