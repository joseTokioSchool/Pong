using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BallCollisionSound : MonoBehaviour
{
    [SerializeField] AudioSource mySource;
    [SerializeField] AudioClip playerHitClips;
    [SerializeField] AudioClip wallHitClips;
    [SerializeField] AudioClip goalClips;

    private void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            mySource.PlayOneShot(playerHitClips);
        }
        if (collision.gameObject.layer == 6)
        {
            mySource.PlayOneShot(wallHitClips);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            mySource.PlayOneShot(goalClips);
        }
    }
}
