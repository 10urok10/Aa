using UnityEngine;

public class Spining : MonoBehaviour
{
    public float spinSpeed = 0;

    void Update()
    {
        transform.Rotate(0f, 0f, spinSpeed * Time.deltaTime);
    }
}
