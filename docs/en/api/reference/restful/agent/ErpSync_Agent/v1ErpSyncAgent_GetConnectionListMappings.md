---
title: POST Agents/ErpSync/GetConnectionListMappings
uid: v1ErpSyncAgent_GetConnectionListMappings
generated: true
content_type: reference
---

# POST Agents/ErpSync/GetConnectionListMappings

```http
POST /api/v1/Agents/ErpSync/GetConnectionListMappings
```

Returns the listmappings for the specified connection.


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetConnectionListMappings?$select=name,department,category/id
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

ErpConnectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ErpConnectionListMappingContainer

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpListItemMappings | array | Array of ErpConnectionListMapping |
| ErpConnectionId | int32 | Primary key |
| ErpConnectionName | string | The name of the erp connection |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetConnectionListMappings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 994
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpListItemMappings": [
    {
      "CrmList": null,
      "ErpListName": "Yundt-Bednar",
      "ErpCrmListItemMappings": [
        {},
        {}
      ],
      "ErpActorTypeName": "Batz Group",
      "ErpFieldId": 780,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "ErpConnectionId": 380,
  "ErpConnectionName": "Schowalter, Lueilwitz and Beer",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 193
    }
  }
}
```