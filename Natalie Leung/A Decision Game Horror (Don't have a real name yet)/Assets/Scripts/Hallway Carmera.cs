using UnityEngine;

public class HallwayCarmera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.x < 48)
        {
            transform.position = new Vector3(transform.position.x, -7, transform.position.z);
        }
        else if (target.position.x > 48 && target.position.x < 54)
        {
            transform.position = new Vector3(50, target.position.y, transform.position.z);
        }
        else if (transform.position.x > 54)
        {
            transform.position = new Vector3(transform.position.x, -38, transform.position.z);
        }
    }
}
