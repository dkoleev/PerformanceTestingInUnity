using System.Collections.Generic;
using PointerChasingTest.CacheFriendlyRealization;
using PointerChasingTest.ClassicRealization;
using UnityEngine;

namespace PointerChasingTest {
    public class TestPerformance : MonoBehaviour {
        public int EnemyAmount;
        public bool IsClassicMode;
        
        private List<EnemyClassic> _classicEnemies = new List<EnemyClassic>();
        private UpdateComponentsSystem _system = new UpdateComponentsSystem();

        private void Start() {
            for (int i = 0; i < EnemyAmount; i++) {
                _classicEnemies.Add(new EnemyClassic());
                
                 _system.AddHealthComponent();
                 _system.AddMoveComponent();
            }
        }

        private void Update() {
           if (IsClassicMode) 
               foreach (var classicEnemy in _classicEnemies)
                   classicEnemy.Update();
           else
               _system.Update();
        }
    }
}