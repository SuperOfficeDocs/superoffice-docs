---
title: POST Agents/Configuration/GetConfigurableScreenDeltasByQuery
id: v1ConfigurationAgent_GetConfigurableScreenDeltasByQuery
---

# POST Agents/Configuration/GetConfigurableScreenDeltasByQuery

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByQuery
```

This method will return a configurablescreen delta matching the properties received from the incomming query







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByQuery?$select=name,department,category/id
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

DeltaQuery 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DeltaQuery |  |  |


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
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByQuery
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DeltaQuery": {
    "RecipeId": "eaque",
    "DeltaStates": [
      "sequi",
      "deserunt"
    ],
    "DeltaTypes": [
      "ullam",
      "blanditiis"
    ],
    "UserGroupIds": [
      3,
      328
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConfigurableScreenDeltaId": 636,
    "Name": "Medhurst Inc and Sons",
    "Description": "Synchronised mission-critical encoding",
    "DeltaJson": "iste",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "quae",
    "UpdatedDate": "1997-06-02T18:28:48.4156236+02:00",
    "CreatedDate": "1996-09-01T18:28:48.4156236+02:00",
    "UpdatedBy": {
      "AssociateId": 345,
      "Name": "Friesen Group",
      "PersonId": 143,
      "Rank": 652,
      "Tooltip": "qui",
      "Type": "AnonymousAssociate",
      "GroupIdx": 17,
      "FullName": "Dr. Antone Buckridge",
      "FormalName": "Dietrich, Borer and Hills",
      "Deleted": false,
      "EjUserId": 797,
      "UserName": "Pouros Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    },
    "CreatedBy": {
      "AssociateId": 515,
      "Name": "Ratke-DuBuque",
      "PersonId": 497,
      "Rank": 822,
      "Tooltip": "in",
      "Type": "AnonymousAssociate",
      "GroupIdx": 903,
      "FullName": "Rylee Rogahn",
      "FormalName": "Prohaska, Wisozk and Collier",
      "Deleted": false,
      "EjUserId": 712,
      "UserName": "Jakubowski LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    },
    "UserGroupIds": [
      100,
      623
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
        "FieldLength": 835
      }
    }
  }
]
```