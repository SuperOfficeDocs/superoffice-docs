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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 13 Jun 2018 18:25:50 G6T

{
  "SourceContactId": 876,
  "SourcePersonId": 275,
  "DestinationContactId": 562,
  "DestinationPersonId": 617,
  "RelationId": 788,
  "Comment": "quo",
  "RelationDefinitionId": 958,
  "Reversed": 588,
  "UpdatedDate": "2018-06-13T18:25:50.3846316+02:00",
  "CreatedDate": "2014-05-20T18:25:50.3846316+02:00",
  "CreatedBy": {
    "AssociateId": 721,
    "Name": "Paucek Group",
    "PersonId": 533,
    "Rank": 552,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 202,
    "FullName": "Trey Strosin Jr.",
    "FormalName": "Kub-Donnelly",
    "Deleted": false,
    "EjUserId": 618,
    "UserName": "Treutel, Crona and Kemmer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 423
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 886,
    "Name": "Towne, Leannon and Nitzsche",
    "PersonId": 971,
    "Rank": 131,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 627,
    "FullName": "Eden Greenholt",
    "FormalName": "Reilly LLC",
    "Deleted": false,
    "EjUserId": 336,
    "UserName": "Little, Gerhold and Zboncak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 159
      }
    }
  },
  "SourceContactName": "Macejkovic-Mitchell",
  "SourcePersonName": "Collier-Watsica",
  "DestinationContactName": "Carroll Inc and Sons",
  "DestinationPersonName": "Pagac LLC",
  "ActiveText": "quod",
  "PassiveText": "vero",
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
      "FieldLength": 898
    }
  }
}
```