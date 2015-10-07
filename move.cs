using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +.3f);

    }
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
            Debug.Log("Detected a keyboard event!");

    }
}
