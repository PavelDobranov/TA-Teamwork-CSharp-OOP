namespace AcademySystem.WpfClient.Data
{
    using System.Runtime.Serialization.Json;

    using AcademySystem.WpfClient.Models;

    public class DataPersister
    {
        private const string BaseServicesUrl = "http://localhost:3030/";

        public static void RegisterUser(string username, string authenticationCode, string email, string humanRole, string humanID)
        {
            //Validation!!!!!
            //validate username
            //validate email
            //validate authentication code
            var user = new UserModel()
            {
                //Username = username,
                //AuthenticationCode = authenticationCode,
                //Email = email,
                //HumanRole = humanRole,
                //HumanID = humanID
                Username = "Pesho",
                AuthenticationCode = "12345",
                Email = "Pesho@Pesho.bg",
                HumanRole = "Student",
                HumanID = "12345"
            };

            HttpRequester.Post(BaseServicesUrl + "users/register", user);
        }

        //public static string LoginUser(string username, string authenticationCode)
        //{
        //    //Validation!!!!!
        //    //validate username
        //    //validate email
        //    //validate authentication code
        //    //use validation from WebAPI
        //    var userModel = new UserModel()
        //    {
        //        Username = username,
        //        AuthCode = authenticationCode
        //    };
        //    //var loginResponse = HttpRequester.Post<LoginResponseModel>(BaseServicesUrl + "auth/token",
        //    //    userModel);
        //    //AccessToken = loginResponse.AccessToken;
        //    //return loginResponse.Username;
        //}

        //internal static bool LogoutUser()
        //{
        //    var headers = new Dictionary<string, string>();
        //    headers["X-accessToken"] = AccessToken;
        //    var isLogoutSuccessful = HttpRequester.Put(BaseServicesUrl + "users/logout", headers);
        //    return isLogoutSuccessful;
        //}

        //internal static void CreateNewTodosList(string title, IEnumerable<TodoViewModel> todos)
        //{
        //    var listModel = new TodolistModel()
        //    {
        //        Title = title,
        //        Todos = todos.Select(t => new TodoModel()
        //        {
        //            Text = t.Text
        //        })
        //    };

        //    var headers = new Dictionary<string, string>();
        //    headers["X-accessToken"] = AccessToken;

        //    var response =
        //        HttpRequester.Post<ListCreatedModel>(BaseServicesUrl + "lists", listModel, headers);
        //}

        //internal static IEnumerable<TodoListViewModel> GetTodoLists()
        //{
        //    var headers = new Dictionary<string, string>();
        //    headers["X-accessToken"] = AccessToken;

        //    var todoListsModels =
        //        HttpRequester.Get<IEnumerable<TodolistModel>>(BaseServicesUrl + "lists", headers);
        //    return todoListsModels.
        //        AsQueryable().
        //         Select(model => new TodoListViewModel()
        //         {
        //             Id = model.Id,
        //             Title = model.Title,
        //             Todos = model.Todos.AsQueryable().Select(todo => new TodoViewModel()
        //             {
        //                 Id = todo.Id,
        //                 Text = todo.Text,
        //                 IsDone = todo.IsDone
        //             })
        //         });
        //}

        //internal static void ChangeState(int todoId)
        //{
        //    var headers = new Dictionary<string, string>();
        //    headers["X-accessToken"] = AccessToken;

        //    HttpRequester.Put(BaseServicesUrl + "todos/" + todoId, headers);
        //}
    }
}
