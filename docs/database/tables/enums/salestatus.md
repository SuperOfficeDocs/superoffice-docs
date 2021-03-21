---
uid: enum-salestatus
title: Enum values for SaleStatus
description: Lists the enum values for SaleStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SaleStatus Enum

Status (open, closed, lost)

* Unknown = 0
* Open = 1
* Sold = 2
* Lost = 3
* Stalled = 4
* SaintAll = 1000

## Usage

* [sale](../sale.md).status - Sales  For every Sale record edited through the SuperOffice GUI, a copy of the previous version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
* [SaleHist](../salehist.md).status - Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the previous record of the sale is moved here. 
* [CounterValue](../countervalue.md).sale_status - Visible for rights
