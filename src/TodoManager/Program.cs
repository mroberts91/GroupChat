using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using MessageServices;
namespace TodoManager
{
    public class Program
    {
        private const string Address = "localhost:5001";

        private static readonly string Username = Environment.UserName;

        private static string _token;

        private static bool _authenticated = false;


        static async Task Main(string[] args)
        {
            var channel = CreateAuthenticatedChannel($"https://{Address}");
            var greetClient = new Greeter.GreeterClient(channel);
            var todoClient = new Todo.TodoClient(channel);
            Console.WriteLine("Todo Manager");
            Console.WriteLine();
            
            var exiting = false;
            while (!exiting)
            {
                DisplayAuthMenu();
                Console.WriteLine();
                if (_authenticated) break;
                Console.Write("Selection:  ");
                var consoleKeyInfo = Console.ReadKey(intercept: true);
                switch (consoleKeyInfo.KeyChar)
                {
                    case '1':
                        _token = await Authenticate();
                        if (_token != null) _authenticated = true;
                        break;
                    case '2':
                        exiting = true;
                        break;
                }
            }

            if (exiting) Exit();
            DisplayGreeting(greetClient);

            while (!exiting)
            {
                DisplayTodoMenu();
                Console.WriteLine();
                if (!_authenticated) break;
                Console.Write("Selection:  ");
                var consoleKeyInfo = Console.ReadKey(intercept: true);
                switch (consoleKeyInfo.KeyChar)
                {
                    case '1':
                        GetAllTodos(todoClient);
                        break;
                    case '2':
                        exiting = true;
                        break;
                }
            }

        }

        private static GrpcChannel CreateAuthenticatedChannel(string address)
        {
            var credentials = CallCredentials.FromInterceptor((context, metadata) =>
            {
                if (!string.IsNullOrEmpty(_token))
                {
                    metadata.Add("Authorization", $"Bearer {_token}");
                }
                return Task.CompletedTask;
            });

            // SslCredentials is used here because this channel is using TLS.
            // Channels that aren't using TLS should use ChannelCredentials.Insecure instead.
            var channel = GrpcChannel.ForAddress(address, new GrpcChannelOptions
            {
                Credentials = ChannelCredentials.Create(new SslCredentials(), credentials)
            });
            return channel;
        }

        private static async Task<string> Authenticate()
        {
            try
            {
                Console.WriteLine($"Authenticating as {Username}...");
                var httpClient = new HttpClient();
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri($"https://{Address}/generateJwtToken?name={HttpUtility.UrlEncode(Username)}&email=user@test.com"),
                    Method = HttpMethod.Get,
                    Version = new Version(2, 0)
                };
                var tokenResponse = await httpClient.SendAsync(request);
                tokenResponse.EnsureSuccessStatusCode();

                var token = await tokenResponse.Content.ReadAsStringAsync();
                Console.WriteLine("Successfully authenticated.");

                return token;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(default(string));

            }
        }
        
        private static string Greeting(Greeter.GreeterClient client)
        {
            try
            {
                var response = client.SayHello(new HelloRequest(){ Name = Username });
                return response.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static void GetAllTodos(Todo.TodoClient client)
        {
            try
            {
                var response = client.AllTodoLists(new Empty());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DisplayAuthMenu()
        {
            Console.WriteLine("Press a key:");
            Console.WriteLine("1: Authenticate");
            Console.WriteLine("2: Exit");
        }

        private static void DisplayTodoMenu()
        {
            Console.WriteLine("Press a key:");
            Console.WriteLine("1: Get TODO List");
            Console.WriteLine("2: Exit");
        }

        private static void DisplayGreeting(Greeter.GreeterClient client)
        {
            Console.WriteLine();
            Console.WriteLine(Greeting(client));
            Console.WriteLine();

        }

        private static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("Have a good Day!");
            Environment.Exit(1);
        }
    }

}
