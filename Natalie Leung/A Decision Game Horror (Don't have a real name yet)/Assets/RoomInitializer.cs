using UnityEngine;

public class RoomInitializer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        string prev = Roomhandler.Instance.getpreviousroom();
        switch (prev)
        {
            case "1":
                player.position = new Vector3(-3.29f,-3.86f,-2.0f);
                break;
            case "2":
                player.position = new Vector3 (0.6f,-3.89f,-2.0f);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
