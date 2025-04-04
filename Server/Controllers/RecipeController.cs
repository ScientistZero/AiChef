﻿using AiChef.Server.Data;
using AiChef.Server.Services;
using AiChef.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AiChef.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
       private readonly IOpenAIAPI _openAIservice;

    public RecipeController(IOpenAIAPI openAIservice)
    {
        _openAIservice = openAIservice;
    }
    
        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {

            string mealtime = recipeParms.MealTime;
            List<string> ingredients = recipeParms.Ingredients.Where(x => !string.IsNullOrEmpty(x.Description))
                                                              .Select(x =>x.Description!)
                                                              .ToList();
            if (string.IsNullOrEmpty(mealtime))
            {
                mealtime = "Breakfast"; // Default to breakfast if no meal time is provided
            }
           var ideas = await _openAIservice.CreateRecipeIdeas(mealtime, ingredients);
            return ideas; // Return the list of recipe ideas generated by the OpenAI API
            //return SampleData.RecipeIdeas;
        }

        [HttpPost, Route("GetRecipe")]
        public async Task<ActionResult<Recipe>> GetRecipe(RecipeParms recipeParms)
        {
            //return SampleData.Recipe;

            List<string> ingredients = recipeParms.Ingredients
                                                  .Where(x => !string.IsNullOrEmpty(x.Description))
                                                  .Select(x => x.Description!)
                                                  .ToList();
            string? title = recipeParms.SelectedIdea;

            if (string.IsNullOrEmpty(title))
            {
                return BadRequest();
            }

            var recipe = await _openAIservice.CreateRecipe(title, ingredients);
            return recipe;
        }
        [HttpGet, Route("GetRecipeImage")]
        public async Task<RecipeImage> GetRecipeImage(string title)
        {
            
                //return SampleData.RecipeImage;

            var recipeImage = await _openAIservice.CreateRecipeImage(title);

            return recipeImage;
           

        }
    }
}
