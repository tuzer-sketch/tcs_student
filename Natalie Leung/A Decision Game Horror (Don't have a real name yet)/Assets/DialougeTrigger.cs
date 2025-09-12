using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public DialougeController dialouge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        dialouge = GameObject.FindFirstObjectByType<DialougeController>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        dialouge.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        dialouge.gameObject.SetActive(false);
    }
}
