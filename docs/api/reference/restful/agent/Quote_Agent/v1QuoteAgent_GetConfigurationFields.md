---
title: POST Agents/Quote/GetConfigurationFields
id: v1QuoteAgent_GetConfigurationFields
---

# POST Agents/Quote/GetConfigurationFields

```http
POST /api/v1/Agents/Quote/GetConfigurationFields
```

Used by ADMIN.

Asks for metadata needed to populate admin dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in SuperOffice db and used when InitializeConnector is called by the client.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetConfigurationFields?$select=name,department,category/id
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

ConnectionId, ConnectorName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionId | int32 |  |
| ConnectorName | string |  |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldKey | string | Internal key/name of the field. Used as the key in the ConnectionConfigField values when TestConnection is called. |
| Rank | int32 | A way to set the order of the fields. Lowest value will be displayed first/over the fields with other values. |
| DisplayName | string | Localized field name – shown in the GUI |
| DisplayDescription | string | Tooltip for the field name. |
| FieldType | string | String, int, decimal, etc. |
| ListName | string | MDO List provider name for list fields |
| DefaultValue | string | A default value for the field. |
| MaxLength | int32 | Maximum length for strings, if set. 0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.) |
| Access | string | Access restrictions on the field |
| ShowInSearch | bool | True if this field is displayed in search result |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/GetConfigurationFields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionId": 259,
  "ConnectorName": "Feil-Stehr"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "fieldName": {
    "FieldKey": "cum",
    "Rank": 532,
    "DisplayName": "Pagac, Morissette and Littel",
    "DisplayDescription": "Phased object-oriented budgetary management",
    "FieldType": "Checkbox",
    "ListName": "DuBuque Group",
    "DefaultValue": "voluptate",
    "MaxLength": 40,
    "Access": "Mandatory",
    "ShowInSearch": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 43
      }
    }
  }
}
```