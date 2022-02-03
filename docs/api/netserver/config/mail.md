---
title: Mail element
uid: ns_config_Mail
description: NetServer Mail component configuration options.
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Mail, NumberOfDaysToDownload, Reader, Sender
so.topic: reference
so.envir: onsite
---
# NetServer Mail element (SuperOffice only)

Configuration of mail parameters when using the SuperOffice Inbox. This is also the one used by Pocket CRM.

```XML
<Mail>
  <Component>
    <add key="Reader" value="MailKit" />
    <add key="Sender" value="MailKit" />
    <add key="NumberOfDaysToDownload" value="30" />
  </Component>
</Mail>
```

## Component

| Name | Description | Default |
|---|---|---|
| NumberOfDaysToDownload | Initial number of days to fetch mail for. | 180 |
| Reader | The Key used for mail reader. | MailKit |
| Sender | The Key used for mail sender. | MailKit |

> [!NOTE]
> [MailKit][2] has been the default sender and reader since version 8.1. It used to be EasyMail.

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Mail>
[2]: ../../../../superoffice-docs/docs/email/mailkit.md
