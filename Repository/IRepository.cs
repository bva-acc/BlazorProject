using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Repository
{
    public interface IRepository
    {
        List<Game> GetAllGames();
    }
}
