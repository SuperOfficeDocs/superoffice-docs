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
  "ProjectId": 816,
  "Name": "Zulauf-Zboncak",
  "ProjectNumber": "1101740",
  "ProjectMembers": [
    {
      "ProjectmemberId": 197,
      "ContactId": 648,
      "ProjectId": 406,
      "ContactName": "Marquardt LLC",
      "ContactDepartment": "",
      "ProjectName": "Simonis, Fahey and McCullough",
      "EmailId": 735,
      "EmailAddress": "thomas@schumm.us",
      "CountryId": 272,
      "Firstname": "Hipolito",
      "MiddleName": "Rippin, Cremin and Langosh",
      "Lastname": "Goyette",
      "PersonId": 956,
      "Mrmrs": "at",
      "ProjectMemberTypeName": "McCullough LLC",
      "Phone": "1-107-998-7434",
      "PhoneId": 802,
      "ProjectMemberTypeId": 760,
      "EmailAddressName": "athena@mcglynn.com",
      "Comment": "ut",
      "FullName": "Dr. Alta Turcotte"
    }
  ],
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled actuating alliance"
    },
    {
      "Value": "ad",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled actuating alliance"
    }
  ],
  "CreatedDate": "2007-11-21T11:44:34.1658395+01:00",
  "UpdatedDate": "2022-07-22T11:44:34.1658395+02:00",
  "Description": "Enterprise-wide tertiary capacity",
  "Postit": "officia",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Extended secondary hub",
  "ActiveStatusMonitorId": 574,
  "Links": [
    {
      "EntityName": "Kshlerin Inc and Sons",
      "Id": 803,
      "Description": "Streamlined demand-driven contingency",
      "ExtraInfo": "in",
      "LinkId": 641
    },
    {
      "EntityName": "Kshlerin Inc and Sons",
      "Id": 803,
      "Description": "Streamlined demand-driven contingency",
      "ExtraInfo": "in",
      "LinkId": 641
    }
  ],
  "ActiveLinks": 587,
  "Completed": false,
  "NextMilestoneDate": "2007-02-14T11:44:34.1658395+01:00",
  "NmdAppointmentId": 308,
  "EndDate": "2022-03-07T11:44:34.1658395+01:00",
  "ActiveErpLinks": 455,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Karina Kautzer"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "eligendi"
  },
  "PublishEventDate": "2023-06-30T11:44:34.1658395+02:00",
  "PublishTo": "2016-09-02T11:44:34.1658395+02:00",
  "PublishFrom": "2007-07-22T11:44:34.1658395+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 284,
  "Name": "Prosacco, Legros and Marvin",
  "ProjectNumber": "1040636",
  "ProjectMembers": [
    {
      "ProjectmemberId": 317,
      "ContactId": 350,
      "ProjectId": 346,
      "ContactName": "Aufderhar Group",
      "ContactDepartment": "",
      "ProjectName": "Volkman, Wisoky and O'Connell",
      "EmailId": 817,
      "EmailAddress": "general_schmidt@torphyquitzon.name",
      "CountryId": 235,
      "Firstname": "Eliane",
      "MiddleName": "Murphy-Crooks",
      "Lastname": "Mills",
      "PersonId": 35,
      "Mrmrs": "quidem",
      "ProjectMemberTypeName": "Cummings LLC",
      "Phone": "516-277-3820 x51648",
      "PhoneId": 891,
      "ProjectMemberTypeId": 853,
      "EmailAddressName": "felicity.schiller@reynolds.name",
      "Comment": "voluptates",
      "FullName": "Jordyn Raina Bogisich Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "voluptas",
      "Description": "Front-line dynamic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "voluptas",
      "Description": "Front-line dynamic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "CreatedDate": "2013-08-30T11:44:34.1658395+02:00",
  "UpdatedDate": "2011-01-25T11:44:34.1658395+01:00",
  "Description": "De-engineered multi-state matrices",
  "Postit": "vel",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Pre-emptive clear-thinking workforce",
  "ActiveStatusMonitorId": 988,
  "Links": [
    {
      "EntityName": "Torp, Pfannerstill and Witting",
      "Id": 758,
      "Description": "Reduced contextually-based moderator",
      "ExtraInfo": "sit",
      "LinkId": 529,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 829
        }
      }
    }
  ],
  "ActiveLinks": 197,
  "Completed": false,
  "NextMilestoneDate": "2012-07-27T11:44:34.1658395+02:00",
  "NmdAppointmentId": 762,
  "EndDate": "2020-12-12T11:44:34.1658395+01:00",
  "ActiveErpLinks": 359,
  "UserDefinedFields": {
    "SuperOffice:1": "25543889",
    "SuperOffice:2": "Prof. Lea Gutmann IV"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "tempora"
  },
  "PublishEventDate": "2002-02-26T11:44:34.1658395+01:00",
  "PublishTo": "2019-06-14T11:44:34.1658395+02:00",
  "PublishFrom": "2001-08-23T11:44:34.1658395+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 425
    }
  }
}
```