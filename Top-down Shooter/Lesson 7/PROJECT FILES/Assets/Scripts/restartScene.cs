using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartScene : MonoBehaviour {

	public void ChangeScene(string sceneName){
		Time.timeScale = 1;
		SceneManager.LoadScene(sceneName);
	}
}
