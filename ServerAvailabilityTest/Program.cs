// Program.cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) => {
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(@"
<!DOCTYPE html>
<html>
<head>
    <title>Simple C# Web App</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f5f5f5;
        }
        .container {
            text-align: center;
            background-color: white;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
        }
        button {
            background-color: #4CAF50;
            color: white;
            border: none;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 20px 0;
            cursor: pointer;
            border-radius: 4px;
        }
        #message {
            margin-top: 20px;
            font-size: 18px;
            color: #333;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h1>Your C# Web Application</h1>
        <p>The application is running successfully!</p>
        
        <button id='showMessageBtn'>Click Me!</button>
        
        <div id='message'></div>
        
        <script>
            document.getElementById('showMessageBtn').addEventListener('click', function() {
                const messages = [
                    'Hello from your C# web app!',
                    'You clicked the button!',
                    'It works perfectly!',
                    'Accessible from your phone too!',
                    'ASP.NET Core is awesome!'
                ];
                
                const randomMessage = messages[Math.floor(Math.random() * messages.length)];
                document.getElementById('message').textContent = randomMessage;
            });
        </script>
    </div>
</body>
</html>");
});

// Add this line to listen on all network interfaces
app.Urls.Add("http://0.0.0.0:5000");

app.Run();