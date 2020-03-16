namespace PointerChasingTest.CacheFriendlyRealization {
    public struct MoveComponent {
        private int _speed;

        public MoveComponent(int speed) {
            _speed = speed;
        }

        public void Update() {
            _speed *= 3;
            _speed = 10;
        }
    }
}