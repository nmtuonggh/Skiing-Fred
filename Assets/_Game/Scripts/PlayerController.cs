using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount;
    private Rigidbody2D _rb;
    private float _baseSpeed = 15f;
    private float _speedUpSpeed = 30f;

    private SurfaceEffector2D surface;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        surface = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateControll();
        SpeedupControll();
    }

    private void SpeedupControll()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            surface.speed = _speedUpSpeed;
        }
        else
        {
            surface.speed = _baseSpeed;
        }
    }

    private void RotateControll()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            _rb.AddTorque(-torqueAmount);
        }
    }
}
