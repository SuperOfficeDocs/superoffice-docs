---
title: POST Agents/Find/SaveRestrictions
uid: v1FindAgent_SaveRestrictions
---

# POST Agents/Find/SaveRestrictions

```http
POST /api/v1/Agents/Find/SaveRestrictions
```

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/SaveRestrictions?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| Restrictions | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/Find/SaveRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "illum",
  "ProviderName": "Kessler-Mayer",
  "StorageKey": "maiores",
  "Restrictions": [
    {
      "Name": "Huels Group",
      "Operator": "deleniti",
      "Values": [
        "beatae",
        "et"
      ],
      "DisplayValues": [
        "voluptatem",
        "eos"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 608,
      "InterOperator": "And",
      "UniqueHash": 111
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```