---
title: so_protocol_crmscript
description: SoProtocol Using SOProtocol in CRMScript
author:
so.date:
keywords:
so.topic: reference
---

# Using SOProtocol in CRMScript

In CRMScript, you can use `setNavigateTo()` and `getNavigateTo()` of the [EventData][1] object to work with SOProtocol URLs.

```crmscript
EventData ed = getEventData();
ed.setNavigateTo("soprotocol:sale.document?document_id=0");
```

<!-- Referenced links -->
[1]: ../eventdata.md
