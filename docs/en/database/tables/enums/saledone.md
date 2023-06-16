---
uid: enum-saledone
title: Enum values for SaleDone
description: Lists the enum values for SaleDone.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SaleDone Enum

Done (0=don&apos;t know, 1 = No, 2=Yes)

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Sale Done/Not done state is unknown|
|NotDone|1|Sale is not done|
|Done|2|Sale is done|

## Usage

* [sale](../sale.md).done - Sales  For every Sale record edited through the SuperOffice GUI, a copy of the current version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
* [SaleHist](../salehist.md).done - Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the current record of the sale is also saved here. 
