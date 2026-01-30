namespace RenAI.Core.Expert
{
    public static class ScenarioBaseline
    {
        // Norm baseline
        public static ScenarioParameters ForDifficulty(DifficultyLevel d)
        {
            return d switch
            {
                DifficultyLevel.Low => new ScenarioParameters
                {
                    Targets = 1,
                    Fog = 0.2f,
                    Rain = 0.1f,
                    Wind = 0.2f,
                    TargetSpeed = 0.2f
                },
                DifficultyLevel.Medium => new ScenarioParameters
                {
                    Targets = 2,
                    Fog = 0.5f,
                    Rain = 0.4f,
                    Wind = 0.5f,
                    TargetSpeed = 0.5f
                },
                DifficultyLevel.High => new ScenarioParameters
                {
                    Targets = 3,
                    Fog = 0.8f,
                    Rain = 0.7f,
                    Wind = 0.8f,
                    TargetSpeed = 0.8f
                },
                _ => new ScenarioParameters { Targets = 1, Fog = 0.2f, Rain = 0.1f, Wind = 0.2f, TargetSpeed = 0.2f }
            };
        }
    }
}