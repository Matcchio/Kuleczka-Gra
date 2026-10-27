using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JabuszkoTrigger : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject _collider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            Debug.Log("Player collected Jabuszko!");
            hasTriggered = true;
            _audioSource.Play();
            _collider.SetActive(false);
            //give score to player;
        }
    }
}
