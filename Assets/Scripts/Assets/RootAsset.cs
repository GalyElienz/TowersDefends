using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(menuName = "Assets/Root Asset", fileName = "Root Asset")]
    public class RootAsset : ScriptableObject
    {   
        public List<LevelAsset> levels;
    }           
}