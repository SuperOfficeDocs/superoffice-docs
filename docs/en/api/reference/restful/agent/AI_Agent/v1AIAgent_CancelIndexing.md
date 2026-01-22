---
title: POST Agents/AI/CancelIndexing
uid: v1AIAgent_CancelIndexing
generated: true
content_type: reference
---

# POST Agents/AI/CancelIndexing

```http
POST /api/v1/Agents/AI/CancelIndexing
```

Cancel the current re-indexing job on a given namespace.


Leaves data in inconsistent state, because removal of old data is skipped.
NsApiSlow threshold: 1000 ms.


## Experimental: ## The AI agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/CancelIndexing?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

NamespaceName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NamespaceName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RagStatus

| Property Name | Type |  Description |
|----------------|------|--------------|
| StartedAt | date-time | UTC timestamp - when content indexeing started. |
| CompletedAt | date-time | UTC timestamp - when content indexing finished. |
| NamespaceName | string | Namespace the status belongs to. |
| CurrentRunTag | string | Unique identifier for current indexing job. |
| IsCompleted | bool | Is the indexing run finished? |
| IsCancelled | bool | Was the indexing cancelled before completion? |
| LastIndexed | date-time | UTC timestamp - when last content was added/updated to index. |
| StatusAll | RagStatusChunks | How many documents/chunks are in the index - sum of all the other types |
| StatusDocuments | RagStatusChunks | How many documents/chunks of type Document are in the index |
| StatusFAQ | RagStatusChunks | How many documents/chunks of type FAQ are in the index |
| StatusNone | RagStatusChunks | How many documents/chunks of type None are in the index |
| StatusProduct | RagStatusChunks | How many documents/chunks of type Product are in the index |
| StatusTicket | RagStatusChunks | How many documents/chunks of type Ticket are in the index |
| StatusWebpage | RagStatusChunks | How many documents/chunks of type Webpage are in the index |
| StatusWebsite | RagStatusChunks | How many documents/chunks of type Website are in the index |

## Sample request

[!include[sample request](../../samples/agent/request/v1AIAgent_CancelIndexing.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1AIAgent_CancelIndexing.md)]