﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaloEstrella_Hamburguesas.Models;
using SQLite;

namespace GaloEstrella_Hamburguesas.Data
{
    public class GEBurgerrDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public GEBurgerrDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }
        public int AddNewBurger(Burger burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<Burger> GetAllBurgers()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }
    }
}
