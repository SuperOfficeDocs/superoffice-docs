---
uid: crmscript_ref_NSQuoteVersionButtonState_SetAction
title: SetAction(Integer action)
intellisense: NSQuoteVersionButtonState.SetAction
keywords: NSQuoteVersionButtonState, GetAction
so.topic: reference
---

# SetAction(Integer action)

Action for the button

**Parameter:** 
 - **action** Integer
     - Enum: 0 = None 
     - Enum: 1 = ValidateVersion 
     - Enum: 2 = Edit 
     - Enum: 3 = Send 
     - Enum: 4 = Approve 
     - Enum: 5 = Reject 
     - Enum: 7 = ValidateVersionAndSendIfPossible 
     - Enum: 8 = ValidateVersionAndPlaceOrderIfPossible 
     - Enum: 9 = CloneVersion 
     - Enum: 10 = SendConfirmation 
     - Enum: 11 = GetOrderState 
     - Enum: 12 = UpdatePrices 

```crmscript
NSQuoteVersionButtonState thing;
Integer action;
thing.SetAction(action);
```

