using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videoList;

        public VideoStore()
        {
            _videoList = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _videoList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            FindVideo(title).BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            FindVideo(title).BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            FindVideo(title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (Video film in _videoList)
            {
                Console.WriteLine(film.ToString());
            }
        }

        public Video FindVideo(string title)
        {
            foreach (var item in _videoList)
            {
                if (item.Title == title)
                {
                    return item;
                    break;
                }
            }

            return null;
        }
    }
}
