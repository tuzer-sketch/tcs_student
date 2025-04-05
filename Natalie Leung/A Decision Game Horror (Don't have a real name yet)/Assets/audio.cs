using UnityEngine;
using UnityEngine.LowLevelPhysics;

public class audio : MonoBehaviour {
    private AudioSource bgMusic;
    [SerializeField] private Transform cameraTransform;

    void Start()
    {
        bgMusic = GetComponent<AudioSource> ();
        bgMusic.Play();
    
    }
    void Update(){
        transform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y,0);
    }
}

   