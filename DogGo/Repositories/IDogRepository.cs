﻿using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {

        List<Dog> GetDogsByOwnerId(int ownerId);

        List<Dog> GetAllDogs();


    }
}
