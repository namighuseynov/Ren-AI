namespace RenAI.Core
{
    public class Stats
    {
        #region Fields
        // --- Shooting ---
        protected int _totalShots;
        protected int _hits;
        protected int _criticalHits;
        protected int _maxHitStreak;

        // --- Per target type ---
        protected int _hitsPrimitiveTank;
        protected int _hitsIntelligentTank;
        protected int _hitsCollectiveTank;

        // --- Timing ---
        protected float _averageReactionTime;
        protected float _sessionDuration;

        // --- Weapon actions ---
        protected int _reloadCount;
        protected int _failedReloads;

        #endregion

        #region Constructor

        public Stats(
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


