---
title: POST Agents/Configuration/GetConfigurableScreenDeltasByDelta
id: v1ConfigurationAgent_GetConfigurableScreenDeltasByDelta
---

# POST Agents/Configuration/GetConfigurableScreenDeltasByDelta

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta
```

This method will return a configurablescreen delta matching the properties received from the incomming delta







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta?$select=name,department,category/id
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

ConfigurableScreenDelta 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDelta |  |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDelta": {
    "ConfigurableScreenDeltaId": 466,
    "Name": "Pfannerstill, Lind and Corwin",
    "Description": "Innovative full-range core",
    "DeltaJson": "beatae",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "ad",
    "UpdatedDate": "2017-11-18T18:28:48.4126252+01:00",
    "CreatedDate": "2003-12-04T18:28:48.4126252+01:00",
    "UpdatedBy": {},
    "CreatedBy": {},
    "UserGroupIds": [
      464,
      646
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConfigurableScreenDeltaId": 121,
    "Name": "Dicki-Dare",
    "Description": "Compatible modular time-frame",
    "DeltaJson": "ut",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "dolor",
    "UpdatedDate": "2001-11-04T18:28:48.4136241+01:00",
    "CreatedDate": "2021-04-02T18:28:48.4136241+02:00",
    "UpdatedBy": {
      "AssociateId": 209,
      "Name": "Flatley-Stamm",
      "PersonId": 171,
      "Rank": 16,
      "Tooltip": "asperiores",
      "Type": "AnonymousAssociate",
      "GroupIdx": 724,
      "FullName": "Zola Boehm",
      "FormalName": "Watsica-Weimann",
      "Deleted": false,
      "EjUserId": 772,
      "UserName": "Johns, Murphy and Grimes",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    },
    "CreatedBy": {
      "AssociateId": 960,
      "Name": "Bernier Group",
      "PersonId": 688,
      "Rank": 305,
      "Tooltip": "et",
      "Type": "AnonymousAssociate",
      "GroupIdx": 706,
      "FullName": "Brooks Hahn",
      "FormalName": "Bosco, Macejkovic and Rowe",
      "Deleted": true,
      "EjUserId": 641,
      "UserName": "Swift-Legros",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement web-enabled supply-chains"
          },
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    },
    "UserGroupIds": [
      912,
      335
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
        "FieldLength": 925
      }
    }
  }
]
```