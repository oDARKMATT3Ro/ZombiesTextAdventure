using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour {

    public float waitTime = 4f;

    private IEnumerator LogoFinishEvent() {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}