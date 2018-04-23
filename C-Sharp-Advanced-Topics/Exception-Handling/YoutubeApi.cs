using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advanced_Topics.Exception_Handling
{
    //use a custom made exception
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access YouTube web service
                //Read the data
                //Create a list of Video objects
                throw new Exception("Ops, some low level YouTube error.");
            }
            catch (Exception e)
            {
                //Log
                Console.WriteLine(e);
                //Wrap low level exception from try block inside a more meaningful exception for user
                throw new YoutubeException("Could not fetch the videos from YouTube", e);
            }

            return new List<Video>();
        }
    }

    public class Video
    {
    }
}
