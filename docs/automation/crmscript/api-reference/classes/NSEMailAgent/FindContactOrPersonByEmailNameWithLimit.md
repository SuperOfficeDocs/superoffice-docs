---
uid: crmscript_ref_NSEMailAgent_FindContactOrPersonByEmailNameWithLimit
title: ContactOrPersonFromEmail[] FindContactOrPersonByEmailNameWithLimit(String name, String emailAddress, Integer numberOfContacts, Integer numberOfPersons)
intellisense: NSEMailAgent.FindContactOrPersonByEmailNameWithLimit
keywords: NSEMailAgent, FindContactOrPersonByEmailNameWithLimit
so.topic: reference
---



**Parameters:**
 - **name** The sender name
 - **emailAddress** The sender email address
 - **numberOfContacts** Maximum returned number of contacts
 - **numberOfPersons** Maximum returned number of persons

**Returns:** ContactOrPersonFromEmail[]

```crmscript
NSEMailAgent agent;
String name;
String emailAddress;
Integer numberOfContacts;
Integer numberOfPersons;
ContactOrPersonFromEmail[] res = agent.FindContactOrPersonByEmailNameWithLimit(name, emailAddress, numberOfContacts, numberOfPersons);
```

