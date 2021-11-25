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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactRelationEntity": {
    "SourceContactId": 452,
    "SourcePersonId": 71,
    "DestinationContactId": 722,
    "DestinationPersonId": 918,
    "RelationId": 434,
    "Comment": "corrupti",
    "RelationDefinitionId": 909,
    "Reversed": 368,
    "UpdatedDate": "2021-02-15T18:28:50.0081396+01:00",
    "CreatedDate": "2011-04-02T18:28:50.0081396+02:00",
    "CreatedBy": {},
    "UpdatedBy": {},
    "SourceContactName": "Ledner-Hodkiewicz",
    "SourcePersonName": "Kreiger LLC",
    "DestinationContactName": "Hilpert, Smith and Legros",
    "DestinationPersonName": "Zieme-Koepp",
    "ActiveText": "modi",
    "PassiveText": "ut"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 926,
  "SourcePersonId": 833,
  "DestinationContactId": 116,
  "DestinationPersonId": 457,
  "RelationId": 486,
  "Comment": "iure",
  "RelationDefinitionId": 520,
  "Reversed": 600,
  "UpdatedDate": "2007-10-22T18:28:50.0091369+02:00",
  "CreatedDate": "2016-11-22T18:28:50.0091369+01:00",
  "CreatedBy": {
    "AssociateId": 324,
    "Name": "Parisian-Towne",
    "PersonId": 735,
    "Rank": 212,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 642,
    "FullName": "Hunter Ebert",
    "FormalName": "Friesen-Dicki",
    "Deleted": false,
    "EjUserId": 593,
    "UserName": "Mohr, Runte and Walker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 126,
    "Name": "Goyette-Vandervort",
    "PersonId": 670,
    "Rank": 124,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 824,
    "FullName": "Cecil Jaskolski",
    "FormalName": "Kuhn Group",
    "Deleted": true,
    "EjUserId": 755,
    "UserName": "Huel-Turner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 865
      }
    }
  },
  "SourceContactName": "Rolfson, Ullrich and Jenkins",
  "SourcePersonName": "Schamberger-Rempel",
  "DestinationContactName": "O'Conner, Bogan and Heathcote",
  "DestinationPersonName": "Ferry, Witting and Harris",
  "ActiveText": "pariatur",
  "PassiveText": "molestiae",
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
      "FieldLength": 922
    }
  }
}
```