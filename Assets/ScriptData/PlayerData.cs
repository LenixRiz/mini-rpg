using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float health;
    public float strength;
    public float magic;
    public float stamina;
    public float speed;
    public Vector3 currentPosition;
}
