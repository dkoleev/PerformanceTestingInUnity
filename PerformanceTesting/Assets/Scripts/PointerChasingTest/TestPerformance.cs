using System.Collections.Generic;
using PointerChasingTest.CacheFriendlyRealization;
using PointerChasingTest.ClassicRealization;
using UnityEngine;

namespace PointerChasingTest {
    public class TestPerformance : MonoBehaviour {
        public int EnemyAmount;
        public bool IsClassicMode;
        
        private List<EnemyClassic> _classicEnemies = new List<EnemyClassic>();
        private List<EnemyCacheFriendly> _cacheFriendlyEnemies = new List<EnemyCacheFriendly>();

        private void Start() {
            for (int i = 0; i < EnemyAmount; i++) {
                _classicEnemies.Add(new EnemyClassic());
                _cacheFriendlyEnemies.Add(new EnemyCacheFriendly());
            }
        }

        private void Update() {
            if (IsClassicMode) {
                foreach (var classicEnemy in _classicEnemies) {
                    classicEnemy.Update();
                }
            } else {
                foreach (var cacheFriendlyEnemy in _cacheFriendlyEnemies) {
                    cacheFriendlyEnemy.Update();
                }
            }
        }
    }
}