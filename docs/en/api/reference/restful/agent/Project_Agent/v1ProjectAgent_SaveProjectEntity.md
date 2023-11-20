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
  "ProjectId": 941,
  "Name": "Stehr, Wolf and Walter",
  "ProjectNumber": "1187941",
  "ProjectMembers": [
    {
      "ProjectmemberId": 78,
      "ContactId": 121,
      "ProjectId": 243,
      "ContactName": "Jewess Group",
      "ContactDepartment": "",
      "ProjectName": "Olson Inc and Sons",
      "EmailId": 472,
      "EmailAddress": "celia@marks.uk",
      "CountryId": 872,
      "Firstname": "Jeanette",
      "MiddleName": "Mante, Klocko and Champlin",
      "Lastname": "Cronin",
      "PersonId": 251,
      "Mrmrs": "aperiam",
      "ProjectMemberTypeName": "Steuber-Bergnaum",
      "Phone": "321.122.6583 x06433",
      "PhoneId": 332,
      "ProjectMemberTypeId": 749,
      "EmailAddressName": "vito@kohler.biz",
      "Comment": "inventore",
      "FullName": "Miss Abbigail Shields"
    }
  ],
  "Urls": [
    {
      "Value": "expedita",
      "StrippedValue": "sunt",
      "Description": "Versatile 3rd generation open architecture"
    },
    {
      "Value": "expedita",
      "StrippedValue": "sunt",
      "Description": "Versatile 3rd generation open architecture"
    }
  ],
  "CreatedDate": "2014-05-17T13:38:13.8741019+02:00",
  "UpdatedDate": "2001-03-22T13:38:13.8741019+01:00",
  "Description": "Business-focused static migration",
  "Postit": "omnis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-layered regional architecture",
  "ActiveStatusMonitorId": 282,
  "Links": [
    {
      "EntityName": "Walsh, Johnston and Lang",
      "Id": 564,
      "Description": "Extended regional Graphical User Interface",
      "ExtraInfo": "laudantium",
      "LinkId": 416
    },
    {
      "EntityName": "Walsh, Johnston and Lang",
      "Id": 564,
      "Description": "Extended regional Graphical User Interface",
      "ExtraInfo": "laudantium",
      "LinkId": 416
    }
  ],
  "ActiveLinks": 506,
  "Completed": false,
  "NextMilestoneDate": "2010-07-23T13:38:13.8741019+02:00",
  "NmdAppointmentId": 686,
  "EndDate": "2013-03-15T13:38:13.8741019+01:00",
  "ActiveErpLinks": 596,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Benjamin Feil DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2013-07-10T13:38:13.8741019+02:00",
  "PublishTo": "2020-05-09T13:38:13.8741019+02:00",
  "PublishFrom": "2001-09-01T13:38:13.8741019+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 48,
  "Name": "Farrell Group",
  "ProjectNumber": "1678431",
  "ProjectMembers": [
    {
      "ProjectmemberId": 394,
      "ContactId": 324,
      "ProjectId": 41,
      "ContactName": "Ratke, Bashirian and Leuschke",
      "ContactDepartment": "",
      "ProjectName": "Miller-Zulauf",
      "EmailId": 128,
      "EmailAddress": "ken@koss.uk",
      "CountryId": 839,
      "Firstname": "Jude",
      "MiddleName": "Gleichner Group",
      "Lastname": "Marvin",
      "PersonId": 902,
      "Mrmrs": "vero",
      "ProjectMemberTypeName": "Kling, Armstrong and Bashirian",
      "Phone": "1-505-691-6703",
      "PhoneId": 456,
      "ProjectMemberTypeId": 402,
      "EmailAddressName": "mckenzie@andersonharvey.uk",
      "Comment": "esse",
      "FullName": "Devonte Reichel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "cumque",
      "Description": "Cross-platform motivating moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "cumque",
      "Description": "Cross-platform motivating moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 705
        }
      }
    }
  ],
  "CreatedDate": "2022-08-30T13:38:13.8741019+02:00",
  "UpdatedDate": "2020-10-18T13:38:13.8741019+02:00",
  "Description": "Customer-focused object-oriented parallelism",
  "Postit": "consequatur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Reduced modular open system",
  "ActiveStatusMonitorId": 392,
  "Links": [
    {
      "EntityName": "Parker-Welch",
      "Id": 632,
      "Description": "Virtual encompassing intranet",
      "ExtraInfo": "impedit",
      "LinkId": 118,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "ActiveLinks": 833,
  "Completed": false,
  "NextMilestoneDate": "2012-04-11T13:38:13.8741019+02:00",
  "NmdAppointmentId": 573,
  "EndDate": "2004-06-15T13:38:13.8741019+02:00",
  "ActiveErpLinks": 884,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Sigurd Heidenreich"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "deleniti"
  },
  "PublishEventDate": "2006-01-01T13:38:13.8741019+01:00",
  "PublishTo": "2010-01-18T13:38:13.8741019+01:00",
  "PublishFrom": "2010-03-23T13:38:13.8741019+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 388
    }
  }
}
```