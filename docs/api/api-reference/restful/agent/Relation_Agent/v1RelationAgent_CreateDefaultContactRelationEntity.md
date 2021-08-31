---
title: CreateDefaultContactRelationEntity
id: v1RelationAgent_CreateDefaultContactRelationEntity
---

# CreateDefaultContactRelationEntity

```http
POST /api/v1/Agents/Relation/CreateDefaultContactRelationEntity
```

Set default values into a new ContactRelationEntity.

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

Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition.



Carrier object for ContactRelationEntity.
Services for the ContactRelationEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IRelationAgent">Relation Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceContactId | int32 | Id of the source contact. The value is mandatory. |
| SourcePersonId | int32 | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | int32 | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | int32 | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | int32 | Primary key |
| Comment | string | Comment for relation |
| RelationDefinitionId | int32 | Reference to definition |
| Reversed | int32 | Is direction reversed relative to definition |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedDate | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Relation/CreateDefaultContactRelationEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 78,
  "SourcePersonId": 379,
  "DestinationContactId": 459,
  "DestinationPersonId": 585,
  "RelationId": 839,
  "Comment": "tempora",
  "RelationDefinitionId": 462,
  "Reversed": 862,
  "UpdatedDate": "2000-03-07T14:58:05.0194653+01:00",
  "CreatedDate": "2008-08-22T14:58:05.0194653+02:00",
  "CreatedBy": {
    "AssociateId": 285,
    "Name": "Stark, Lesch and Fahey",
    "PersonId": 277,
    "Rank": 677,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 718,
    "FullName": "Sylvester Schroeder",
    "FormalName": "Rohan, Tillman and Reichel",
    "Deleted": false,
    "EjUserId": 895,
    "UserName": "Mayert, Gorczany and Gleason",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 297
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 410,
    "Name": "Lind-Lehner",
    "PersonId": 376,
    "Rank": 382,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 734,
    "FullName": "Maddison Corwin",
    "FormalName": "Bayer-Green",
    "Deleted": true,
    "EjUserId": 452,
    "UserName": "Rutherford-Yundt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 241
      }
    }
  },
  "SourceContactName": "Mayert, Prosacco and Larkin",
  "SourcePersonName": "Huels-Effertz",
  "DestinationContactName": "Hoeger, Olson and Schmitt",
  "DestinationPersonName": "Denesik-Lowe",
  "ActiveText": "illo",
  "PassiveText": "velit",
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
      "FieldLength": 535
    }
  }
}
```