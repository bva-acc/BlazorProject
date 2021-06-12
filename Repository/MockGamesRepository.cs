using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Repository
{
    public class MockGamesRepository : IRepository
    {
        List<Game> _games;
        public MockGamesRepository()
        {
            _games = new List<Game>()
            {
                new Game()
            {
                Name = "Adepts of Might and Magic",
                Genre = "Strategy",
                ReleaseDate = new DateTime(1999, 02, 23)
            },
            new Game()
            {
                Name = "FM-Simulator 2018",
                Genre = "Simulator",
                ReleaseDate = new DateTime(2017, 06, 29)
            },
            new Game()
            {
                Name = "The Wizard 3",
                Genre = "Action/RPG",
                ReleaseDate = new DateTime(2012, 10, 06)
            },
             new Game()
            {
                Name = "Catch the Frog",
                Genre = "Adventure",
                ReleaseDate = new DateTime(2019, 05, 16)
            }
            };
        }
        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
