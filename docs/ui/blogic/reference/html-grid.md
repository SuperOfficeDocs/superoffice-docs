---
title: HtmlGrid
uid: blogic_htmlgrid
description: HtmlGrid
author:
so.date:
keywords:
so.topic: reference
---

# HtmlGrid

This element is the oldest grid version that allows you to create an HTML grid.

## Configuration

| Value         | Description                                  |
|:--------------|:---------------------------------------------|
|  hasCheckbox  | the grid will output a checkbox row          |
|  checkboxLeft | the checkbox row will be left aligned        |
|  persistent   | the grid will retain values between requests |
|  width        | the width of the grid                        |

### Headers

| Value           | Description |
|:----------------|:------------|
| headers.n.label |             |
| headers.n.url   |             |
| headers.n.flags |             |
| headers.n.width |             |

### Rows

| Value                   | Description |
|:------------------------|:------------|
| rows.n.id               |             |
| rows.n.columns          |             |
| rows.n.columns.i.label  |             |
| rows.n.columns.i.url    |             |
| rows.n.columns.i.flags  |             |
| rows.n.columns.i.target |             |

## Functions

### getFieldValue(String field)

* rows
* all
* row.n.checked
* row.n.column.label
* row.n.id

### setFieldValue(String action, Map values)

| Action        | Map keys                           | Description   |
|:--------------|:-----------------------------------|:--------------|
| addHeader     | label<br>url<br>flags<br>width  | Adds a header |
| addRow        | unique<br>id<br>checked          | Adds a row    |
| addCell       | label<br>url<br>flags<br>target | Adds a cell   |
| deleteChecked |                                    |               |
