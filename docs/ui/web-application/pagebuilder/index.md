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

![02][img1]

The PageBuilder generates a page based on the information passed by the SuperState. The SuperState determines which configuration to fetch based on the SoProtocol and passes it to the PageBuilder.

The controls consider the UI status and the current values when rendering a page. Once the page shows in the browser, it brings all elements in the page into one level. SuperOffice connects the [SuperState][1], [user controls][2], [SoProtocol][1], [data handlers][4], and the [XML configuration files][5] to render the page.

## SuperOffice pages

A page consists of several different kinds of objects:

### Panel

A single page may consist of several panels. The panel object is the top-level UI frame for the interface. The panel can consist of any number of cards. The Card can be treated as canvases on which we can place views using different layout rules. The panel implementation will interpret what these cards are going to be used for and how they are shown. The card can contain any number of views, which are laid out according to the definition on the card and the properties of the control.

### Cards

The card section contains one or more views. The views can be displayed one by one or all at once, which is decided by the implementation of the card. In SuperOffice, the card will display a tab control or a dropdown control telling the user which view is active and what other views are available.

### Views

The view section contains one or more controls. The controls can be displayed one by one or all at once, this is decided by the implementation of the view.

### Control

The control is the most interesting object in the framework because the controls are what we are interacting with when we use the panel.

A control is a set of smaller UI controls, which also contains all the presentation logic. Embedding this logic into the control simplifies the configuration a lot. The interaction between fields (controls) and other event-driven logic must be implemented specifically into each control.

## default.aspx

*Default.aspx* is the main page used by SuperOffice Web. Every time this page is loaded, the PageBuilder framework supplies the information. The ASPX file has a `PageBuilder` element:

```XML
<so2:PageBuilder ID="PageContent" runat="server">

</so2:PageBuilder>
```

## Methods in the PageBuilder class

* InitializeCard
* InitializeControl
* InitializePanels
* InitializeView
* InitializeDataHandler
* ...

<!-- Referenced links -->
[1]: superstate/index.md
[2]: usercontrols/index.md
[4]: datahandlers/index.md
[5]: config/index.md

<!-- Referenced images -->
[img1]: media/image002.jpg
