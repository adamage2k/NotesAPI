﻿using Microsoft.EntityFrameworkCore;
using Notes.API.Models.Entites;

namespace Notes.API.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
