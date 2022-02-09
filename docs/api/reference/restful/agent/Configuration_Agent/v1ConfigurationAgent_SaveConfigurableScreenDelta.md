---
title: POST Agents/Configuration/SaveConfigurableScreenDelta
id: v1ConfigurationAgent_SaveConfigurableScreenDelta
---

# POST Agents/Configuration/SaveConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/SaveConfigurableScreenDelta
```

Updates the existing ConfigurableScreenDelta or creates a new ConfigurableScreenDelta if the id parameter is empty








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

The ConfigurableScreenDelta to be saved. 

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
POST /api/v1/Agents/Configuration/SaveConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 576,
  "Name": "Bergstrom-Funk",
  "Description": "Profound hybrid algorithm",
  "DeltaJson": "eum",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "quos",
  "UpdatedDate": "2010-01-23T18:28:48.400623+01:00",
  "CreatedDate": "2020-09-17T18:28:48.4016232+02:00",
  "UpdatedBy": {
    "AssociateId": 911,
    "Name": "Gerlach, Lynch and Abernathy",
    "PersonId": 105,
    "Rank": 880,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 601,
    "FullName": "Horace Reichel",
    "FormalName": "Satterfield, Altenwerth and Wiegand",
    "Deleted": true,
    "EjUserId": 570,
    "UserName": "Watsica-Frami"
  },
  "CreatedBy": {
    "AssociateId": 62,
    "Name": "Doyle, Stamm and Armstrong",
    "PersonId": 380,
    "Rank": 619,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 655,
    "FullName": "Oliver Reynolds",
    "FormalName": "Bode Group",
    "Deleted": false,
    "EjUserId": 561,
    "UserName": "Cummings-Bechtelar"
  },
  "UserGroupIds": [
    892,
    598
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 591,
  "Name": "Bauch Group",
  "Description": "Upgradable tertiary secured line",
  "DeltaJson": "temporibus",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "praesentium",
  "UpdatedDate": "2005-06-07T18:28:48.4026517+02:00",
  "CreatedDate": "2020-09-14T18:28:48.4026517+02:00",
  "UpdatedBy": {
    "AssociateId": 828,
    "Name": "Christiansen, Klocko and Heaney",
    "PersonId": 322,
    "Rank": 87,
    "Tooltip": "excepturi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 138,
    "FullName": "Sienna Stark",
    "FormalName": "Ferry Inc and Sons",
    "Deleted": false,
    "EjUserId": 500,
    "UserName": "Heaney Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 368
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 74,
    "Name": "Rutherford-Buckridge",
    "PersonId": 245,
    "Rank": 921,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 640,
    "FullName": "Leanna D'Amore",
    "FormalName": "Kutch Group",
    "Deleted": false,
    "EjUserId": 111,
    "UserName": "Grant, Weber and Bauch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate dynamic web services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 702
      }
    }
  },
  "UserGroupIds": [
    879,
    519
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
      "FieldLength": 496
    }
  }
}
```