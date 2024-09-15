---
uid: table-Quote
title: Quote table
description: Quote root level, at most one per Sale, always connected to one Sale
so.generated: true
keywords: database table Quote
so.topic: reference
so.envir: onsite, online
---

# Quote Table (34)

Quote root level, at most one per Sale, always connected to one Sale

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quote\_id|Primary key|PK| |
|SaleId|The foreign key to the corresponding sale|FK [sale](sale.md)|&#x25CF;|
|QuoteConnectionId|The connection in the CRM system to where this quote came from. Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection.|FK [QuoteConnection](quoteconnection.md)|&#x25CF;|
|ERPQuoteKey|Foreign key of quote (if available). The key in the ERP system that identifies this sale&apos;s Quote (as opposed to the later Order information)|String(254)|&#x25CF;|
|ERPOrderKey|The key in the ERP system that identifies this sale&apos;s Order, as transferred and possibly later edited in the ERP system.  Only filled out if there exists a corresponding order representation of the quote in the ERP system.|String(254)|&#x25CF;|
|ActiveQuoteVersionId|The primary key of the Quote Version that is currently active. (The active version will always be the latest version.)|FK [QuoteVersion](quoteversion.md)|&#x25CF;|
|AcceptedQuoteAlternativeId|The primary key of the Quote Alternative which was finally accepted by the customer. Set when the user is marking a quote as accepted.|FK [QuoteAlternative](quotealternative.md)|&#x25CF;|
|UseValuesFromQuote|If true, then the Earning, Earning_Percent and Amount fields are populated from the QuoteVersion.QuoteAlternative (current revision, most-likely alternative).|Bool|&#x25CF;|
|DocumentId|The ID of the main Quote Document|FK [document](document.md)|&#x25CF;|
|PreferredEmailCulture|When emails are sent (offer or confirmation), a language can be chosen in the GUI; this field saves the most recent choice and can be used to default the next such choice. Default-default is user&apos;s current language|String(19)|&#x25CF;|
|PoNumber|Customer&apos;s Purchase order number|String(127)|&#x25CF;|
|OrderComment|A comment that is intended for the Invoice, Order, Packing list and similar stages - AFTER the quote has become an order and goes to ERP for processing|String(2046)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Quote table relationship diagram](./media/Quote.png)

[!include[details](./includes/quote.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quote\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[document](document.md)  |Documents, this table is an extension of the Appointment table.  There is always a corresponding appointment record; the relation between appointment and document is navigable in both directions. A document-type appointment record always has a corresponding document record and a record in VisibleFor specifying who may see this.   |
|[QuoteAlternative](quotealternative.md)  |Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version. The reason we have alternatives is that a quote can say to a customer, “we can solve you problem in two (or more) different ways, with different technology and sideeffects (and price)”. An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount , Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed. |
|[QuoteConnection](quoteconnection.md)  |Primary key in the CRM database. Definition of a connection to an external system, for the Quote system. |
|[QuoteVersion](quoteversion.md)  |There may be multiple Versions of a Quote, with one of them active |
|[sale](sale.md)  |Sales  For every Sale record edited through the SuperOffice GUI, a copy of the current version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.   |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.

