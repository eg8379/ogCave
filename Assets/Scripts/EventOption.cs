
class EventOption
{
    private string text;

    private float[] resourceEffects;

    /// <summary>
    /// Creates an event option
    /// </summary>
    /// <param name="text">the option text</param>
    /// <param name="resourceEffects">the option resource effects</param>
    public EventOption(string text, float[] resourceEffects)
    {
        this.text = text;
        this.resourceEffects = resourceEffects;
    }

}
