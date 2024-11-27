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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 292,
  "Name": "Adams Group",
  "ProjectNumber": "1044432",
  "ProjectMembers": [
    {
      "ProjectmemberId": 309,
      "ContactId": 406,
      "ProjectId": 70,
      "ContactName": "Will-Lynch",
      "ContactDepartment": "e-enable bricks-and-clicks e-markets",
      "ProjectName": "Welch-Farrell",
      "EmailId": 958,
      "EmailAddress": "jeff@vandervort.name",
      "CountryId": 908,
      "Firstname": "Rita",
      "MiddleName": "Mraz-Cormier",
      "Lastname": "Greenfelder",
      "PersonId": 657,
      "Mrmrs": "voluptate",
      "ProjectMemberTypeName": "Sawayn, Runolfsson and Kulas",
      "Phone": "629.350.9061 x35696",
      "PhoneId": 834,
      "ProjectMemberTypeId": 210,
      "EmailAddressName": "edd_runte@thielweimann.uk",
      "Comment": "consequatur",
      "FullName": "Geovany Hills"
    }
  ],
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "tempore",
      "Description": "Horizontal methodical groupware"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "tempore",
      "Description": "Horizontal methodical groupware"
    }
  ],
  "CreatedDate": "2018-01-27T14:45:05.9750288+01:00",
  "UpdatedDate": "2012-10-31T14:45:05.9750288+01:00",
  "Description": "Secured methodical internet solution",
  "Postit": "sed",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Triple-buffered discrete portal",
  "ActiveStatusMonitorId": 306,
  "Links": [
    {
      "EntityName": "Volkman, Frami and Nader",
      "Id": 464,
      "Description": "Cross-group explicit matrix",
      "ExtraInfo": "aliquid",
      "LinkId": 250
    },
    {
      "EntityName": "Volkman, Frami and Nader",
      "Id": 464,
      "Description": "Cross-group explicit matrix",
      "ExtraInfo": "aliquid",
      "LinkId": 250
    }
  ],
  "ActiveLinks": 438,
  "Completed": false,
  "NextMilestoneDate": "2017-10-14T14:45:05.9750288+02:00",
  "NmdAppointmentId": 577,
  "EndDate": "2018-08-22T14:45:05.9750288+02:00",
  "ActiveErpLinks": 452,
  "UserDefinedFields": {
    "SuperOffice:1": "Ole Boehm",
    "SuperOffice:2": "Narciso Windler"
  },
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "numquam"
  },
  "PublishEventDate": "2019-12-22T14:45:05.9750288+01:00",
  "PublishTo": "2019-11-29T14:45:05.9750288+01:00",
  "PublishFrom": "2020-10-19T14:45:05.9750288+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 674,
  "Name": "VonRueden, Zulauf and Ernser",
  "ProjectNumber": "775861",
  "ProjectMembers": [
    {
      "ProjectmemberId": 936,
      "ContactId": 256,
      "ProjectId": 504,
      "ContactName": "Kunze, Nienow and Effertz",
      "ContactDepartment": "",
      "ProjectName": "Rogahn Group",
      "EmailId": 181,
      "EmailAddress": "kassandra.kihn@predovicboehm.us",
      "CountryId": 102,
      "Firstname": "Reece",
      "MiddleName": "O'Keefe, Kiehn and Cormier",
      "Lastname": "Orn",
      "PersonId": 365,
      "Mrmrs": "eum",
      "ProjectMemberTypeName": "Schowalter-Tremblay",
      "Phone": "(307)877-4991",
      "PhoneId": 815,
      "ProjectMemberTypeId": 633,
      "EmailAddressName": "emmy.kris@millsbashirian.name",
      "Comment": "repellendus",
      "FullName": "Ethyl Prosacco",
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
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "voluptate",
      "Description": "Organized even-keeled toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "voluptate",
      "Description": "Organized even-keeled toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "CreatedDate": "2006-07-25T14:45:05.9750288+02:00",
  "UpdatedDate": "2022-10-09T14:45:05.9750288+02:00",
  "Description": "Pre-emptive local collaboration",
  "Postit": "eveniet",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Sharable tertiary alliance",
  "ActiveStatusMonitorId": 466,
  "Links": [
    {
      "EntityName": "Green Group",
      "Id": 23,
      "Description": "De-engineered cohesive encoding",
      "ExtraInfo": "consectetur",
      "LinkId": 441,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "ActiveLinks": 600,
  "Completed": false,
  "NextMilestoneDate": "2016-12-13T14:45:05.9906489+01:00",
  "NmdAppointmentId": 177,
  "EndDate": "2015-10-07T14:45:05.9906489+02:00",
  "ActiveErpLinks": 32,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Kamron Eliza Christiansen DDS",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "ducimus"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "1999-01-18T14:45:05.9906489+01:00",
  "PublishTo": "2001-07-17T14:45:05.9906489+02:00",
  "PublishFrom": "2008-11-18T14:45:05.9906489+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 636
    }
  }
}
```