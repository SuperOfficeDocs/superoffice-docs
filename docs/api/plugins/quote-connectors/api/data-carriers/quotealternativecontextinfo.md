---
title: QuoteAlternativeContextInfo
uid: quote_connector_carrier_quotealternativecontextinfo
description: ERP Quote Connector Interface data carrier - QuoteAlternativeContextInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# QuoteAlternativeContextInfo

![37][img1]

Exists to be able to give the connector the relevant information for QuoteAlternative specific operations, for example, to be able to compute the correct price/discount on all levels.

## string ERPClientKey

Foreign key - always present.

## UserInfo CRMAssociate

Read-only. The logged-in user (the salesman)

> [!NOTE]
> Not necessarily the owner of the sale - that is exposed via the SaleInfo object

## IContactInfo CRMCompany

Read-only. The sale’s customer info - more detailed information than is provided by the ISaleInfo object.

## IPersonInfo CRMPerson

Read-only. The sales-related person info (if any).

## IProjectInfo CRMProject

Read-only. The sales-related project info (if any).

## ISaleInfo CRMSale

Read-only information about the sale the quote is attached to.

The CRM client will update the amount + cost fields on the sale based on the quote values.

## ForeignKeyInfo[] ForeignKeys

The foreign keys related to this quote.

Contact keys, project keys, sales keys, and quotekeys.

## QuoteInfo CRMQuote

Read + Write quote information

## QuoteVersionInfo CRMQuoteVersion

Read + Write version information.

This is the active version

## int EISConnectionId

The ID of the EIS Connection in the CRM system.

## string EISConnectionGuid

A conversation identifier

## string ERPCompanyKey

[!include[ALT](./includes/erpkey.md)]

May be empty.

## string ERPPersonKey

[!include[ALT](./includes/erpkey.md)]

May be empty.

## string ERPProjectKey

[!include[ALT](./includes/erpkey.md)]

May be empty.

## string ERPSaleKey

[!include[ALT](./includes/erpkey.md)]

May be empty.

## String UserLanguageCode

The language the users use in the CRM client. The connector should preferably respond using this language.
.net culture code: "nb-NO", "en-US" etc.

## QuoteAlternativeWithLinesInfo CRMAlternativeWithLines

Read + Write alternative information.

This is the active alternative

<!-- Referenced images -->
[img1]: media/image037.png
