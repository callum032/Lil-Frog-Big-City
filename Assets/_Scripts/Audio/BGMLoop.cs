// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BGMLoop : MonoBehaviour
// {
    
//     private AudioSource source;

//     // Start is called before the first frame update
//     void Start()
//     {
//         source = GetComponent<AudioSource>();
//         source.volume = 0f;
//         StartCoroutine(Fade(true, source, lengthOfSource, 1f));
//         StartCoroutine(Fade(false, source, lengthOfSource, 0f));
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     public IEnumerator Fade(bool fadeIn, AudioSource source, float duration, float targetVolume){
//         if(!fadeIn){
//             double lengthOfSource = (double)source.clip.samples/source.clip.frequency;
//             yield return new waitForSecondRealTime((float)(lengthOfSource-duration));
//         }else{

//         }

//         float time = 0f;
//         float startVol = source.volume;
//         while (time<duration){
//             time += Time.deltaTime;
//             source.volume = Mathf.Lerp(startVol, targetVolume, time/duration);

//             yield return null;
//         }

//         yield break;
//     }
// }
