using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitionManager : MonoBehaviour
{
    private static LevelTransitionManager _instance;
    private float _fadeDuration = 1;

    [Header("Test Variables")]
    [Tooltip("Scene Loaded When Pressing 'O'")]
    [SerializeField] private string _prevScene;
    [Tooltip("Scene Loaded When Pressing 'P'")]
    [SerializeField] private string _nextScene;

    public static LevelTransitionManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject newGameObject = new GameObject("LevelTransitionManager");
                _instance = newGameObject.AddComponent<LevelTransitionManager>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(_instance.gameObject);
        }

        _instance = this;
    }

    private void Start()
    {
        CanvasGroup canvasGroup = GameObject.FindObjectOfType<CanvasGroup>();
        StartCoroutine(DoFade(canvasGroup, 0f, 1f));
    }

    void Update()
    {
        //Comment this method for the final version
        TestSceneNavigation();
    }

    /// <summary>
    /// To Call This use StartCoroutine(LevelTransitionManager.Instance.CallScene("SceneName"));
    /// </summary>
    /// <param name="pScene">Scene Name</param>
    /// <returns></returns>
    public IEnumerator CallScene(string pScene)
    {
        CanvasGroup canvasGroup = GameObject.FindObjectOfType<CanvasGroup>();
        yield return StartCoroutine(DoFade(canvasGroup, 1f, 0f));
        yield return SceneManager.LoadSceneAsync(pScene);
        yield return null;
    }

    /// <summary>
    /// Call this to do a simple fade effect
    /// </summary>
    /// <param name="pCanvasGroup">Attatch the canvas group that will be affected by the effect</param>
    /// <param name="pStart">FadeOut = 1, FadeIn = 0</param>
    /// <param name="pEnd">FadeOut = 0, FadeIn = 1</param>
    /// <returns></returns>
    IEnumerator DoFade(CanvasGroup pCanvasGroup, float pStart, float pEnd)
    {
        if(pCanvasGroup != null)
        {
            float counter = 0f;
            while (counter < _fadeDuration)
            {
                counter += Time.deltaTime;
                pCanvasGroup.alpha = Mathf.Lerp(pStart, pEnd, counter / _fadeDuration);

                yield return null;
            }
        }
        else
        {
            Debug.LogWarning("CanvasGroup is null");
        }

        yield return null;
    }

    /// <summary>
    /// Navigate thru the scenes pressing P to next scene and O to go back
    /// TODO:Disable this for the final version
    /// </summary>
    private void TestSceneNavigation()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (string.IsNullOrEmpty(_nextScene))
            {
                Debug.LogWarning("This is the last scene");
                return;
            }

            StartCoroutine(CallScene(_nextScene));
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (string.IsNullOrEmpty(_prevScene))
            {
                Debug.LogWarning("This is the first scene");
                return;
            }

            StartCoroutine(CallScene(_prevScene));
        }
    }
}
