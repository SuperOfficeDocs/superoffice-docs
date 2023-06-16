---
uid: enum-salestatus
title: Enum values for SaleStatus
description: Lists the enum values for SaleStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# SaleStatus Enum

Status (open, closed, lost)

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Sale status is unknown|
|Open|1|Sale is open|
|Sold|2|Sale has been sold (green $ in GUI)|
|Lost|3|Sale has been lost (red $ in GUI)|
|Stalled|4|Sale has been stalled, or "parked", awaiting further developments|
|SaintAll|1000|All' choice for Saint. This is NOT an acceptable value for a sale, but is used by the Saint system for indexing all sales|

## Usage

* [sale](../sale.md).status - Sales  For every Sale record edited through the SuperOffice GUI, a copy of the current version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  
* [SaleHist](../salehist.md).status - Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the current record of the sale is also saved here. 
* [CounterValue](../countervalue.md).sale_status - Visible for rights
