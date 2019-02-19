
namespace Weapons
{
    public class Sword
    {
        #region Fields

        private int damage;

        #endregion

        #region Properties

        public int Damage
        {
            get
            {
                return this.damage;
            }

            private set
            {
                this.damage = value;
            }
        }

        #endregion

        #region Constructors

        public Sword()
        {
            this.Damage = 10;
        }
        
        #endregion
    }
}
