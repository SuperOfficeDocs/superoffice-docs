---
title: POST Agents/Relation/SaveContactRelation
id: v1RelationAgent_SaveContactRelation
---

# POST Agents/Relation/SaveContactRelation

```http
POST /api/v1/Agents/Relation/SaveContactRelation
```

Creates a new or updates an existing contact relation.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Relation/SaveContactRelation?$select=name,department,category/id
```


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

## Request Body: request  

ContactRelationEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactRelationEntity |  | Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition. <para /> Carrier object for ContactRelationEntity. Services for the ContactRelationEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IRelationAgent">Relation Agent</see>. |


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
POST /api/v1/Agents/Relation/SaveContactRelation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactRelationEntity": {
    "SourceContactId": 601,
    "SourcePersonId": 922,
    "DestinationContactId": 868,
    "DestinationPersonId": 586,
    "RelationId": 54,
    "Comment": "eius",
    "RelationDefinitionId": 424,
    "Reversed": 353,
    "UpdatedDate": "1996-10-12T16:48:30.4739401+02:00",
    "CreatedDate": "2007-06-08T16:48:30.4739401+02:00",
    "CreatedBy": {},
    "UpdatedBy": {},
    "SourceContactName": "Champlin LLC",
    "SourcePersonName": "Greenholt LLC",
    "DestinationContactName": "Mante LLC",
    "DestinationPersonName": "Macejkovic, Roberts and Schmeler",
    "ActiveText": "nisi",
    "PassiveText": "consectetur"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 987,
  "SourcePersonId": 714,
  "DestinationContactId": 960,
  "DestinationPersonId": 110,
  "RelationId": 613,
  "Comment": "eaque",
  "RelationDefinitionId": 122,
  "Reversed": 975,
  "UpdatedDate": "2003-04-03T16:48:30.4750298+02:00",
  "CreatedDate": "2012-11-09T16:48:30.4750298+01:00",
  "CreatedBy": {
    "AssociateId": 955,
    "Name": "Schmitt, Lemke and Wunsch",
    "PersonId": 253,
    "Rank": 980,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 355,
    "FullName": "Arianna Murray",
    "FormalName": "Mitchell-Marvin",
    "Deleted": false,
    "EjUserId": 443,
    "UserName": "Herzog Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 65
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 51,
    "Name": "Halvorson, Block and Glover",
    "PersonId": 197,
    "Rank": 637,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 732,
    "FullName": "Elenor Rau",
    "FormalName": "Ward LLC",
    "Deleted": false,
    "EjUserId": 633,
    "UserName": "Thompson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 352
      }
    }
  },
  "SourceContactName": "Kiehn-West",
  "SourcePersonName": "Weimann Inc and Sons",
  "DestinationContactName": "VonRueden Inc and Sons",
  "DestinationPersonName": "Abbott Group",
  "ActiveText": "nesciunt",
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
      "FieldType": "System.Int32",
      "FieldLength": 727
    }
  }
}
```