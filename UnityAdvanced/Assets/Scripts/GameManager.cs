using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject UItext;
    [SerializeField] private AudioClip m_SoundEffect1;
    [SerializeField] private AudioClip m_SoundEffect2;
    [SerializeField] private AudioSource m_SoundEffectSource;
    //public ShootBullets ShootBullets;
    public NavigationScript[] NavigationScript;


    // Start is called before the first frame update
    void Start()
    {
        NavigationScript[0].onFinishedTrack.AddListener(FinishedTrack);
        NavigationScript[1].onFinishedTrack.AddListener(FinishedTrack);
        //ShootBullets.onBulletHit.AddListener(BulletHitHandler);
    }

    //private void BulletHitHandler()
    //{
    //    Debug.Log("bullet hit!");
    //}
    private void FinishedTrack()
    {
        UItext.SetActive(true);
        m_SoundEffectSource.clip = m_SoundEffect1;
        m_SoundEffectSource.Play();
        m_SoundEffectSource.clip = m_SoundEffect2;
        m_SoundEffectSource.PlayDelayed(5f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
