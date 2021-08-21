using UnityEngine;

[CreateAssetMenu]
public class PlayerDatabase : ScriptableObject
{
    public Player[] player;

    public int PlayerCount
    {
        get
        {
            return player.Length;
        }
    }
    public Player GetPlayer(int index)
    {
        return player[index];
    }
}
