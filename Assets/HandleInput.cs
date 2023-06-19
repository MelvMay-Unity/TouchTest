using UnityEngine;

public class HandleInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var camera = Camera.main;

        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                var sceneTouchPosition = camera.ScreenToWorldPoint(touch.position);

                var collider = Physics2D.OverlapPoint(sceneTouchPosition);

                if (collider)
                {
                    Destroy(collider.gameObject);
                }
            }
        }
    }
}
