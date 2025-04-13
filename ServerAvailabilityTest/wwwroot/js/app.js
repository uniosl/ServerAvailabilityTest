// wwwroot/js/app.js
document.getElementById('showMessageBtn').addEventListener('click', function () {
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