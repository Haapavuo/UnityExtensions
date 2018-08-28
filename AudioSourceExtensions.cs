using UnityEngine;

public static class AudioSourceExtensions
{
    public static void PlayClip(this AudioSource source, AudioClip clip, bool looping = false, float volume = 1.0f)
    {
        source.loop = looping;
        source.clip = clip;
        source.volume = volume;
        source.Play();

        Debug.Log($"Playing clip '{clip.name}' on source '{source.name}'");
    }
}
