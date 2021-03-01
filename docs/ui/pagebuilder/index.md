---
title: pagebuilder       
description: PageBuilder
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
---

# PageBuilder

PageBuilder's main functionality is rendering the page with the UI states and current changes in the page.

The following diagram shows the components in a typical CRM.web webpage. The webpage consists of one or more panels. A panel should consist of at least one card. Each card has its own set of views.

![01][img1]

The PageBuilder generates a page based on the information passed by the SuperState. The SuperState determines which configuration to fetch based on the SoProtocol and passes it to the PageBuilder.

The controls consider the UI status and the current values when rendering a page. Once the page shows in the browser, it brings all elements in the page into one level. SuperOffice connects the SuperState, User Controls, SoProtocols, DataHandlers, and the XML configuration files to render the page.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
