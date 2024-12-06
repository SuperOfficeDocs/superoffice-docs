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
  "ProjectId": 932,
  "Name": "Beier Group",
  "ProjectNumber": "1888887",
  "ProjectMembers": [
    {
      "ProjectmemberId": 256,
      "ContactId": 567,
      "ProjectId": 182,
      "ContactName": "Breitenberg, Bartell and Smith",
      "ContactDepartment": "",
      "ProjectName": "Sanford, Cremin and Lebsack",
      "EmailId": 778,
      "EmailAddress": "camren@cassin.ca",
      "CountryId": 144,
      "Firstname": "Garrett",
      "MiddleName": "Fritsch-Abbott",
      "Lastname": "Zieme",
      "PersonId": 66,
      "Mrmrs": "dolores",
      "ProjectMemberTypeName": "Bosco, Wolf and Wisoky",
      "Phone": "1-527-308-7553",
      "PhoneId": 786,
      "ProjectMemberTypeId": 353,
      "EmailAddressName": "mallory@waters.info",
      "Comment": "voluptate",
      "FullName": "Prof. Haskell Reilly I"
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "ullam",
      "Description": "Customizable bi-directional matrices"
    },
    {
      "Value": "id",
      "StrippedValue": "ullam",
      "Description": "Customizable bi-directional matrices"
    }
  ],
  "CreatedDate": "2014-11-29T10:18:00.4887104+01:00",
  "UpdatedDate": "2021-04-09T10:18:00.4887104+02:00",
  "Description": "Integrated static migration",
  "Postit": "quam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Horizontal solution-oriented complexity",
  "ActiveStatusMonitorId": 131,
  "Links": [
    {
      "EntityName": "Jakubowski LLC",
      "Id": 274,
      "Description": "Profit-focused multi-tasking implementation",
      "ExtraInfo": "voluptatum",
      "LinkId": 743
    },
    {
      "EntityName": "Jakubowski LLC",
      "Id": 274,
      "Description": "Profit-focused multi-tasking implementation",
      "ExtraInfo": "voluptatum",
      "LinkId": 743
    }
  ],
  "ActiveLinks": 413,
  "Completed": false,
  "NextMilestoneDate": "2019-03-03T10:18:00.5043364+01:00",
  "NmdAppointmentId": 252,
  "EndDate": "2010-11-17T10:18:00.5043364+01:00",
  "ActiveErpLinks": 984,
  "UserDefinedFields": {
    "SuperOffice:1": "98099075",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "ducimus"
  },
  "PublishEventDate": "2011-05-02T10:18:00.5043364+02:00",
  "PublishTo": "2011-05-23T10:18:00.5043364+02:00",
  "PublishFrom": "2024-06-18T10:18:00.5043364+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 321,
  "Name": "Beer, Emmerich and Olson",
  "ProjectNumber": "954682",
  "ProjectMembers": [
    {
      "ProjectmemberId": 143,
      "ContactId": 760,
      "ProjectId": 622,
      "ContactName": "Crooks-McClure",
      "ContactDepartment": "",
      "ProjectName": "Nikolaus, Nikolaus and Jacobi",
      "EmailId": 662,
      "EmailAddress": "amir@hagenesschiller.biz",
      "CountryId": 900,
      "Firstname": "Nicola",
      "MiddleName": "Halvorson Group",
      "Lastname": "Stokes",
      "PersonId": 502,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Wisoky-Little",
      "Phone": "1-879-019-0643",
      "PhoneId": 752,
      "ProjectMemberTypeId": 695,
      "EmailAddressName": "trevor@kertzmann.name",
      "Comment": "et",
      "FullName": "Gino Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veniam",
      "StrippedValue": "eligendi",
      "Description": "Horizontal bifurcated adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "eligendi",
      "Description": "Horizontal bifurcated adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "CreatedDate": "1998-06-13T10:18:00.5043364+02:00",
  "UpdatedDate": "2005-12-01T10:18:00.5043364+01:00",
  "Description": "De-engineered impactful paradigm",
  "Postit": "asperiores",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Seamless web-enabled alliance",
  "ActiveStatusMonitorId": 861,
  "Links": [
    {
      "EntityName": "Pollich, Heidenreich and Grant",
      "Id": 919,
      "Description": "Triple-buffered tertiary ability",
      "ExtraInfo": "incidunt",
      "LinkId": 716,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    }
  ],
  "ActiveLinks": 909,
  "Completed": false,
  "NextMilestoneDate": "1998-03-05T10:18:00.5043364+01:00",
  "NmdAppointmentId": 507,
  "EndDate": "2015-11-04T10:18:00.5043364+01:00",
  "ActiveErpLinks": 235,
  "UserDefinedFields": {
    "SuperOffice:1": "Shawna Grant",
    "SuperOffice:2": "Laurence Bernier"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "minus"
  },
  "PublishEventDate": "2008-08-11T10:18:00.5043364+02:00",
  "PublishTo": "2006-09-09T10:18:00.5043364+02:00",
  "PublishFrom": "2011-06-09T10:18:00.5043364+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 30
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```