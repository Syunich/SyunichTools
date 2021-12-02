【使用方法】
①:プロジェクト初めのシーンのHieearchyに
SyunichScene -> Resources -> Prefabs -> SceneChanger
を置きます。

②:namespace SyunichTool にあるSceneChangeEffectorを継承した.csファイルを適当に1つ作ります。
yield句を使用し、
RunBefore()にはシーン遷移前にする演出
RunAfter()にはシーン遷移後にする演出
を記述します。
(サンプルをSyunichScene -> Resources -> Scripts -> SampleFeedOneImage.csに記述しています)

③:適当な空のゲームオブジェクトを作り、②で作成した.csファイルをアタッチします。

④:③で作成したゲームオブジェクトをプレハブ化しておきます。

⑤:④で作成したプレハブの参照を①で置いたSceneChangerのコンポーネント"SceneChanger"の
Effector prefabsに置いておきます。

⑥SyunichTool.SceneChangerクラスを用いて、シーンを変更したいタイミングで
StartCoroutine(SceheChanger())を呼びます。
