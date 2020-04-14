func @_API.ContextSeed.Init$bool$(i1) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :15 :8) {
^entry (%__useInMemory : i1):
%0 = cbde.alloca i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :15 :32)
cbde.store %__useInMemory, %0 : memref<i1> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :15 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.load %0 : memref<i1> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :17 :26)
br ^1

^1: // ExitBlock
return

}
func @_API.ContextSeed.SeedAsync$System.IServiceProvider$(none) -> () loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :19 :8) {
^entry (%_services : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :19 :37)
cbde.store %_services, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :19 :37)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :21 :27) // Not a variable of known type: services
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :21 :27) // services.GetRequiredService<DataContext>() (InvocationExpression)
%4 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :23 :16) // Not a variable of known type: useInMemory
%5 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :23 :31) // null (NullLiteralExpression)
%6 = cbde.unknown : i1  loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :23 :16) // comparison of unknown type: useInMemory == null
cond_br %6, ^1, ^2 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :23 :16)

^1: // JumpBlock
%7 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :25 :47) // "Please initialize the ContextSeed using the Init method." (StringLiteralExpression)
%8 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :25 :22) // new ApplicationException("Please initialize the ContextSeed using the Init method.") (ObjectCreationExpression)
cbde.throw %8 :  none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :25 :16)

^2: // BinaryBranchBlock
%9 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :28 :17) // Not a variable of known type: useInMemory
%10 = cbde.unknown : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :28 :17) // useInMemory.Value (SimpleMemberAccessExpression)
%11 = cbde.unknown : i1 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :28 :16) // !useInMemory.Value (LogicalNotExpression)
cond_br %11, ^3, ^4 loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :28 :16)

^3: // SimpleBlock
%12 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :30 :16) // Not a variable of known type: _context
%13 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :30 :16) // _context.Database (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\ContextSeed.cs" :30 :16) // _context.Database.Migrate() (InvocationExpression)
br ^4

^4: // ExitBlock
return

}
