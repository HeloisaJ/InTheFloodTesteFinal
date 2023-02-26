using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform player;
    public GameObject floor;
    public Vector3 dir;
    public float move = 3;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (floor.GetComponent<Ground>().gazeAtFloor)
        {
            dir = player.TransformVector(new Vector3(0, 0, move).normalized);
        }
    }

    private void FixedUpdate()
    {
        if (floor.GetComponent<Ground>().gazeAtFloor)
        {
            rb.MovePosition(rb.position + dir * 2 * Time.fixedDeltaTime);
        }
    }
}
