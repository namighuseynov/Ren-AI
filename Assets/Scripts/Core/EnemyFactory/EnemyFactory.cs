using UnityEngine;

namespace RenAI.Core.EnemyFactory
{
    public abstract class EnemyFactory : ScriptableObject
    {
        public abstract Enemy CreateEnemy(Vector3 position);
    }
}