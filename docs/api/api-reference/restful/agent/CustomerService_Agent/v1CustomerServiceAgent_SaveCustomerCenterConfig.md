---
title: SaveCustomerCenterConfig
id: v1CustomerServiceAgent_SaveCustomerCenterConfig
---

# SaveCustomerCenterConfig

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
| CustConfigId | int32 | Primary key |
| Type | string | What kind of data is in this row |
| Config | string | A JSON-formatted config |
| CustLangId | int32 | The customer language which this config belongs to. 0 indicates that the config is global |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |


## Response: object

Contains configuration when displaying the Customer Center



Carrier object for CustomerCenterConfig.
Services for the CustomerCenterConfig Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CustomerService/SaveCustomerCenterConfig
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "CustConfigId": 767,
  "Type": "Options",
  "Config": "id",
  "CustLangId": 615,
  "Registered": "2003-11-26T14:58:03.7524323+01:00",
  "RegisteredAssociateId": 837,
  "Updated": "1995-08-16T14:58:03.7524323+02:00",
  "UpdatedAssociateId": 179
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CustConfigId": 279,
  "Type": "Options",
  "Config": "debitis",
  "CustLangId": 432,
  "Registered": "1997-11-03T14:58:03.75346+01:00",
  "RegisteredAssociateId": 350,
  "Updated": "2005-04-27T14:58:03.75346+02:00",
  "UpdatedAssociateId": 93,
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
      "FieldLength": 966
    }
  }
}
```