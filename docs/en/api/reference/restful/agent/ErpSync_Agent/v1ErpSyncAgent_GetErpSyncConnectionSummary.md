---
title: POST Agents/ErpSync/GetErpSyncConnectionSummary
uid: v1ErpSyncAgent_GetErpSyncConnectionSummary
generated: true
---

# POST Agents/ErpSync/GetErpSyncConnectionSummary

```http
POST /api/v1/Agents/ErpSync/GetErpSyncConnectionSummary
```

Get a summary of the current ErpSync configuration/setup


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetErpSyncConnectionSummary?$select=name,department,category/id
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

ErpSyncConnectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpSyncConnectionId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ErpSyncConnectionSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayName | string | Connection name shown to user; multi-language support |
| DisplayDescription | string | Tooltip/description shown to user; multi-language support |
| Active | bool | Is the connection currently active |
| Deleted | bool | Is the connection deleted |
| LastSync | date-time | The time of the last sync |
| Actors | array | Summaries of the configuration of the actors configured for this connection |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetErpSyncConnectionSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpSyncConnectionId": 408
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DisplayName": "Schuster-Kris",
  "DisplayDescription": "Optimized even-keeled encryption",
  "Active": false,
  "Deleted": true,
  "LastSync": "2016-11-21T03:45:23.4517052+01:00",
  "Actors": [
    {
      "ActorType": "Customer",
      "HasMappings": true,
      "Defaults": "tenetur",
      "Mappings": "id",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    },
    {
      "ActorType": "Customer",
      "HasMappings": true,
      "Defaults": "tenetur",
      "Mappings": "id",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 670
    }
  }
}
```