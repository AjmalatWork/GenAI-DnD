using System.Collections.Generic;
using System;

[Serializable]
public class SafetyRating
{
    public string category;
    public string probability;
}

[Serializable]
public class Part
{
    public string text;
}

[Serializable]
public class Content
{
    public List<Part> parts;
    public string role;
}

[Serializable]
public class Candidate
{
    public Content content;
    public string finishReason;
    public int index;
    public List<SafetyRating> safetyRatings;
}

[Serializable]
public class UsageMetadata
{
    public int promptTokenCount;
    public int candidatesTokenCount;
    public int totalTokenCount;
}

[Serializable]
public class Root
{
    public List<Candidate> candidates;
    public UsageMetadata usageMetadata;
}