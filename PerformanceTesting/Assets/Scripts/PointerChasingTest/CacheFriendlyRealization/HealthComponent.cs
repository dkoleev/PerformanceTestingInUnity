namespace PointerChasingTest.CacheFriendlyRealization {
    public struct HealthComponent {
        private int _health;

        public HealthComponent(int health) {
            _health = health;
        }

        public void Update() {
            _health -= 1;
            _health = 100;
        }
    }
}