using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JabuszkoTrigger : MonoBehaviour
{
    public JabuszkoCounter jabuszkoCounter;
    [SerializeField] private int value;
    private bool hasTriggered;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject _collider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {

            hasTriggered = true;
            _audioSource.Play();
            _collider.SetActive(false);
            jabuszkoCounter.ChangeCoins(value);
            //give score to player;
        }
    }
}
