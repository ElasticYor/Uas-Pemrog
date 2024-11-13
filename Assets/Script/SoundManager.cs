using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance = null;
    public static SoundManager Instance
    {
        get { return instance; }
    }

    private AudioSource audioSource;
    private readonly string[] gameplayScenes = { "Gameplay 1", "Gameplay 2", "Gameplay 3" };

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to scene load event
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (Array.Exists(gameplayScenes, s => s == scene.name))
        {
            // Play the audio only if it's a gameplay scene
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            // Stop the audio if it's not a gameplay scene
            audioSource.Stop();
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe when destroyed
    }
}
