---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 526,
  "Name": "Schuster Group",
  "ProjectNumber": "1825704",
  "ProjectMembers": [
    {
      "ProjectmemberId": 635,
      "ContactId": 209,
      "ProjectId": 455,
      "ContactName": "Upton, Schultz and Kshlerin",
      "ContactDepartment": "",
      "ProjectName": "Dietrich Inc and Sons",
      "EmailId": 571,
      "EmailAddress": "jonas_bradtke@schusterhowe.name",
      "CountryId": 309,
      "Firstname": "Raquel",
      "MiddleName": "Schulist Inc and Sons",
      "Lastname": "Keebler",
      "PersonId": 369,
      "Mrmrs": "sit",
      "ProjectMemberTypeName": "Feest Inc and Sons",
      "Phone": "1-171-312-6506 x1042",
      "PhoneId": 19,
      "ProjectMemberTypeId": 261,
      "EmailAddressName": "kailyn@prohaskajacobson.uk",
      "Comment": "a",
      "FullName": "Elwyn Baumbach PhD"
    }
  ],
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "perferendis",
      "Description": "Customer-focused attitude-oriented adapter"
    },
    {
      "Value": "a",
      "StrippedValue": "perferendis",
      "Description": "Customer-focused attitude-oriented adapter"
    }
  ],
  "CreatedDate": "2008-12-31T03:24:48.0644879+01:00",
  "UpdatedDate": "2022-10-16T03:24:48.0644879+02:00",
  "Description": "Upgradable systemic hub",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Expanded methodical firmware",
  "ActiveStatusMonitorId": 306,
  "Links": [
    {
      "EntityName": "Crooks, Zulauf and Auer",
      "Id": 131,
      "Description": "Cross-platform global throughput",
      "ExtraInfo": "quisquam",
      "LinkId": 316
    },
    {
      "EntityName": "Crooks, Zulauf and Auer",
      "Id": 131,
      "Description": "Cross-platform global throughput",
      "ExtraInfo": "quisquam",
      "LinkId": 316
    }
  ],
  "ActiveLinks": 968,
  "Completed": false,
  "NextMilestoneDate": "2005-09-27T03:24:48.0644879+02:00",
  "NmdAppointmentId": 63,
  "EndDate": "1999-03-04T03:24:48.0644879+01:00",
  "ActiveErpLinks": 820,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Miss Gussie Hills Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "ab",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "ratione"
  },
  "PublishEventDate": "2017-04-10T03:24:48.0644879+02:00",
  "PublishTo": "2015-04-02T03:24:48.0644879+02:00",
  "PublishFrom": "2019-04-30T03:24:48.0644879+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 1000,
  "Name": "Grant, Tremblay and Kunde",
  "ProjectNumber": "1451070",
  "ProjectMembers": [
    {
      "ProjectmemberId": 355,
      "ContactId": 69,
      "ProjectId": 167,
      "ContactName": "Barton Group",
      "ContactDepartment": "",
      "ProjectName": "Harvey, Gleason and Pouros",
      "EmailId": 486,
      "EmailAddress": "mohamed@bartell.co.uk",
      "CountryId": 945,
      "Firstname": "Emmitt",
      "MiddleName": "Rice Inc and Sons",
      "Lastname": "Bruen",
      "PersonId": 55,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Nader, Schimmel and Prohaska",
      "Phone": "(771)948-6369 x6656",
      "PhoneId": 898,
      "ProjectMemberTypeId": 788,
      "EmailAddressName": "izabella.sporer@wisoky.uk",
      "Comment": "voluptas",
      "FullName": "Mr. Ibrahim Derrick O'Reilly V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tempore",
      "StrippedValue": "assumenda",
      "Description": "Programmable responsive utilisation",
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
      "Value": "tempore",
      "StrippedValue": "assumenda",
      "Description": "Programmable responsive utilisation",
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
  "CreatedDate": "2019-11-02T03:24:48.0644879+01:00",
  "UpdatedDate": "2002-07-31T03:24:48.0644879+02:00",
  "Description": "Operative user-facing secured line",
  "Postit": "repellat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Up-sized real-time synergy",
  "ActiveStatusMonitorId": 826,
  "Links": [
    {
      "EntityName": "Reichert, Bode and Ziemann",
      "Id": 488,
      "Description": "Universal stable secured line",
      "ExtraInfo": "expedita",
      "LinkId": 875,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    }
  ],
  "ActiveLinks": 338,
  "Completed": true,
  "NextMilestoneDate": "1996-06-24T03:24:48.0644879+02:00",
  "NmdAppointmentId": 995,
  "EndDate": "2013-07-23T03:24:48.0644879+02:00",
  "ActiveErpLinks": 865,
  "UserDefinedFields": {
    "SuperOffice:1": "Addie Kuhic",
    "SuperOffice:2": "1706118099"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "1999-08-29T03:24:48.0801113+02:00",
  "PublishTo": "2021-02-16T03:24:48.0801113+01:00",
  "PublishFrom": "2016-12-27T03:24:48.0801113+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 730
    }
  }
}
```