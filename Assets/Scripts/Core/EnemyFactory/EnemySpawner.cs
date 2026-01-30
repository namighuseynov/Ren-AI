using UnityEngine;

namespace RenAI.Core.EnemyFactory
{
    public sealed class EnemySpawner : MonoBehaviour
    {
        public EnemyFactory factory;

        private void Start()
        {
            //Timer timer = new Timer(3f, () => Debug.Log("Finished"), false);
            //timer.Start();

            if (factory == null) return;
            var enemy = factory.CreateEnemy(Vector3.zero);
        }
    }
}