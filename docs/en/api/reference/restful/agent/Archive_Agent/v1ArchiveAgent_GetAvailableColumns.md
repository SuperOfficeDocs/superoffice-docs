---
title: POST Agents/Archive/GetAvailableColumns
uid: v1ArchiveAgent_GetAvailableColumns
---

# POST Agents/Archive/GetAvailableColumns

```http
POST /api/v1/Agents/Archive/GetAvailableColumns
```

Return list of all columns supported by an archive provider.


See also GetArchiveConfiguration.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetAvailableColumns?$select=name,department,category/id
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

ProviderName, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Context | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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

## Sample request

```http!
POST /api/v1/Agents/Archive/GetAvailableColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Lehner Inc and Sons",
  "Context": "explicabo"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Mayer, Rohan and Barton",
    "DisplayTooltip": "est",
    "DisplayType": "libero",
    "CanOrderBy": false,
    "Name": "Yundt, Hirthe and Grimes",
    "CanRestrictBy": false,
    "RestrictionType": "labore",
    "RestrictionListName": "Hodkiewicz-Wuckert",
    "IsVisible": true,
    "ExtraInfo": "officia",
    "Width": "rem",
    "IconHint": "omnis",
    "HeadingIconHint": "voluptas"
  }
]
```