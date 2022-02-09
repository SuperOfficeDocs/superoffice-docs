---
title: POST Agents/Relation/CreateDefaultContactRelationEntity
id: v1RelationAgent_CreateDefaultContactRelationEntity
---

# POST Agents/Relation/CreateDefaultContactRelationEntity

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
  "SourceContactId": 669,
  "SourcePersonId": 841,
  "DestinationContactId": 817,
  "DestinationPersonId": 127,
  "RelationId": 254,
  "Comment": "eligendi",
  "RelationDefinitionId": 578,
  "Reversed": 195,
  "UpdatedDate": "2005-08-31T18:28:50.0051372+02:00",
  "CreatedDate": "1994-10-31T18:28:50.0051372+01:00",
  "CreatedBy": {
    "AssociateId": 151,
    "Name": "Kautzer-Spinka",
    "PersonId": 125,
    "Rank": 850,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 257,
    "FullName": "Ferne Reynolds Sr.",
    "FormalName": "Crist-Lehner",
    "Deleted": false,
    "EjUserId": 439,
    "UserName": "Lang Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark transparent partnerships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 245
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 62,
    "Name": "Stokes Inc and Sons",
    "PersonId": 94,
    "Rank": 882,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 945,
    "FullName": "Cooper Schmeler",
    "FormalName": "Ferry LLC",
    "Deleted": true,
    "EjUserId": 83,
    "UserName": "Stanton, Schamberger and Crooks",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 479
      }
    }
  },
  "SourceContactName": "McCullough-Hansen",
  "SourcePersonName": "Gutkowski Group",
  "DestinationContactName": "Harber-Dach",
  "DestinationPersonName": "Hodkiewicz, Gutkowski and Nitzsche",
  "ActiveText": "qui",
  "PassiveText": "doloribus",
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
      "FieldLength": 770
    }
  }
}
```