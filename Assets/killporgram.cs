using UnityEngine;
using UnityEngine.SceneManagement;

public class killporgram : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}
