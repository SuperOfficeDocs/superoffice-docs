---
title: ns_config_Mail
description: NetServer Mail element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---
# NetServer Mail Element (SuperOffice only)

Mail component configuration options.

```XML
<Mail>
  <Component>
    <add key="Reader" value="EasyMail" />
    <add key="Sender" value="EasyMail" />
  </Component>
</Mail>
```

## Component

| Name | Description |
|---|---|
| Reader | The Key used for mail reader. |
| Sender | The Key used for mail sender. |
| NumberOfDaysToDownload | Initial number of days to fetch mail for. |
