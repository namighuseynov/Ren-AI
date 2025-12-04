using UnityEngine;

namespace RenAI.Core.EnemyFactory
{
    [CreateAssetMenu(menuName = "Factories/Tank Factory")]
    public class TankFactory : EnemyFactory
    {
        public TankEnemy prefab;
        public override Enemy CreateEnemy(Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}