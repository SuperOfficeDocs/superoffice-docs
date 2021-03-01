---
title: pagebuilder_tag
description: PageBuilder class
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# PageBuilder

In the CRM.web *default.aspx*, there is a PageBuilder tag:

```XML
<so2:PageBuilder ID="PageContent" runat="server">

</so2:PageBuilder>
```

*Default.aspx* is the main page used by CRM.web. Every time this page is loaded, the PageBuilder framework supplies the information.

The `PageBuilder` class includes a lot of methods:

* InitializeCard
* InitializeControl
* InitializePanels
* InitializeView
* InitializeDataHandler
* ...
