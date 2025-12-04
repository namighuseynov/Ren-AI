namespace RenAI.Core
{
    public sealed class UserState
    {
        #region Fields
        private EmotionType _emotion;
        private EyeMetrics _eyeMetrics;
        private WeaponState _weaponState;
        private SessionStats _sessionStats;
        #endregion

        #region Properties 
        public EmotionType Emotion { get { return _emotion; } }
        public EyeMetrics EyeMetrics { get { return _eyeMetrics; } }
        public WeaponState WeaponState { get { return _weaponState; } }
        public SessionStats SessionStats { get { return _sessionStats; } }
        #endregion

        #region Constructor 
        public UserState(
            EmotionType emotion, 
            EyeMetrics eyeMetrics,
            WeaponState weaponState,
            SessionStats sessionStats)
        {
            _emotion = emotion;
            _eyeMetrics = eyeMetrics;
            _weaponState = weaponState;
            _sessionStats = sessionStats;
        }
        #endregion
    }
}