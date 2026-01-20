namespace RenAI.Core
{
    /// <summary>
    /// Statistics collected during a single training session.
    /// </summary>
    public sealed class SessionStats : Stats
    {
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
            ) : base(
                totalShots, 
                hits, 
                criticalHits, 
                maxHitStreak, 
                hitsPrimitiveTank, 
                hitsIntelligentTank, 
                hitsCollectiveTank, 
                averageReactionTime, 
                sessionDuration, 
                reloadCount, 
                failedReloads
                )
        {
        }
    }
}