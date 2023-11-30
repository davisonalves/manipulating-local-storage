using Newtonsoft.Json;

namespace c__example
{
    public class Scripts
    {
        public string RegisterUser(User user)
        {
            string userJson = JsonConvert.SerializeObject(user);
            string script = $"window.localStorage.setItem('{user.Email}', JSON.stringify({userJson}))";
            
            return script;
        }
    }
}
