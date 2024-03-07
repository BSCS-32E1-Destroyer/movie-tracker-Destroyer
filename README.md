# Movie-Tracker


User Stories for a Movie Tracker App in MVC
As a user, I want to...

#### 1. Search for movies:

I can search for movies by title, genre, or director.
The search results should display relevant movies with basic information like title, release year, and poster image.
I can filter the search results by release year or genre.
#### 2. View movie details:

When I click on a movie in the search results, I should be able to see its details, including:
Title
Release year
Genre
Director
Cast
Synopsis
Trailer link (optional)
User rating (optional)
Average rating from other users (optional)
#### 3. Add movies to my watchlist:

I can mark movies as "watched" or "to watch" by clicking on a button.
The app should store my watchlist preferences for future reference.
I should be able to easily access my watchlist to see movies I want to watch or have already seen.
#### 4. Rate movies (optional):

I can rate movies on a scale (e.g., 1-5 stars).
My rating should be stored for the movie and potentially averaged with other users' ratings to display an overall score.
#### 5. Share movie recommendations (optional):

I can share movie recommendations with other users through social media or email (using external sharing functionalities).
Separate Concerns:

1. Model:

Movie class: Stores movie information (title, release year, genre, director, cast, synopsis, trailer link, etc.).
WatchlistItem class (optional): Stores user's watchlist preference (movie and watched/to watch status).
UserRating class (optional): Stores user's rating for a specific movie.
2. Controller:

MovieController: Handles search requests, retrieves movie details, manages watchlist operations.
UserController (optional): Handles user authentication and profile management (if applicable).
3. View:

Search view: Displays search form and search results.
MovieDetails view: Displays detailed information about a specific movie.
Watchlist view: Displays the user's watchlist with added movies and their status.
_Layout view: Provides the overall website layout and navigation.
4. Data Access (Optional):

Implement a data access layer (e.g., using Entity Framework Core) to store and retrieve movie data, user watchlist, and ratings (if applicable) from a database.
5. Services (Optional):

Implement services for specific tasks like interacting with external APIs for movie search, user authentication, or sending email recommendations.
This is a basic set of user stories and separate concerns for the Movie Tracker app. You can extend or modify it based on your specific requirements and desired functionalities.
