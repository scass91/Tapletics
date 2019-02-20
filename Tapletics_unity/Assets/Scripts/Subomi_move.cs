using UnityEngine;
using System.Collections;

public class Subomi_move : MonoBehaviour  {
  public float moveForce = 200.0f;

  void FixedUpdate ()
  {
    bool run = Input.GetButtonDown("Jump");

    if (run) GetComponent<Rigidbody2D>().AddForce(Vector3.right * moveForce);


  }
}
