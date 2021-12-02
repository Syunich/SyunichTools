using UnityEngine.UI;
using UnityEngine;
using SyunichTool;

namespace SyunichSample
{
    public class SceneChangeButton : MonoBehaviour
    {
        [SerializeField] Button _clicked_Button;
        [SerializeField] int _effectorNumber;
        [SerializeField] string _directionScenename;

        private void Start()
        {
            _clicked_Button.onClick.AddListener(() => StartCoroutine(SceneChanger.Instance.ChangeScene(_directionScenename, _effectorNumber)));

        }

        private void OnDestroy()
        {
            _clicked_Button.onClick.RemoveAllListeners();
        }
    }
}