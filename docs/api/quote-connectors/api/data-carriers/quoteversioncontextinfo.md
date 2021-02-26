---
title: quote_connector_carrier_quoteversioncontextinfo
description:  ERP Quote Connector Interface data carrier - QuoteVersionContextInfo
so.date:
keywords: quote
so.topic: reference
---

# QuoteVersionContextInfo

![38][img1]

Exists to be able to give the connector relevant information for QuoteVersion specific operations, like SendQuoteVersion.

## string ERPClientKey

Foreign key - always present.

## UserInfo CRMAssociate

Read-only. The logged in user (the salesman)

Note: not necessarily the the owner of the sale | that is exposed via the SaleInfo object

## ISaleInfo CRMSale

Read-only information about the sale the quote is attached to.

The CRM client will update the amount + cost fields on the sale based on the quote values.

## IContactInfo CRMCompany

Read-only. The sale’s customer info | more detailed information than is provided by the ISaleInfo object.

## IProjectInfo CRMProject

Read-only. The sales related project info (if any).

## ForeignKeyInfo[] ForeignKeys

The foreign keys that is related to this quote.

Contact keys, project keys, sales keys and quotekeys.

## int EISConnectionId

The id of the EIS Connection in the CRM system.

## string EISConnectionGuid

A conversation identifier

## string ERPCompanyKey

A key to the equivalent id in the ERP system, from the EIS System.

May be empty.

## string ERPPersonKey

A key to the equivalent id in the ERP system, from the EIS System.

May be empty.

## string ERPProjectKey

A key to the equivalent id in the ERP system, from the EIS System.

May be empty.

## string ERPSaleKey

A key to the equivalent id in the ERP system, from the EIS System.

May be empty.

## QuoteInfo CRMQuote

Read + Write quote information

## QuoteVersionInfo CRMQuoteVersion

Read + Write version information.

This is the active version

## String UserLanguageCode

The language the users uses in the CRM client. The connector should preferably respond using this language.
.net culture code: "nb-NO", "en-US" etc.

## QuoteAlternativeWithLinesInfo CRMQuoteAlternativeWithLines

Read + Write alternative information.

This is the active alternative

<!-- Referenced images -->
[img1]: media/image038.png
