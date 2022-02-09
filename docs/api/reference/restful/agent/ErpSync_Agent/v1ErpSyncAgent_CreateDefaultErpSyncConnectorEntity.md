---
title: POST Agents/ErpSync/CreateDefaultErpSyncConnectorEntity
id: v1ErpSyncAgent_CreateDefaultErpSyncConnectorEntity
---

# POST Agents/ErpSync/CreateDefaultErpSyncConnectorEntity

```http
POST /api/v1/Agents/ErpSync/CreateDefaultErpSyncConnectorEntity
```

Set default values into a new ErpSyncConnectorEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Erp connector information



Carrier object for ErpSyncConnectorEntity.
Services for the ErpSyncConnectorEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IErpSyncAgent">ErpSync Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectorId | int32 | Primary key |
| DisplayName | string | Name shown in the list |
| URL | string | The URL where the connector is located and can be called |
| Deleted | bool | True if the connector is deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ErpSync/CreateDefaultErpSyncConnectorEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectorId": 799,
  "DisplayName": "Ebert-Feest",
  "URL": "http://www.example.com/",
  "Deleted": false,
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
      "FieldType": "System.Int32",
      "FieldLength": 910
    }
  }
}
```