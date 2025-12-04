namespace RenAI.Core
{
    /// <summary>
    /// State of physical weapon (RPG7v2)
    /// </summary>
    public sealed class WeaponState
    {
        #region Fields
        private float _pitch;
        private float _roll;
        private float _yaw;
        private bool _isAiming;
        private int _maxAmmo;
        private int _reserveAmmo;
        private bool _isReloading;
        private bool _isFiring;
        #endregion

        #region Constructor
        public WeaponState(
            float pitch,
            float yaw,
            float roll,
            bool isAiming,
            int maxAmmo,
            int reserveAmmo,
            bool isReloading,
            bool ifFiring
            )
        {
            _pitch = pitch;
            _yaw = yaw;
            _roll = roll;
            _isAiming = isAiming;
            _maxAmmo = maxAmmo;
            _reserveAmmo = reserveAmmo;
            _isReloading = isReloading;
            _isFiring = ifFiring;
        }
        #endregion

        #region Properties
        public float Pitch { get { return _pitch; } }
        public float Yaw { get { return _yaw; } }
        public float Roll { get { return _roll; } }
        public bool IsAiming { get { return _isAiming; } }
        public int MaxAmmo { get { return _maxAmmo; } }
        public int ReserveAmmo { get { return _reserveAmmo; } }
        public bool IsReloading { get { return _isReloading; } }
        public bool IsFiring { get { return _isFiring; } }
        #endregion
    }
}