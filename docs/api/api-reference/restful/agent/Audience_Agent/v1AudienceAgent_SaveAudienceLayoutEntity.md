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
  "AudienceLayoutId": 341,
  "InstanceLayout": "earum",
  "InstanceName": "Haley-Bartell",
  "CreatedDate": "1997-05-26T16:48:28.7622062+02:00",
  "UpdatedDate": "2019-12-13T16:48:28.7622062+01:00",
  "CreatedBy": {
    "AssociateId": 577,
    "Name": "Hintz-Strosin",
    "PersonId": 696,
    "Rank": 370,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 251,
    "FullName": "Yasmin Moore",
    "FormalName": "Douglas, Schuster and Roberts",
    "Deleted": false,
    "EjUserId": 638,
    "UserName": "McGlynn Group"
  },
  "UpdatedBy": {
    "AssociateId": 977,
    "Name": "Crooks Group",
    "PersonId": 734,
    "Rank": 605,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 399,
    "FullName": "Shawn Prohaska",
    "FormalName": "Macejkovic, Labadie and Auer",
    "Deleted": false,
    "EjUserId": 920,
    "UserName": "Satterfield, Cummerata and Rosenbaum"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 822,
  "InstanceLayout": "minima",
  "InstanceName": "Kling-Zieme",
  "CreatedDate": "2012-08-19T16:48:28.763199+02:00",
  "UpdatedDate": "2003-06-13T16:48:28.763199+02:00",
  "CreatedBy": {
    "AssociateId": 527,
    "Name": "Reichel-Gutmann",
    "PersonId": 292,
    "Rank": 66,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 74,
    "FullName": "Dr. Rylan Green",
    "FormalName": "Gleason, D'Amore and Rath",
    "Deleted": false,
    "EjUserId": 168,
    "UserName": "Kling-Nolan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 435
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 368,
    "Name": "Raynor-Labadie",
    "PersonId": 290,
    "Rank": 322,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 445,
    "FullName": "Charlene McDermott",
    "FormalName": "Barrows, Carter and Graham",
    "Deleted": true,
    "EjUserId": 877,
    "UserName": "Legros Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 16
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
      "FieldLength": 734
    }
  }
}
```