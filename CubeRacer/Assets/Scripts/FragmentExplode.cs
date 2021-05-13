using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentExplode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode() {
        Rigidbody rb = transform.GetComponent<Rigidbody>();
        rb.AddExplosionForce (Random.Range(100,500), transform.position, 10);

        yield return new WaitForSeconds(2);

        Destroy(gameObject);
    }
}
