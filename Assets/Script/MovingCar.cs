using UnityEngine;

public class MovingCar : MonoBehaviour
{

    public float speed = 10f;

    void Update()
    {

        transform.Translate(0, 0, speed * Time.deltaTime, Space.World);

    }
}
