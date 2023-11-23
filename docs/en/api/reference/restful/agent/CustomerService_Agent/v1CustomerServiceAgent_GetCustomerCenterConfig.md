---
title: POST Agents/CustomerService/GetCustomerCenterConfig
uid: v1CustomerServiceAgent_GetCustomerCenterConfig
generated: true
---

# POST Agents/CustomerService/GetCustomerCenterConfig

```http
POST /api/v1/Agents/CustomerService/GetCustomerCenterConfig
```

Gets a CustomerCenterConfig object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| customerCenterConfigId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetCustomerCenterConfig?customerCenterConfigId=50
POST /api/v1/Agents/CustomerService/GetCustomerCenterConfig?$select=name,department,category/id
```


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
POST /api/v1/Agents/CustomerService/GetCustomerCenterConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CustConfigId": 202,
  "Type": "Options",
  "Config": "consequatur",
  "CustLangId": 283,
  "Registered": "2021-04-15T13:38:13.3896326+02:00",
  "RegisteredAssociateId": 625,
  "Updated": "2015-06-01T13:38:13.3896326+02:00",
  "UpdatedAssociateId": 578,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 616
    }
  }
}
```