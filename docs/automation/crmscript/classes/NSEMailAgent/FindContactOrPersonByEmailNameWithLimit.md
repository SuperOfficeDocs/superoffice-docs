---
title: crmscript_ref_NSEMailAgent_FindContactOrPersonByEmailNameWithLimit
description: ContactOrPersonFromEmailArray FindContactOrPersonByEmailNameWithLimit(String name, String emailAddress, Integer numberOfContacts, Integer numberOfPersons)
intellisense: NSEMailAgent.FindContactOrPersonByEmailNameWithLimit
keywords: NSEMailAgent,FindContactOrPersonByEmailNameWithLimit
so.topic: reference
---



**Parameters:**
 - **name** The sender name
 - **emailAddress** The sender email address
 - **numberOfContacts** Maximum returned number of contacts
 - **numberOfPersons** Maximum returned number of persons

**Returns:** Contacts and persons matching emailaddress and name

```crmscript
NSEMailAgent agent;
String name;
String emailAddress;
Integer numberOfContacts;
Integer numberOfPersons;
ContactOrPersonFromEmailArray res = agent.FindContactOrPersonByEmailNameWithLimit(name, emailAddress, numberOfContacts, numberOfPersons);
```

