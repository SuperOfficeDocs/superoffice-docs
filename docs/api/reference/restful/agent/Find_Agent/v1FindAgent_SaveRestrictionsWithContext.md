---
title: POST Agents/Find/SaveRestrictionsWithContext
uid: v1FindAgent_SaveRestrictionsWithContext
---

# POST Agents/Find/SaveRestrictionsWithContext

```http
POST /api/v1/Agents/Find/SaveRestrictionsWithContext
```

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/SaveRestrictionsWithContext?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

StorageType, ProviderName, StorageKey, Restrictions, Context

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| Restrictions | array |  |
| Context | string |  |

## Response

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body:

## Sample request

```http!
POST /api/v1/Agents/Find/SaveRestrictionsWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StorageType": "quas",
  "ProviderName": "Reichert, O'Reilly and O'Kon",
  "StorageKey": "explicabo",
  "Restrictions": [
    {
      "Name": "Reichert-Hirthe",
      "Operator": "in",
      "Values": [
        "sit",
        "eum"
      ],
      "DisplayValues": [
        "doloribus",
        "incidunt"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 188,
      "InterOperator": "And",
      "UniqueHash": 482
    }
  ],
  "Context": "porro"
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
