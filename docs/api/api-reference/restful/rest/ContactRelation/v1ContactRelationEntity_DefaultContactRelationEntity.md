---
title: GET Relation/default
id: v1ContactRelationEntity_DefaultContactRelationEntity
---

# GET Relation/default

```http
GET /api/v1/Relation/default
```

Set default values into a new ContactRelationEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Relation agent service CreateDefaultContactRelationEntity.






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
GET /api/v1/Relation/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 06 Oct 2016 15:05:42 G10T

{
  "SourceContactId": 622,
  "SourcePersonId": 989,
  "DestinationContactId": 55,
  "DestinationPersonId": 879,
  "RelationId": 689,
  "Comment": "culpa",
  "RelationDefinitionId": 234,
  "Reversed": 960,
  "UpdatedDate": "2016-10-06T15:05:42.0070028+02:00",
  "CreatedDate": "2009-12-04T15:05:42.0070028+01:00",
  "CreatedBy": {
    "AssociateId": 602,
    "Name": "Rodriguez, Kunze and Dicki",
    "PersonId": 601,
    "Rank": 477,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 253,
    "FullName": "Effie Ernser",
    "FormalName": "Ullrich Inc and Sons",
    "Deleted": false,
    "EjUserId": 184,
    "UserName": "Kozey-Kuvalis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 414
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 339,
    "Name": "West LLC",
    "PersonId": 889,
    "Rank": 176,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 832,
    "FullName": "Sylvester Weissnat",
    "FormalName": "Bruen-Heaney",
    "Deleted": false,
    "EjUserId": 971,
    "UserName": "McDermott-Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 490
      }
    }
  },
  "SourceContactName": "Ryan-Ledner",
  "SourcePersonName": "Botsford, Greenholt and Wilkinson",
  "DestinationContactName": "Sanford Inc and Sons",
  "DestinationPersonName": "Kuhlman LLC",
  "ActiveText": "beatae",
  "PassiveText": "aut",
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
      "FieldLength": 764
    }
  }
}
```