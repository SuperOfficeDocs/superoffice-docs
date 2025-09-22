---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
content_type: reference
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
  "ProjectId": 602,
  "Name": "Mertz-Armstrong",
  "ProjectNumber": "1225360",
  "ProjectMembers": [
    {
      "ProjectmemberId": 867,
      "ContactId": 732,
      "ProjectId": 985,
      "ContactName": "Schamberger, Bauch and Becker",
      "ContactDepartment": "",
      "ProjectName": "D'Amore Group",
      "EmailId": 85,
      "EmailAddress": "marge@stracke.biz",
      "CountryId": 537,
      "Firstname": "Blake",
      "MiddleName": "Braun, Schinner and Aufderhar",
      "Lastname": "Buckridge",
      "PersonId": 510,
      "Mrmrs": "consequatur",
      "ProjectMemberTypeName": "Yundt, Beahan and Keeling",
      "Phone": "751.049.0622 x47449",
      "PhoneId": 561,
      "ProjectMemberTypeId": 202,
      "EmailAddressName": "judd.terry@kassulkeabbott.ca",
      "Comment": "modi",
      "FullName": "Emmy Krajcik",
      "Registered": "2011-11-27T11:24:53.437431+01:00",
      "Updated": "2013-09-07T11:24:53.437431+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "debitis",
      "StrippedValue": "molestiae",
      "Description": "Optimized logistical moratorium"
    },
    {
      "Value": "debitis",
      "StrippedValue": "molestiae",
      "Description": "Optimized logistical moratorium"
    }
  ],
  "CreatedDate": "2018-08-08T11:24:53.437431+02:00",
  "UpdatedDate": "2017-11-06T11:24:53.437431+01:00",
  "Description": "Centralized foreground capability",
  "Postit": "impedit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Extended homogeneous structure",
  "ActiveStatusMonitorId": 602,
  "Links": [
    {
      "EntityName": "Rippin Group",
      "Id": 285,
      "Description": "Profit-focused encompassing task-force",
      "ExtraInfo": "totam",
      "LinkId": 340
    },
    {
      "EntityName": "Rippin Group",
      "Id": 285,
      "Description": "Profit-focused encompassing task-force",
      "ExtraInfo": "totam",
      "LinkId": 340
    }
  ],
  "ActiveLinks": 280,
  "Completed": true,
  "NextMilestoneDate": "2016-02-07T11:24:53.437431+01:00",
  "NmdAppointmentId": 638,
  "EndDate": "2004-06-22T11:24:53.437431+02:00",
  "ActiveErpLinks": 600,
  "UserDefinedFields": {
    "SuperOffice:1": "Macey Rolfson",
    "SuperOffice:2": "1990991806"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "ducimus"
  },
  "PublishEventDate": "2015-08-25T11:24:53.437431+02:00",
  "PublishTo": "2002-12-06T11:24:53.437431+01:00",
  "PublishFrom": "2019-03-26T11:24:53.437431+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 957,
  "Name": "Hermiston LLC",
  "ProjectNumber": "982296",
  "ProjectMembers": [
    {
      "ProjectmemberId": 938,
      "ContactId": 874,
      "ProjectId": 26,
      "ContactName": "Corkery, Hirthe and Williamson",
      "ContactDepartment": "optimize best-of-breed vortals",
      "ProjectName": "Parker, Price and Herman",
      "EmailId": 23,
      "EmailAddress": "aaron@kertzmannschroeder.com",
      "CountryId": 541,
      "Firstname": "Beatrice",
      "MiddleName": "Wisozk, Kihn and Paucek",
      "Lastname": "Bashirian",
      "PersonId": 89,
      "Mrmrs": "tempore",
      "ProjectMemberTypeName": "Nolan LLC",
      "Phone": "(678)599-3993 x34085",
      "PhoneId": 33,
      "ProjectMemberTypeId": 698,
      "EmailAddressName": "shayne@reinger.ca",
      "Comment": "deserunt",
      "FullName": "Marcos Feest",
      "Registered": "2018-05-11T11:24:53.4530638+02:00",
      "Updated": "2014-11-24T11:24:53.4530638+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 532
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "officiis",
      "Description": "Customer-focused transitional Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "officiis",
      "Description": "Customer-focused transitional Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 674
        }
      }
    }
  ],
  "CreatedDate": "2021-06-08T11:24:53.4530638+02:00",
  "UpdatedDate": "2016-03-21T11:24:53.4530638+01:00",
  "Description": "Future-proofed 3rd generation installation",
  "Postit": "vel",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Extended stable productivity",
  "ActiveStatusMonitorId": 19,
  "Links": [
    {
      "EntityName": "Denesik-Powlowski",
      "Id": 844,
      "Description": "Secured incremental product",
      "ExtraInfo": "enim",
      "LinkId": 571,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "ActiveLinks": 115,
  "Completed": false,
  "NextMilestoneDate": "2003-03-02T11:24:53.4530638+01:00",
  "NmdAppointmentId": 172,
  "EndDate": "2004-06-20T11:24:53.4530638+02:00",
  "ActiveErpLinks": 487,
  "UserDefinedFields": {
    "SuperOffice:1": "Oral Padberg",
    "SuperOffice:2": "473169808"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "2014-10-31T11:24:53.4530638+01:00",
  "PublishTo": "1998-11-08T11:24:53.4530638+01:00",
  "PublishFrom": "2002-03-17T11:24:53.4530638+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 1000
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```