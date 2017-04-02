using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    Dictionary<string, float> resources = new Dictionary<string, float>();
    Dictionary<int, Event> events = new Dictionary<int, Event>();
	// Use this for initialization
	void Start () {
        // initial values for resources
        resources.Add("pop", 0);
        resources.Add("money", 0);
        resources.Add("food", 0);
        resources.Add("panic", 0);
        resources.Add("trust", 0);
        resources.Add("cPop", 0.0f);
        resources.Add("cMoney", 0.0f);
        resources.Add("cFood", 0.0f);
        resources.Add("cPanic", 0.0f);
        resources.Add("cTrust", 0.0f);

        events.Add(1, new Event("Welcome!", "Welcome to your new position as mayor of this little town. May you lead us forward and keep us safe.", new List<EventOption>()));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
