---
title: quote_connector_carrier_quoteversionstateinfo
description: ERP Quote Connector Interface data carrier - QuoteVersionStateInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# QuoteVersionStateInfo

The various states a `QuoteVersion` can be in.

## Unknown

State unknown

## DraftNotCalculated

This is a draft that has not been calculated

## DraftCalculated

Draft that has been calculated and ERP has verified it as OK

## DraftNeedsApproval

Draft has been checked, and there was a problem that needs approval

## DraftApproved

Draft with potential problems has been human-approved

## Sent

Sent to the customer and is presumably a legally binding document

## SentExpired

Sent to the customer but has expired and is no longer binding

## Archived

Archived without being sent

## Ordered

Accepted and ordered by the customer

## Rejected

Version was rejected by the customer

## Sold

Quote was accepted and the sale was carried through all steps

![26][img1]

<!-- Referenced images -->
[img1]: media/image026.png
