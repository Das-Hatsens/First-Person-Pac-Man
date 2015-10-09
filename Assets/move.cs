using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    float speed = 0.05f;
    Vector3 direction;

    // Use this for initialization
    void Start()
    {
        direction = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction;
    }
    void OnGUI()    {        Event e = Event.current;
        
        if (e.type == EventType.KeyDown && e.isKey)
        {
            if (e.keyCode == KeyCode.LeftArrow)
            {
                direction =  Quaternion.Euler(0, -90, 0) * direction;
                StartCoroutine(RotateObject(transform, new Vector3(0, -90, 0), 0.5f));
            }
            else if (e.keyCode == KeyCode.RightArrow)
            {
                direction =  Quaternion.Euler(0, 90, 0) * direction;
                StartCoroutine(RotateObject(transform, new Vector3(0, 90, 0), 0.5f));
            }
        }
    }

    bool rotating;

    IEnumerator RotateObject(Transform transform, Vector3 degrees , float seconds)
    {
        if (rotating)  yield return null;
        rotating = true;

        var startRotation = transform.rotation;
        var endRotation = transform.rotation * Quaternion.Euler(degrees);
        var t = 0.0f;
        float rate = 1.0f / seconds;
        while (t < 1.0) {
            t += Time.deltaTime * rate;
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }
        rotating = false;
    }
}
