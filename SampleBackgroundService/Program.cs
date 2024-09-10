using SampleBackgroundService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<TimedHostedService>();
builder.Services.AddHostedService<TimedBackgroundService>();

var host = builder.Build();
host.Run();
