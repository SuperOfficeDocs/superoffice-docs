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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 105,
  "Name": "Glover LLC",
  "ProjectNumber": "1270987",
  "ProjectMembers": [
    {
      "ProjectmemberId": 692,
      "ContactId": 386,
      "ProjectId": 373,
      "ContactName": "Leffler Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Strosin, O'Reilly and Lindgren",
      "EmailId": 15,
      "EmailAddress": "consuelo.farrell@pfannerstill.us",
      "CountryId": 513,
      "Firstname": "Lila",
      "MiddleName": "Fay, Koelpin and Cummings",
      "Lastname": "Morar",
      "PersonId": 885,
      "Mrmrs": "odio",
      "ProjectMemberTypeName": "Glover LLC",
      "Phone": "758.559.3868",
      "PhoneId": 231,
      "ProjectMemberTypeId": 225,
      "EmailAddressName": "kali.bernier@cronin.co.uk",
      "Comment": "ut",
      "FullName": "Mrs. Rudolph Letha Stark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "saepe",
      "Description": "Compatible hybrid synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "saepe",
      "Description": "Compatible hybrid synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "CreatedDate": "2017-11-03T23:03:56.6191206+01:00",
  "UpdatedDate": "2010-08-09T23:03:56.6191206+02:00",
  "Description": "Grass-roots local structure",
  "Postit": "pariatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Business-focused static extranet",
  "ActiveStatusMonitorId": 306,
  "Links": [
    {
      "EntityName": "Harvey-Kuvalis",
      "Id": 853,
      "Description": "Distributed explicit paradigm",
      "ExtraInfo": "corporis",
      "LinkId": 292,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "ActiveLinks": 67,
  "Completed": false,
  "NextMilestoneDate": "2009-09-02T23:03:56.6206214+02:00",
  "NmdAppointmentId": 904,
  "EndDate": "2001-01-30T23:03:56.6206214+01:00",
  "ActiveErpLinks": 688,
  "UserDefinedFields": {
    "SuperOffice:1": "Arely Bode",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "quibusdam"
  },
  "PublishEventDate": "2005-11-24T23:03:56.6206214+01:00",
  "PublishTo": "2005-11-10T23:03:56.6206214+01:00",
  "PublishFrom": "2017-04-07T23:03:56.6206214+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 33
    }
  }
}
```