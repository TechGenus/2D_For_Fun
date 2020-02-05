using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
	{
		transform.parent.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
	}
}
