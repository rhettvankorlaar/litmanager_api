func @_litmanager_api.Services.SecurityService.HashPassword$string$(none) -> none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :10 :8) {
^entry (%_password : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :10 :35)
cbde.store %_password, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :10 :35)
br ^0

^0: // JumpBlock
// Entity from another assembly: BCrypt
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :12 :19) // BCrypt.Net.BCrypt (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :12 :58) // Not a variable of known type: password
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :12 :19) // BCrypt.Net.BCrypt.EnhancedHashPassword(password) (InvocationExpression)
return %3 : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :12 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_litmanager_api.Services.SecurityService.VerifyPassword$string.string$(none, none) -> i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :15 :8) {
^entry (%_inputPassword : none, %_storedPassword : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :15 :35)
cbde.store %_inputPassword, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :15 :35)
%1 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :15 :57)
cbde.store %_storedPassword, %1 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :15 :57)
br ^0

^0: // JumpBlock
// Entity from another assembly: BCrypt
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :17 :19) // BCrypt.Net.BCrypt (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :17 :52) // Not a variable of known type: inputPassword
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :17 :67) // Not a variable of known type: storedPassword
%5 = cbde.unknown : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :17 :19) // BCrypt.Net.BCrypt.EnhancedVerify(inputPassword, storedPassword) (InvocationExpression)
return %5 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\SecurityService.cs" :17 :12)

^1: // ExitBlock
cbde.unreachable

}
