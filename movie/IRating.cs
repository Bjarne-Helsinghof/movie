using System.Collections.Generic;

namespace movierating.Rating
{
    public interface IRating
    {
        int GetNumberOfReviewsFromSelectUser(int userId);
        double GetAverageReviewRatingFromUser(int userId);
        int GetRatingsFromUser(int userId, int rating);
        int GetNumberOfReviews(int movieId);
        double GetAverageRatingOnMovie(int movieId);
        int GetRatingsFromMovie(int movieId, int rating);
        List<int> GetMoviesWithHighestRating();
        List<int> GetUserWithMostReviews();
        List<int> GetTopList(int numberOfItems);
        List<int> ReviewedMoviesBySingleUser(int userId);
        List<int> UsersReviewedMovie(int movieId);

    }
}