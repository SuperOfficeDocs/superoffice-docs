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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 606,
  "Name": "Jerde, Schumm and West",
  "ProjectNumber": "762130",
  "ProjectMembers": [
    {
      "ProjectmemberId": 185,
      "ContactId": 86,
      "ProjectId": 80,
      "ContactName": "Abernathy, Schinner and Haley",
      "ContactDepartment": "integrate sexy action-items",
      "ProjectName": "Pfannerstill-Olson",
      "EmailId": 298,
      "EmailAddress": "elda@watsica.us",
      "CountryId": 5,
      "Firstname": "Fannie",
      "MiddleName": "Green, Kunze and Heidenreich",
      "Lastname": "Welch",
      "PersonId": 480,
      "Mrmrs": "impedit",
      "ProjectMemberTypeName": "Maggio-Barton",
      "Phone": "235-864-2254 x03448",
      "PhoneId": 966,
      "ProjectMemberTypeId": 303,
      "EmailAddressName": "cyril_schuster@schinnerdibbert.biz",
      "Comment": "omnis",
      "FullName": "Ms. Devon Keeling V"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "illum",
      "Description": "Ameliorated fresh-thinking portal"
    },
    {
      "Value": "non",
      "StrippedValue": "illum",
      "Description": "Ameliorated fresh-thinking portal"
    }
  ],
  "CreatedDate": "2020-11-08T23:04:04.4190162+01:00",
  "UpdatedDate": "2008-07-21T23:04:04.4190162+02:00",
  "Description": "Pre-emptive stable secured line",
  "Postit": "autem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "De-engineered bifurcated website",
  "ActiveStatusMonitorId": 945,
  "Links": [
    {
      "EntityName": "Lueilwitz, McLaughlin and Langosh",
      "Id": 674,
      "Description": "Enterprise-wide full-range framework",
      "ExtraInfo": "eos",
      "LinkId": 149
    },
    {
      "EntityName": "Lueilwitz, McLaughlin and Langosh",
      "Id": 674,
      "Description": "Enterprise-wide full-range framework",
      "ExtraInfo": "eos",
      "LinkId": 149
    }
  ],
  "ActiveLinks": 604,
  "Completed": false,
  "NextMilestoneDate": "2010-08-04T23:04:04.4260167+02:00",
  "NmdAppointmentId": 960,
  "EndDate": "2002-01-25T23:04:04.4260167+01:00",
  "ActiveErpLinks": 277,
  "UserDefinedFields": {
    "SuperOffice:1": "Adrain Hackett",
    "SuperOffice:2": "Darion Kovacek"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "ea"
  },
  "PublishEventDate": "2019-12-17T23:04:04.4265151+01:00",
  "PublishTo": "2012-05-02T23:04:04.4265151+02:00",
  "PublishFrom": "2003-11-18T23:04:04.4265151+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 684,
  "Name": "Friesen-Gerlach",
  "ProjectNumber": "666236",
  "ProjectMembers": [
    {
      "ProjectmemberId": 691,
      "ContactId": 836,
      "ProjectId": 159,
      "ContactName": "Bergnaum, Mohr and Mann",
      "ContactDepartment": "",
      "ProjectName": "Wisozk, Skiles and Wiegand",
      "EmailId": 915,
      "EmailAddress": "maximilian_frami@batz.ca",
      "CountryId": 609,
      "Firstname": "Matilde",
      "MiddleName": "Weimann, Grant and DuBuque",
      "Lastname": "Larkin",
      "PersonId": 677,
      "Mrmrs": "aliquam",
      "ProjectMemberTypeName": "Connelly-Rau",
      "Phone": "1-691-819-1551 x51652",
      "PhoneId": 106,
      "ProjectMemberTypeId": 738,
      "EmailAddressName": "destini@ratkeosinski.name",
      "Comment": "deserunt",
      "FullName": "Luz Spencer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "omnis",
      "Description": "Compatible disintermediate parallelism",
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
      "Value": "eveniet",
      "StrippedValue": "omnis",
      "Description": "Compatible disintermediate parallelism",
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
  "CreatedDate": "2023-05-23T23:04:04.4305139+02:00",
  "UpdatedDate": "2001-11-26T23:04:04.4305139+01:00",
  "Description": "Synergistic bottom-line initiative",
  "Postit": "dolore",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Reactive content-based function",
  "ActiveStatusMonitorId": 118,
  "Links": [
    {
      "EntityName": "Grimes Group",
      "Id": 162,
      "Description": "Cross-group bifurcated core",
      "ExtraInfo": "neque",
      "LinkId": 558,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 947
        }
      }
    }
  ],
  "ActiveLinks": 789,
  "Completed": false,
  "NextMilestoneDate": "2018-11-13T23:04:04.4315139+01:00",
  "NmdAppointmentId": 771,
  "EndDate": "2008-02-01T23:04:04.4315139+01:00",
  "ActiveErpLinks": 127,
  "UserDefinedFields": {
    "SuperOffice:1": "13962103",
    "SuperOffice:2": "Mrs. Christina Towne IV"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2004-04-08T23:04:04.4320137+02:00",
  "PublishTo": "2000-08-11T23:04:04.4320137+02:00",
  "PublishFrom": "2016-10-01T23:04:04.4320137+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 878
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```