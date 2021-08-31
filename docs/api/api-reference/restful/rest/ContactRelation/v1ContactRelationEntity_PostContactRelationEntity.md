---
title: POST Relation
id: v1ContactRelationEntity_PostContactRelationEntity
---

# POST Relation

```http
POST /api/v1/Relation
```

Creates a new ContactRelationEntity

Calls the Relation agent service SaveContactRelationEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Relation?$select=name,department,category/id
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

## Request Body: newEntity  

The ContactRelationEntity to be saved. 

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


## Response: object

Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition.



ContactRelationEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Relation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 198,
  "SourcePersonId": 907,
  "DestinationContactId": 306,
  "DestinationPersonId": 598,
  "RelationId": 15,
  "Comment": "illum",
  "RelationDefinitionId": 580,
  "Reversed": 673,
  "UpdatedDate": "2007-01-20T15:05:42.0090027+01:00",
  "CreatedDate": "2018-05-11T15:05:42.0090027+02:00",
  "CreatedBy": {
    "AssociateId": 130,
    "Name": "McLaughlin-Bernhard",
    "PersonId": 518,
    "Rank": 716,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 65,
    "FullName": "Edwin Greenfelder",
    "FormalName": "Moen, Price and Goyette",
    "Deleted": false,
    "EjUserId": 813,
    "UserName": "Wolf Group"
  },
  "UpdatedBy": {
    "AssociateId": 622,
    "Name": "Langworth-Macejkovic",
    "PersonId": 848,
    "Rank": 387,
    "Tooltip": "esse",
    "Type": "AnonymousAssociate",
    "GroupIdx": 866,
    "FullName": "Olen Barton",
    "FormalName": "Fritsch-Sauer",
    "Deleted": true,
    "EjUserId": 98,
    "UserName": "Kohler-Schiller"
  },
  "SourceContactName": "Jacobs, Morissette and Anderson",
  "SourcePersonName": "Jaskolski, Graham and Lemke",
  "DestinationContactName": "Stokes, Jacobson and Corkery",
  "DestinationPersonName": "Williamson Inc and Sons",
  "ActiveText": "tenetur",
  "PassiveText": "exercitationem"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 5,
  "SourcePersonId": 957,
  "DestinationContactId": 771,
  "DestinationPersonId": 60,
  "RelationId": 549,
  "Comment": "mollitia",
  "RelationDefinitionId": 508,
  "Reversed": 967,
  "UpdatedDate": "2006-12-28T15:05:42.0120024+01:00",
  "CreatedDate": "2000-09-20T15:05:42.0120024+02:00",
  "CreatedBy": {
    "AssociateId": 180,
    "Name": "Pouros-Hilpert",
    "PersonId": 86,
    "Rank": 600,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 265,
    "FullName": "Christian Reilly",
    "FormalName": "Bergnaum-Medhurst",
    "Deleted": false,
    "EjUserId": 805,
    "UserName": "Dickens Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 89,
    "Name": "Beier, Rodriguez and Koch",
    "PersonId": 167,
    "Rank": 635,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 206,
    "FullName": "Leta Stroman",
    "FormalName": "Pollich, Pfeffer and Homenick",
    "Deleted": true,
    "EjUserId": 288,
    "UserName": "Bayer, O'Kon and Kris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 835
      }
    }
  },
  "SourceContactName": "Bergstrom-Feeney",
  "SourcePersonName": "Kuphal-Beier",
  "DestinationContactName": "VonRueden, Hettinger and Conn",
  "DestinationPersonName": "Boyle, Boehm and Morissette",
  "ActiveText": "sequi",
  "PassiveText": "repellendus",
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
      "FieldLength": 564
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```