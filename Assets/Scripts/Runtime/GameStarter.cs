using Assets;
using UnityEngine;

namespace Runtime
{    
    public class GameStarter : MonoBehaviour 
    {
        [SerializeField]
        private RootAsset m_rootAsset;

        private void Awake() 
        {
            Game.SetAssetRoot(m_rootAsset);
        }

        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Game.StartLevel(m_rootAsset.levels[0]);
            }
        }
    }

}