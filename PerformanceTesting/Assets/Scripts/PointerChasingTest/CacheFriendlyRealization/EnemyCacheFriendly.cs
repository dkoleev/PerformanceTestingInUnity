namespace PointerChasingTest.CacheFriendlyRealization {
    public class EnemyCacheFriendly {
        private UpdateComponentsSystem _system;
        
        public EnemyCacheFriendly()
        {
            _system = new UpdateComponentsSystem();
        }

        public void Update()
        {
            _system.Update();
        }
    }
}