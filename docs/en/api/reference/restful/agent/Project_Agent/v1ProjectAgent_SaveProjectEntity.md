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
  "ProjectId": 452,
  "Name": "Roberts LLC",
  "ProjectNumber": "1092490",
  "ProjectMembers": [
    {
      "ProjectmemberId": 71,
      "ContactId": 111,
      "ProjectId": 949,
      "ContactName": "Schiller, Monahan and Brown",
      "ContactDepartment": "",
      "ProjectName": "Vandervort-Hyatt",
      "EmailId": 920,
      "EmailAddress": "nat@quitzonstanton.co.uk",
      "CountryId": 689,
      "Firstname": "Ova",
      "MiddleName": "Flatley Group",
      "Lastname": "Dooley",
      "PersonId": 158,
      "Mrmrs": "ad",
      "ProjectMemberTypeName": "Pfannerstill-Lowe",
      "Phone": "1-425-885-2717 x5392",
      "PhoneId": 13,
      "ProjectMemberTypeId": 685,
      "EmailAddressName": "stanford.doyle@coleblock.uk",
      "Comment": "excepturi",
      "FullName": "Ms. Kristopher Moore"
    }
  ],
  "Urls": [
    {
      "Value": "maiores",
      "StrippedValue": "quos",
      "Description": "Self-enabling disintermediate pricing structure"
    },
    {
      "Value": "maiores",
      "StrippedValue": "quos",
      "Description": "Self-enabling disintermediate pricing structure"
    }
  ],
  "CreatedDate": "2010-12-29T14:19:03.9219591+01:00",
  "UpdatedDate": "2019-07-28T14:19:03.9219591+02:00",
  "Description": "Centralized solution-oriented core",
  "Postit": "saepe",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Business-focused executive groupware",
  "ActiveStatusMonitorId": 369,
  "Links": [
    {
      "EntityName": "Jaskolski Inc and Sons",
      "Id": 286,
      "Description": "Operative bifurcated definition",
      "ExtraInfo": "aut",
      "LinkId": 231
    },
    {
      "EntityName": "Jaskolski Inc and Sons",
      "Id": 286,
      "Description": "Operative bifurcated definition",
      "ExtraInfo": "aut",
      "LinkId": 231
    }
  ],
  "ActiveLinks": 843,
  "Completed": false,
  "NextMilestoneDate": "2021-01-31T14:19:03.9219591+01:00",
  "NmdAppointmentId": 603,
  "EndDate": "2008-11-14T14:19:03.9219591+01:00",
  "ActiveErpLinks": 352,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Charlie Ethan Macejkovic Jr.",
    "SuperOffice:2": "Liza Boyle"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "officia"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "fuga"
  },
  "PublishEventDate": "2015-11-16T14:19:03.9219591+01:00",
  "PublishTo": "2017-08-09T14:19:03.9219591+02:00",
  "PublishFrom": "1995-10-14T14:19:03.9219591+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 411,
  "Name": "Batz-Howell",
  "ProjectNumber": "995196",
  "ProjectMembers": [
    {
      "ProjectmemberId": 426,
      "ContactId": 738,
      "ProjectId": 130,
      "ContactName": "Wiegand, Schuster and Schmitt",
      "ContactDepartment": "",
      "ProjectName": "Kulas LLC",
      "EmailId": 548,
      "EmailAddress": "kiarra_mcglynn@whitechamplin.name",
      "CountryId": 255,
      "Firstname": "Allison",
      "MiddleName": "Beier Inc and Sons",
      "Lastname": "Kreiger",
      "PersonId": 792,
      "Mrmrs": "deleniti",
      "ProjectMemberTypeName": "Greenholt-Skiles",
      "Phone": "(513)603-1326 x05393",
      "PhoneId": 29,
      "ProjectMemberTypeId": 548,
      "EmailAddressName": "hellen@simonis.uk",
      "Comment": "quas",
      "FullName": "Leo Golden Howell I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "optio",
      "StrippedValue": "explicabo",
      "Description": "User-friendly heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "explicabo",
      "Description": "User-friendly heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    }
  ],
  "CreatedDate": "2022-02-15T14:19:03.9219591+01:00",
  "UpdatedDate": "2017-02-25T14:19:03.9219591+01:00",
  "Description": "Customizable tertiary paradigm",
  "Postit": "quaerat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Team-oriented background artificial intelligence",
  "ActiveStatusMonitorId": 341,
  "Links": [
    {
      "EntityName": "Luettgen, Towne and Kemmer",
      "Id": 333,
      "Description": "Function-based mission-critical forecast",
      "ExtraInfo": "suscipit",
      "LinkId": 382,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "ActiveLinks": 579,
  "Completed": false,
  "NextMilestoneDate": "1998-04-21T14:19:03.9219591+02:00",
  "NmdAppointmentId": 23,
  "EndDate": "2011-08-07T14:19:03.9219591+02:00",
  "ActiveErpLinks": 715,
  "UserDefinedFields": {
    "SuperOffice:1": "2054672223",
    "SuperOffice:2": "Fred Lockman"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "quisquam"
  },
  "PublishEventDate": "2001-02-25T14:19:03.9219591+01:00",
  "PublishTo": "2009-12-07T14:19:03.9219591+01:00",
  "PublishFrom": "2001-04-10T14:19:03.9219591+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 116
    }
  }
}
```