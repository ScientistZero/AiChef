using AiChef.Shared;

namespace AiChef.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);
        // This method will call the OpenAI API to generate recipe ideas based on the provided meal time and ingredients.

    }
}
