---
uid: QuoteApproval
title: QuoteApproval
description: Retrieves pending sale quotes for current associate with state approved, denied, approval needed or approval requested
keywords: QuoteApproval archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "QuoteApproval"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider">SuperOffice.CRM.ArchiveLists.QuoteApprovalProvider</see> inside NetServer's SODatabase assembly.

Retrieves pending sale quotes for current associate with state approved, denied, approval needed or approval requested

## Supported Entities
| Name | Description |
| ---- | ----- |
|"approved"|Quotes with state Approved|
|"denied"|Quotes with state Lost|
|"requested"|Quotes with state Needs approval|
|"needsapproval"|Quotes that need approval|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|lastUpdated|date|Last updated| x |
|quoteId|int|Quote ID: Database ID of quote| x |
|quoteVersionId|int|ID: Database ID of QuoteVersion record| x |
|quoteAlternativeVersionId|int|Description: Description of the quote alternative| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|saleStatus|listAny|Status: The status of the sale - open, lost or sold| x |
|quoteVersionState|int|State: The current state the quote is in| x |
|quoteOwnerAssociateId|associate|Quote owner ID| x |
|quoteOwnerAssociateName| *None* |Quote owner|  |
|saleHeading|string|Sale title| x |
|amount|decimal|Amount| x |
|currency|listAny|Currency|  |
|contactId|int|Company ID: Database ID of company| x |
|contactName|string|Company: Displays the company an activity is linked to| x |
|personId|int|Contact ID: Database ID of the contact row| x |
|personName| *None* |Contact: Displays the contact to which an item is linked|  |
|approvedText|string|Approval reason| x |
|approvedByName| *None* |Approved by: Associate who approved a quote that broke one or more of the workflow rules that trigger an approval process|  |
|approvedById|associate|Approved by ID| x |
|quoteReason|string|Quote warning| x |
|requestComment|string|Approval comment| x |
|requestAssociateId|associate|Approval associate| x |
|requestAssociateName| *None* |Approval associate|  |

## Sample

```http!
GET /api/v1/archive/QuoteApproval?$select=quoteVersionState,amount
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

