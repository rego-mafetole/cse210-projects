using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Morning prayer: What are you grateful for this morning? What hopes do you have for the day?",
        "Physical activity: How did you move your body today? How did that make you feel mentally and physically?",
        "Self care: How did you stay hydrated today? How did that affect your day?",
        "Emotional Reflection: What emotions did you experience today? How did those emotions influence your day?",
        "Evening routine: How did you spend your evening? What moment brought you peace or enjoyment?"
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        int index = rand.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public List<string> GetAllPrompts(int count)
    {
        return _prompts.OrderBy(x => rand.Next()).Take(count).ToList();
    }
}