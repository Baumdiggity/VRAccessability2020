using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    public string NextLevel;
    [Range(0.0f, 30f)]
    public float waitTimeToLoadNextScene = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        Debug.Log("Successfully passed the butter, you win!");
        // should we load the scene???
        Invoke("LoadScene", waitTimeToLoadNextScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
