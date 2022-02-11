---
title: POST Agents/Configuration/GetConfigurableScreenDelta
id: v1ConfigurationAgent_GetConfigurableScreenDelta
---

# POST Agents/Configuration/GetConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta
```

Gets a ConfigurableScreenDelta object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| configurableScreenDeltaId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta?configurableScreenDeltaId=406
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta?$select=name,department,category/id
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDeltaId | int32 |  |
| Name | string |  |
| Description | string |  |
| DeltaJson | string |  |
| DeltaType | string |  |
| DeltaState | string |  |
| RecipeId | string |  |
| UpdatedDate | date-time |  |
| CreatedDate | date-time |  |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UserGroupIds | array |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 657,
  "Name": "Hoppe-Gutmann",
  "Description": "Proactive holistic extranet",
  "DeltaJson": "sed",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "qui",
  "UpdatedDate": "2014-03-02T18:28:48.4116241+01:00",
  "CreatedDate": "2019-12-22T18:28:48.4116241+01:00",
  "UpdatedBy": {
    "AssociateId": 954,
    "Name": "Nitzsche LLC",
    "PersonId": 189,
    "Rank": 829,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 725,
    "FullName": "Donna Wisoky",
    "FormalName": "Skiles, Harber and Pagac",
    "Deleted": false,
    "EjUserId": 957,
    "UserName": "Berge LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage enterprise metrics"
        },
        "FieldType": "System.Int32",
        "FieldLength": 650
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 628,
    "Name": "Wunsch LLC",
    "PersonId": 156,
    "Rank": 177,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 977,
    "FullName": "Laney Blanda",
    "FormalName": "McClure, White and Doyle",
    "Deleted": true,
    "EjUserId": 649,
    "UserName": "Mante, Oberbrunner and Orn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 521
      }
    }
  },
  "UserGroupIds": [
    123,
    546
  ],
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
      "FieldLength": 13
    }
  }
}
```