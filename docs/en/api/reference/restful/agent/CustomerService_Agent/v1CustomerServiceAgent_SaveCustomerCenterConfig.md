---
title: POST Agents/CustomerService/SaveCustomerCenterConfig
uid: v1CustomerServiceAgent_SaveCustomerCenterConfig
generated: true
---

# POST Agents/CustomerService/SaveCustomerCenterConfig

```http
POST /api/v1/Agents/CustomerService/SaveCustomerCenterConfig
```

Updates the existing CustomerCenterConfig or creates a new CustomerCenterConfig if the id parameter is empty








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

The CustomerCenterConfig to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CustConfigId | Integer | Primary key |
| Type | String | What kind of data is in this row |
| Config | String | A JSON-formatted config |
| CustLangId | Integer | The customer language which this config belongs to. 0 indicates that the config is global |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CustomerCenterConfig

| Property Name | Type |  Description |
|----------------|------|--------------|
| CustConfigId | int32 | Primary key |
| Type | string | What kind of data is in this row |
| Config | string | A JSON-formatted config |
| CustLangId | int32 | The customer language which this config belongs to. 0 indicates that the config is global |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/SaveCustomerCenterConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CustConfigId": 340,
  "Type": "Options",
  "Config": "nihil",
  "CustLangId": 810,
  "Registered": "2005-06-09T02:38:21.182685+02:00",
  "RegisteredAssociateId": 314,
  "Updated": "2016-05-15T02:38:21.182685+02:00",
  "UpdatedAssociateId": 329
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CustConfigId": 416,
  "Type": "Options",
  "Config": "nihil",
  "CustLangId": 87,
  "Registered": "2024-09-20T02:38:21.182685+02:00",
  "RegisteredAssociateId": 75,
  "Updated": "1999-09-12T02:38:21.182685+02:00",
  "UpdatedAssociateId": 208,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 308
    }
  }
}
```