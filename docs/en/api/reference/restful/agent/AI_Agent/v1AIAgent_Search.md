---
title: POST Agents/AI/Search
uid: v1AIAgent_Search
generated: true
content_type: reference
---

# POST Agents/AI/Search

```http
POST /api/v1/Agents/AI/Search
```

Returns semantic search results from vector database.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/Search?$select=name,department,category/id
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

NamespaceName, Query, Type, Top 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NamespaceName | String |  |
| Query | String |  |
| Type | String |  |
| Top | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Chunk | string | Markdown text that matched query. |
| Title | string | Title or filename of matched document, extracted from the Metadata |
| Id | string | Matched document's unique id. Typically a URI. |
| Type | string | Content type (web/faq/ticket/...) |
| Score | double | Relevancy score (0-1). How close this chunk of the document matched the query. |
| Metadata | object | Dictionary of metadata for this result. Keys depend on the source of the document. e.g. 'Title', 'Filename', 'Url', etc. |

## Sample request

```http!
POST /api/v1/Agents/AI/Search
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "NamespaceName": "Ratke, Harris and Mann",
  "Query": "eos",
  "Type": "Document",
  "Top": 571
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Chunk": "consectetur",
    "Title": "cupiditate",
    "Id": "error",
    "Type": "Document",
    "Score": 16585.128,
    "Metadata": {
      "fieldName": {}
    }
  },
  {
    "Chunk": "consectetur",
    "Title": "cupiditate",
    "Id": "error",
    "Type": "Document",
    "Score": 16585.128,
    "Metadata": {
      "fieldName": {}
    }
  }
]
```