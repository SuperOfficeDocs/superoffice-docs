---
title: POST Relation
uid: v1ContactRelationEntity_PostContactRelationEntity
generated: true
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
| SourceContactId | Integer | Id of the source contact. The value is mandatory. |
| SourcePersonId | Integer | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | Integer | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | Integer | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | Integer | Primary key |
| Comment | String | Comment for relation |
| RelationDefinitionId | Integer | Reference to definition |
| Reversed | Integer | Is direction reversed relative to definition |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedDate | String | Registered when  in UTC. |
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | String | Name of the source contact. |
| SourcePersonName | String | Name of the source person. |
| DestinationContactName | String | Name of the destination contact. |
| DestinationPersonName | String | Name of the destination person. |
| ActiveText | String | Active text for the relation. |
| PassiveText | String | Passive text for the relation. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactRelationEntityWithLinks

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
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Relation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 988,
  "SourcePersonId": 960,
  "DestinationContactId": 825,
  "DestinationPersonId": 565,
  "RelationId": 613,
  "Comment": "et",
  "RelationDefinitionId": 166,
  "Reversed": 65,
  "UpdatedDate": "2015-07-10T02:38:26.0266945+02:00",
  "CreatedDate": "1998-01-07T02:38:26.0266945+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Treutel, Hermann and Torp",
  "SourcePersonName": "Hoppe, Emard and Ledner",
  "DestinationContactName": "McLaughlin Group",
  "DestinationPersonName": "Block, Kihn and Schuster",
  "ActiveText": "facere",
  "PassiveText": "perspiciatis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 261,
  "SourcePersonId": 743,
  "DestinationContactId": 766,
  "DestinationPersonId": 88,
  "RelationId": 446,
  "Comment": "ipsa",
  "RelationDefinitionId": 123,
  "Reversed": 183,
  "UpdatedDate": "2009-09-11T02:38:26.0266945+02:00",
  "CreatedDate": "2013-06-07T02:38:26.0266945+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Donnelly-Hudson",
  "SourcePersonName": "Hyatt-Leuschke",
  "DestinationContactName": "Nienow, Gerlach and Kuphal",
  "DestinationPersonName": "Ebert-Pfeffer",
  "ActiveText": "quo",
  "PassiveText": "ipsam",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 969
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```