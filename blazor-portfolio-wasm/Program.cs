// Copyright 2022 Matthew Opie (mattopie.com, matthewopie.com) All Rights Reserved.

using blazor_portfolio_wasm;
using CurrieTechnologies.Razor.Vibration;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddVibration();

await builder.Build().RunAsync();