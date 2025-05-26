using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Circle;
    public GameObject CircleSpawn;
    public void End()
    {
        Circle.GetComponent<Spining>().enabled = false;
        CircleSpawn.GetComponent<CircleSpawn>().enabled = false;
    }
}
