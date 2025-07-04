---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
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

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 914,
  "Name": "Rohan, Pfeffer and Wisoky",
  "ProjectNumber": "965280",
  "ProjectMembers": [
    {
      "ProjectmemberId": 364,
      "ContactId": 553,
      "ProjectId": 288,
      "ContactName": "Runte Inc and Sons",
      "ContactDepartment": "redefine compelling bandwidth",
      "ProjectName": "Wiza Group",
      "EmailId": 255,
      "EmailAddress": "colleen.fay@rutherford.uk",
      "CountryId": 868,
      "Firstname": "Kobe",
      "MiddleName": "Doyle LLC",
      "Lastname": "Gottlieb",
      "PersonId": 749,
      "Mrmrs": "eius",
      "ProjectMemberTypeName": "Maggio LLC",
      "Phone": "(859)698-3942 x6658",
      "PhoneId": 127,
      "ProjectMemberTypeId": 606,
      "EmailAddressName": "jaden_parker@hoppe.biz",
      "Comment": "commodi",
      "FullName": "Dr. Bradly Runolfsdottir"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "placeat",
      "Description": "Grass-roots transitional function"
    },
    {
      "Value": "quo",
      "StrippedValue": "placeat",
      "Description": "Grass-roots transitional function"
    }
  ],
  "CreatedDate": "2007-09-17T03:45:28.4984325+02:00",
  "UpdatedDate": "1999-12-26T03:45:28.4984325+01:00",
  "Description": "Inverse real-time concept",
  "Postit": "quod",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Exclusive optimal open architecture",
  "ActiveStatusMonitorId": 178,
  "Links": [
    {
      "EntityName": "Stark Group",
      "Id": 255,
      "Description": "Optimized systemic project",
      "ExtraInfo": "aut",
      "LinkId": 755
    },
    {
      "EntityName": "Stark Group",
      "Id": 255,
      "Description": "Optimized systemic project",
      "ExtraInfo": "aut",
      "LinkId": 755
    }
  ],
  "ActiveLinks": 602,
  "Completed": true,
  "NextMilestoneDate": "2010-04-25T03:45:28.4984325+02:00",
  "NmdAppointmentId": 110,
  "EndDate": "2012-09-16T03:45:28.4984325+02:00",
  "ActiveErpLinks": 398,
  "UserDefinedFields": {
    "SuperOffice:1": "486878096",
    "SuperOffice:2": "Cassie Feil"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "dolores"
  },
  "PublishEventDate": "2010-09-22T03:45:28.4984325+02:00",
  "PublishTo": "2003-08-13T03:45:28.4984325+02:00",
  "PublishFrom": "2016-12-10T03:45:28.4984325+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 124,
  "Name": "Schowalter LLC",
  "ProjectNumber": "1283262",
  "ProjectMembers": [
    {
      "ProjectmemberId": 381,
      "ContactId": 136,
      "ProjectId": 640,
      "ContactName": "Parker, Blick and Carroll",
      "ContactDepartment": "",
      "ProjectName": "O'Kon LLC",
      "EmailId": 978,
      "EmailAddress": "hadley_marks@franecki.us",
      "CountryId": 378,
      "Firstname": "Kaycee",
      "MiddleName": "Howell-Bailey",
      "Lastname": "Rath",
      "PersonId": 638,
      "Mrmrs": "possimus",
      "ProjectMemberTypeName": "Sanford, VonRueden and Stokes",
      "Phone": "1-282-190-5606 x333",
      "PhoneId": 454,
      "ProjectMemberTypeId": 138,
      "EmailAddressName": "carroll@wiza.biz",
      "Comment": "recusandae",
      "FullName": "Miss Rafaela Will Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "nisi",
      "Description": "Ergonomic motivating matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "nisi",
      "Description": "Ergonomic motivating matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    }
  ],
  "CreatedDate": "2025-02-20T03:45:28.4984325+01:00",
  "UpdatedDate": "2015-03-24T03:45:28.4984325+01:00",
  "Description": "Re-engineered bandwidth-monitored access",
  "Postit": "modi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-channelled grid-enabled policy",
  "ActiveStatusMonitorId": 71,
  "Links": [
    {
      "EntityName": "Emmerich-Metz",
      "Id": 370,
      "Description": "Open-architected even-keeled array",
      "ExtraInfo": "numquam",
      "LinkId": 347,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "ActiveLinks": 314,
  "Completed": false,
  "NextMilestoneDate": "1998-08-19T03:45:28.4984325+02:00",
  "NmdAppointmentId": 271,
  "EndDate": "2010-03-25T03:45:28.4984325+01:00",
  "ActiveErpLinks": 386,
  "UserDefinedFields": {
    "SuperOffice:1": "1158426338",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "similique"
  },
  "PublishEventDate": "2015-11-24T03:45:28.4984325+01:00",
  "PublishTo": "2000-02-21T03:45:28.4984325+01:00",
  "PublishFrom": "2022-10-23T03:45:28.4984325+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 309
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```