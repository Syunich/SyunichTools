# SyunichScene
It'll do a good work for impression about scene change.

# Import
you can use SyunichScene.unitypacage and easy to import in unity.
(It contains **DOTWEEN** https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676?locale=ja-JP in 
SyunichScene -> Demigiant. if you imported DOTWEEN in your project , please **uncheck the Demigiant File**.)

# How to use
##### **1**. 
Put the **SceneChanger** Prefab in the first scene(in SyunichScene -> Resources -> Prefabs).

![scene_1_0](https://user-images.githubusercontent.com/78691899/144390982-6ea90ee6-c487-4fa2-a6c7-d3d0e7e61026.PNG)
![scene1_1](https://user-images.githubusercontent.com/78691899/144391869-ca8ad6cb-266f-4c3f-baec-fe0decd2bc7c.PNG)


##### (2)
(if you use sample effector , you can go (x).)
You can make your only effectors used by scene changing. Make the class which inherit the
`SyunichTool.SceneChangeEffector` class.
`RunBefore()` need the staging of before scene changing.
`RunAfter()` need the staging of after scene changing.
(Sample code is SyunichScene -> Resources -> Scripts -> SampleFeedOneImage.cs).

##### (3)
Make the GameObhect in Any Hierarchy and use AddComponent to put the class which you made in (2).

![scene2_1](https://user-images.githubusercontent.com/78691899/144393007-b0da540c-575c-41d7-bf69-aff22b8bcc4d.PNG)

##### (4)
Make this Object a Prefab, and you can delete this object in Hierarchy.

##### **5**
Set the Effector Prefabs in Inspector of SceneChanger.

![scene3_0](https://user-images.githubusercontent.com/78691899/144393571-fa648917-ffe3-4c53-bbf8-e5f1f9f099b5.PNG)

If you didn't make Effector Prefab in (2) ~ (4) , you can use Sample Effector in SyunichScene -> Resources -> Prefabs -> Effectors 
instead.

![sampleeffector](https://user-images.githubusercontent.com/78691899/144393894-46ce8ccb-ca0e-4d08-ac5e-f297c1bb33cb.PNG)

##### **6**
You can Change the Scene by using `SyunichTool.SceneChanger.Instance.ChangeScene(string scenename , int effectnumber)`  anywhere in the Project.
`scenename` is the scene you want to change.
`scenenumber` is the effector number you select in 5.
