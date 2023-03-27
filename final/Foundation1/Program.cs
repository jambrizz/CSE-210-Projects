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
            Console.WriteLine("3. Display file");
            Console.WriteLine("4. Display selected video details");
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
                    if (comments.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"You dont have any videos to comment on. Please add a video or load a file to use this feature. \n");
                        Console.WriteLine();
                    }
                    else
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
                                Console.WriteLine($"There are no videos in the video list. Please load a file or add some videos. \n");
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
                                Console.WriteLine($"There are no comments in the comment list. Please load a file or add some comments. \n");
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
                // Save to file
                else if(featureSelection == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("File save");
                    Console.WriteLine();
                    Console.WriteLine("Please select the option you would like to save.");
                    Console.WriteLine("1. Video List");
                    Console.WriteLine("2. Comment List");
                    Console.WriteLine("3. Video and Comment List");
                    Console.Write("Please enter your selection: ");
                    string fileSelection = Console.ReadLine();
                    bool validFileSelection = int.TryParse(fileSelection, out int selectionFile);

                    if (validFileSelection == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("File save");
                        Console.WriteLine();
                        Console.WriteLine("Please select the option you would like to save.");
                        Console.WriteLine("1. Video List");
                        Console.WriteLine("2. Comment List");
                        Console.WriteLine("3. Video and Comment List");
                        Console.Write("Please enter your selection: ");
                        fileSelection = Console.ReadLine();
                        validFileSelection = int.TryParse(fileSelection, out selectionFile);
                    }

                    if(selectionFile == 1)
                    {
                        Console.WriteLine();
                        Console.Write("What would you like to name the file? ");
                        string fileName = Console.ReadLine();
                        File file = new File();
                        file.SaveFile(fileName, videos);
                        Console.WriteLine();
                        Console.WriteLine($"You have created a video file called {fileName}. \n");
                        videos.Clear();
                    }
                    else if(selectionFile == 2)
                    {
                        Console.WriteLine();
                        Console.Write("What would you like to name the file? ");
                        string fileName = Console.ReadLine();
                        File file = new File();
                        file.SaveFile(fileName, comments);
                        Console.WriteLine();
                        Console.WriteLine($"You have created a comment file called {fileName}. \n");
                        comments.Clear();
                    }
                    else if(selectionFile == 3)
                    {
                        Console.WriteLine();
                        Console.Write("What would you like to name your video file:  "); 
                        string videoFileName = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What would you like to name your comment file:  ");
                        string commentFileName = Console.ReadLine();
                        File file = new File();
                        file.SaveTwoFiles(videoFileName, commentFileName, videos, comments);
                        videos.Clear();
                        comments.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"");
                        Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                    }
                }
                else if(featureSelection == 6)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Load file.");
                    Console.WriteLine("Select the load feature you would like to use.");
                    Console.WriteLine("1. Load Video List");
                    Console.WriteLine("2. Load Comment List");
                    Console.WriteLine("3. Load Video and Comment List");
                    Console.Write("Please enter your selection: ");
                    string loadSelection = Console.ReadLine();
                    bool validLoadSelection = int.TryParse(loadSelection, out int selectionLoad);

                    if (validLoadSelection == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Load file.");
                        Console.WriteLine("Select the load feature you would like to use.");
                        Console.WriteLine("1. Load Video List");
                        Console.WriteLine("2. Load Comment List");
                        Console.WriteLine("3. Load Video and Comment List");
                        Console.Write("Please enter your selection: ");
                        loadSelection = Console.ReadLine();
                        validLoadSelection = int.TryParse(loadSelection, out selectionLoad);
                    }

                    if(selectionLoad == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Load Video File");
                        Console.Write("What is the name of the file you would like to load, don't forget to add the .txt at the end? ");
                        string fileName = Console.ReadLine();
                        File file = new File();
                        file.LoadFile(fileName, videos);
                    }
                    else if(selectionLoad == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Load Comment File");
                        Console.Write("What is the name of the file you would like to load, don't forget to add the .txt at the end? ");
                        string fileName = Console.ReadLine();
                        File file = new File();
                        file.LoadFile(fileName, comments);
                    }
                    else if(selectionLoad == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Load Video and Comment Files");
                        Console.Write("What is the name of the video file you would like to load, don't forget to add the .txt at the end: ");
                        string videoFileName = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("What is the name of the comment file you would like to load, don't forget to add the .txt at the end: ");
                        string commentFileName = Console.ReadLine();
                        File file = new File();
                        file.LoadTwoFiles(videoFileName, commentFileName, videos, comments);
                    }
                    else
                    {
                        Console.WriteLine($"");
                        Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                    }
                }
                else if(featureSelection == 7)
                {
                    if (videos.Count > 0 && comments.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have items for both your video and comment files that are unsaved, Do you wish to exit without saving your progress? (Y/N)");
                        string exitSelection = Console.ReadLine();

                        if(exitSelection == "y" || exitSelection == "Y")
                        {
                            Console.WriteLine("Thank you for using the YouTube product placement program. See you next time. \n");
                            programRun = false;
                        }
                        else if (exitSelection == "n" || exitSelection == "N")
                        {
                            Console.WriteLine("Youtube Product Tracking Program is still running. \n");
                        }
                        else
                        {
                            Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                        }
                    }
                    else if(comments.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have items in your comment file that are unsaved, Do you wish to exit without saving your progress? (Y/N)");
                        string exitSelection = Console.ReadLine();

                        if(exitSelection == "y" || exitSelection == "Y")
                        {
                            Console.WriteLine("Thank you for using the YouTube product placement program. See you next time. \n");
                            programRun = false;
                        }
                        else if (exitSelection == "n" || exitSelection == "N")
                        {
                            Console.WriteLine("Youtube Product Tracking Program is still running. \n");
                        }
                        else
                        {
                            Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                        }
                    }
                    else if(videos.Count > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have items in your video file that are unsaved, Do you wish to exit without saving your progress? (Y/N)");
                        string exitSelection = Console.ReadLine();

                        if(exitSelection == "y" || exitSelection == "Y")
                        {
                            Console.WriteLine("Thank you for using the YouTube product placement program. See you next time. \n");
                            programRun = false;
                        }
                        else if (exitSelection == "n" || exitSelection == "N")
                        {
                            Console.WriteLine("Youtube Product Tracking Program is still running. \n");
                        }
                        else
                        {
                            Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using the YouTube product placement program. See you next time. \n");
                        programRun = false;
                    }
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