func @_litmanager_api.Startup.ConfigureServices$Microsoft.Extensions.DependencyInjection.IServiceCollection$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :26 :8) {
^entry (%_services : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :26 :38)
cbde.store %_services, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :26 :38)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :28 :12) // Not a variable of known type: services
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :28 :47) // Not a variable of known type: Configuration
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :28 :12) // services.InstallServicesInAssembly(Configuration) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_litmanager_api.Startup.GetJsonPatchInputFormatter$$() -> none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :31 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection() (ObjectCreationExpression)
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection()                  .AddLogging() (InvocationExpression)
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection()                  .AddLogging()                  .AddMvc() (InvocationExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection()                  .AddLogging()                  .AddMvc()                  .AddNewtonsoftJson() (InvocationExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection()                  .AddLogging()                  .AddMvc()                  .AddNewtonsoftJson()                  .Services (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :33 :26) // new ServiceCollection()                  .AddLogging()                  .AddMvc()                  .AddNewtonsoftJson()                  .Services.BuildServiceProvider() (InvocationExpression)
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // Not a variable of known type: builder
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // builder                  .GetRequiredService<IOptions<MvcOptions>>() (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // builder                  .GetRequiredService<IOptions<MvcOptions>>()                  .Value (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // builder                  .GetRequiredService<IOptions<MvcOptions>>()                  .Value                  .InputFormatters (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // builder                  .GetRequiredService<IOptions<MvcOptions>>()                  .Value                  .InputFormatters                  .OfType<NewtonsoftJsonPatchInputFormatter>() (InvocationExpression)
%12 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :19) // builder                  .GetRequiredService<IOptions<MvcOptions>>()                  .Value                  .InputFormatters                  .OfType<NewtonsoftJsonPatchInputFormatter>()                  .First() (InvocationExpression)
return %12 : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Startup.cs" :39 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function Configure(none, none), it contains poisonous unsupported syntaxes

