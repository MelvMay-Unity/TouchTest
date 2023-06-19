using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class HandleInput : MonoBehaviour
{
    public TextMesh ScoreText;
    public AudioSource Audio;

    private int Score = 0;

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
        Touch.onFingerDown += OnFingerDown;
    }

    private void OnDisable()
    {
        Touch.onFingerDown -= OnFingerDown;        
    }

    void OnFingerDown(Finger finger)
    {
        var position = Camera.main.ScreenToWorldPoint(finger.screenPosition);
       
        var collider = Physics2D.OverlapPoint(position);

        if (collider)
        {
            Audio.Play();
            Destroy(collider.gameObject);
            ScoreText.text = (++Score).ToString();
        }
    }
}
