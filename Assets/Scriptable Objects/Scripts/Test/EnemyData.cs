using UnityEngine;

namespace Scriptable_Objects.Scripts.Test
{
    [CreateAssetMenu(fileName = "Test", menuName = "MY/EnemyData", order = 0)]
    public class EnemyData : ScriptableTest
    {
        public int hp;

        public override void DoSomeThings()
        {
            throw new System.NotImplementedException();
        }
    }
}