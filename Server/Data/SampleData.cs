﻿using AiChef.Shared;

  using global::AiChef.Shared;
namespace AiChef.Server.Data;
public static class SampleData
{
    public static List<Idea> RecipeIdeas = new()
        {
            new Idea
            {
                index = 0,
                title = "Chocolate Chip Cookies",
                description = "Delicious chocolate chip cookies made with browned butter"
            },
            new Idea
            {
                index = 1,
                title = "Peanut Butter Cookies",
                description = "Cookies made with peanut butter and butterscotch chips. Yum!"
            },
            new Idea {
                index = 2,
                title = "Snickerdoodles",
                description = "Classic snickerdoodle cookies. The secret ingredient is cream of tartar!"
            },
            new Idea {
                index = 2,
                title = "Sugar Cookies",
                description = "A sugar cookie is a cookie with the main ingredients being sugar, flour, butter, eggs, vanilla, and either baking powder or baking soda."
            },
            new Idea {
                index = 2,
                title = "Ginger Snaps",
                description = "Ginger snaps are a classic favorite. With just a few ingredients and even fewer steps this recipe for fabulous, spicy cookies is truly a snap to make."
            },
        };

    public static Recipe Recipe = new()
    {
        title = "Ginger Snaps",
        summary = "Ginger snaps are a classic favorite. With just a few ingredients and even fewer steps this recipe for fabulous, spicy cookies is truly a snap to make.",
        ingredients = new[]
      {
                "1 cup packed brown sugar",
                "3/4 cup vegetable oil",
                "1/4 cup molasses",
                "1 large egg",
                "2 cups all-purpose flour",
                "2 teaspoons baking soda",
                "1 teaspoon ground ginger",
                "1 teaspoon ground cinnamon",
                "3/4 teaspoon ground cloves",
                "1/4 teaspoon salt",
            },
        instructions = new[]
      {
                "Preheat the oven to 375 degrees F (190 degrees C).",
                "Mix together brown sugar, oil, molasses, and egg in a large bowl.",
                "Combine flour, baking soda, ginger, cinnamon, cloves, and salt; stir into the molasses mixture.",
                "Roll dough into 1 1/4-inch balls. Roll each ball in white sugar before placing 2 inches apart on ungreased cookie sheets.",
                "Bake for 10 to 12 minutes in the preheated oven, or until center is firm. Cool on wire racks.",
            }
    };

    public static RecipeImage RecipeImage = new()
    {
        data = new ImageData[] {
                new ImageData()
                {
                    url = "https://www.allrecipes.com/thmb/nX1dNGl1mKTUOLCKTkRmhPkdohE=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/5969369-682611ebae5a42ddbcaaa90c27b3e1fd.jpg"
                }
            }
    };

}