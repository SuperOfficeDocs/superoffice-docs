---
title: POST Agents/Configuration/SaveAndPublish
id: v1ConfigurationAgent_SaveAndPublish
---

# POST Agents/Configuration/SaveAndPublish

```http
POST /api/v1/Agents/Configuration/SaveAndPublish
```

Save the incomming draft and publish







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/SaveAndPublish?$select=name,department,category/id
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
POST /api/v1/Agents/Configuration/SaveAndPublish
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDelta": {
    "ConfigurableScreenDeltaId": 424,
    "Name": "Vandervort, Schowalter and McDermott",
    "Description": "Centralized full-range paradigm",
    "DeltaJson": "exercitationem",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "aspernatur",
    "UpdatedDate": "2005-07-14T18:28:48.4166521+02:00",
    "CreatedDate": "2002-02-08T18:28:48.4166521+01:00",
    "UpdatedBy": {},
    "CreatedBy": {},
    "UserGroupIds": [
      199,
      379
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 302,
  "Name": "Jones, Nader and Simonis",
  "Description": "Digitized dedicated data-warehouse",
  "DeltaJson": "provident",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "reprehenderit",
  "UpdatedDate": "2005-06-29T18:28:48.4176522+02:00",
  "CreatedDate": "2015-12-14T18:28:48.4176522+01:00",
  "UpdatedBy": {
    "AssociateId": 129,
    "Name": "Nicolas LLC",
    "PersonId": 153,
    "Rank": 848,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 390,
    "FullName": "Dr. Clemmie Treutel",
    "FormalName": "Klein-Rodriguez",
    "Deleted": true,
    "EjUserId": 819,
    "UserName": "White-McGlynn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 556
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 868,
    "Name": "Walker-Buckridge",
    "PersonId": 796,
    "Rank": 380,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 281,
    "FullName": "Alfonso Mann",
    "FormalName": "Lebsack-Klein",
    "Deleted": false,
    "EjUserId": 442,
    "UserName": "Gleason Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 71
      }
    }
  },
  "UserGroupIds": [
    693,
    574
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
      "FieldType": "System.Int32",
      "FieldLength": 626
    }
  }
}
```