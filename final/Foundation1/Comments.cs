using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

public class Comments
{
    public string _videoId;

    public string _user;

    public string _comment;

    public Comments(string videoId, string user, string comment)
    {
        _videoId = videoId;
        _user = user;
        _comment = comment;
    }

    public Comments()
    {

    }

     public string GetCommentDetails()
     {
        return $"VideoId: {_videoId}, User: {_user}, Comment: {_comment}";
     }

    public string GetVideoId(string videoId)
    {
        return _videoId;
    }

    public string ExtractVideoId(List<string> list, int number)
    {
        string newLine = list[number - 1];
        string [] exposeVideoId = {"VideoId:", " "};

        int positionOfVideoId = newLine.IndexOf(exposeVideoId[0]);
        string videoId = newLine.Substring(positionOfVideoId);

        foreach (string item in exposeVideoId)
        {
            videoId = videoId.Replace(item, "");
        }

        return videoId;
    }

    public string newComment(string videoId, string user, string comment)
    {
        string newComment = $"VideoId: {videoId}, User: {user}, Comment: {comment}";
        return newComment;
    }
}
    