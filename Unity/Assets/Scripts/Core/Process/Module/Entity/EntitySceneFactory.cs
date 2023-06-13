﻿namespace ET
{
    public static class EntitySceneFactory
    {
        public static Scene CreateScene(Process process, long id, long instanceId, int zone, SceneType sceneType, string name, Entity parent = null)
        {
            Scene scene = new Scene(process, id, instanceId, zone, sceneType, name);
            parent?.AddChild(scene);
            return scene;
        }

        public static Scene CreateScene(Process process, int zone, SceneType sceneType, string name, Entity parent = null)
        {
            long instanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene scene = new Scene(process, zone, instanceId, zone, sceneType, name);
            parent?.AddChild(scene);
            return scene;
        }
    }
}