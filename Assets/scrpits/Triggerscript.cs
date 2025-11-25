using UnityEngine;
using UnityEngine.Playables;
public class Triggerscript : MonoBehaviour
{
    public PlayableDirector timeLine;
    static int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        if(count == 1)
        {
            timeLine.Play();
        }
        
    }

}
