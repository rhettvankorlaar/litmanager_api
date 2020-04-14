// Skipping function AddAsync(none), it contains poisonous unsupported syntaxes

// Skipping function GetAllAsync(), it contains poisonous unsupported syntaxes

// Skipping function GetAsync(none), it contains poisonous unsupported syntaxes

// Skipping function UpdateAsync(none), it contains poisonous unsupported syntaxes

// Skipping function DeleteAsync(none), it contains poisonous unsupported syntaxes

func @_litmanager_api.Services.UserTypeService.PatchAsync$System.Guid.Microsoft.AspNetCore.JsonPatch.JsonPatchDocument$(none, none) -> none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :70 :8) {
^entry (%_idToPatch : none, %_patchDocument : none):
%0 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :70 :37)
cbde.store %_idToPatch, %0 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :70 :37)
%1 = cbde.alloca none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :70 :53)
cbde.store %_patchDocument, %1 : memref<none> loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :70 :53)
br ^0

^0: // JumpBlock
%2 = cbde.unknown : none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :72 :18) // new NotImplementedException() (ObjectCreationExpression)
cbde.throw %2 :  none loc("E:\\litmanager\\litmanager-api\\litmanager-api\\Services\\UserTypeService.cs" :72 :12)

^1: // ExitBlock
cbde.unreachable

}
