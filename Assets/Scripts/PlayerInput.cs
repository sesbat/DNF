using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private string moveVName = "Vertical";
    private string moveHName = "Horizontal";
    private string attackName = "Attack";
    // Start is called before the first frame update
    public float moveV { get; set; }
    public float moveH { get; set; }
    public bool attack { get; set; }

    // Update is called once per frame
    private void Update()
    {
        moveV = Input.GetAxisRaw(moveVName);
        moveH = Input.GetAxisRaw(moveHName);
        attack = Input.GetButton(attackName);
    }
}
