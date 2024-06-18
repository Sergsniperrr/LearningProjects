using UnityEngine;

public class MovingForvard : MonoBehaviour
{
    private float _speed = 30f;

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime), Space.Self);
    }
}
