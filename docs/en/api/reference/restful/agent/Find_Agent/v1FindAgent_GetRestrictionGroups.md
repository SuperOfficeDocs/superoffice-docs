---
title: POST Agents/Find/GetRestrictionGroups
uid: v1FindAgent_GetRestrictionGroups
---

# POST Agents/Find/GetRestrictionGroups

```http
POST /api/v1/Agents/Find/GetRestrictionGroups
```

Return all the restriction groups.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetRestrictionGroups?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| Context | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Description | string |  |
| Rank | int32 |  |
| Restrictions | array |  |

## Sample request

```http!
POST /api/v1/Agents/Find/GetRestrictionGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "eos",
  "ProviderName": "Hilpert LLC",
  "StorageKey": "consequatur",
  "Context": "voluptatibus"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Mitchell Group",
    "Description": "Open-architected neutral projection",
    "Rank": 422,
    "Restrictions": [
      {
        "Name": "Schumm, Waelchi and Lang",
        "Operator": "sed",
        "Values": [
          "aperiam",
          "voluptas"
        ],
        "DisplayValues": [
          "laboriosam",
          "ipsa"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 815,
        "InterOperator": "And",
        "UniqueHash": 85
      }
    ]
  },
  {
    "Name": "Mitchell Group",
    "Description": "Open-architected neutral projection",
    "Rank": 422,
    "Restrictions": [
      {
        "Name": "Schumm, Waelchi and Lang",
        "Operator": "sed",
        "Values": [
          "aperiam",
          "voluptas"
        ],
        "DisplayValues": [
          "laboriosam",
          "ipsa"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 815,
        "InterOperator": "And",
        "UniqueHash": 85
      }
    ]
  }
]
```