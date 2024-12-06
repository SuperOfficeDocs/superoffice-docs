---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 141,
  "Name": "Kuhn LLC",
  "ProjectNumber": "1058757",
  "ProjectMembers": [
    {
      "ProjectmemberId": 203,
      "ContactId": 483,
      "ProjectId": 488,
      "ContactName": "Barton, Gibson and Spinka",
      "ContactDepartment": "",
      "ProjectName": "Kunze Group",
      "EmailId": 556,
      "EmailAddress": "jewell.morissette@gloverbeahan.biz",
      "CountryId": 234,
      "Firstname": "Estevan",
      "MiddleName": "Russel Group",
      "Lastname": "Boyer",
      "PersonId": 810,
      "Mrmrs": "iste",
      "ProjectMemberTypeName": "Greenfelder, Kuhic and Huels",
      "Phone": "(298)101-5776 x60213",
      "PhoneId": 109,
      "ProjectMemberTypeId": 284,
      "EmailAddressName": "mackenzie.kutch@schulistrunte.ca",
      "Comment": "doloribus",
      "FullName": "Amber Kovacek"
    }
  ],
  "Urls": [
    {
      "Value": "quas",
      "StrippedValue": "dignissimos",
      "Description": "Business-focused 6th generation concept"
    },
    {
      "Value": "quas",
      "StrippedValue": "dignissimos",
      "Description": "Business-focused 6th generation concept"
    }
  ],
  "CreatedDate": "2018-06-14T10:18:00.5043364+02:00",
  "UpdatedDate": "2008-08-05T10:18:00.5043364+02:00",
  "Description": "Visionary clear-thinking instruction set",
  "Postit": "earum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-lateral maximized Graphical User Interface",
  "ActiveStatusMonitorId": 156,
  "Links": [
    {
      "EntityName": "Schmeler Group",
      "Id": 121,
      "Description": "Multi-lateral empowering portal",
      "ExtraInfo": "porro",
      "LinkId": 726
    },
    {
      "EntityName": "Schmeler Group",
      "Id": 121,
      "Description": "Multi-lateral empowering portal",
      "ExtraInfo": "porro",
      "LinkId": 726
    }
  ],
  "ActiveLinks": 592,
  "Completed": false,
  "NextMilestoneDate": "2005-10-19T10:18:00.5043364+02:00",
  "NmdAppointmentId": 988,
  "EndDate": "2013-09-26T10:18:00.5043364+02:00",
  "ActiveErpLinks": 794,
  "UserDefinedFields": {
    "SuperOffice:1": "Chloe Rohan",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "repudiandae"
  },
  "PublishEventDate": "2024-02-19T10:18:00.5043364+01:00",
  "PublishTo": "2010-04-18T10:18:00.5043364+02:00",
  "PublishFrom": "2007-06-02T10:18:00.5043364+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 128,
  "Name": "Bashirian Group",
  "ProjectNumber": "825499",
  "ProjectMembers": [
    {
      "ProjectmemberId": 308,
      "ContactId": 528,
      "ProjectId": 715,
      "ContactName": "Kiehn Group",
      "ContactDepartment": "e-enable bleeding-edge partnerships",
      "ProjectName": "Batz-Rohan",
      "EmailId": 114,
      "EmailAddress": "dustin_will@sawayn.info",
      "CountryId": 487,
      "Firstname": "Beatrice",
      "MiddleName": "Gleason, Johnston and Corkery",
      "Lastname": "Schumm",
      "PersonId": 317,
      "Mrmrs": "id",
      "ProjectMemberTypeName": "Graham Group",
      "Phone": "1-603-983-1151",
      "PhoneId": 554,
      "ProjectMemberTypeId": 88,
      "EmailAddressName": "brook_cassin@labadie.ca",
      "Comment": "architecto",
      "FullName": "Abigale Haag",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "nostrum",
      "Description": "Business-focused discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "nostrum",
      "Description": "Business-focused discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "CreatedDate": "2002-05-16T10:18:00.5043364+02:00",
  "UpdatedDate": "2001-03-08T10:18:00.5043364+01:00",
  "Description": "Quality-focused content-based hardware",
  "Postit": "laudantium",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Reduced empowering capability",
  "ActiveStatusMonitorId": 22,
  "Links": [
    {
      "EntityName": "Dickens, Koss and Lebsack",
      "Id": 365,
      "Description": "Expanded 4th generation strategy",
      "ExtraInfo": "est",
      "LinkId": 592,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "ActiveLinks": 748,
  "Completed": false,
  "NextMilestoneDate": "2000-12-11T10:18:00.5043364+01:00",
  "NmdAppointmentId": 849,
  "EndDate": "2020-05-24T10:18:00.5043364+02:00",
  "ActiveErpLinks": 288,
  "UserDefinedFields": {
    "SuperOffice:1": "Madelyn Prosacco",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2002-02-16T10:18:00.5043364+01:00",
  "PublishTo": "2000-04-17T10:18:00.5043364+02:00",
  "PublishFrom": "2004-08-18T10:18:00.5043364+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 967
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```