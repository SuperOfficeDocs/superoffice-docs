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
  "ProjectId": 62,
  "Name": "Dicki Inc and Sons",
  "ProjectNumber": "1112860",
  "ProjectMembers": [
    {
      "ProjectmemberId": 918,
      "ContactId": 255,
      "ProjectId": 67,
      "ContactName": "Donnelly-Weber",
      "ContactDepartment": "",
      "ProjectName": "Yost-McClure",
      "EmailId": 348,
      "EmailAddress": "may@parker.biz",
      "CountryId": 888,
      "Firstname": "Caterina",
      "MiddleName": "Raynor Group",
      "Lastname": "Wisoky",
      "PersonId": 372,
      "Mrmrs": "harum",
      "ProjectMemberTypeName": "Gleason-Morissette",
      "Phone": "1-111-452-9135",
      "PhoneId": 36,
      "ProjectMemberTypeId": 777,
      "EmailAddressName": "gardner_kunze@heathcote.co.uk",
      "Comment": "molestiae",
      "FullName": "Fidel Beatty V"
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "optio",
      "Description": "Progressive contextually-based definition"
    },
    {
      "Value": "totam",
      "StrippedValue": "optio",
      "Description": "Progressive contextually-based definition"
    }
  ],
  "CreatedDate": "2001-05-10T12:19:53.7273414+02:00",
  "UpdatedDate": "2005-05-30T12:19:53.7273414+02:00",
  "Description": "Optimized systematic conglomeration",
  "Postit": "delectus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Universal non-volatile time-frame",
  "ActiveStatusMonitorId": 256,
  "Links": [
    {
      "EntityName": "Orn-Kuhlman",
      "Id": 897,
      "Description": "Fundamental multi-tasking groupware",
      "ExtraInfo": "adipisci",
      "LinkId": 594
    },
    {
      "EntityName": "Orn-Kuhlman",
      "Id": 897,
      "Description": "Fundamental multi-tasking groupware",
      "ExtraInfo": "adipisci",
      "LinkId": 594
    }
  ],
  "ActiveLinks": 421,
  "Completed": false,
  "NextMilestoneDate": "2013-07-07T12:19:53.7273414+02:00",
  "NmdAppointmentId": 778,
  "EndDate": "2003-06-13T12:19:53.7273414+02:00",
  "ActiveErpLinks": 644,
  "UserDefinedFields": {
    "SuperOffice:1": "Jimmie Nader",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "enim"
  },
  "PublishEventDate": "2005-12-09T12:19:53.7273414+01:00",
  "PublishTo": "2002-09-18T12:19:53.7273414+02:00",
  "PublishFrom": "1998-10-20T12:19:53.7273414+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 644,
  "Name": "Sporer LLC",
  "ProjectNumber": "1247773",
  "ProjectMembers": [
    {
      "ProjectmemberId": 797,
      "ContactId": 754,
      "ProjectId": 820,
      "ContactName": "Rosenbaum, Crooks and Hayes",
      "ContactDepartment": "",
      "ProjectName": "Lemke, Kemmer and Gislason",
      "EmailId": 647,
      "EmailAddress": "june@witting.name",
      "CountryId": 86,
      "Firstname": "Adrienne",
      "MiddleName": "Ernser, Gulgowski and Mayer",
      "Lastname": "Fadel",
      "PersonId": 817,
      "Mrmrs": "tenetur",
      "ProjectMemberTypeName": "Renner Group",
      "Phone": "1-680-984-8745 x55158",
      "PhoneId": 313,
      "ProjectMemberTypeId": 463,
      "EmailAddressName": "logan@kublarkin.com",
      "Comment": "quasi",
      "FullName": "Miss Anissa Xzavier Veum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "repudiandae",
      "Description": "Grass-roots next generation info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "repudiandae",
      "Description": "Grass-roots next generation info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "CreatedDate": "1999-08-15T12:19:53.7429635+02:00",
  "UpdatedDate": "2009-08-14T12:19:53.7429635+02:00",
  "Description": "Configurable mobile encoding",
  "Postit": "amet",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Re-engineered mission-critical toolset",
  "ActiveStatusMonitorId": 981,
  "Links": [
    {
      "EntityName": "Mann, Donnelly and Gislason",
      "Id": 955,
      "Description": "Implemented exuding encryption",
      "ExtraInfo": "magnam",
      "LinkId": 247,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    }
  ],
  "ActiveLinks": 111,
  "Completed": false,
  "NextMilestoneDate": "2019-01-14T12:19:53.7429635+01:00",
  "NmdAppointmentId": 188,
  "EndDate": "2018-02-20T12:19:53.7429635+01:00",
  "ActiveErpLinks": 873,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Braxton Langworth"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "dolores"
  },
  "PublishEventDate": "2009-04-27T12:19:53.7429635+02:00",
  "PublishTo": "2008-06-07T12:19:53.7429635+02:00",
  "PublishFrom": "2004-06-29T12:19:53.7429635+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 83
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```