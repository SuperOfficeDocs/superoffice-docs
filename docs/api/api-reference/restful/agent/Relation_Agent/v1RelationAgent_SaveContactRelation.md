---
title: SaveContactRelation
id: v1RelationAgent_SaveContactRelation
---

# SaveContactRelation

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactRelationEntity": {
    "SourceContactId": 850,
    "SourcePersonId": 765,
    "DestinationContactId": 403,
    "DestinationPersonId": 88,
    "RelationId": 288,
    "Comment": "et",
    "RelationDefinitionId": 614,
    "Reversed": 273,
    "UpdatedDate": "2007-08-22T14:58:05.0234654+02:00",
    "CreatedDate": "2019-10-20T14:58:05.0234654+02:00",
    "CreatedBy": {},
    "UpdatedBy": {},
    "SourceContactName": "Roob-Heathcote",
    "SourcePersonName": "Adams, Bartell and Borer",
    "DestinationContactName": "Schamberger, Mayer and Klocko",
    "DestinationPersonName": "Cummings LLC",
    "ActiveText": "qui",
    "PassiveText": "perspiciatis"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 369,
  "SourcePersonId": 130,
  "DestinationContactId": 134,
  "DestinationPersonId": 68,
  "RelationId": 809,
  "Comment": "eos",
  "RelationDefinitionId": 305,
  "Reversed": 551,
  "UpdatedDate": "2015-03-24T14:58:05.024466+01:00",
  "CreatedDate": "2021-05-25T14:58:05.024466+02:00",
  "CreatedBy": {
    "AssociateId": 123,
    "Name": "Strosin, Jakubowski and Ebert",
    "PersonId": 713,
    "Rank": 346,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 858,
    "FullName": "Damien Vandervort",
    "FormalName": "Mayer Group",
    "Deleted": true,
    "EjUserId": 311,
    "UserName": "Bins, Heller and Kub",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 333
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 545,
    "Name": "Cormier Group",
    "PersonId": 70,
    "Rank": 960,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Forrest Sauer",
    "FormalName": "Hyatt-Zulauf",
    "Deleted": true,
    "EjUserId": 513,
    "UserName": "Upton, Crist and Rosenbaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  },
  "SourceContactName": "Wehner-Runte",
  "SourcePersonName": "Lockman-Rosenbaum",
  "DestinationContactName": "Hodkiewicz, Schmidt and Hodkiewicz",
  "DestinationPersonName": "McKenzie, Schaefer and Kirlin",
  "ActiveText": "itaque",
  "PassiveText": "pariatur",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "synthesize granular bandwidth"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 932
    }
  }
}
```