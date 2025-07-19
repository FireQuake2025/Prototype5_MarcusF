using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody targetRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        targetRB.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4),-6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
