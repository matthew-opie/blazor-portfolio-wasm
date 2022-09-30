// Copyright 2022 Matthew Opie (mattopie.com, matthewopie.com) All Rights Reserved.

using blazor_portfolio_wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Majorsoft.Blazor.Components.CssEvents;
using Majorsoft.Blazor.Components.Notifications;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddCssEvents();
builder.Services.AddNotifications();

await builder.Build().RunAsync();