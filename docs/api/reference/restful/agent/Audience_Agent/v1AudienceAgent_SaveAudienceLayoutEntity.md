---
title: POST Agents/Audience/SaveAudienceLayoutEntity
id: v1AudienceAgent_SaveAudienceLayoutEntity
---

# POST Agents/Audience/SaveAudienceLayoutEntity

```http
POST /api/v1/Agents/Audience/SaveAudienceLayoutEntity
```

Updates the existing AudienceLayoutEntity or creates a new AudienceLayoutEntity if the id parameter is empty








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

The AudienceLayoutEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The Id of the Audience layout |
| InstanceLayout | string | The web part layout as a serialized string |
| InstanceName | string | Name of the layout instance |
| CreatedDate | date-time | The date and time the Audience layout was created  in UTC. |
| UpdatedDate | date-time | The date and time the Audience layout was last updated  in UTC. |
| CreatedBy |  | Name of the person that created the Audience layout |
| UpdatedBy |  | Name of the person that last updated the Audience layout |


## Response: object

Audience layout. Each instance of Audience has at least one layout. The layout is connected to the instance by it's instance name or is linked to the currently logged on user. The web part layout and the Audience configuration parameters belongs to an Audience layout



Carrier object for AudienceLayoutEntity.
Services for the AudienceLayoutEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAudienceAgent">Audience Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The Id of the Audience layout |
| InstanceLayout | string | The web part layout as a serialized string |
| InstanceName | string | Name of the layout instance |
| CreatedDate | date-time | The date and time the Audience layout was created  in UTC. |
| UpdatedDate | date-time | The date and time the Audience layout was last updated  in UTC. |
| CreatedBy |  | Name of the person that created the Audience layout |
| UpdatedBy |  | Name of the person that last updated the Audience layout |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Audience/SaveAudienceLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 422,
  "InstanceLayout": "voluptas",
  "InstanceName": "Cronin Group",
  "CreatedDate": "2013-12-14T18:28:48.1255427+01:00",
  "UpdatedDate": "2014-04-27T18:28:48.1255427+02:00",
  "CreatedBy": {
    "AssociateId": 616,
    "Name": "Blanda Inc and Sons",
    "PersonId": 566,
    "Rank": 946,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 146,
    "FullName": "Samara Mueller",
    "FormalName": "Leffler-Champlin",
    "Deleted": true,
    "EjUserId": 69,
    "UserName": "Rau-Nicolas"
  },
  "UpdatedBy": {
    "AssociateId": 360,
    "Name": "DuBuque-Oberbrunner",
    "PersonId": 273,
    "Rank": 118,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 243,
    "FullName": "Erna Predovic",
    "FormalName": "Mosciski, Hermiston and Wiza",
    "Deleted": false,
    "EjUserId": 156,
    "UserName": "Bruen-Hirthe"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 978,
  "InstanceLayout": "quidem",
  "InstanceName": "Nikolaus LLC",
  "CreatedDate": "2008-08-15T18:28:48.1265489+02:00",
  "UpdatedDate": "2019-09-26T18:28:48.1265489+02:00",
  "CreatedBy": {
    "AssociateId": 757,
    "Name": "Sauer, Streich and Gislason",
    "PersonId": 716,
    "Rank": 285,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 607,
    "FullName": "Brendan Ebert",
    "FormalName": "Pacocha Inc and Sons",
    "Deleted": true,
    "EjUserId": 247,
    "UserName": "Lang-Farrell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 214
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 218,
    "Name": "Schulist, McLaughlin and Pfannerstill",
    "PersonId": 123,
    "Rank": 784,
    "Tooltip": "atque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 438,
    "FullName": "Taya Daniel MD",
    "FormalName": "Heathcote Inc and Sons",
    "Deleted": false,
    "EjUserId": 858,
    "UserName": "Runolfsson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 334
      }
    }
  },
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
      "FieldLength": 925
    }
  }
}
```