---
title: SaveAudienceLayoutEntity
id: v1AudienceAgent_SaveAudienceLayoutEntity
---

# SaveAudienceLayoutEntity

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 411,
  "InstanceLayout": "distinctio",
  "InstanceName": "Murray-Beatty",
  "CreatedDate": "1997-11-11T14:58:03.2532352+01:00",
  "UpdatedDate": "2014-04-12T14:58:03.2532352+02:00",
  "CreatedBy": {
    "AssociateId": 310,
    "Name": "Lakin-Johnston",
    "PersonId": 627,
    "Rank": 844,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 312,
    "FullName": "Ashley Beier",
    "FormalName": "Block, Rowe and McClure",
    "Deleted": true,
    "EjUserId": 82,
    "UserName": "Langworth, Casper and Von"
  },
  "UpdatedBy": {
    "AssociateId": 711,
    "Name": "Kub, Beahan and Lowe",
    "PersonId": 481,
    "Rank": 12,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 432,
    "FullName": "Peggie Carter",
    "FormalName": "Will LLC",
    "Deleted": true,
    "EjUserId": 58,
    "UserName": "Stehr-Dietrich"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 288,
  "InstanceLayout": "nesciunt",
  "InstanceName": "Gerlach Group",
  "CreatedDate": "2016-09-13T14:58:03.2552376+02:00",
  "UpdatedDate": "1994-11-11T14:58:03.2552376+01:00",
  "CreatedBy": {
    "AssociateId": 721,
    "Name": "Wilderman, Hilll and Volkman",
    "PersonId": 322,
    "Rank": 467,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 688,
    "FullName": "Lizeth Dibbert",
    "FormalName": "Braun, Tremblay and Grant",
    "Deleted": true,
    "EjUserId": 472,
    "UserName": "Satterfield LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 34
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 343,
    "Name": "Hessel-Grady",
    "PersonId": 69,
    "Rank": 41,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 926,
    "FullName": "Antwan Weimann Sr.",
    "FormalName": "Klein, Rau and Mohr",
    "Deleted": true,
    "EjUserId": 733,
    "UserName": "Mosciski Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 712
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
      "FieldLength": 906
    }
  }
}
```