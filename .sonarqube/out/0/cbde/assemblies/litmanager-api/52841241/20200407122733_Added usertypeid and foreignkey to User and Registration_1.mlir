func @_litmanager_api.Migrations.AddedusertypeidandforeignkeytoUserandRegistration.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :7 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :7 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :7 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :9 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :10 :22) // "FK_Registrations_UserTypes_UserTypeId" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :11 :23) // "Registrations" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :9 :12) // migrationBuilder.DropForeignKey(                  name: "FK_Registrations_UserTypes_UserTypeId",                  table: "Registrations") (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :13 :12) // Not a variable of known type: migrationBuilder
%6 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :14 :22) // "FK_Users_UserTypes_UserTypeId" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :15 :23) // "Users" (StringLiteralExpression)
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :13 :12) // migrationBuilder.DropForeignKey(                  name: "FK_Users_UserTypes_UserTypeId",                  table: "Users") (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :17 :12) // Not a variable of known type: migrationBuilder
%10 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :18 :22) // "UserTypeId" (StringLiteralExpression)
%11 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :19 :23) // "Users" (StringLiteralExpression)
%12 = constant 0 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :20 :26) // false
%13 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :21 :28) // typeof(Guid) (TypeOfExpression)
%14 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :22 :25) // "uniqueidentifier" (StringLiteralExpression)
%15 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :23 :29) // true
%16 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :17 :12) // migrationBuilder.AlterColumn<Guid>(                  name: "UserTypeId",                  table: "Users",                  nullable: false,                  oldClrType: typeof(Guid),                  oldType: "uniqueidentifier",                  oldNullable: true) (InvocationExpression)
%17 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :25 :12) // Not a variable of known type: migrationBuilder
%18 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :26 :22) // "UserTypeId" (StringLiteralExpression)
%19 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :27 :23) // "Registrations" (StringLiteralExpression)
%20 = constant 0 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :28 :26) // false
%21 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :29 :28) // typeof(Guid) (TypeOfExpression)
%22 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :30 :25) // "uniqueidentifier" (StringLiteralExpression)
%23 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :31 :29) // true
%24 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :25 :12) // migrationBuilder.AlterColumn<Guid>(                  name: "UserTypeId",                  table: "Registrations",                  nullable: false,                  oldClrType: typeof(Guid),                  oldType: "uniqueidentifier",                  oldNullable: true) (InvocationExpression)
%25 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :33 :12) // Not a variable of known type: migrationBuilder
%26 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :34 :22) // "FK_Registrations_UserTypes_UserTypeId" (StringLiteralExpression)
%27 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :35 :23) // "Registrations" (StringLiteralExpression)
%28 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :36 :24) // "UserTypeId" (StringLiteralExpression)
%29 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :37 :32) // "UserTypes" (StringLiteralExpression)
%30 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :38 :33) // "Id" (StringLiteralExpression)
// Entity from another assembly: ReferentialAction
%31 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :39 :26) // ReferentialAction.Cascade (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :33 :12) // migrationBuilder.AddForeignKey(                  name: "FK_Registrations_UserTypes_UserTypeId",                  table: "Registrations",                  column: "UserTypeId",                  principalTable: "UserTypes",                  principalColumn: "Id",                  onDelete: ReferentialAction.Cascade) (InvocationExpression)
%33 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :41 :12) // Not a variable of known type: migrationBuilder
%34 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :42 :22) // "FK_Users_UserTypes_UserTypeId" (StringLiteralExpression)
%35 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :43 :23) // "Users" (StringLiteralExpression)
%36 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :44 :24) // "UserTypeId" (StringLiteralExpression)
%37 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :45 :32) // "UserTypes" (StringLiteralExpression)
%38 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :46 :33) // "Id" (StringLiteralExpression)
// Entity from another assembly: ReferentialAction
%39 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :47 :26) // ReferentialAction.Cascade (SimpleMemberAccessExpression)
%40 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :41 :12) // migrationBuilder.AddForeignKey(                  name: "FK_Users_UserTypes_UserTypeId",                  table: "Users",                  column: "UserTypeId",                  principalTable: "UserTypes",                  principalColumn: "Id",                  onDelete: ReferentialAction.Cascade) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_litmanager_api.Migrations.AddedusertypeidandforeignkeytoUserandRegistration.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :50 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :50 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :50 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :52 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :53 :22) // "FK_Registrations_UserTypes_UserTypeId" (StringLiteralExpression)
%3 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :54 :23) // "Registrations" (StringLiteralExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :52 :12) // migrationBuilder.DropForeignKey(                  name: "FK_Registrations_UserTypes_UserTypeId",                  table: "Registrations") (InvocationExpression)
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :56 :12) // Not a variable of known type: migrationBuilder
%6 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :57 :22) // "FK_Users_UserTypes_UserTypeId" (StringLiteralExpression)
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :58 :23) // "Users" (StringLiteralExpression)
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :56 :12) // migrationBuilder.DropForeignKey(                  name: "FK_Users_UserTypes_UserTypeId",                  table: "Users") (InvocationExpression)
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :60 :12) // Not a variable of known type: migrationBuilder
%10 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :61 :22) // "UserTypeId" (StringLiteralExpression)
%11 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :62 :23) // "Users" (StringLiteralExpression)
%12 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :63 :22) // "uniqueidentifier" (StringLiteralExpression)
%13 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :64 :26) // true
%14 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :65 :28) // typeof(Guid) (TypeOfExpression)
%15 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :60 :12) // migrationBuilder.AlterColumn<Guid>(                  name: "UserTypeId",                  table: "Users",                  type: "uniqueidentifier",                  nullable: true,                  oldClrType: typeof(Guid)) (InvocationExpression)
%16 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :67 :12) // Not a variable of known type: migrationBuilder
%17 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :68 :22) // "UserTypeId" (StringLiteralExpression)
%18 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :69 :23) // "Registrations" (StringLiteralExpression)
%19 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :70 :22) // "uniqueidentifier" (StringLiteralExpression)
%20 = constant 1 : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :71 :26) // true
%21 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :72 :28) // typeof(Guid) (TypeOfExpression)
%22 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :67 :12) // migrationBuilder.AlterColumn<Guid>(                  name: "UserTypeId",                  table: "Registrations",                  type: "uniqueidentifier",                  nullable: true,                  oldClrType: typeof(Guid)) (InvocationExpression)
%23 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :74 :12) // Not a variable of known type: migrationBuilder
%24 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :75 :22) // "FK_Registrations_UserTypes_UserTypeId" (StringLiteralExpression)
%25 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :76 :23) // "Registrations" (StringLiteralExpression)
%26 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :77 :24) // "UserTypeId" (StringLiteralExpression)
%27 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :78 :32) // "UserTypes" (StringLiteralExpression)
%28 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :79 :33) // "Id" (StringLiteralExpression)
// Entity from another assembly: ReferentialAction
%29 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :80 :26) // ReferentialAction.Restrict (SimpleMemberAccessExpression)
%30 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :74 :12) // migrationBuilder.AddForeignKey(                  name: "FK_Registrations_UserTypes_UserTypeId",                  table: "Registrations",                  column: "UserTypeId",                  principalTable: "UserTypes",                  principalColumn: "Id",                  onDelete: ReferentialAction.Restrict) (InvocationExpression)
%31 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :82 :12) // Not a variable of known type: migrationBuilder
%32 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :83 :22) // "FK_Users_UserTypes_UserTypeId" (StringLiteralExpression)
%33 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :84 :23) // "Users" (StringLiteralExpression)
%34 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :85 :24) // "UserTypeId" (StringLiteralExpression)
%35 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :86 :32) // "UserTypes" (StringLiteralExpression)
%36 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :87 :33) // "Id" (StringLiteralExpression)
// Entity from another assembly: ReferentialAction
%37 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :88 :26) // ReferentialAction.Restrict (SimpleMemberAccessExpression)
%38 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Migrations\\20200407122733_Added usertypeid and foreignkey to User and Registration.cs" :82 :12) // migrationBuilder.AddForeignKey(                  name: "FK_Users_UserTypes_UserTypeId",                  table: "Users",                  column: "UserTypeId",                  principalTable: "UserTypes",                  principalColumn: "Id",                  onDelete: ReferentialAction.Restrict) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
