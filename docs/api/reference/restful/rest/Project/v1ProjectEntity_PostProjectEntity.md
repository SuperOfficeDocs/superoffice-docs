---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity

Calls the Project agent service SaveProjectEntity.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

The ProjectEntity to be saved.

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 35,
  "Name": "Walsh, Jacobson and Reichel",
  "ProjectNumber": "1288430",
  "ProjectMembers": [
    {
      "ProjectmemberId": 581,
      "ContactId": 787,
      "ProjectId": 812,
      "ContactName": "Cremin, Baumbach and Rice",
      "ContactDepartment": "",
      "ProjectName": "Torp LLC",
      "EmailId": 455,
      "EmailAddress": "jon_beatty@fisher.uk",
      "CountryId": 496,
      "Firstname": "Miller",
      "MiddleName": "Dare, Rolfson and Wunsch",
      "Lastname": "Blanda",
      "PersonId": 55,
      "Mrmrs": "aut",
      "ProjectMemberTypeName": "Oberbrunner LLC",
      "Phone": "(053)292-2927 x07004",
      "PhoneId": 170,
      "ProjectMemberTypeId": 708,
      "EmailAddressName": "ofelia@flatleysporer.info",
      "Comment": "nisi",
      "FullName": "Guiseppe Effertz"
    }
  ],
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "cum",
      "Description": "Quality-focused discrete software"
    },
    {
      "Value": "iusto",
      "StrippedValue": "cum",
      "Description": "Quality-focused discrete software"
    }
  ],
  "CreatedDate": "2018-11-03T11:10:53.2741815+01:00",
  "UpdatedDate": "2001-03-01T11:10:53.2741815+01:00",
  "Description": "Public-key encompassing attitude",
  "Postit": "porro",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Multi-layered logistical migration",
  "ActiveStatusMonitorId": 733,
  "Links": [
    {
      "EntityName": "Wilderman Inc and Sons",
      "Id": 146,
      "Description": "User-centric client-server secured line",
      "ExtraInfo": "illum",
      "LinkId": 830
    },
    {
      "EntityName": "Wilderman Inc and Sons",
      "Id": 146,
      "Description": "User-centric client-server secured line",
      "ExtraInfo": "illum",
      "LinkId": 830
    }
  ],
  "ActiveLinks": 606,
  "Completed": false,
  "NextMilestoneDate": "2014-01-20T11:10:53.2751847+01:00",
  "NmdAppointmentId": 335,
  "EndDate": "2004-11-27T11:10:53.2751847+01:00",
  "ActiveErpLinks": 179,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "deleniti"
  },
  "PublishEventDate": "2008-04-13T11:10:53.2751847+02:00",
  "PublishTo": "1997-03-17T11:10:53.2751847+01:00",
  "PublishFrom": "2010-05-23T11:10:53.2751847+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 926,
  "Name": "Zboncak LLC",
  "ProjectNumber": "1168708",
  "ProjectMembers": [
    {
      "ProjectmemberId": 590,
      "ContactId": 576,
      "ProjectId": 873,
      "ContactName": "Windler-Hartmann",
      "ContactDepartment": "",
      "ProjectName": "Thompson Group",
      "EmailId": 497,
      "EmailAddress": "lydia@schuppe.com",
      "CountryId": 510,
      "Firstname": "Frederique",
      "MiddleName": "Ledner LLC",
      "Lastname": "Schmitt",
      "PersonId": 644,
      "Mrmrs": "tempora",
      "ProjectMemberTypeName": "O'Keefe, Rau and Green",
      "Phone": "420.605.5172 x74025",
      "PhoneId": 659,
      "ProjectMemberTypeId": 368,
      "EmailAddressName": "soledad@beier.us",
      "Comment": "molestiae",
      "FullName": "Ms. Amparo Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "quae",
      "Description": "Assimilated web-enabled infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "quae",
      "Description": "Assimilated web-enabled infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "CreatedDate": "2003-06-14T11:10:53.2801796+02:00",
  "UpdatedDate": "1998-12-11T11:10:53.2801796+01:00",
  "Description": "Fundamental responsive orchestration",
  "Postit": "voluptatem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-lateral client-driven database",
  "ActiveStatusMonitorId": 885,
  "Links": [
    {
      "EntityName": "Abbott-Cassin",
      "Id": 158,
      "Description": "Phased next generation forecast",
      "ExtraInfo": "deserunt",
      "LinkId": 735,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 216
        }
      }
    }
  ],
  "ActiveLinks": 399,
  "Completed": false,
  "NextMilestoneDate": "1998-03-19T11:10:53.2811794+01:00",
  "NmdAppointmentId": 921,
  "EndDate": "2006-11-15T11:10:53.2811794+01:00",
  "ActiveErpLinks": 627,
  "UserDefinedFields": {
    "SuperOffice:1": "Zane Wisoky",
    "SuperOffice:2": "1754638870"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "sed"
  },
  "PublishEventDate": "2012-08-16T11:10:53.2811794+02:00",
  "PublishTo": "2019-06-15T11:10:53.2811794+02:00",
  "PublishFrom": "2022-08-07T11:10:53.2811794+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 141
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
