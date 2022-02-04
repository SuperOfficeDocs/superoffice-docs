---
title: PriceListInfo
uid: quote_connector_carrier_pricelistinfo
description: ERP Quote Connector Interface data carrier - PriceListInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# PriceListInfo

![39][img1]

A pricelist is basically a collection of products. It can be valid in a time-period and outright deactivated. All prices in the product list are in a specific currency.

We have decided not to separate prices and products, which means that we get a simpler data model, but some redundancy.

## string ERPPricelistKey

Reference to the pricelist in the product supplier system.

## int QuoteConnectionId

The connection in SuperOffice this pricelist comes from.

## string Name

Name of this pricelist to use in the user interface.

## string Description

Description of this pricelist, will be used as tool-tip in the user interface.

## string Currency

The ISO currency code, like 'USD' or 'NOK'.

## string CurrencyName

The name to use in the user interface, like perhaps 'US dollar' or '$'

## DateTime ValidFrom

The date (inclusive) the pricelist starts to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date.

## DateTime ValidTo

The date (inclusive) the pricelist ends to be valid. This can be DateTime.MaxValue to signal that it doesn't have a specific end date.

## Bool IsActive

Is the list active (as opposed to being worked on, suddenly canceled, etc.)

<!-- Referenced images -->
[img1]: media/image039.png
