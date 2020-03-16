using System.Collections.Generic;

namespace PointerChasingTest.ClassicRealization {
    public class EnemyClassic {
        private List<IComponent> _components;

        public EnemyClassic() {
            _components = new List<IComponent> {
                new MoveComponent(), 
                new HealthComponent()
            };
        }

        public void Update() {
            foreach (var component in _components) {
                component.Update();
            }
        }
    }
}