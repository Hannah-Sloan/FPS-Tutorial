using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderComponent : MonoBehaviour
{
    [SerializeField] private string sceneToLoadName;
    [SerializeField] private bool additive;
    [Tooltip("Will load scene even if scene is already loaded.")]
    [SerializeField] private bool forceSceneLoad;

    private void OnEnable()
    {
        var scen = SceneManager.GetSceneByName(sceneToLoadName);
        if (!forceSceneLoad && scen.isLoaded)
            return;
        LoadSceneMode loadSceneMode = additive ? LoadSceneMode.Additive : LoadSceneMode.Single;
        SceneManager.LoadScene(sceneToLoadName, loadSceneMode);
    }
}
