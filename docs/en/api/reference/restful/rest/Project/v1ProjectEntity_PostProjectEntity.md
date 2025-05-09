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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 376,
  "Name": "Turner Inc and Sons",
  "ProjectNumber": "1393643",
  "ProjectMembers": [
    {
      "ProjectmemberId": 896,
      "ContactId": 61,
      "ProjectId": 388,
      "ContactName": "Herzog-Stanton",
      "ContactDepartment": "",
      "ProjectName": "Daniel-Borer",
      "EmailId": 444,
      "EmailAddress": "linwood@rolfsonhartmann.co.uk",
      "CountryId": 702,
      "Firstname": "Dangelo",
      "MiddleName": "Glover Inc and Sons",
      "Lastname": "Beier",
      "PersonId": 468,
      "Mrmrs": "recusandae",
      "ProjectMemberTypeName": "Russel-Bosco",
      "Phone": "651.135.3329",
      "PhoneId": 797,
      "ProjectMemberTypeId": 337,
      "EmailAddressName": "julianne@welch.co.uk",
      "Comment": "nesciunt",
      "FullName": "Mr. April Dietrich"
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "dolores",
      "Description": "Versatile system-worthy concept"
    },
    {
      "Value": "in",
      "StrippedValue": "dolores",
      "Description": "Versatile system-worthy concept"
    }
  ],
  "CreatedDate": "2016-11-19T16:32:47.6964194+01:00",
  "UpdatedDate": "2015-08-28T16:32:47.6964194+02:00",
  "Description": "Fundamental global hierarchy",
  "Postit": "odit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Organized maximized knowledge base",
  "ActiveStatusMonitorId": 722,
  "Links": [
    {
      "EntityName": "Gerhold-Kutch",
      "Id": 363,
      "Description": "Fundamental 24/7 initiative",
      "ExtraInfo": "laudantium",
      "LinkId": 861
    },
    {
      "EntityName": "Gerhold-Kutch",
      "Id": 363,
      "Description": "Fundamental 24/7 initiative",
      "ExtraInfo": "laudantium",
      "LinkId": 861
    }
  ],
  "ActiveLinks": 927,
  "Completed": false,
  "NextMilestoneDate": "2011-01-01T16:32:47.6964194+01:00",
  "NmdAppointmentId": 98,
  "EndDate": "2000-07-28T16:32:47.6964194+02:00",
  "ActiveErpLinks": 665,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "harum"
  },
  "PublishEventDate": "2009-05-21T16:32:47.6964194+02:00",
  "PublishTo": "2012-03-10T16:32:47.6964194+01:00",
  "PublishFrom": "2023-02-09T16:32:47.6964194+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 962,
  "Name": "Bednar LLC",
  "ProjectNumber": "1134830",
  "ProjectMembers": [
    {
      "ProjectmemberId": 256,
      "ContactId": 767,
      "ProjectId": 47,
      "ContactName": "Klocko, Keeling and Robel",
      "ContactDepartment": "",
      "ProjectName": "Dibbert Group",
      "EmailId": 664,
      "EmailAddress": "scarlett@labadie.info",
      "CountryId": 541,
      "Firstname": "Judy",
      "MiddleName": "Boehm Group",
      "Lastname": "Rosenbaum",
      "PersonId": 517,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "Legros LLC",
      "Phone": "731-693-5342",
      "PhoneId": 763,
      "ProjectMemberTypeId": 106,
      "EmailAddressName": "angeline@blanda.ca",
      "Comment": "est",
      "FullName": "Dena Nolan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "veniam",
      "Description": "Reactive client-server core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "veniam",
      "Description": "Reactive client-server core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "CreatedDate": "2001-01-14T16:32:47.7120406+01:00",
  "UpdatedDate": "2016-05-17T16:32:47.7120406+02:00",
  "Description": "Programmable asynchronous task-force",
  "Postit": "ex",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Face to face fault-tolerant portal",
  "ActiveStatusMonitorId": 235,
  "Links": [
    {
      "EntityName": "Terry, Nienow and Braun",
      "Id": 446,
      "Description": "Progressive methodical productivity",
      "ExtraInfo": "qui",
      "LinkId": 92,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "ActiveLinks": 763,
  "Completed": false,
  "NextMilestoneDate": "2016-08-31T16:32:47.7120406+02:00",
  "NmdAppointmentId": 891,
  "EndDate": "2003-12-04T16:32:47.7120406+01:00",
  "ActiveErpLinks": 115,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Jacinthe Freeda Lebsack III"
  },
  "ExtraFields": {
    "ExtraFields1": "dolore",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "quaerat"
  },
  "PublishEventDate": "2000-07-27T16:32:47.7120406+02:00",
  "PublishTo": "2007-11-20T16:32:47.7120406+01:00",
  "PublishFrom": "2011-05-16T16:32:47.7120406+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 223
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```