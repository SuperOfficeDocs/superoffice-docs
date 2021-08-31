---
title: GetDefaultDesiredColumns
id: v1FindAgent_GetDefaultDesiredColumns
---

# GetDefaultDesiredColumns

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumns
```

Calculate the default desired columns, i.

e., the result columns for a given search. The search is defined by a storage type, provider name and storage key, which are used to fetch the corresponding restrictions from the database (in the same way as Find does). If you want to specify the restriction directly, use the GetDefaultDesiredColumnsFromRestrictions method instead. This is the algorithm that is used by the Find service method.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumns?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |


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
POST /api/v1/Agents/Find/GetDefaultDesiredColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "dignissimos",
  "ProviderName": "Trantow LLC",
  "StorageKey": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Fay-Yost",
    "DisplayTooltip": "vero",
    "DisplayType": "sunt",
    "CanOrderBy": false,
    "Name": "Kub LLC",
    "CanRestrictBy": false,
    "RestrictionType": "vitae",
    "RestrictionListName": "Hahn-Metz",
    "IsVisible": false,
    "ExtraInfo": "earum",
    "Width": "debitis",
    "IconHint": "veritatis",
    "HeadingIconHint": "est"
  }
]
```