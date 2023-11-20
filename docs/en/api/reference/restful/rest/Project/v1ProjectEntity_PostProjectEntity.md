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
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 120,
  "Name": "Connelly-Schmidt",
  "ProjectNumber": "760309",
  "ProjectMembers": [
    {
      "ProjectmemberId": 653,
      "ContactId": 966,
      "ProjectId": 454,
      "ContactName": "Wisozk-Sporer",
      "ContactDepartment": "",
      "ProjectName": "Rosenbaum, Krajcik and Murazik",
      "EmailId": 982,
      "EmailAddress": "laron.howe@beiermitchell.co.uk",
      "CountryId": 508,
      "Firstname": "Sim",
      "MiddleName": "Leffler, Collins and Altenwerth",
      "Lastname": "Von",
      "PersonId": 744,
      "Mrmrs": "occaecati",
      "ProjectMemberTypeName": "Yost, Kerluke and Bauch",
      "Phone": "(058)615-2015",
      "PhoneId": 552,
      "ProjectMemberTypeId": 676,
      "EmailAddressName": "lilliana_schmidt@schuppewalter.biz",
      "Comment": "quidem",
      "FullName": "Guadalupe Hartmann"
    }
  ],
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "distinctio",
      "Description": "Persistent zero tolerance approach"
    },
    {
      "Value": "earum",
      "StrippedValue": "distinctio",
      "Description": "Persistent zero tolerance approach"
    }
  ],
  "CreatedDate": "2011-09-15T13:38:17.5305626+02:00",
  "UpdatedDate": "2013-10-07T13:38:17.5305626+02:00",
  "Description": "Customer-focused clear-thinking support",
  "Postit": "delectus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Sharable scalable synergy",
  "ActiveStatusMonitorId": 622,
  "Links": [
    {
      "EntityName": "Bashirian, Turner and Jewess",
      "Id": 619,
      "Description": "Customizable intermediate data-warehouse",
      "ExtraInfo": "autem",
      "LinkId": 74
    },
    {
      "EntityName": "Bashirian, Turner and Jewess",
      "Id": 619,
      "Description": "Customizable intermediate data-warehouse",
      "ExtraInfo": "autem",
      "LinkId": 74
    }
  ],
  "ActiveLinks": 53,
  "Completed": false,
  "NextMilestoneDate": "2003-06-06T13:38:17.5305626+02:00",
  "NmdAppointmentId": 737,
  "EndDate": "2005-01-05T13:38:17.5305626+01:00",
  "ActiveErpLinks": 615,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Yolanda D'Amore",
    "SuperOffice:2": "Marquis Weber"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "consequuntur",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2003-01-15T13:38:17.5305626+01:00",
  "PublishTo": "2008-02-28T13:38:17.5305626+01:00",
  "PublishFrom": "2006-07-24T13:38:17.5305626+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 75,
  "Name": "Hauck, Kuhlman and Powlowski",
  "ProjectNumber": "862054",
  "ProjectMembers": [
    {
      "ProjectmemberId": 929,
      "ContactId": 532,
      "ProjectId": 616,
      "ContactName": "Pfannerstill, Ortiz and Swift",
      "ContactDepartment": "monetize mission-critical markets",
      "ProjectName": "Toy LLC",
      "EmailId": 587,
      "EmailAddress": "josh@grahamjakubowski.co.uk",
      "CountryId": 366,
      "Firstname": "Myron",
      "MiddleName": "Fisher Inc and Sons",
      "Lastname": "Legros",
      "PersonId": 278,
      "Mrmrs": "animi",
      "ProjectMemberTypeName": "Hane, Klein and Runolfsson",
      "Phone": "1-382-801-1370 x21941",
      "PhoneId": 487,
      "ProjectMemberTypeId": 418,
      "EmailAddressName": "kylie@huelweissnat.uk",
      "Comment": "id",
      "FullName": "Mohamed Greyson Krajcik III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 58
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "nihil",
      "Description": "Switchable national parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "nihil",
      "Description": "Switchable national parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "CreatedDate": "1999-09-20T13:38:17.5305626+02:00",
  "UpdatedDate": "2015-07-09T13:38:17.5305626+02:00",
  "Description": "Profound cohesive methodology",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Phased dedicated functionalities",
  "ActiveStatusMonitorId": 42,
  "Links": [
    {
      "EntityName": "Schulist, Herman and Koelpin",
      "Id": 55,
      "Description": "Proactive optimizing forecast",
      "ExtraInfo": "quo",
      "LinkId": 370,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    }
  ],
  "ActiveLinks": 454,
  "Completed": false,
  "NextMilestoneDate": "2016-03-29T13:38:17.5305626+02:00",
  "NmdAppointmentId": 133,
  "EndDate": "2003-04-16T13:38:17.5305626+02:00",
  "ActiveErpLinks": 452,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Morris Tyrel Renner",
    "SuperOffice:2": "Kaleb Buckridge"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "delectus"
  },
  "PublishEventDate": "2012-09-18T13:38:17.5305626+02:00",
  "PublishTo": "2021-04-11T13:38:17.5305626+02:00",
  "PublishFrom": "2016-11-29T13:38:17.5305626+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 974
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```