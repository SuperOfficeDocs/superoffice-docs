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

UserControls are reusable components that can be used by many pages.

The UserControls are the outermost elements in SuperOffice. The control is perhaps the most interesting object in the framework because the controls are what we actually interact with when we use the panel.

A UserControl is a set of smaller UI controls, which also contains all the presentation logic. Embedding this logic into the UserControl simplifies the configuration a lot. The interaction between fields (controls) and other event-driven logic must be implemented specifically into each control.

## ASCX vs. ASPX

ASCX pages are web controls that can be used in an ASPX page.

File extensions:

* UserControls: *.ascx*
* ASP webpages: *.aspx*

The basic difference between ASPX and ASCX pages is that ASCX pages may not have `<HTML>`, `<Body>`, or `<Form>` tags but the ASPX pages have those tags

## ASP.Net DataBinding

Data Binding is **binding controls to data from databases**.

With [ASP. Net data binding][1], we can bind a control to a particular column in a table from the database or we can bind the whole table to the data grid. Data binding provides a simple, convenient, and powerful way to create a read/write link between the controls on a form and the data in their application.

ASP.net data-binding causes the values in a grid to be automatically populated from a data source. If the user edits a value on the page, the ASP.Net framework automatically updates the data source with the new value.

The PageBuilder framework uses a slightly different form of data-binding since it overrides the standard ASP.Net page model with a new AJAX update model. The PageBuilder framework does not use view-state, which means there is much less data to transmit back and forth, but it does mean that the server has to do a bit more work to figure out what has to be updated.

## DataHandler

The databinding is handled by the DataHandler. The DataHandler databinds all the controls that implement the `IDataBound` interface in the card.

<!-- Referenced links -->
[1]: http://www.startvbdotnet.com/aspsite/ado/databinding.aspx

<!-- Referenced images -->
