namespace PointerChasingTest.CacheFriendlyRealization {
    public class EnemyCacheFriendly : IEntity {
        public int Id { get; }

        public EnemyCacheFriendly(int id)
        {
            Id = id;
        }
    }
}