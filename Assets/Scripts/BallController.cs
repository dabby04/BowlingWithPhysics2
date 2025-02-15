using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force=1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    private Rigidbody ballRB;
    private bool isBallLaunched;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB=GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
        transform.parent=ballAnchor;
        transform.localPosition=Vector3.zero;
        ballRB.isKinematic=true;
    }

    private void LaunchBall(){
        if(isBallLaunched)return;
        isBallLaunched=true;
        transform.parent=null;
        ballRB.isKinematic=false;
        ballRB.AddForce(transform.forward*force, ForceMode.Impulse);
    }
}
