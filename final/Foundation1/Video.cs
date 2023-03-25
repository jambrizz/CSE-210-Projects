using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

public class Video
{
    public string _title;

    public string _description;

    public string _author;

    public int _hours;

    public int _minutes;

    public int _seconds;

    public int _length;

    public string _videoId;

    public Video(string title, string description, string author, int hours, int minutes, int seconds)
    {
        _title = title;
        _description = description;
        _author = author;
        _hours = hours;
        _minutes = minutes;
        _seconds = seconds;
        _hours = hours;
        _minutes = minutes;
        _seconds = seconds;
        _videoId = GetRandomLetterAndNumber();
    }

    public string GetVideoDetails()
    {
        return $"Title: {_title}, Description: {_description}, Author: {_author}, Length: {_length}, VideoId: {_videoId}";
    }

    public string GetVideoTitle(string title)
    {
        return _title;
    }

    public string GetVideoDescription(string description)
    {
        return _description;
    }

    public string GetVideoAuthor(string author)
    {
        return _author;
    }

    public int GetHoursInSeconds(int hours)
    {
        int newHours = hours * 3600;
        return newHours;
    }

    public int GetMinutesInSeconds(int minutes)
    {
        int newMinutes = minutes * 60;
        return newMinutes;
    }

    public int GetSeconds(int seconds)
    {
        int newSeconds = seconds;
        return newSeconds;
    }

    public int GetVideoLength(int hours, int minutes, int seconds)
    {
        _length = hours + minutes + seconds;
        return _length;
    }

    public string GetVideoId(string videoId)
    {
        return _videoId;
    }

    public void SetVideoTitle(string title)
    {
        _title = title;
    }

    public void SetVideoDescription(string description)
    {
        _description = description;
    }

    public void SetVideoAuthor(string author)
    {
        _author = author;
    }

    public void SetVideoLength(int length)
    {
        _length = length;
    }

    public void SetVideoId(string videoId)
    {
        _videoId = videoId;
    }

    public int RandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);
        return randomNumber;
    }

    public char RandomLetter()
    {
        Random random = new Random();
        char randomLetter = (char)random.Next('a', 'z');
        return randomLetter;
    }

    public string GetRandomLetterAndNumber()
    {
        string newId = "";
        for (int i = 0; i < 3; i++)
        {
            newId += RandomLetter();
            newId += RandomNumber();
        }
        return newId;
    }
}