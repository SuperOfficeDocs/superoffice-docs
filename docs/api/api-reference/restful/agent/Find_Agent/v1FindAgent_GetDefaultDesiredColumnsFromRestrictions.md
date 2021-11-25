---
title: POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions
id: v1FindAgent_GetDefaultDesiredColumnsFromRestrictions
---

# POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions
```

Calculate the default desired columns, i.

e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions?$select=name,department,category/id
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

ProviderName, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Restrictions | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayName | string |  |
| DisplayTooltip | string |  |
| DisplayType | string |  |
| CanOrderBy | bool |  |
| Name | string |  |
| CanRestrictBy | bool |  |
| RestrictionType | string |  |
| RestrictionListName | string |  |
| IsVisible | bool |  |
| ExtraInfo | string |  |
| Width | string |  |
| IconHint | string |  |
| HeadingIconHint | string |  |

## Sample Request

```http!
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Hintz-Sawayn",
  "Restrictions": [
    {
      "Name": "Lesch Inc and Sons",
      "Operator": "et",
      "Values": [
        "et",
        "officia"
      ],
      "DisplayValues": [
        "sequi",
        "quis"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 270,
      "InterOperator": "And",
      "UniqueHash": 114
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Quigley-Waters",
    "DisplayTooltip": "non",
    "DisplayType": "voluptas",
    "CanOrderBy": true,
    "Name": "Mueller Inc and Sons",
    "CanRestrictBy": false,
    "RestrictionType": "doloremque",
    "RestrictionListName": "Haag-Sanford",
    "IsVisible": true,
    "ExtraInfo": "consectetur",
    "Width": "commodi",
    "IconHint": "debitis",
    "HeadingIconHint": "facere"
  }
]
```