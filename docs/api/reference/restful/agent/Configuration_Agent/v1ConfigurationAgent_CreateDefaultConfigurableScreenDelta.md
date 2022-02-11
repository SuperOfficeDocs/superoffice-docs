---
title: POST Agents/Configuration/CreateDefaultConfigurableScreenDelta
id: v1ConfigurationAgent_CreateDefaultConfigurableScreenDelta
---

# POST Agents/Configuration/CreateDefaultConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/CreateDefaultConfigurableScreenDelta
```

Set default values into a new ConfigurableScreenDelta.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Configuration/CreateDefaultConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 783,
  "Name": "Collins, Herman and Homenick",
  "Description": "Vision-oriented logistical extranet",
  "DeltaJson": "amet",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "voluptate",
  "UpdatedDate": "2018-10-17T18:28:48.400623+02:00",
  "CreatedDate": "2011-08-28T18:28:48.400623+02:00",
  "UpdatedBy": {
    "AssociateId": 403,
    "Name": "Pfeffer, Romaguera and Kilback",
    "PersonId": 158,
    "Rank": 967,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 854,
    "FullName": "Elsa Blanda",
    "FormalName": "Fahey-Crooks",
    "Deleted": false,
    "EjUserId": 10,
    "UserName": "Ratke, Orn and Nader",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 444
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 974,
    "Name": "Feil, Kerluke and Gorczany",
    "PersonId": 184,
    "Rank": 245,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 132,
    "FullName": "Linnea Rutherford",
    "FormalName": "Barton, Connelly and Conroy",
    "Deleted": true,
    "EjUserId": 1001,
    "UserName": "Rath-Frami",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 361
      }
    }
  },
  "UserGroupIds": [
    662,
    735
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "visualize real-time models"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 808
    }
  }
}
```