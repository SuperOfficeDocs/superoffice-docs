---
title: POST Agents/ErpSync/SaveErpSyncConnectorEntity
uid: v1ErpSyncAgent_SaveErpSyncConnectorEntity
---

# POST Agents/ErpSync/SaveErpSyncConnectorEntity

```http
POST /api/v1/Agents/ErpSync/SaveErpSyncConnectorEntity
```

Updates the existing ErpSyncConnectorEntity or creates a new ErpSyncConnectorEntity if the id parameter is empty

## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps

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

## Request Body: entity

The ErpSyncConnectorEntity to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectorId | int32 | Primary key |
| DisplayName | string | Name shown in the list |
| URL | string | The URL where the connector is located and can be called |
| Deleted | bool | True if the connector is deleted |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectorId | int32 | Primary key |
| DisplayName | string | Name shown in the list |
| URL | string | The URL where the connector is located and can be called |
| Deleted | bool | True if the connector is deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/SaveErpSyncConnectorEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ErpConnectorId": 592,
  "DisplayName": "Kling Inc and Sons",
  "URL": "http://www.example.com/",
  "Deleted": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectorId": 264,
  "DisplayName": "Dach, Tromp and Hilpert",
  "URL": "http://www.example.com/",
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 454
    }
  }
}
```
