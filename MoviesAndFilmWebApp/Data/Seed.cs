using MoviesAndFilmWebApp.Models;

namespace MoviesAndFilmWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "The Departed",
                            Stars = "Leonardo Dicaprio, Matt Damon, Jack Nicholson",
                            Director = "Martin Scorsese",
                            Writer = "William Monahan",
                            Genre = "Crime, Drama, Thriller",
                            UserRating = 9.5,
                            Plot = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                            MPAARating = "R",
                            RunTime= "2h 31m",
                            ReleaseYear = "2006"
                         },

                        new Movie()
                        {
                            Title = "There Will Be Blood",
                            Stars = "Daniel Day-Lewis, Paul Dano, Ciaran Hinds",
                            Director = "Paul Thomas Anderson",
                            Writer = "Paul Thomas Anderson",
                            Genre = "Drama",
                            UserRating = 9.6,
                            Plot = "A story of family, religion, hatred, oil and madness, focusing on a turn-of-the-century prospector in the early days of the business.",
                            MPAARating = "R",
                            RunTime= "2h 38m",
                            ReleaseYear = "2007"
                         },

                        new Movie()
                        {
                            Title = "Magnolia",
                            Stars = "Tom Cruise, Jason Robards, Julianne Moore",
                            Director = "Paul Thomas Anderson",
                            Writer = "Paul Thomas Anderson",
                            Genre = "Drama",
                            UserRating = 9.6,
                            Plot = "An epic mosaic of interrelated characters in search of love, forgiveness and meaning in the San Fernando Valley.",
                            MPAARating = "R",
                            RunTime= "3h 8m",
                            ReleaseYear = "1999"
                         },

                        new Movie()
                        {
                            Title = "Blade Runner",
                            Stars = "Harrison Ford, Rutger Hauer, Sean Young",
                            Director = "Ridley Scott",
                            Writer = "Hampton Fancher, David Webb Peoples",
                            Genre = "Action, Drama, Sci-Fi",
                            UserRating = 9.3,
                            Plot = "A blade runner must pursue and terminate four replicants who stole a ship in space and have returned to Earth to find their creator.",
                            MPAARating = "R",
                            RunTime= "1h 57m",
                            ReleaseYear = "1982"
                         },

                        new Movie()
                        {
                            Title = "Spotlight",
                            Stars = "Mark Ruffalo, Michael Keaton, Rachel McAdams",
                            Director = "Tom McCarthy",
                            Writer = "Josh Singer, Tom McCarthy",
                            Genre = "Biography, Crime, Drama",
                            UserRating = 9.6,
                            Plot = "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.",
                            MPAARating = "R",
                            RunTime= "2h 9m",
                            ReleaseYear = "2015"
                         },

                        new Movie()
                        {
                            Title = "The Apartment",
                            Stars = "Jack Lemmon, Shirley MacLaine, Fred MacMurray",
                            Director = "Billy Wilder",
                            Writer = "Billy Wilder, I.A.L. Diamond",
                            Genre = "Comedy, Drama, Romance",
                            UserRating = 8.6,
                            Plot = "A Manhattan insurance clerk tries to rise in his company by letting its executives use his apartment for trysts, but complications and a romance of his own ensue.",
                            MPAARating = "NR",
                            RunTime= "2h 5m",
                            ReleaseYear = "1960"
                         },

                        new Movie()
                        {
                            Title = "Heat",
                            Stars = "Al Pacino, Robert De Niro, Val Kilmer",
                            Director = "Michael Mann",
                            Writer = "Michael Mann",
                            Genre = "Action, Crime, Drama",
                            UserRating = 10.0,
                            Plot = "A group of high-end professional thieves start to feel the heat from the LAPD when they unknowingly leave a clue at their latest heist.",
                            MPAARating = "R",
                            RunTime= "2h 50m",
                            ReleaseYear = "1995"
                         },

                        new Movie()
                        {
                            Title = "Before Sunset",
                            Stars = "Ethan Hawke, Julie Delphy",
                            Director = "Richard Linklater",
                            Writer = "Richard Linklater, Julie Delpy, Ethan Hawke",
                            Genre = "Drama, Romance",
                            UserRating = 9.7,
                            Plot = "Nine years after Jesse and Celine first met, they encounter each other again on the French leg of Jesse's book tour.",
                            MPAARating = "R",
                            RunTime= "1h 20m",
                            ReleaseYear = "2004"
                         },

                        new Movie()
                        {
                            Title = "Gigli",
                            Stars = "Ben Affleck, Jennifer Lopez",
                            Director = "Martin Breast",
                            Writer = "Martin Breast",
                            Genre = "Comedy, Crime, Romance",
                            UserRating = 2.6,
                            Plot = "Larry Gigli is assigned by a crime boss to kidnap the brother of a prominent district attorney. A beautiful woman known only as Ricki is sent to stay with him to make sure he doesn't mess up the job.",
                            MPAARating = "R",
                            RunTime= "2h 1m",
                            ReleaseYear = "2003"
                         },

                        new Movie()
                        {
                            Title = "Brave",
                            Stars = "Kelly Macdonald, Billy Connolly, Emma Thompson",
                            Director = "Mark Andrews, Brenda Chapman, Steve Purcell",
                            Writer = "Brenda Chapman, Mark Andrews, Steve Purcell",
                            Genre = "Animation, Adventure, Comedy",
                            UserRating = 7.1,
                            Plot = "Determined to make her own path in life, Princess Merida defies a custom that brings chaos to her kingdom. Granted one wish, Merida must rely on her bravery and her archery skills to undo a beastly curse.",
                            MPAARating = "PG",
                            RunTime= "1h 33m",
                            ReleaseYear = "2012"
                         },

                        new Movie()
                        {
                            Title = "Jacob's Ladder",
                            Stars = "Tim Robbins, Elizabeth Pena, Danny Aiello",
                            Director = "Adrian Lyne",
                            Writer = "Bruce Joel Rubin",
                            Genre = "Drama, Horror, Mystery",
                            UserRating = 7.4,
                            Plot = "Mourning his dead child, a haunted Vietnam War veteran attempts to uncover his past while suffering from a severe case of dissociation. To do so, he must decipher reality and life from his own dreams, delusions, and perceptions of death.",
                            MPAARating = "R",
                            RunTime= "1h 53m",
                            ReleaseYear = "1990"
                         },

                        new Movie()
                        {
                            Title = "Jaws",
                            Stars = "Roy Scheider, Robert Shaw, Richard Dreyfuss",
                            Director = "Steven Spielberg",
                            Writer = "Peter Benchley",
                            Genre = "Adventure, Thriller",
                            UserRating = 9.0,
                            Plot = "When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.",
                            MPAARating = "PG",
                            RunTime= "2h 4m",
                            ReleaseYear = "1975"
                         },

                        new Movie()
                        {
                            Title = "No Country for Old Men",
                            Stars = "Tommy Lee Jones, Javier Bardem, Josh Brolin",
                            Director = "Joel Coen, Ethan Coen",
                            Writer = "Joel Coen, Ethan Coen",
                            Genre = "Crime, Drama, Thriller",
                            UserRating = 9.4,
                            Plot = "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",
                            MPAARating = "R",
                            RunTime= "1h 2m",
                            ReleaseYear = "2007"
                         },

                        new Movie()
                        {
                            Title = "Ghost Dog: The Way of the Samurai",
                            Stars = "Forest Whitaker, Henry Silva, John Tormey",
                            Director = "Jim Jarmusch",
                            Writer = "Jim Jarmusch",
                            Genre = "Crime, Drama",
                            UserRating = 7.5,
                            Plot = "An African-American Mafia hit man who models himself after the samurai of old finds himself targeted for death by the mob",
                            MPAARating = "R",
                            RunTime= "1h 56m",
                            ReleaseYear = "1999"
                         },

                        new Movie()
                        {
                            Title = "Atonement",
                            Stars = "Keira Knightley, James McAvoy, Brenda Blethyn",
                            Director = "Joe Wright",
                            Writer = "Christopher Hampton",
                            Genre = "Drama, Mystery, Romance",
                            UserRating = 8.5,
                            Plot = "Thirteen-year-old fledgling writer Briony Tallis irrevocably changes the course of several lives when she accuses her older sister's lover of a crime he did not commit.",
                            MPAARating = "R",
                            RunTime= "2h 3m",
                            ReleaseYear = "2007"
                         },

                        new Movie()
                        {
                            Title = "Crank: High Voltage",
                            Stars = "Jason Statham, Amy Smart, Clifton Collins Jr",
                            Director = "Mark Neveldine, Brian Taylor",
                            Writer = "Mark Neveldine, Brian Taylor",
                            Genre = "Action, Crime, Thriller",
                            UserRating = 7.0,
                            Plot = "Chelios faces a Chinese mobster who has stolen his nearly indestructible heart and replaced it with a battery-powered ticker which requires regular jolts of electricity to keep working.",
                            MPAARating = "R",
                            RunTime= "1h 35m",
                            ReleaseYear = "2009"
                         },

                        new Movie()
                        {
                            Title = "The Thing",
                            Stars = "Kurt Russell, Wilford Brimley, Keith David",
                            Director = "John Carpenter",
                            Writer = "Bill Lancaster",
                            Genre = "Horror, Mystery, Sci-Fi",
                            UserRating = 8.9,
                            Plot = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.",
                            MPAARating = "R",
                            RunTime= "1h 49m",
                            ReleaseYear = "1982"
                         },

                        new Movie()
                        {
                            Title = "Do The Right Thing",
                            Stars = "Danny Aiello, Ossie Davis, Ruby Dee",
                            Director = "Spike Lee",
                            Writer = "Spike Lee",
                            Genre = "Comedy, Drama",
                            UserRating = 8.5,
                            Plot = "On the hottest day of the year on a street in the Bedford-Stuyvesant section of Brooklyn, everyone's hate and bigotry smolders and builds until it explodes into violence.",
                            MPAARating = "R",
                            RunTime= "2h",
                            ReleaseYear = "1989"
                         },

                        new Movie()
                        {
                            Title = "Surf Ninjas",
                            Stars = "Ernie Reyes Sr, Rob Schneider, Ernie Reyes Jr",
                            Director = "Neal Israel",
                            Writer = "Dan Gordon",
                            Genre = "Action, Adventure, Comedy",
                            UserRating = 5.0,
                            Plot = "Two boys learn from a mysterious warrior that they are the heirs to the throne of Patusan and set out to overthrow the current monarchy.",
                            MPAARating = "PG",
                            RunTime= "1h 27m",
                            ReleaseYear = "1993"
                         },

                        new Movie()
                        {
                            Title = "Goodfellas",
                            Stars = "Robert De Niro, Ray Liotta, Joe Pesci",
                            Director = "Martin Scorsese",
                            Writer = "Martin Scorsese",
                            Genre = "Biography, Crime, Drama",
                            UserRating = 9.6,
                            Plot = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                            MPAARating = "R",
                            RunTime= "2h 25m",
                            ReleaseYear = "1990"
                         },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
