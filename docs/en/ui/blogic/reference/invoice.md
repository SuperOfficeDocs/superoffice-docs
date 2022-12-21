---
title: nvoice
uid: blogic_invoice
description: Invoice
author:
so.date:
keywords:
so.topic: reference
---

# Invoice

This element is used for listing and adding invoice lines.

It has a grid for the lines and some input fields for adding a new line.

## Configuration

| Setting      | Description                          |
|:-------------|:-------------------------------------|
| label        | UI label                             |
| rows.length  | Number of lines                      |
| rows.i.id    | The ID of the invoice type to change |
| rows.i.price | The new price for the invoice type   |

> [!NOTE]
> The price must be multiplied by 100.

## Functions

### getFieldValue(String field)

| Field               | Description                              |
|:--------------------|:-----------------------------------------|
| rows                | The number of rows in the grid           |
| row.n.type          | The invoice type for row n               |
| row.n.description   | The description for row n                |
| row.n.price         | The price for row n                      |
| row.n.quantity      | The quantity for row n                   |
| row.n.discount      | The discount in percent for row n        |
| row.n.discountMoney | The discount in monetary units for row n |
| row.n.date          | The date for row n                       |

### setFieldValue(String action, Map values)

| Action     | Map keys      | Description                                 |
|:-----------|:--------------|:--------------------------------------------|
| add        | id<br>type<br>description<br>price<br>quantity<br>discount<br>discountMoney<br>date | Adds a line of values to the grid |
| addCurrent |               | Adds the current line to the grid           |
| default    | default       | Sets the default invoice type to show by ID |
