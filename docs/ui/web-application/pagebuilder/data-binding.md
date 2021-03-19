---
title: pb_usercontrols_binding
description: User controls data binding
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Data binding

Data Binding is **binding controls to data from databases**.

With [ASP. Net data binding][1], we can bind a control to a particular column in a table from the database or we can bind the whole table to the data grid. Data binding provides a simple, convenient, and powerful way to create a read/write link between the controls on a form and the data in their application.

ASP.net data-binding causes the values in a grid to be automatically populated from a data source. If the user edits a value on the page, the ASP.Net framework automatically updates the data source with the new value.

The PageBuilder framework uses a slightly different form of data-binding since it overrides the standard ASP.Net page model with a new AJAX update model. The PageBuilder framework does not use view-state, which means there is much less data to transmit back and forth, but it does mean that the server has to do a bit more work to figure out what has to be updated.

## DataHandler

The data binding is handled by the PageBuilder [data handler][2], which binds all the controls that implement the `IDataBound` interface in the card.

<!-- Referenced links -->
[1]: http://www.startvbdotnet.com/aspsite/ado/databinding.aspx
[2]: datahandlers/index.md

<!-- Referenced images -->
