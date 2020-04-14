func @_litmanager_api.Migrations.removedpasswordhashfromregistration.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :6 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :6 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :6 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :8 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :9 :22) // "PasswordHash" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :10 :23) // "Registrations" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :8 :12) // migrationBuilder.DropColumn(                  name: "PasswordHash",                  table: "Registrations") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_litmanager_api.Migrations.removedpasswordhashfromregistration.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :13 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :13 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :13 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :15 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :16 :22) // "PasswordHash" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :17 :23) // "Registrations" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :18 :22) // "nvarchar(max)" (StringLiteralExpression)
%5 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :19 :26) // true
%6 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407162248_removed passwordhash from registration.cs" :15 :12) // migrationBuilder.AddColumn<string>(                  name: "PasswordHash",                  table: "Registrations",                  type: "nvarchar(max)",                  nullable: true) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
