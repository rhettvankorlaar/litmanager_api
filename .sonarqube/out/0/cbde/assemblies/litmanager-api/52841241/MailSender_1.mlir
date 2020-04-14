func @_litmanager_api.Mail.MailSender.SendMail$litmanager_api.Mail.Receiver.string.string$(none, none, none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :8) {
^entry (%_receiver : none, %_subject : none, %_content : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :29)
cbde.store %_receiver, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :29)
%1 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :48)
cbde.store %_subject, %1 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :48)
%2 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :64)
cbde.store %_content, %2 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :20 :64)
br ^0

^0: // SimpleBlock
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :22 :17) // new MimeMessage() (ObjectCreationExpression)
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :3) // Not a variable of known type: message
%6 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :3) // message.To (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :37) // Not a variable of known type: receiver
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :37) // receiver.FirstName (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :58) // " " (StringLiteralExpression)
%10 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :37) // Binary expression on unsupported types receiver.FirstName + " "
%11 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :64) // Not a variable of known type: receiver
%12 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :64) // receiver.LastName (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :37) // Binary expression on unsupported types receiver.FirstName + " " + receiver.LastName
%14 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :83) // Not a variable of known type: receiver
%15 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :83) // receiver.Email (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :18) // new MailboxAddress(receiver.FirstName + " " + receiver.LastName, receiver.Email) (ObjectCreationExpression)
%17 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :23 :3) // message.To.Add(new MailboxAddress(receiver.FirstName + " " + receiver.LastName, receiver.Email)) (InvocationExpression)
%18 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :3) // Not a variable of known type: message
%19 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :3) // message.From (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :39) // "LIT Manager" (StringLiteralExpression)
%21 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :54) // Not a variable of known type: _emailConfiguration
%22 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :54) // _emailConfiguration.From (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :20) // new MailboxAddress("LIT Manager", _emailConfiguration.From) (ObjectCreationExpression)
%24 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :24 :3) // message.From.Add(new MailboxAddress("LIT Manager", _emailConfiguration.From)) (InvocationExpression)
%25 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :26 :3) // Not a variable of known type: message
%26 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :26 :3) // message.Subject (SimpleMemberAccessExpression)
%27 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :26 :21) // Not a variable of known type: subject
%28 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :29 :3) // Not a variable of known type: message
%29 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :29 :3) // message.Body (SimpleMemberAccessExpression)
// Entity from another assembly: TextFormat
%30 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :29 :31) // TextFormat.Html (SimpleMemberAccessExpression)
%31 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :29 :18) // new TextPart(TextFormat.Html)     {      Text = content     } (ObjectCreationExpression)
%32 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :31 :11) // Not a variable of known type: content
%33 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :35 :27) // new SmtpClient() (ObjectCreationExpression)
%35 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :3) // Not a variable of known type: emailClient
%36 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :23) // Not a variable of known type: _emailConfiguration
%37 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :23) // _emailConfiguration.SmtpServer (SimpleMemberAccessExpression)
%38 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :55) // Not a variable of known type: _emailConfiguration
%39 = cbde.unknown : i32 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :55) // _emailConfiguration.Port (SimpleMemberAccessExpression)
%40 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :81) // true
%41 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :37 :3) // emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.Port, true) (InvocationExpression)
%42 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :40 :3) // Not a variable of known type: emailClient
%43 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :40 :3) // emailClient.AuthenticationMechanisms (SimpleMemberAccessExpression)
%44 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :40 :47) // "XOAUTH2" (StringLiteralExpression)
%45 = cbde.unknown : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :40 :3) // emailClient.AuthenticationMechanisms.Remove("XOAUTH2") (InvocationExpression)
%46 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :3) // Not a variable of known type: emailClient
%47 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :28) // Not a variable of known type: _emailConfiguration
%48 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :28) // _emailConfiguration.UserName (SimpleMemberAccessExpression)
%49 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :58) // Not a variable of known type: _emailConfiguration
%50 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :58) // _emailConfiguration.Password (SimpleMemberAccessExpression)
%51 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :42 :3) // emailClient.Authenticate(_emailConfiguration.UserName, _emailConfiguration.Password) (InvocationExpression)
%52 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :44 :3) // Not a variable of known type: emailClient
%53 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :44 :20) // Not a variable of known type: message
%54 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :44 :3) // emailClient.Send(message) (InvocationExpression)
%55 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :46 :3) // Not a variable of known type: emailClient
%56 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :46 :26) // true
%57 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Mail\\MailSender.cs" :46 :3) // emailClient.Disconnect(true) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
