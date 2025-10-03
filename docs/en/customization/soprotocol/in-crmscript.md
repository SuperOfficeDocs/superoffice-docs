---
uid: so-protocol-crmscript
title: Using SOProtocol in CRMScript
description: Using SOProtocol in CRMScript
keywords: soprotocol, deeplinking, CRMScript
author: Eivind Fasting
date: 05.23.2025
content_type: reference
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/in-crmscript
language: en
---

# Using SOProtocol in CRMScript

In CRMScript, you can use `setNavigateTo()` and `getNavigateTo()` of the [EventData][1] object to work with [SOProtocol URLs][2].

```crmscript
EventData ed = getEventData();
ed.setNavigateTo("soprotocol:sale.document?document_id=0");
```

> [!NOTE]
> The [NSViewStateAgent][3] contains information about which archive tab is currently open. This can be useful to construct the correct soprotocol and refresh the correct parts.

<!-- Referenced links -->
[1]: ../../automation/crmscript/reference/CRMScript.Native.EventData.yml
[2]: ./index.md
[3]: ../../automation/crmscript/reference/CRMScript.NetServer.NSViewStateAgent.yml
