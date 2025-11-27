using UnityEngine;

public class ApplyForceScript : MonoBehaviour
{
    Rigidbody ourRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(10000,transform.position - new Vector3(0,-1,1), 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch!");
        collision.transform.position += Vector3.down;
    }

}
