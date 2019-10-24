using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

    Light testLight;
    public float minWaitTimeOff;
    public float maxWaitTimeOff;
    public float minWaitTimeOn;
    public float maxWaitTimeOn;
    // Use this for initialization
    void Start () {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
	}

    IEnumerator Flashing()
    {
        while(true)
        {
 /*
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
                testLight.enabled = !testLight.enabled;
            }
*/

            if (testLight == testLight.enabled)
            {
                yield return new WaitForSeconds(Random.Range(minWaitTimeOff, maxWaitTimeOff));
                testLight.enabled = !testLight.enabled;
            }
            if (testLight == !testLight.enabled)
            {
                yield return new WaitForSeconds(Random.Range(minWaitTimeOn, maxWaitTimeOn));
                testLight.enabled = !testLight.enabled;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
