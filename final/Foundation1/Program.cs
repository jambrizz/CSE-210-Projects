using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> comments = new List<string>();
        List<string> videos = new List<string>();
        //List<string> savedvideos = new List<string>();
        //List<string> savedcomments = new List<string>();
        
        bool programRun = true;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Youtube Product Tracking");
            Console.WriteLine("Welcome to the Youtube Product Tracking Program");
            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("1. Add a video");
            Console.WriteLine("2. Add a comment");
            Console.WriteLine("3. Display all videos");
            Console.WriteLine("4. Display video details");
            Console.WriteLine("5. Save file");
            Console.WriteLine("6. Load from file");
            Console.WriteLine("7. Exit program");
            Console.Write("Please enter your selection:");
            string userSelection = Console.ReadLine();
            bool validSelection = int.TryParse(userSelection, out int selection);

            if(validSelection == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid selection. Please try again. \n");
            }
            else
            {
                int featureSelection = int.Parse(userSelection);
                // Add a video
                if(featureSelection == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected to add a video. \n");
                    Console.Write("Please enter the video title: ");
                    string videoTitle = Console.ReadLine();
                    Console.Write("Please enter a brief video description: ");
                    string videoDescription = Console.ReadLine();
                    Console.Write("Please enter the video author: ");
                    string videoAuthor = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Next we will add the video length in hours, minutes and seconds. \n");
                    Console.Write("Please enter the video length in hours: ");
                    string videoLengthHours = Console.ReadLine();
                    Console.Write("Please enter the video length in minutes: ");
                    string videoLengthMinutes = Console.ReadLine();
                    Console.Write("Please enter the video length in seconds: ");
                    string videoLengthSeconds = Console.ReadLine();

                    bool validHours = int.TryParse(videoLengthHours, out int hours);
                    if (validHours == false)
                    {
                        Console.WriteLine("Invalid hours. Please try again. \n");
                        Console.Write("Please enter the video length in hours: ");
                        videoLengthHours = Console.ReadLine();
                    }

                    bool validMinutes = int.TryParse(videoLengthMinutes, out int minutes);
                    if (validMinutes == false)
                    {
                        Console.WriteLine("Invalid minutes. Please try again. \n");
                        Console.Write("Please enter the video length in minutes: ");
                        videoLengthMinutes = Console.ReadLine();
                    }

                    bool validSeconds = int.TryParse(videoLengthSeconds, out int seconds);
                    if (validSeconds == false)
                    {
                        Console.WriteLine("Invalid seconds. Please try again. \n");
                        Console.Write("Please enter the video length in seconds: ");
                        videoLengthSeconds = Console.ReadLine();
                    }

                    hours = int.Parse(videoLengthHours);
                    minutes = int.Parse(videoLengthMinutes);
                    seconds = int.Parse(videoLengthSeconds);

                    Video video = new Video(videoTitle, videoDescription, videoAuthor, hours, minutes, seconds);
                    int hoursConverted = video.GetHoursInSeconds(hours);
                    int minutesConverted = video.GetMinutesInSeconds(minutes);
                    int secondsConverted = video.GetSeconds(seconds);
                    int videoLength = video.GetVideoLength(hoursConverted, minutesConverted, secondsConverted);
                    //Console.WriteLine(videoLength);
                    string videoEntry = video.GetVideoDetails();
                    videos.Add(videoEntry);
                    Console.WriteLine();
                    Console.WriteLine(videoEntry);
                    Console.WriteLine("Video added successfully. \n");
                    
                }
                //Add a Comment
                else if(featureSelection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Please select the video you want to add a comment for. \n");
                    File file = new File();
                    file.DisplayListContents(videos);
                    Console.WriteLine();
                    Console.Write("Please enter your selection: ");
                    string videoSelection = Console.ReadLine();
                    bool validVideoSelection = int.TryParse(videoSelection, out int selectionVideo);

                    if(validVideoSelection == false || selectionVideo > videos.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid selection. Please try again. \n");
                        Console.WriteLine();
                        Console.WriteLine($"Please select the video you want to add a comment for. \n");
                        file.DisplayListContents(videos);
                        Console.WriteLine();
                        Console.Write("Please enter your selection: ");
                        videoSelection = Console.ReadLine();
                    }

                    int videoSelectionInt = int.Parse(videoSelection); 
                    
                    Comments comment = new Comments();
                    string videoId = comment.ExtractVideoId(videos, videoSelectionInt);

                    Console.WriteLine();
                    Console.WriteLine("Please enter the username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Please enter the comment: ");
                    string commentText = Console.ReadLine();

                    string commentEntry = comment.newComment(videoId, username, commentText);
                    comments.Add(commentEntry);

                }
                // Display all videos
                else if(featureSelection == 3)
                {
                    //TODO: Code the rest of the menu options
                    Console.WriteLine($"");
                    Console.WriteLine("What list would you like to view?");
                    Console.WriteLine("1. Video List");
                    Console.WriteLine("2. Comment List");
                    Console.Write("Please enter your selection: ");
                    string listSelection = Console.ReadLine();
                    bool validListSelection = int.TryParse(listSelection, out int selectionList);

                    if(validListSelection == false)
                    {
                        Console.WriteLine($"");
                        Console.WriteLine("Invalid selection. Please try again. \n");
                        Console.WriteLine();
                        Console.WriteLine("What list would you like to view?");
                        Console.WriteLine("1. Video List");
                        Console.WriteLine("2. Comment List");
                        Console.Write("Please enter your selection: ");
                        listSelection = Console.ReadLine();
                    }
                    
                    int listType = int.Parse(listSelection);                     
                        if(listType == 1)
                        {
                            if (videos.Count == 0)
                            {
                                Console.WriteLine($"");
                                Console.WriteLine($"You have selected to view the video list. \n");
                                Console.WriteLine($"There are no videos in the video list. \n");
                            }
                            else
                            {
                                File file = new File();
                                file.DisplayListContents(videos);
                            }
                        }
                        else if(listType == 2)
                        {
                            if (comments.Count == 0)
                            {
                                Console.WriteLine($"");
                                Console.WriteLine($"You have selected to view the comment list. \n");
                                Console.WriteLine($"There are no comments in the comment list. \n");
                            }
                            else
                            {
                                File file = new File();
                                file.DisplayListContents(comments);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                        }
                }
                // Display video details
                else if(featureSelection == 4)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"Please select a video from below to see the  \n");
                    File file = new File();
                    file.DisplayListContents(videos);
                    Console.WriteLine();
                    Console.Write("Please enter the number of your selection: ");
                    string videoSelection = Console.ReadLine();
                    bool validVideoSelection = int.TryParse(videoSelection, out int selectionVideo);

                    if (validVideoSelection == false || selectionVideo > videos.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid selection. Please try again. \n");
                        Console.WriteLine();
                        Console.WriteLine($"Please select a video from below to see the  \n");
                        file.DisplayListContents(videos);
                        Console.WriteLine();
                        Console.Write("Please enter the number of your selection: ");
                        videoSelection = Console.ReadLine();
                        bool validVideoSelection2 = int.TryParse(videoSelection, out int selectionVideo2);

                    }

                    int videoSelectionInt = int.Parse(videoSelection);
                    Comments comment = new Comments();
                    string videoId = comment.ExtractVideoId(videos, videoSelectionInt);

                    file.DisplaySelectedVideoComments(comments, videoId);

                }
                //////////////////////////////
                //TODO: Add the rest of the menu options
                /////////////////////////////
                else if(featureSelection == 5)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to save videos to a file. \n");
                }
                else if(featureSelection == 6)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to load videos from file. \n");
                }
                else if(featureSelection == 7)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"Thank you for using the Youtube Product Tracking App. See you next time. \n");
                    programRun = false;
                }
                else
                {
                    Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                }
                
            }
        }
        while (programRun == true);
    }
}