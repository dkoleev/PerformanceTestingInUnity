namespace PointerChasingTest.ClassicRealization {
    public class HealthComponent : IComponent {
        private int _health = 100000;
        public void Update() {
            _health -= 1;
            _health = 1000;
        }
    }
}