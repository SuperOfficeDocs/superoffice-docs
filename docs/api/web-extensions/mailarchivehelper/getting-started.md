---
title: Initializing
uid: mailarchivehelper_init
description: Initializing the MailArchiveHelper
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# Initializing

Before you start using the helper, you need to tell it who you are by using the `Initialize` method:

```csharp
SuperOffice.Mail.MailArchiveHelper helper = new SuperOffice.Mail.MailArchiveHelper();
helper.Initialize("Thunderbird", ".eml", "ThunderMailLink.chm");
```

The first parameter corresponds to the registry section where settings are stored on the client. In this case in the `HKCU\Software\SuperOffice\Thunderbird` key.

## Helper function

We often wrap this initializing code in a helper function, so that we can use it like this:

```csharp
MailArchiveHelper GetMailArchiveHelper()
{
  MailArchiveHelper tmp = new MailArchiveHelper();
  tmp.Initialize("Thunderbird", ".eml", "ThunderMailLink.chm");
  return tmp;
}
using (MailArchiveHelper mah = GetMailArchiveHelper())
{
  string path = mah.GetPreference("Path", Registry.LocalMachine.Name, "", string.Empty).Trim();
  if (!File.Exists(path))
    mah.LogError("oh dear - file '" + path + "' does not exist");
}
```

The helper is designed to be used and then disposed of so that your connection with the SuperOffice application lasts only as long as the action the user requested. This is to avoid keeping COM objects alive unnecessarily.
