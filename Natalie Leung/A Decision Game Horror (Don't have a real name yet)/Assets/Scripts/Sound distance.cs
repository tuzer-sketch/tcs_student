using UnityEngine;

public class Sounddistance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject camera;
    private AudioSource audio;

    void Start()
    {
      audio = GetComponent<AudioSource>();
      audio.volume = 0.0f;
      audio.Play();
    }

   void Update()
   {
      float minDistance =08.0f;
      float distance = Vector3.Distance(camera.transform.position,transform.position);
      Debug.Log("Distance: " + distance);
      if (distance < minDistance)
      {
         Debug.Log("Playing sound");
         audio.volume = 1.0f - 1.0f/(minDistance/distance);
      }
   }
 
}
