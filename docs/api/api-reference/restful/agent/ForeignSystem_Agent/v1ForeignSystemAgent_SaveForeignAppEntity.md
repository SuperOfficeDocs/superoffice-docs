---
title: SaveForeignAppEntity
id: v1ForeignSystemAgent_SaveForeignAppEntity
---

# SaveForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
```

Updates the existing ForeignAppEntity or creates a new ForeignAppEntity if the id parameter is empty








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

The ForeignAppEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |


## Response: object

Carrier object for ForeignAppEntity.
Services for the ForeignAppEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 901,
  "Name": "Hermann, O'Kon and Harvey",
  "CreatedDate": "2006-08-29T14:58:04.29146+02:00",
  "UpdatedDate": "2018-06-15T14:58:04.29146+02:00",
  "CreatedBy": {
    "AssociateId": 389,
    "Name": "Huel-Kohler",
    "PersonId": 455,
    "Rank": 982,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 813,
    "FullName": "Halle Ritchie",
    "FormalName": "Grimes, Bernhard and Bashirian",
    "Deleted": false,
    "EjUserId": 753,
    "UserName": "Schoen-Daniel"
  },
  "UpdatedBy": {
    "AssociateId": 814,
    "Name": "Torp-Hansen",
    "PersonId": 657,
    "Rank": 204,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 104,
    "FullName": "Alfreda Murray",
    "FormalName": "Adams-Hammes",
    "Deleted": true,
    "EjUserId": 311,
    "UserName": "Hirthe-Wisoky"
  },
  "Devices": [
    {
      "ForeignDeviceId": 595,
      "Name": "Bruen-Fadel",
      "CreatedDate": "2008-09-13T14:58:04.29146+02:00",
      "UpdatedDate": "2005-03-06T14:58:04.29146+01:00",
      "AssociateFullName": "Emiliano Cormier",
      "CreatedBy": "aspernatur",
      "UpdatedBy": "numquam",
      "DeviceIdentifier": "ut",
      "ForeignAppId": 583
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 494,
  "Name": "Watsica Inc and Sons",
  "CreatedDate": "1998-08-12T14:58:04.2934661+02:00",
  "UpdatedDate": "2010-06-21T14:58:04.2934661+02:00",
  "CreatedBy": {
    "AssociateId": 495,
    "Name": "Fay Inc and Sons",
    "PersonId": 98,
    "Rank": 547,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 629,
    "FullName": "Marquise Hane",
    "FormalName": "Wiza, Prosacco and Volkman",
    "Deleted": true,
    "EjUserId": 441,
    "UserName": "Shields-Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 841
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 134,
    "Name": "McLaughlin Group",
    "PersonId": 43,
    "Rank": 430,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 727,
    "FullName": "Maxine Pacocha",
    "FormalName": "Williamson Inc and Sons",
    "Deleted": false,
    "EjUserId": 700,
    "UserName": "Pfannerstill Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 218
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 898,
      "Name": "Klein, McClure and Christiansen",
      "CreatedDate": "2000-07-25T14:58:04.2934661+02:00",
      "UpdatedDate": "2009-08-03T14:58:04.2934661+02:00",
      "AssociateFullName": "Desiree Jenkins",
      "CreatedBy": "aut",
      "UpdatedBy": "officia",
      "DeviceIdentifier": "architecto",
      "ForeignAppId": 925,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
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
      "FieldLength": 840
    }
  }
}
```