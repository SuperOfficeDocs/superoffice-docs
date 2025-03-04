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
  "ProjectId": 152,
  "Name": "Cassin LLC",
  "ProjectNumber": "802065",
  "ProjectMembers": [
    {
      "ProjectmemberId": 395,
      "ContactId": 86,
      "ProjectId": 182,
      "ContactName": "Durgan, Rice and Batz",
      "ContactDepartment": "",
      "ProjectName": "Ebert, Gorczany and Wisozk",
      "EmailId": 503,
      "EmailAddress": "juana_abshire@hamill.co.uk",
      "CountryId": 216,
      "Firstname": "Mina",
      "MiddleName": "Streich LLC",
      "Lastname": "Ledner",
      "PersonId": 995,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Ullrich-Langworth",
      "Phone": "(261)175-6153 x7748",
      "PhoneId": 528,
      "ProjectMemberTypeId": 555,
      "EmailAddressName": "kayli_schumm@hirthe.com",
      "Comment": "pariatur",
      "FullName": "Wilson Ernser"
    }
  ],
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "qui",
      "Description": "Realigned holistic paradigm"
    },
    {
      "Value": "iusto",
      "StrippedValue": "qui",
      "Description": "Realigned holistic paradigm"
    }
  ],
  "CreatedDate": "2004-07-31T14:13:49.0400197+02:00",
  "UpdatedDate": "2005-05-26T14:13:49.0400197+02:00",
  "Description": "Extended interactive monitoring",
  "Postit": "incidunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Team-oriented multi-state encoding",
  "ActiveStatusMonitorId": 684,
  "Links": [
    {
      "EntityName": "Littel-Deckow",
      "Id": 756,
      "Description": "Upgradable executive task-force",
      "ExtraInfo": "beatae",
      "LinkId": 299
    },
    {
      "EntityName": "Littel-Deckow",
      "Id": 756,
      "Description": "Upgradable executive task-force",
      "ExtraInfo": "beatae",
      "LinkId": 299
    }
  ],
  "ActiveLinks": 625,
  "Completed": true,
  "NextMilestoneDate": "2012-05-02T14:13:49.0400197+02:00",
  "NmdAppointmentId": 547,
  "EndDate": "2019-10-08T14:13:49.0400197+02:00",
  "ActiveErpLinks": 940,
  "UserDefinedFields": {
    "SuperOffice:1": "Zachariah Wiegand",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "quo"
  },
  "PublishEventDate": "2013-03-27T14:13:49.0400197+01:00",
  "PublishTo": "2020-09-06T14:13:49.0400197+02:00",
  "PublishFrom": "2012-12-22T14:13:49.0400197+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 138,
  "Name": "Keebler Inc and Sons",
  "ProjectNumber": "966209",
  "ProjectMembers": [
    {
      "ProjectmemberId": 405,
      "ContactId": 767,
      "ProjectId": 728,
      "ContactName": "Wilkinson Group",
      "ContactDepartment": "",
      "ProjectName": "Fahey Group",
      "EmailId": 661,
      "EmailAddress": "fae@wintheiser.co.uk",
      "CountryId": 420,
      "Firstname": "Santiago",
      "MiddleName": "Kreiger-Bartoletti",
      "Lastname": "Hand",
      "PersonId": 830,
      "Mrmrs": "saepe",
      "ProjectMemberTypeName": "Lehner Group",
      "Phone": "1-674-474-3555",
      "PhoneId": 716,
      "ProjectMemberTypeId": 835,
      "EmailAddressName": "korbin@mohr.info",
      "Comment": "necessitatibus",
      "FullName": "Lonny VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "autem",
      "Description": "Synergistic directional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "autem",
      "Description": "Synergistic directional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 924
        }
      }
    }
  ],
  "CreatedDate": "2016-05-01T14:13:49.0400197+02:00",
  "UpdatedDate": "2000-06-16T14:13:49.0400197+02:00",
  "Description": "Organic cohesive contingency",
  "Postit": "possimus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Networked stable process improvement",
  "ActiveStatusMonitorId": 713,
  "Links": [
    {
      "EntityName": "Bosco LLC",
      "Id": 677,
      "Description": "Enhanced homogeneous focus group",
      "ExtraInfo": "omnis",
      "LinkId": 779,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "ActiveLinks": 647,
  "Completed": true,
  "NextMilestoneDate": "2013-05-28T14:13:49.0400197+02:00",
  "NmdAppointmentId": 883,
  "EndDate": "2020-06-28T14:13:49.0400197+02:00",
  "ActiveErpLinks": 479,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Myrtis Medhurst",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "1999-10-16T14:13:49.0400197+02:00",
  "PublishTo": "2023-12-02T14:13:49.0400197+01:00",
  "PublishFrom": "2017-10-20T14:13:49.0400197+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 78
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```