using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> comments = new List<string>();
        List<string> videos = new List<string>();
        List<string> savedvideos = new List<string>();
        
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
            Console.WriteLine("5. Save videos to file");
            Console.WriteLine("6. Load videos from file");
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
                    Console.WriteLine($"{videos[0]}");
                    
                }
                else if(featureSelection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have selected to add a comment. \n");
                }
                else if(featureSelection == 3)
                {
                    //TODO: I need to continue working on this. I need to figure out how to display the videos in the list. So the user can select which video they want to see the details for.
                    //TODO: Add functionality to be able to select between temporary and saved lists.
                    //TODO: Finish the first TODO so I can work on adding the comments to the videos. by selecting the video from the list.
                    Console.WriteLine($"");
                    Console.WriteLine("What list would you like to view?");
                    Console.WriteLine("1. Temporary Video List");
                    Console.WriteLine("2. Temporary Comment List");
                    Console.WriteLine("3. Saved Video List");
                    Console.Write("Please enter your selection: ");
                    string listSelection = Console.ReadLine();
                    bool validListSelection = int.TryParse(listSelection, out int selectionList);

                    if(validListSelection == false)
                    {
                        Console.WriteLine($"");
                        Console.WriteLine("Invalid selection. Please try again. \n");
                        Console.WriteLine();
                        Console.WriteLine("What list would you like to view?");
                        Console.WriteLine("1. Temporary Video List");
                        Console.WriteLine("2. Temporary Comment List");
                        Console.WriteLine("3. Saved Video List");
                        Console.Write("Please enter your selection: ");
                        listSelection = Console.ReadLine();
                    }
                    else
                    {
                        int listType = int.Parse(listSelection);                     
                        if(listType == 1)
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"You have selected to view the temporary video list. \n");
                            Console.WriteLine($"");
                            Console.WriteLine($"Here are the videos in the temporary video list: \n");
                            Console.WriteLine($"{videos[0]}");
                        }
                        else if(listType == 2)
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"You have selected to view the temporary comment list. \n");
                        }
                        else if(listType == 3)
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"You have selected to view the saved video list. \n");
                        }
                        else
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"You have selected an invalid option. Please try again. \n");
                        }
                    }
                }
                else if(featureSelection == 4)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to display video details. \n");
                }
                else if(featureSelection == 5)
                {
                    Console.WriteLine($"");
                    Console.WriteLine($"You have selected to save videos to file. \n");
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