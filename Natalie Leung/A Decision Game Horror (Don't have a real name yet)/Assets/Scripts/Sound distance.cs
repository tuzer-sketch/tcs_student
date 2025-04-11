using Unity.VisualScripting;
using UnityEngine;

public class Sounddistance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject camera;
    void Start()
    {
      audio = GetComponent<AudioSource();
    }

 iEEnumerator PlaySound (boo1 randomize = false, float chance = 0.5f, float minDistance = 1.0f);
 Vector3 distance = Vector3.Distance(Camera.transform.position,transform.position);
 if (Distance < minDistance)
 {
    void OnAudioFilterRead(float[] data, int channels)
    {
        audio.Volume = 1.0f - (distance / minDistance);
    }
}
}
