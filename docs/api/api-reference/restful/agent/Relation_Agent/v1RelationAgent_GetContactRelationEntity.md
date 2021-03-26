---
title: POST Agents/Relation/GetContactRelationEntity
id: v1RelationAgent_GetContactRelationEntity
---

# POST Agents/Relation/GetContactRelationEntity

```http
POST /api/v1/Agents/Relation/GetContactRelationEntity
```

Gets a ContactRelationEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactRelationEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Relation/GetContactRelationEntity?contactRelationEntityId=809
POST /api/v1/Agents/Relation/GetContactRelationEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Relation/GetContactRelationEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 45,
  "SourcePersonId": 623,
  "DestinationContactId": 455,
  "DestinationPersonId": 41,
  "RelationId": 729,
  "Comment": "omnis",
  "RelationDefinitionId": 998,
  "Reversed": 858,
  "UpdatedDate": "2001-09-30T16:48:30.4719424+02:00",
  "CreatedDate": "2001-02-01T16:48:30.4719424+01:00",
  "CreatedBy": {
    "AssociateId": 852,
    "Name": "Kozey-Hilll",
    "PersonId": 60,
    "Rank": 633,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 924,
    "FullName": "Nikki O'Keefe",
    "FormalName": "Ruecker Group",
    "Deleted": true,
    "EjUserId": 548,
    "UserName": "Lebsack, Wolf and Feest",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 385
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 876,
    "Name": "Thiel-Kunze",
    "PersonId": 803,
    "Rank": 939,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Tommie Corwin",
    "FormalName": "Ortiz, Abbott and Pollich",
    "Deleted": false,
    "EjUserId": 426,
    "UserName": "Schmeler, Schuster and Windler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 46
      }
    }
  },
  "SourceContactName": "Rowe LLC",
  "SourcePersonName": "Christiansen LLC",
  "DestinationContactName": "Roob, Bradtke and Jakubowski",
  "DestinationPersonName": "Cartwright, Parisian and Bergnaum",
  "ActiveText": "voluptatum",
  "PassiveText": "totam",
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
      "FieldLength": 546
    }
  }
}
```