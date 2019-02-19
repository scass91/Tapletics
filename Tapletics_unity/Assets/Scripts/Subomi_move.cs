using UnityEngine;
using System.Collections;

public class Subomi_move : MonoBehaviour
{
  public float moveSpeed = 10.0f;

  void FixedUpdate ()
  {
    float move = Input.GetAxis("Horizontal");

    if (move < 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    if (move > 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
  }
}
