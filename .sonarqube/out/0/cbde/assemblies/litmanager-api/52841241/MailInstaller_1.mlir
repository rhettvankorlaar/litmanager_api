func @_litmanager_api.Installers.MailInstaller.InstallServices$Microsoft.Extensions.DependencyInjection.IServiceCollection.Microsoft.Extensions.Configuration.IConfiguration$(none, none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :13 :8) {
^entry (%_services : none, %_Configuration : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :13 :36)
cbde.store %_services, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :13 :36)
%1 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :13 :65)
cbde.store %_Configuration, %1 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :13 :65)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :15 :30) // Not a variable of known type: Configuration
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :15 :55) // "EmailConfiguration" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :15 :30) // Configuration.GetSection("EmailConfiguration") (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :15 :30) // Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>() (InvocationExpression)
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :16 :12) // Not a variable of known type: services
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :16 :34) // Not a variable of known type: emailConfig
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :16 :12) // services.AddSingleton(emailConfig) (InvocationExpression)
%10 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :18 :12) // Not a variable of known type: services
%11 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Installers\\MailInstaller.cs" :18 :12) // services.AddScoped<IMailSender, MailSender>() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
