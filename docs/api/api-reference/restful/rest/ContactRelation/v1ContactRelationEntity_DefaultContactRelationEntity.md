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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 04 Dec 2012 09:40:59 G12T

{
  "SourceContactId": 241,
  "SourcePersonId": 699,
  "DestinationContactId": 353,
  "DestinationPersonId": 147,
  "RelationId": 836,
  "Comment": "et",
  "RelationDefinitionId": 578,
  "Reversed": 460,
  "UpdatedDate": "2012-12-04T09:40:59.0093712+01:00",
  "CreatedDate": "2010-12-21T09:40:59.0093712+01:00",
  "CreatedBy": {
    "AssociateId": 479,
    "Name": "Jacobson, Gottlieb and Rohan",
    "PersonId": 545,
    "Rank": 955,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 548,
    "FullName": "Maryse Spencer",
    "FormalName": "Mann, Walker and Rodriguez",
    "Deleted": true,
    "EjUserId": 221,
    "UserName": "Will LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark collaborative relationships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 110
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 194,
    "Name": "Hirthe, Gleason and Cassin",
    "PersonId": 257,
    "Rank": 674,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 744,
    "FullName": "Rhoda Keebler",
    "FormalName": "Sanford, Olson and Gutmann",
    "Deleted": false,
    "EjUserId": 478,
    "UserName": "Simonis, D'Amore and Boehm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 188
      }
    }
  },
  "SourceContactName": "Carter LLC",
  "SourcePersonName": "Bartell-Williamson",
  "DestinationContactName": "Pacocha LLC",
  "DestinationPersonName": "Rau-Powlowski",
  "ActiveText": "qui",
  "PassiveText": "omnis",
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
      "FieldLength": 313
    }
  }
}
```