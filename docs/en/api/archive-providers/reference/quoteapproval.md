---
uid: QuoteApproval
title: QuoteApproval
description: Retrieves pending sale quotes for current associate with state approved, denied, approval needed or approval requested
keywords: QuoteApproval archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteApproval"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider">SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider</see> inside NetServer's SODatabase assembly.

Retrieves pending sale quotes for current associate with state approved, denied, approval needed or approval requested

## Supported Entities
| Name | Description |
| ---- | ----- |
|"approved"|[[SR_ARCHIVE_QUOTE_ENTITY_APPROVED]]|
|"denied"|[[SR_ARCHIVE_QUOTE_ENTITY_DENIED]]|
|"requested"|[[SR_ARCHIVE_QUOTE_ENTITY_REQUESTED]]|
|"needsapproval"|[[SR_ARCHIVE_QUOTE_ENTITY_NEEDS_APPROVAL]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|lastUpdated|date|SR\_SEL\_LAST\_UPDATED| x |
|quoteId|int|SR\_QUOTE\_ID: SR\_QUOTE\_ID\_TOOLTIP| x |
|quoteVersionId|int|SR\_QUOTE\_QUOTEVERSION\_ID: SR\_QUOTE\_QUOTEVERSION\_ID\_TOOLTIP| x |
|quoteAlternativeVersionId|int|SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION: SR\_QUOTE\_QUOTEALTERNATIVE\_DESCRIPTION\_TOOLTIP| x |
|saleId|int|SR\_SALE\_ID: SR\_SALE\_ID\_TOOLTIP| x |
|saleStatus|listAny|SR\_SALEDLG\_STATUS: SR\_SALE\_STATUS\_TOOLTIP| x |
|quoteVersionState|int|SR\_QUOTE\_QUOTEVERSION\_STATE: SR\_QUOTE\_QUOTEVERSION\_STATE\_TOOLTIP| x |
|quoteOwnerAssociateId|associate|SR\_ARCHIVE\_QUOTE\_OWNER\_ID| x |
|quoteOwnerAssociateName| *None* |SR\_ARCHIVE\_QUOTE\_OWNER|  |
|saleHeading|string|SR\_ARCHIVE\_SALE\_TITLE| x |
|amount|decimal|SR\_ARCHIVE\_SALE\_AMOUNT| x |
|currency|listAny|SR\_ARCHIVE\_SALE\_CURRENCY|  |
|contactId|int|SR\_CONTACT\_ID: SR\_CONTACT\_ID\_TOOLTIP| x |
|contactName|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|personId|int|SR\_PERSON\_ID: SR\_PERSON\_ID\_TOOLTIP| x |
|personName| *None* |SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP|  |
|approvedText|string|SR\_ARCHIVE\_QUOTEVERSION\_APPROVED\_TEXT| x |
|approvedByName| *None* |SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY: SR\_QUOTE\_QUOTEVERSION\_APPROVEDBY\_TOOLTIP|  |
|approvedById|associate|SR\_QUOTE\_APPROVED\_BY\_ID| x |
|quoteReason|string|SR\_ARCHIVE\_QUOTE\_WARNING\_REASON| x |
|requestComment|string|SR\_QUOTE\_REQUEST\_APPROVAL\_COMMENT| x |
|requestAssociateId|associate|SR\_ARCHIVE\_QUOTE\_APPROVAL\_ASSOCIATE\_ID| x |
|requestAssociateName| *None* |SR\_ARCHIVE\_QUOTE\_APPROVAL\_ASSOCIATE|  |

## Sample

```http!
GET /api/v1/archive/QuoteApproval?$select=quoteVersionState,amount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

