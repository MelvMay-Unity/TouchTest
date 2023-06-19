using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class HandleInput : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();

        Touch.onFingerDown += OnFingerDown;
    }

    void OnFingerDown(Finger finger)
    {
        var position = Camera.main.ScreenToWorldPoint(finger.screenPosition);
       
        var collider = Physics2D.OverlapPoint(position);

        if (collider)
        {
            Destroy(collider.gameObject);
        }
    }
}
