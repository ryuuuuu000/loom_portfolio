using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundscript : MonoBehaviour
{
    //現在流れているBGMを管理しているスクリプト


    [SerializeField]
    AudioMixer audioMixer;

    [SerializeField]
    GameObject bgm1;
    [SerializeField]
    GameObject bgm2;
    [SerializeField]
    GameObject bgm3;
    [SerializeField]
    GameObject bgm4;
    [SerializeField]
    GameObject bgm5;

    [SerializeField]
    AudioClip sound;


    [SerializeField]
    GameObject se1;



    void Start()
    {
        bgm1.GetComponent<AudioSource>().Play();
        bgm2.GetComponent<AudioSource>().Stop();
        bgm3.GetComponent<AudioSource>().Stop();
        bgm4.GetComponent<AudioSource>().Stop();
        bgm5.GetComponent<AudioSource>().Stop();
    }

    void Update()
    {
        
    }

    public void SetBGM(float vol)
    {
        audioMixer.SetFloat("BGMvol1", vol);
        audioMixer.SetFloat("BGMvol2", vol);
        audioMixer.SetFloat("BGMvol3", vol);
        audioMixer.SetFloat("BGMvol4", vol);
        audioMixer.SetFloat("BGMvol5", vol);
    }
    public void SetSE(float vol)
    {
        audioMixer.SetFloat("SEvol", vol);
    }

    public void SEplay()
    {
        se1.GetComponent<AudioSource>().PlayOneShot(sound);
    }

    public void BGM1Play()
    {
        bgm1.GetComponent<AudioSource>().Play();
        bgm2.GetComponent<AudioSource>().Stop();
        bgm3.GetComponent<AudioSource>().Stop();
        bgm4.GetComponent<AudioSource>().Stop();
        bgm5.GetComponent<AudioSource>().Stop();
    }

    public void BGM2Play()
    {
        bgm1.GetComponent<AudioSource>().Stop();
        bgm2.GetComponent<AudioSource>().Play();
        bgm3.GetComponent<AudioSource>().Stop();
        bgm4.GetComponent<AudioSource>().Stop();
        bgm5.GetComponent<AudioSource>().Stop();
    }
    public void BGM3Play()
    {
        bgm1.GetComponent<AudioSource>().Stop();
        bgm2.GetComponent<AudioSource>().Stop();
        bgm3.GetComponent<AudioSource>().Play();
        bgm4.GetComponent<AudioSource>().Stop();
        bgm5.GetComponent<AudioSource>().Stop();
    }
    public void BGM4Play()
    {
        bgm1.GetComponent<AudioSource>().Stop();
        bgm2.GetComponent<AudioSource>().Stop();
        bgm3.GetComponent<AudioSource>().Stop();
        bgm4.GetComponent<AudioSource>().Play();
        bgm5.GetComponent<AudioSource>().Stop();
    }
    public void BGM5Play()
    {
        bgm1.GetComponent<AudioSource>().Stop();
        bgm2.GetComponent<AudioSource>().Stop();
        bgm3.GetComponent<AudioSource>().Stop();
        bgm4.GetComponent<AudioSource>().Stop();
        bgm5.GetComponent<AudioSource>().Play();
    }
}
