namespace RenAI.Core
{
    /// <summary>
    /// Statistics collected during a single training session.
    /// </summary>
    public sealed class SessionStats
    {
        #region Fields
        // --- Shooting ---
        private int _totalShots;
        private int _hits;
        private int _criticalHits;
        private int _maxHitStreak;

        // --- Per target type ---
        private int _hitsPrimitiveTank;
        private int _hitsIntelligentTank;
        private int _hitsCollectiveTank;

        // --- Timing ---
        private float _averageReactionTime;
        private float _sessionDuration;

        // --- Weapon actions ---
        private int _reloadCount;
        private int _failedReloads;

        #endregion


        #region Constructor

        public SessionStats(
            int totalShots,
            int hits,
            int criticalHits,
            int maxHitStreak,
            int hitsPrimitiveTank,
            int hitsIntelligentTank,
            int hitsCollectiveTank,
            float averageReactionTime,
            float sessionDuration,
            int reloadCount,
            int failedReloads
        )
        {
            _totalShots = totalShots;
            _hits = hits;
            _criticalHits = criticalHits;
            _maxHitStreak = maxHitStreak;

            _hitsPrimitiveTank = hitsPrimitiveTank;
            _hitsIntelligentTank = hitsIntelligentTank;
            _hitsCollectiveTank = hitsCollectiveTank;

            _averageReactionTime = averageReactionTime;
            _sessionDuration = sessionDuration;

            _reloadCount = reloadCount;
            _failedReloads = failedReloads;
        }

        #endregion


        #region Properties (Read-only API)

        public int TotalShots => _totalShots;
        public int Hits => _hits;
        public int CriticalHits => _criticalHits;
        public int MaxHitStreak => _maxHitStreak;

        public int HitsPrimitiveTank => _hitsPrimitiveTank;
        public int HitsIntelligentTank => _hitsIntelligentTank;
        public int HitsCollectiveTank => _hitsCollectiveTank;

        public float AverageReactionTime => _averageReactionTime;
        public float SessionDuration => _sessionDuration;

        public int ReloadCount => _reloadCount;
        public int FailedReloads => _failedReloads;

        // Derived property
        public float Accuracy => _totalShots == 0 ? 0 : (float)_hits / _totalShots;

        #endregion
    }
}