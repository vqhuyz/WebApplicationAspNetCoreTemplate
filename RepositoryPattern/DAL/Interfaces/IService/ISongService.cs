﻿using RepositoryPattern.DAL.DataService;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.Interfaces.IService
{
    public interface ISongService
    {
        Task<List<SongDataService>> GetAll();
        Task<SongDataService> GetSongById(int id);
        Task AddSong(SongRequest dto);
        Task UpdateSong(Song song);
        Task DeleteSong(int id);
    }
}