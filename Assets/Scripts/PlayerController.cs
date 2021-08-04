using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 80.0f;
	private Rigidbody rigid;

	void Start() {
		/// Gets rigidbody at start
		rigid = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{
		
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 move = new Vector3(horizontal, 0.0f, vertical);
		
		/// Takes the vector3 move and applies it to direction of addforce and * by speed
		rigid.AddForce(move * speed);
		// transform.position += move * speed;
	}
}
		
		// public float speed = 500f;



    	// FixedUpdate is called when messing with Physics 
    
		///Add forward force
		//rb.AddForce(0, 0, 2000 * Time.deltaTime);
		
		/// **Input Actions** WASD||arrow keys
		
		// /// Move up
		// if ( Input.GetKey("w") || Input.GetKeyDown(KeyCode.UpArrow))
		// {
		// 	rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		// }
		
		// /// Move down
		// if ( Input.GetKey("s") || Input.GetKeyDown(KeyCode.DownArrow))
		// {
		// 	rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		// }

		// /// Move right
		// if ( Input.GetKey("d") || Input.GetKeyDown(KeyCode.UpArrow))
		// {
		// 	rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		// 
