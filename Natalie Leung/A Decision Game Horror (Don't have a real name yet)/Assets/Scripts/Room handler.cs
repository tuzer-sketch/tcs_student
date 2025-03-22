using UnityEngine;

public class Roomhandler : MonoBehaviour
{
    public static Roomhandler Instance;
    public string currentRoomName;
    public string previousRoomName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);// persists between scene loads (optional)
        }
        else
        {
            Destroy(gameObject); // make sure there's only one RoomManager!
        }
    }
   public void EnterRoom(string newRoomName)
   {
        previousRoomName = currentRoomName;
        currentRoomName = newRoomName;
        Debug.Log("Entered: " + currentRoomName);
   }
    

}
