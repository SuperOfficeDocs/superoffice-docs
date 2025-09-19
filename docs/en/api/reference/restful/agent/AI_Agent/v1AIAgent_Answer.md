---
title: POST Agents/AI/Answer
uid: v1AIAgent_Answer
generated: true
content_type: reference
---

# POST Agents/AI/Answer

```http
POST /api/v1/Agents/AI/Answer
```

Returns an answer.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/Answer?$select=name,department,category/id
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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RagAnswer

| Property Name | Type |  Description |
|----------------|------|--------------|
| Answer | string | Response to the question |
| Source | array | Array of sources used to ground the answer. Each source has a chunk of text, relevancy score, title. |
| TrackingId | string | Unique identifier for this answer. Used for correlating feedback to answers |

## Sample request

```http!
POST /api/v1/Agents/AI/Answer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "NamespaceName": "Hagenes-Murphy",
  "Query": "inventore",
  "Type": "Document",
  "Top": 622
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Answer": "laboriosam",
  "Source": [
    {
      "Chunk": "iusto",
      "Title": "earum",
      "Id": "praesentium",
      "Type": "Document",
      "Score": 22461.378,
      "Metadata": {
        "fieldName": {}
      }
    },
    {
      "Chunk": "iusto",
      "Title": "earum",
      "Id": "praesentium",
      "Type": "Document",
      "Score": 22461.378,
      "Metadata": {
        "fieldName": {}
      }
    }
  ],
  "TrackingId": "id"
}
```