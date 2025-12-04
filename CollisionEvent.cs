using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public UnityEvent onCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            onCollision.Invoke();
        }

    }

    public void RemoveObject()
    {
        Destroy(gameObject);
    }
}
