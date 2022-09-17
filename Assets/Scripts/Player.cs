using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    float AxisX, AxisY;
    Vector3 Direction;
    Rigidbody Rb;
    bool InputMouseButton = false;
    [HideInInspector] static public int DistanceCounter = 0;

    public GameObject UiDeath;
    public TextMeshProUGUI Distance;

    public int PlayerSpeed = 1;
    public float Gravity = 9.81f;
    private void Start()
    {
        DistanceCounter = 0;

        Rb = GetComponent<Rigidbody>();
        Rb.useGravity = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && InputMouseButton == false)
        {
            InputMouseButton = true;
        } else if (Input.GetMouseButtonDown(0) && InputMouseButton == true)
        {
            InputMouseButton = false;
        }
    }
    private void FixedUpdate()
    {
        AxisX = Input.GetAxis("Horizontal");

        Direction = AxisX * PlayerSpeed * transform.right;

        //Rb.AddForce(Direction);

        if (InputMouseButton) {
            // Вверх ногами.
            Rb.AddForce(Gravity * Vector3.up);
        } else {
            // Нормальная гравитация.
            Rb.AddForce(Gravity * -Vector3.up);
        }

        DistanceCounter += 1;
        Distance.text = "Distance: " + DistanceCounter;

        Debug.DrawRay(transform.position, PlayerSpeed * transform.right, Color.red);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            UiDeath.SetActive(true);
            Destroy( GetComponent<Player>() );
        }
    }
}