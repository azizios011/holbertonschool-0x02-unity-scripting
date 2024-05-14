using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public GameObject Player;
    public float vInput;
    public float HzInput;

    private void Start()
    {
        
    }

    // pre frame
    private void Update()
    {
        vInput = Input.GetAxis("Vertical");
        HzInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * vInput * Speed);
        transform.Translate(Vector3.right * Time.deltaTime * HzInput * Speed);
    }
}
