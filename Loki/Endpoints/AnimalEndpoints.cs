using Loki.Core;
using Loki.Entities;
using Loki.Models;
using Loki.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Loki.Endpoints
{
    public class AnimalEndpoints : IEndpointDefinition
    {
        public void MapEndpoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/animals", GetAnimalsView);
            app.MapGet("/animals/{id}", GetAnimalDetails);
        }

        /// <summary>
        /// Reads animal data from csv file and converts it 
        /// to a list of animal entities
        /// </summary>
        /// <returns>List of animal entities with column headers</returns>
        private static async Task<AnimalsView> GetAnimalsView(IAnimalService service)
        {
            var animalsView = await service.GetAnimalsView();

            return animalsView;
        }

        /// <summary>
        /// Reads animal data from csv file and converts it 
        /// to a list of animal entities
        /// </summary>
        /// <returns>List of animal entities with column headers</returns>
        private static async Task<AnimalEntity> GetAnimalDetails(IAnimalService service, int id)
        {
            var animal = await service.GetAnimalDetails(id);

            return animal;
        }
    }
}


