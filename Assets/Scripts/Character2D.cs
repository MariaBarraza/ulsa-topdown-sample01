using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    [SerializeField]float moveSpeed = 5f;
    //float moveSpeed {get;set;}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Axis * moveSpeed * Time.deltaTime);
    }

    Vector2 Axis
    {
      //get{return new Vector2();}
        get => new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")); 
    }
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
}
