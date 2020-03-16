using System.Collections.Generic;

namespace PointerChasingTest.CacheFriendlyRealization {
    public class UpdateComponentsSystem {
        public List<MoveComponent> _moveComponents;
        public List<HealthComponent> _healthComponents;
        
        public UpdateComponentsSystem() {
            _moveComponents = new List<MoveComponent>();
            _moveComponents.Add(new MoveComponent(100));
            _healthComponents = new List<HealthComponent>();
            _healthComponents.Add(new HealthComponent(100));
        }
        
        public void Update() {
            foreach (var moveComponent in _moveComponents) {
                moveComponent.Update();
            }

            foreach (var healthComponent in _healthComponents) {
                healthComponent.Update();
            }
        }
    }
}
