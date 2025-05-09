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
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
  "ProjectId": 505,
  "Name": "Bashirian, Mohr and Lueilwitz",
  "ProjectNumber": "737836",
  "ProjectMembers": [
    {
      "ProjectmemberId": 137,
      "ContactId": 566,
      "ProjectId": 604,
      "ContactName": "Kulas Group",
      "ContactDepartment": "",
      "ProjectName": "Schmeler LLC",
      "EmailId": 168,
      "EmailAddress": "johan@stark.name",
      "CountryId": 535,
      "Firstname": "Blaise",
      "MiddleName": "Ortiz, Leffler and Beier",
      "Lastname": "Pacocha",
      "PersonId": 614,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Abernathy, Larkin and Ferry",
      "Phone": "923.615.5827 x687",
      "PhoneId": 506,
      "ProjectMemberTypeId": 956,
      "EmailAddressName": "keith@eichmann.com",
      "Comment": "eligendi",
      "FullName": "Prof. Emerald Ethan Gaylord DVM"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Centralized zero defect project"
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Centralized zero defect project"
    }
  ],
  "CreatedDate": "2011-12-22T16:32:39.6021536+01:00",
  "UpdatedDate": "2003-07-04T16:32:39.6021536+02:00",
  "Description": "Front-line motivating archive",
  "Postit": "aspernatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Stand-alone bifurcated initiative",
  "ActiveStatusMonitorId": 523,
  "Links": [
    {
      "EntityName": "Nader-Gerlach",
      "Id": 737,
      "Description": "Quality-focused client-server array",
      "ExtraInfo": "illum",
      "LinkId": 111
    },
    {
      "EntityName": "Nader-Gerlach",
      "Id": 737,
      "Description": "Quality-focused client-server array",
      "ExtraInfo": "illum",
      "LinkId": 111
    }
  ],
  "ActiveLinks": 664,
  "Completed": false,
  "NextMilestoneDate": "2014-06-16T16:32:39.6021536+02:00",
  "NmdAppointmentId": 715,
  "EndDate": "2002-05-13T16:32:39.6021536+02:00",
  "ActiveErpLinks": 363,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Georgianna Ed O'Conner",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "incidunt"
  },
  "PublishEventDate": "2021-09-18T16:32:39.6021536+02:00",
  "PublishTo": "2002-03-13T16:32:39.6021536+01:00",
  "PublishFrom": "2022-02-09T16:32:39.6021536+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 937,
  "Name": "Jones-Abernathy",
  "ProjectNumber": "1323015",
  "ProjectMembers": [
    {
      "ProjectmemberId": 723,
      "ContactId": 680,
      "ProjectId": 826,
      "ContactName": "Hackett-Mayert",
      "ContactDepartment": "",
      "ProjectName": "Swift LLC",
      "EmailId": 482,
      "EmailAddress": "jane@herzog.info",
      "CountryId": 620,
      "Firstname": "Kristy",
      "MiddleName": "Fisher Inc and Sons",
      "Lastname": "Stracke",
      "PersonId": 794,
      "Mrmrs": "itaque",
      "ProjectMemberTypeName": "Schneider, Corwin and Spinka",
      "Phone": "1-045-843-7402",
      "PhoneId": 981,
      "ProjectMemberTypeId": 39,
      "EmailAddressName": "luigi@fahey.ca",
      "Comment": "fuga",
      "FullName": "Prof. Otto McDermott II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minima",
      "StrippedValue": "nemo",
      "Description": "Networked national moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 684
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "nemo",
      "Description": "Networked national moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 684
        }
      }
    }
  ],
  "CreatedDate": "2024-02-01T16:32:39.6021536+01:00",
  "UpdatedDate": "2001-07-16T16:32:39.6021536+02:00",
  "Description": "Decentralized background strategy",
  "Postit": "minima",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Ergonomic bi-directional benchmark",
  "ActiveStatusMonitorId": 908,
  "Links": [
    {
      "EntityName": "Jones-Lubowitz",
      "Id": 671,
      "Description": "Team-oriented didactic groupware",
      "ExtraInfo": "aliquam",
      "LinkId": 245,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 779
        }
      }
    }
  ],
  "ActiveLinks": 991,
  "Completed": true,
  "NextMilestoneDate": "2008-04-29T16:32:39.6021536+02:00",
  "NmdAppointmentId": 659,
  "EndDate": "2011-02-20T16:32:39.6021536+01:00",
  "ActiveErpLinks": 686,
  "UserDefinedFields": {
    "SuperOffice:1": "Camden Tracy Hodkiewicz III",
    "SuperOffice:2": "Christian Conn"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2015-07-12T16:32:39.6021536+02:00",
  "PublishTo": "2004-07-23T16:32:39.6021536+02:00",
  "PublishFrom": "1998-09-25T16:32:39.6021536+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```