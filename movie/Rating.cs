using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace movierating.Rating
{
    public class Rating : IRating
    {
        public List<Item> _Item;

        static void Main(string[] args)
        {

        }
        public void LoadJson()
        {
            using (var r = new StreamReader(@"C:\Users\Bjarne Helsinghof\Documents\GitHub\seriousSDMTitle\small.json"))
            {
                var json = r.ReadToEnd();
                _Item = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
        public class Item
        {
            public int Reviewer;
            public int Movie;
            public DateTime Date;
            public int Grade;
        }

        // task 1 
        public int GetNumberOfReviewsFromSelectUser(int userId)
        {
            var item = _Item.Where(user => user.Reviewer == userId).ToList();
            return item.Count;
        }
        // task 2
        public double GetAverageReviewRatingFromUser(int userId)
        {
            var person = _Item.Where(user => user.Reviewer == userId);
            var average = person.Average(user => user.Grade);
            return average;
        }
        //task 3
        public int GetRatingsFromUser(int userId, int rating)
        {
            var person = _Item.Count(user => user.Reviewer == userId && user.Grade == rating);
            return person;
        }
        //task 4
        public int GetNumberOfReviews(int movieId)
        {
            return _Item.Count(movie => movie.Movie == movieId);
        }
        //task 5
        public double GetAverageRatingOnMovie(int movieId)
        {
            var avMovieRating = _Item.Where(mo => mo.Movie == movieId);
            var avgmovie = avMovieRating.Average(mo => mo.Grade);
            return avgmovie;
        }
        //task 6
        public int GetRatingsFromMovie(int movieId, int rating)
        {
            return _Item.Count(rate => rate.Movie == movieId && rate.Grade == rating);
        }
        // task 7 
        public List<int> GetMoviesWithHighestRating()
        {
            throw new System.NotImplementedException();
        }
        //task 8
        public List<int> GetUserWithMostReviews()
        {
            throw new System.NotImplementedException();
        }
        //task 9
        public List<int> GetTopList(int numberOfItems)
        {
            throw new System.NotImplementedException();
        }
        //task 10
        public List<int> ReviewedMoviesBySingleUser(int userId)
        {
            throw new System.NotImplementedException();
        }
        // task 11
        public List<int> UsersReviewedMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }
    }
}