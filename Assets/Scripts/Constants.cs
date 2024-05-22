using UnityEngine;

public static class Constants
{
    public static string apiURL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=";
    public static string apiKey = "Your API Key here";    
    public static string jsonFormat = "{\"prompt\": { \"text\": \"{prompt}\"}}";    
    public static string startPrompt = "Consider that you are a dungeon master of a D&D game. And your job is to make the player feel that he is part of a story and his actions matter. Remember what his choices were and continue the story in that way forward. Your job is to give appropriate next steps to his actions that feel like a cohesive story moving forward. Keep the texts in between player inputs not more than 3 sentences so that the player does not have to read a lot. The last line of each prompt should be an explicit action that you ask from the user. Do not use single or double quotes or any type of bracket in your response. Your starting prompt is - I am the Voice. I will accompany you on each step of your journey.What do i call you, O brave adventurer? that you already asked and the user responded - ";
    public static string recallPrompt = "Do not use single or double quotes or any type of bracket in your response. You are acting as DnD dungeon master for the player. Your job is to make the player feel that he is part of a story and his actions matter. Remember what his choices were and continue the story in that way forward. Your job is to give appropriate next steps to his actions that feel like a cohesive story moving forward. Keep the texts in between player inputs not more than 5 sentences so that the player does not have to read a lot. The last line of each prompt should be an explicit action that you ask from the user. Conversation history - ";
    public static string Black = "#000000";
    public static string White = "#FFFFFF";
    public static string Red = "#FF0000";
    public static string Lime = "#00FF00";
    public static string Blue = "#0000FF";
    public static string Yellow = "#FFFF00";
    public static string Cyan = "#00FFFF";
    public static string Magenta = "#FF00FF";
    public static string Silver = "#C0C0C0";
    public static string Gray = "#808080";
    public static string Maroon = "#800000";
    public static string Olive = "#808000";
    public static string Green = "#008000";
    public static string Purple = "#800080";
    public static string Teal = "#008080";
    public static string Navy = "#000080";
    public static string Orange = "#FFA500";
    public static string Gold = "#FFD700";
    public static string Pink = "#FFC0CB";
    public static string LightBlue = "#ADD8E6";
    public static string Brown = "#A52A2A";
    public static string Beige = "#F5F5DC";
    public static string LightGray = "#D3D3D3";
    public static string DarkGray = "#A9A9A9";
    public static string SkyBlue = "#87CEEB";
    public static string Violet = "#EE82EE";
    public static string Indigo = "#4B0082";
    public static string Coral = "#FF7F50";
    public static string Turquoise = "#40E0D0";
    public static string Salmon = "#FA8072";
    public static string Khaki = "#F0E68C";
    public static string Lavender = "#E6E6FA";
}