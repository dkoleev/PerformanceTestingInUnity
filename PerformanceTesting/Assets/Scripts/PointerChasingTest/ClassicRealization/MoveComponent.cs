namespace PointerChasingTest.ClassicRealization {
    public class MoveComponent : IComponent {
        private int _speed = 10;
        public void Update() {
            _speed *= 3;
            _speed = 10;
        }
    }
}