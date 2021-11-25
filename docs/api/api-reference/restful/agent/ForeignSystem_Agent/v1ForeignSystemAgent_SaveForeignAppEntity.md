---
title: POST Agents/ForeignSystem/SaveForeignAppEntity
id: v1ForeignSystemAgent_SaveForeignAppEntity
---

# POST Agents/ForeignSystem/SaveForeignAppEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 344,
  "Name": "Hermiston-Hammes",
  "CreatedDate": "2004-04-07T18:28:49.1951183+02:00",
  "UpdatedDate": "2004-10-01T18:28:49.1951183+02:00",
  "CreatedBy": {
    "AssociateId": 334,
    "Name": "Kuphal, Boyle and Wisozk",
    "PersonId": 621,
    "Rank": 514,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 325,
    "FullName": "Americo Murray",
    "FormalName": "Crooks, Dach and Kub",
    "Deleted": false,
    "EjUserId": 277,
    "UserName": "Spencer-Bernhard"
  },
  "UpdatedBy": {
    "AssociateId": 425,
    "Name": "Kozey-Feil",
    "PersonId": 545,
    "Rank": 729,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 798,
    "FullName": "Raleigh Dibbert",
    "FormalName": "Stehr-Mueller",
    "Deleted": false,
    "EjUserId": 181,
    "UserName": "Marquardt Group"
  },
  "Devices": [
    {
      "ForeignDeviceId": 972,
      "Name": "Ankunding-Schamberger",
      "CreatedDate": "2015-10-01T18:28:49.1971168+02:00",
      "UpdatedDate": "2016-11-30T18:28:49.1971168+01:00",
      "AssociateFullName": "Sarina Heller",
      "CreatedBy": "consequatur",
      "UpdatedBy": "dolorum",
      "DeviceIdentifier": "blanditiis",
      "ForeignAppId": 495
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 524,
  "Name": "Hartmann-Fahey",
  "CreatedDate": "2010-05-20T18:28:49.1981177+02:00",
  "UpdatedDate": "2018-09-02T18:28:49.1981177+02:00",
  "CreatedBy": {
    "AssociateId": 883,
    "Name": "Koepp, Pouros and Murazik",
    "PersonId": 252,
    "Rank": 279,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 258,
    "FullName": "Kaela Schmeler",
    "FormalName": "Koch Inc and Sons",
    "Deleted": false,
    "EjUserId": 44,
    "UserName": "Braun-Konopelski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 98
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 891,
    "Name": "Corkery-Hammes",
    "PersonId": 375,
    "Rank": 742,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 63,
    "FullName": "Dr. Ebba Sauer",
    "FormalName": "McCullough Group",
    "Deleted": false,
    "EjUserId": 839,
    "UserName": "Hirthe, Farrell and Weber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 185
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 957,
      "Name": "Jenkins Inc and Sons",
      "CreatedDate": "2020-05-08T18:28:49.1990885+02:00",
      "UpdatedDate": "1995-01-26T18:28:49.1990885+01:00",
      "AssociateFullName": "Frances Oberbrunner",
      "CreatedBy": "et",
      "UpdatedBy": "sint",
      "DeviceIdentifier": "error",
      "ForeignAppId": 108,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
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
      "FieldLength": 573
    }
  }
}
```