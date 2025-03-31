using AiChef.Shared;

namespace AiChef.Server.Services
{
    public class OpenAIService : IOpenAIAPI
    {
        public Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}
