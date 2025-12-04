using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenAI.AI.FunzzyLogic;

public class testFuzzy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FuzzyVariable temperature = new FuzzyVariable("Temperature", 0, 50);
        temperature.AddSet(new TriangleFuzzySet("High", 0, 0, 5));
        temperature.AddSet(new TriangleFuzzySet("Low", 0, 0, 0));

        FuzzyVariable humidity = new FuzzyVariable("Humidity", 0, 50);
        humidity.AddSet(new TriangleFuzzySet("High", 0, 0, 5));
        humidity.AddSet(new TriangleFuzzySet("Low", 0, 0, 0));

        FuzzyRule rule1 = new FuzzyRule(
            temperature.Is("High").And(humidity.Is("High")),
            temperature.Is("Low")
            );

        var inputs = new Dictionary<FuzzyVariable, double>
        {
            [temperature] = 10,
            [humidity] = 20
        };
        rule1.Evaluate(inputs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
