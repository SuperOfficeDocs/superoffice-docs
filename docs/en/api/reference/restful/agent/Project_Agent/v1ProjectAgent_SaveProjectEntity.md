---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

## Request Body: entity 

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 159,
  "Name": "Cronin-Douglas",
  "ProjectNumber": "869529",
  "ProjectMembers": [
    {
      "ProjectmemberId": 15,
      "ContactId": 334,
      "ProjectId": 84,
      "ContactName": "Schmeler-Ernser",
      "ContactDepartment": "",
      "ProjectName": "Christiansen-Hilpert",
      "EmailId": 378,
      "EmailAddress": "hettie@gerlach.com",
      "CountryId": 779,
      "Firstname": "Brittany",
      "MiddleName": "Schinner Group",
      "Lastname": "Dickens",
      "PersonId": 425,
      "Mrmrs": "ratione",
      "ProjectMemberTypeName": "Schmeler, Stokes and Larkin",
      "Phone": "(057)447-5554 x61677",
      "PhoneId": 330,
      "ProjectMemberTypeId": 264,
      "EmailAddressName": "monserrate_blick@emmerich.ca",
      "Comment": "sunt",
      "FullName": "Ms. Lucinda Tyshawn Heller"
    }
  ],
  "Urls": [
    {
      "Value": "alias",
      "StrippedValue": "sed",
      "Description": "Progressive modular moderator"
    },
    {
      "Value": "alias",
      "StrippedValue": "sed",
      "Description": "Progressive modular moderator"
    }
  ],
  "CreatedDate": "1999-07-12T17:37:18.6052417+02:00",
  "UpdatedDate": "2016-01-15T17:37:18.6052417+01:00",
  "Description": "Focused zero defect data-warehouse",
  "Postit": "voluptatem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enterprise-wide assymetric matrix",
  "ActiveStatusMonitorId": 3,
  "Links": [
    {
      "EntityName": "Grant Group",
      "Id": 5,
      "Description": "Open-source transitional superstructure",
      "ExtraInfo": "distinctio",
      "LinkId": 507
    },
    {
      "EntityName": "Grant Group",
      "Id": 5,
      "Description": "Open-source transitional superstructure",
      "ExtraInfo": "distinctio",
      "LinkId": 507
    }
  ],
  "ActiveLinks": 449,
  "Completed": false,
  "NextMilestoneDate": "2008-02-20T17:37:18.6062416+01:00",
  "NmdAppointmentId": 26,
  "EndDate": "2011-10-07T17:37:18.6062416+02:00",
  "ActiveErpLinks": 456,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Allie Denis Champlin",
    "SuperOffice:2": "1668689025"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2001-08-15T17:37:18.6072416+02:00",
  "PublishTo": "2010-09-22T17:37:18.6072416+02:00",
  "PublishFrom": "2017-08-28T17:37:18.6072416+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 547,
  "Name": "Runolfsson, Halvorson and Hilll",
  "ProjectNumber": "1843351",
  "ProjectMembers": [
    {
      "ProjectmemberId": 940,
      "ContactId": 110,
      "ProjectId": 707,
      "ContactName": "Blick Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Schmidt, Ritchie and Trantow",
      "EmailId": 164,
      "EmailAddress": "alvena@harberwest.biz",
      "CountryId": 178,
      "Firstname": "Hudson",
      "MiddleName": "Beier-Monahan",
      "Lastname": "Armstrong",
      "PersonId": 5,
      "Mrmrs": "ratione",
      "ProjectMemberTypeName": "Welch, Schowalter and Stamm",
      "Phone": "1-817-890-0265 x902",
      "PhoneId": 833,
      "ProjectMemberTypeId": 636,
      "EmailAddressName": "isac@stoltenbergziemann.name",
      "Comment": "id",
      "FullName": "Jayne Murray",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "expedita",
      "Description": "Persevering solution-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "expedita",
      "Description": "Persevering solution-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "CreatedDate": "2010-05-07T17:37:18.6112417+02:00",
  "UpdatedDate": "1998-01-14T17:37:18.6112417+01:00",
  "Description": "Polarised disintermediate capacity",
  "Postit": "sequi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Team-oriented 3rd generation functionalities",
  "ActiveStatusMonitorId": 321,
  "Links": [
    {
      "EntityName": "O'Kon, O'Keefe and Johns",
      "Id": 126,
      "Description": "De-engineered incremental initiative",
      "ExtraInfo": "suscipit",
      "LinkId": 607,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "ActiveLinks": 864,
  "Completed": true,
  "NextMilestoneDate": "2012-05-11T17:37:18.6122418+02:00",
  "NmdAppointmentId": 818,
  "EndDate": "2001-04-04T17:37:18.6122418+02:00",
  "ActiveErpLinks": 272,
  "UserDefinedFields": {
    "SuperOffice:1": "Tina Elvera Douglas DDS",
    "SuperOffice:2": "Dr. Tremayne Monahan"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "quidem"
  },
  "PublishEventDate": "2020-09-18T17:37:18.6122418+02:00",
  "PublishTo": "2015-12-15T17:37:18.6122418+01:00",
  "PublishFrom": "2020-09-26T17:37:18.6122418+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 757
    }
  }
}
```