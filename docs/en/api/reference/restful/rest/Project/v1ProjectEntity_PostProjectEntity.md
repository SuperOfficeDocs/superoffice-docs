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
  "ProjectId": 813,
  "Name": "Ratke, Gusikowski and Denesik",
  "ProjectNumber": "1027708",
  "ProjectMembers": [
    {
      "ProjectmemberId": 842,
      "ContactId": 505,
      "ProjectId": 926,
      "ContactName": "Bayer-Heidenreich",
      "ContactDepartment": "",
      "ProjectName": "Hoeger-Wyman",
      "EmailId": 390,
      "EmailAddress": "elmira_hilll@metz.us",
      "CountryId": 950,
      "Firstname": "Kirsten",
      "MiddleName": "Ruecker Group",
      "Lastname": "Rice",
      "PersonId": 796,
      "Mrmrs": "nemo",
      "ProjectMemberTypeName": "McDermott LLC",
      "Phone": "272-424-8471 x1926",
      "PhoneId": 901,
      "ProjectMemberTypeId": 600,
      "EmailAddressName": "trinity@bashirian.uk",
      "Comment": "consequatur",
      "FullName": "Mr. Winifred Charles Stark V"
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "ratione",
      "Description": "Ameliorated homogeneous protocol"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "ratione",
      "Description": "Ameliorated homogeneous protocol"
    }
  ],
  "CreatedDate": "2013-04-19T17:54:08.3824501+02:00",
  "UpdatedDate": "2020-01-12T17:54:08.3824501+01:00",
  "Description": "Total grid-enabled protocol",
  "Postit": "molestiae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Polarised tertiary groupware",
  "ActiveStatusMonitorId": 167,
  "Links": [
    {
      "EntityName": "Bailey-Bosco",
      "Id": 957,
      "Description": "Cross-platform composite instruction set",
      "ExtraInfo": "at",
      "LinkId": 777
    },
    {
      "EntityName": "Bailey-Bosco",
      "Id": 957,
      "Description": "Cross-platform composite instruction set",
      "ExtraInfo": "at",
      "LinkId": 777
    }
  ],
  "ActiveLinks": 578,
  "Completed": false,
  "NextMilestoneDate": "2014-07-08T17:54:08.3824501+02:00",
  "NmdAppointmentId": 976,
  "EndDate": "2011-08-23T17:54:08.3824501+02:00",
  "ActiveErpLinks": 44,
  "UserDefinedFields": {
    "SuperOffice:1": "Edward Lueilwitz",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "2000-04-24T17:54:08.3824501+02:00",
  "PublishTo": "2022-07-10T17:54:08.3824501+02:00",
  "PublishFrom": "2023-12-26T17:54:08.3824501+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 111,
  "Name": "Kunze-Altenwerth",
  "ProjectNumber": "1331267",
  "ProjectMembers": [
    {
      "ProjectmemberId": 898,
      "ContactId": 877,
      "ProjectId": 58,
      "ContactName": "Raynor, Altenwerth and Rath",
      "ContactDepartment": "deploy cutting-edge functionalities",
      "ProjectName": "Schneider-Stehr",
      "EmailId": 343,
      "EmailAddress": "christian_dietrich@hermann.ca",
      "CountryId": 203,
      "Firstname": "Jaron",
      "MiddleName": "Zboncak LLC",
      "Lastname": "Spinka",
      "PersonId": 837,
      "Mrmrs": "hic",
      "ProjectMemberTypeName": "Nicolas-Lind",
      "Phone": "532.496.7612 x85885",
      "PhoneId": 5,
      "ProjectMemberTypeId": 629,
      "EmailAddressName": "mark_lakin@grimesleffler.info",
      "Comment": "dolor",
      "FullName": "Christ Herman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "autem",
      "Description": "Optional client-server Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 559
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "autem",
      "Description": "Optional client-server Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 559
        }
      }
    }
  ],
  "CreatedDate": "2015-07-20T17:54:08.3824501+02:00",
  "UpdatedDate": "1999-06-25T17:54:08.3824501+02:00",
  "Description": "Public-key needs-based solution",
  "Postit": "in",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-tiered optimizing system engine",
  "ActiveStatusMonitorId": 870,
  "Links": [
    {
      "EntityName": "Lockman-Kuhn",
      "Id": 650,
      "Description": "Organic zero tolerance infrastructure",
      "ExtraInfo": "fugit",
      "LinkId": 294,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "ActiveLinks": 960,
  "Completed": false,
  "NextMilestoneDate": "2016-11-29T17:54:08.3824501+01:00",
  "NmdAppointmentId": 516,
  "EndDate": "2017-07-18T17:54:08.3824501+02:00",
  "ActiveErpLinks": 515,
  "UserDefinedFields": {
    "SuperOffice:1": "Devante Frami",
    "SuperOffice:2": "Hellen Yundt"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "magni",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2025-01-25T17:54:08.3824501+01:00",
  "PublishTo": "2021-11-03T17:54:08.3824501+01:00",
  "PublishFrom": "2009-05-23T17:54:08.3824501+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 915
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```