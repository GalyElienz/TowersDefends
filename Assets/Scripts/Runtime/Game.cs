using System;
using Assets;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runtime 
{
    public static class Game
    {
        private static Player s_Player;
        public static Player player => s_Player;

        private static RootAsset s_rootAsset;
        public static RootAsset rootAsset => s_rootAsset;

        private static LevelAsset s_CurrentLevel;
        public static LevelAsset currentLevel => s_CurrentLevel;

        private static Runner s_runner;

        public static void SetAssetRoot(RootAsset rootAsset)
        {
            s_rootAsset = rootAsset;
        }

        public static void StartLevel(LevelAsset levelAsset) 
        {
            s_CurrentLevel = levelAsset;
            AsyncOperation operation = SceneManager.LoadSceneAsync(levelAsset.sceneAsset.name);
            operation.completed += StartPlayer;
        }

        private static void StartPlayer(AsyncOperation operation) 
        {
            if (!operation.isDone) 
            {
                throw new Exception("Can't load scene");
            }
            s_Player = new Player();
            s_runner = UnityEngine.Object.FindObjectOfType<Runner>();
            s_runner.StartRunning();
        }

        private static void StopPlayer() 
        {
            s_runner.StopRunning();
        }
    }
}
