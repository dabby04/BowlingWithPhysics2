using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (triggeredBody.CompareTag("Ball"))
        {


            Debug.Log(triggeredBody.gameObject.name);
            Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);
        }
    }
}
