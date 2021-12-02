﻿using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace SyunichTool
{

    public sealed class SceneChanger : SingletonMonovehavior<SceneChanger>
    {
        private bool _isChangingScene;
        protected override bool IsDestroyOnLoad => false;
        [SerializeField] SceneChangeEffector[] EffectorPrefabs;
        /// <summary>
        /// effecctorの情報に基づいてシーンを変更する。StartCoroutineで呼び出すことに注意する。
        /// </summary>
        /// <param name="effectornumber">登録したプレハブ内で呼び出したい番号</param>
        /// <param name="scenename">シーン名</param>
        /// <returns></returns>
        public IEnumerator ChangeScene(string scenename , int effectornumber)
        {
            if(_isChangingScene)
            {
                yield break;
            }
            SceneChangeEffector effector = Instantiate(EffectorPrefabs[effectornumber]);
            DontDestroyOnLoad(effector.gameObject);

            yield return StartCoroutine(effector.RunBefore());
            SceneManager.LoadScene(scenename);
            yield return StartCoroutine(effector.RunAfter());
        }
    }

    /// <summary>
    /// シーン遷移の情報を含むクラス
    /// </summary>
    public abstract class SceneChangeEffector : MonoBehaviour
    {
        /// <summary>
        /// シーン遷移前にやる演出を記述.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerator RunBefore();

        /// <summary>
        /// シーン遷移後にやる演出を記述.IsDestroyOnLoadがtrueだと実行されない.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerator RunAfter();
    }

}
