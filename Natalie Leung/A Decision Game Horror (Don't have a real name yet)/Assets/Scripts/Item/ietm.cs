using UnityEngine;

[CreateAssetMenu(fileName = "ietm", menuName = "Scriptable Objects/ietm")]
public class ietm : ScriptableObject
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite icon;
    [SerializeField] private int maxStackSize = 16;
}
