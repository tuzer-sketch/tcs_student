using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Sounddistance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject camera;
    private AudioSource audio;

    void Start()
    {
      audio = GetComponent<AudioSource>();
      audio.volume = 0.0f;
      StartCoroutine(PlaySound(minDistance: 50f));
    }

 IEnumerator PlaySound(float minDistance = 1.0f){
    float distance = Vector3.Distance(camera.transform.position,transform.position);
    Debug.Log("Distance: " + distance);
   if (distance < minDistance)
   {
      Debug.Log("Playing sound");
      audio.volume = 1.0f - 1.0f/(distance / minDistance);
   }
     yield return new WaitForSeconds(0.1f);
 }
 
}
