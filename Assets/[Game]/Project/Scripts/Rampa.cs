using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampa : MonoBehaviour
{
    public GameObject cube;
    public Player player;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (!cube)
            return;
        cube.GetComponent<Destruction>().Createcube.Invoke();
        StartCoroutine(ExampleCoroutine());
        collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 200, ForceMode.Impulse);

    }
    IEnumerator ExampleCoroutine()
    {
        player.speedLimit = 20f;
        
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        player.speedLimit = 8;
        yield return null;
    }
}
