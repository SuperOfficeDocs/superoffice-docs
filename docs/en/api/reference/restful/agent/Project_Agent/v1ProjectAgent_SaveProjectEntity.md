---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is 0.


NsApiSlow threshold: 2000 ms.







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

## Request Body: projectEntity 

The ProjectEntity that is saved 

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
  "ProjectId": 973,
  "Name": "Herzog-Marvin",
  "ProjectNumber": "928539",
  "ProjectMembers": [
    {
      "ProjectmemberId": 734,
      "ContactId": 88,
      "ProjectId": 783,
      "ContactName": "Kreiger, Hettinger and Lockman",
      "ContactDepartment": "",
      "ProjectName": "Stehr, King and Howe",
      "EmailId": 779,
      "EmailAddress": "tyrell.labadie@boganboyer.ca",
      "CountryId": 391,
      "Firstname": "Kennedy",
      "MiddleName": "Larkin, Cassin and Veum",
      "Lastname": "Hauck",
      "PersonId": 526,
      "Mrmrs": "molestiae",
      "ProjectMemberTypeName": "Kemmer, Larson and Hirthe",
      "Phone": "(845)970-8852",
      "PhoneId": 379,
      "ProjectMemberTypeId": 770,
      "EmailAddressName": "josiah_kassulke@marks.com",
      "Comment": "occaecati",
      "FullName": "Prof. Elyssa Yost",
      "Registered": "2007-12-26T02:30:47.6632017+01:00",
      "Updated": "2005-03-31T02:30:47.6632017+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "voluptatem",
      "Description": "Open-architected heuristic structure"
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "voluptatem",
      "Description": "Open-architected heuristic structure"
    }
  ],
  "CreatedDate": "2014-08-02T02:30:47.6632017+02:00",
  "UpdatedDate": "2023-10-14T02:30:47.6632017+02:00",
  "Description": "Open-source content-based benchmark",
  "Postit": "doloribus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Reactive intermediate capability",
  "ActiveStatusMonitorId": 395,
  "Links": [
    {
      "EntityName": "Kiehn, Homenick and McGlynn",
      "Id": 581,
      "Description": "Persevering asynchronous hierarchy",
      "ExtraInfo": "quas",
      "LinkId": 844
    },
    {
      "EntityName": "Kiehn, Homenick and McGlynn",
      "Id": 581,
      "Description": "Persevering asynchronous hierarchy",
      "ExtraInfo": "quas",
      "LinkId": 844
    }
  ],
  "ActiveLinks": 518,
  "Completed": false,
  "NextMilestoneDate": "2009-04-29T02:30:47.6632017+02:00",
  "NmdAppointmentId": 784,
  "EndDate": "2020-12-31T02:30:47.6632017+01:00",
  "ActiveErpLinks": 518,
  "UserDefinedFields": {
    "SuperOffice:1": "Sibyl Hettinger",
    "SuperOffice:2": "Billie Beahan"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "vitae"
  },
  "PublishEventDate": "2015-11-23T02:30:47.6632017+01:00",
  "PublishTo": "1998-07-13T02:30:47.6632017+02:00",
  "PublishFrom": "2013-12-19T02:30:47.6632017+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 389,
  "Name": "Roberts Inc and Sons",
  "ProjectNumber": "361362",
  "ProjectMembers": [
    {
      "ProjectmemberId": 84,
      "ContactId": 982,
      "ProjectId": 838,
      "ContactName": "Graham-Jaskolski",
      "ContactDepartment": "",
      "ProjectName": "Kessler, Dickens and Lind",
      "EmailId": 293,
      "EmailAddress": "janae_monahan@goodwin.ca",
      "CountryId": 761,
      "Firstname": "Angela",
      "MiddleName": "Swaniawski-Ledner",
      "Lastname": "Cruickshank",
      "PersonId": 712,
      "Mrmrs": "blanditiis",
      "ProjectMemberTypeName": "Bogan Group",
      "Phone": "799.848.6789 x9998",
      "PhoneId": 765,
      "ProjectMemberTypeId": 985,
      "EmailAddressName": "sarai.wiza@dietrich.uk",
      "Comment": "natus",
      "FullName": "Mrs. Beth Purdy Sr.",
      "Registered": "2020-01-26T02:30:47.6632017+01:00",
      "Updated": "2013-07-11T02:30:47.6632017+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequuntur",
      "StrippedValue": "hic",
      "Description": "Innovative upward-trending structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "hic",
      "Description": "Innovative upward-trending structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    }
  ],
  "CreatedDate": "2016-10-25T02:30:47.6632017+02:00",
  "UpdatedDate": "2018-01-06T02:30:47.6632017+01:00",
  "Description": "Polarised modular pricing structure",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Integrated 6th generation approach",
  "ActiveStatusMonitorId": 693,
  "Links": [
    {
      "EntityName": "Murazik Inc and Sons",
      "Id": 702,
      "Description": "Total foreground firmware",
      "ExtraInfo": "ad",
      "LinkId": 458,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 556
        }
      }
    }
  ],
  "ActiveLinks": 274,
  "Completed": true,
  "NextMilestoneDate": "2024-01-16T02:30:47.6632017+01:00",
  "NmdAppointmentId": 85,
  "EndDate": "2003-06-26T02:30:47.6632017+02:00",
  "ActiveErpLinks": 387,
  "UserDefinedFields": {
    "SuperOffice:1": "1856992677",
    "SuperOffice:2": "986007960"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "odio"
  },
  "PublishEventDate": "2019-07-22T02:30:47.6632017+02:00",
  "PublishTo": "2003-08-28T02:30:47.6632017+02:00",
  "PublishFrom": "2016-01-07T02:30:47.6632017+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 343
    }
  }
}
```