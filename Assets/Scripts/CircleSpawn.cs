using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    public GameObject littleCircle;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            littleCircleSpawn();
        }
    }

    void littleCircleSpawn()
    {
        Instantiate(littleCircle, transform.position, transform.rotation);
    }

}
