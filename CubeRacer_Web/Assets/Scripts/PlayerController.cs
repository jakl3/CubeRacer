using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float frontForce;
    public float sideForce;
    public bool active;
    public GameObject shatter;
    public Score score;
    public new ConstantForce constantForce;
    public Lives lives;
    float speedLimit;

    void Start() {
        active = true;
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if (DATA.Infinite == false && lives.getLives() <= 0) {
            StartCoroutine(endGame());
        }
    }
    IEnumerator endGame() {
        active = false;
        yield return new WaitForSeconds(0.2f);
        FindObjectOfType<GameManager>().GameOver();
    }

    void FixedUpdate() {
        if (active) {
            // rotate
            Quaternion targetRotation = Quaternion.identity;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 15);

            // velocity
            if (rb.velocity.magnitude < speedLimit) {
                rb.AddForce(0, 0, frontForce * Time.deltaTime);
            }
            //Debug.Log(rb.velocity.magnitude);

            // rb.MovePosition (rb.position + new Vector3(0, 0, 30 * Time.fixedDeltaTime));

            rb.AddForce(Input.GetAxisRaw("Horizontal") * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0.7f) {
            StartCoroutine(endGame());
            StartCoroutine(fallSpin());
        }
    }

    IEnumerator fallSpin() {
        Vector3 torque;
        int tor = 2;
        torque.x = Random.Range (-tor, tor);
        torque.y = Random.Range (-tor, tor);
        torque.z = Random.Range (-tor, tor);
        constantForce.torque = torque;
        yield return new WaitForSeconds(1);
        constantForce.torque = new Vector3(0,0,0);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Obstacle") {
            // Debug.Log("We hit object " + collision);
            Instantiate(shatter, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Destroy (collision.gameObject);
            score.collide();
            if (DATA.Infinite == false) {
                lives.DeductLife();
            }
        }
    }

    public void Easy() {
        speedLimit = 50f;
        rb.mass = 4f;
        rb.drag = 4f;
        frontForce = 64000f;
        sideForce = 120f;
        Debug.Log("Easy: " + speedLimit + " " + rb.mass + " " + rb.drag + " " + frontForce + " " + sideForce);
    }

    public void Medium() {
        speedLimit = 60f;
        rb.mass = 3f;
        rb.drag = 3f;
        frontForce = 48000f;
        sideForce = 120f;
        Debug.Log("Medium: " + speedLimit + " " + rb.mass + " " + rb.drag + " " + frontForce + " " + sideForce);
    }

    public void Hard() {
        speedLimit = 70f;
        rb.mass = 1f;
        rb.drag = 1f;
        frontForce = 8000f;
        sideForce = 90f;
        Debug.Log("Hard: " + speedLimit + " " + rb.mass + " " + rb.drag + " " + frontForce + " " + sideForce);
    }
}