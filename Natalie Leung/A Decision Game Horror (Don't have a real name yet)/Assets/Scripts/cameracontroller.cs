using System.Runtime.CompilerServices;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Followcamera();
    }

    private void Followcamera()
    {
        transform.position =  new Vector3 (player.position.x,player.position.y,transform.position.z);

    }
    
}
