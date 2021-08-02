---
uid: crmscript_ref_NSChatMessage_SetSpecialType
title: SetSpecialType(NSChatMessageSpecialType specialType)
intellisense: NSChatMessage.SetSpecialType
keywords: NSChatMessage, GetSpecialType
so.topic: reference
---

Enum indicating if it is a special message, such as an URL redirection, etc.

**Parameter:** 
 - **specialType** NSChatMessageSpecialType
     - Enum: 0 = None 
     - Enum: 1 = Welcome 
     - Enum: 2 = Url 
     - Enum: 3 = Block 
     - Enum: 5 = NewSession 
     - Enum: 6 = TransferedSession 
     - Enum: 7 = Error 
     - Enum: 8 = SessionDeleted 
     - Enum: 9 = FaqSuccessQuestion 
     - Enum: 10 = ClosedByUser 
     - Enum: 11 = ClosedByCustomer 
     - Enum: 12 = ClosedByIdle 
     - Enum: 13 = TransferRejected 
     - Enum: 14 = ReopenedByCustomer 
     - Enum: 15 = ClickedOption 
     - Enum: 16 = BotMessage 
     - Enum: 17 = Options 

```crmscript
NSChatMessage thing;
NSChatMessageSpecialType specialType;
thing.SetSpecialType(specialType);
```

