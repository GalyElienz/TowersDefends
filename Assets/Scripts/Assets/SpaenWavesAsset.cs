using UnityEngine;
namespace Assets
{
    [CreateAssetMenu(menuName = "Assets/Spaen Waves Asset", fileName = "Spaen Waves Asset")]
    public class SpaenWavesAsset : ScriptableObject
    {
        public EnemyAsset enemyAsset;
        public int count;
        public float tineBetwenSpawns;

    }           
}