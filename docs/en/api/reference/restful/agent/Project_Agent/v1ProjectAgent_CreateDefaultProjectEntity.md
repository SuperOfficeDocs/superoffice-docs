---
title: POST Agents/Project/CreateDefaultProjectEntity
uid: v1ProjectAgent_CreateDefaultProjectEntity
generated: true
---

# POST Agents/Project/CreateDefaultProjectEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
```

Set default values into a new ProjectEntity.


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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 870,
  "Name": "Murray-Gislason",
  "ProjectNumber": "556654",
  "ProjectMembers": [
    {
      "ProjectmemberId": 260,
      "ContactId": 523,
      "ProjectId": 788,
      "ContactName": "Kuhlman, Gislason and Brakus",
      "ContactDepartment": "",
      "ProjectName": "Hane-Marquardt",
      "EmailId": 410,
      "EmailAddress": "bria@cruickshanklarkin.biz",
      "CountryId": 692,
      "Firstname": "Alycia",
      "MiddleName": "Cassin, Casper and Lindgren",
      "Lastname": "Bergnaum",
      "PersonId": 1001,
      "Mrmrs": "voluptas",
      "ProjectMemberTypeName": "Friesen-VonRueden",
      "Phone": "992-530-8314",
      "PhoneId": 479,
      "ProjectMemberTypeId": 268,
      "EmailAddressName": "elizabeth.reilly@stroman.biz",
      "Comment": "consectetur",
      "FullName": "Mrs. Bradford Pfeffer III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented optimizing adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented optimizing adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "CreatedDate": "1998-02-25T13:57:12.812547+01:00",
  "UpdatedDate": "2000-02-11T13:57:12.812547+01:00",
  "Description": "Managed user-facing Graphic Interface",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Focused logistical complexity",
  "ActiveStatusMonitorId": 322,
  "Links": [
    {
      "EntityName": "Kohler-Buckridge",
      "Id": 205,
      "Description": "User-friendly global open architecture",
      "ExtraInfo": "facilis",
      "LinkId": 456,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 59
        }
      }
    }
  ],
  "ActiveLinks": 185,
  "Completed": false,
  "NextMilestoneDate": "1996-11-06T13:57:12.812547+01:00",
  "NmdAppointmentId": 660,
  "EndDate": "2001-05-20T13:57:12.812547+02:00",
  "ActiveErpLinks": 94,
  "UserDefinedFields": {
    "SuperOffice:1": "404555308",
    "SuperOffice:2": "Prof. Cedrick Schaefer"
  },
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "porro"
  },
  "PublishEventDate": "2000-08-17T13:57:12.812547+02:00",
  "PublishTo": "2007-04-06T13:57:12.812547+02:00",
  "PublishFrom": "2009-10-24T13:57:12.812547+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 367
    }
  }
}
```