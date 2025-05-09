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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 410,
  "Name": "Bruen, Haag and O'Hara",
  "ProjectNumber": "644506",
  "ProjectMembers": [
    {
      "ProjectmemberId": 431,
      "ContactId": 574,
      "ProjectId": 200,
      "ContactName": "Pouros-Kuhn",
      "ContactDepartment": "repurpose bleeding-edge e-markets",
      "ProjectName": "Robel, Lebsack and Lehner",
      "EmailId": 51,
      "EmailAddress": "may@torp.info",
      "CountryId": 588,
      "Firstname": "Arlie",
      "MiddleName": "Jakubowski-Auer",
      "Lastname": "Sipes",
      "PersonId": 330,
      "Mrmrs": "non",
      "ProjectMemberTypeName": "Torp, Wilderman and Mosciski",
      "Phone": "1-561-724-7533 x47529",
      "PhoneId": 346,
      "ProjectMemberTypeId": 640,
      "EmailAddressName": "else@mraz.name",
      "Comment": "sed",
      "FullName": "Laura Wolf"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "in",
      "Description": "Networked fresh-thinking emulation"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "in",
      "Description": "Networked fresh-thinking emulation"
    }
  ],
  "CreatedDate": "2008-02-12T16:32:47.7120406+01:00",
  "UpdatedDate": "1999-03-21T16:32:47.7120406+01:00",
  "Description": "Streamlined maximized hierarchy",
  "Postit": "optio",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Focused composite open system",
  "ActiveStatusMonitorId": 939,
  "Links": [
    {
      "EntityName": "Berge Inc and Sons",
      "Id": 197,
      "Description": "Reactive impactful productivity",
      "ExtraInfo": "eos",
      "LinkId": 245
    },
    {
      "EntityName": "Berge Inc and Sons",
      "Id": 197,
      "Description": "Reactive impactful productivity",
      "ExtraInfo": "eos",
      "LinkId": 245
    }
  ],
  "ActiveLinks": 451,
  "Completed": true,
  "NextMilestoneDate": "2008-01-21T16:32:47.7120406+01:00",
  "NmdAppointmentId": 306,
  "EndDate": "2011-07-25T16:32:47.7120406+02:00",
  "ActiveErpLinks": 900,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1716700519"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "voluptates"
  },
  "PublishEventDate": "2019-01-06T16:32:47.7120406+01:00",
  "PublishTo": "2023-09-09T16:32:47.7120406+02:00",
  "PublishFrom": "2001-01-23T16:32:47.7120406+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 268,
  "Name": "Sipes-Cormier",
  "ProjectNumber": "951494",
  "ProjectMembers": [
    {
      "ProjectmemberId": 465,
      "ContactId": 363,
      "ProjectId": 67,
      "ContactName": "Wyman-Hauck",
      "ContactDepartment": "",
      "ProjectName": "Frami-Prohaska",
      "EmailId": 165,
      "EmailAddress": "april.boehm@howe.uk",
      "CountryId": 109,
      "Firstname": "Gilbert",
      "MiddleName": "Luettgen LLC",
      "Lastname": "Erdman",
      "PersonId": 709,
      "Mrmrs": "impedit",
      "ProjectMemberTypeName": "Ankunding, Bogan and Herman",
      "Phone": "(570)335-1274 x24614",
      "PhoneId": 664,
      "ProjectMemberTypeId": 578,
      "EmailAddressName": "donnell_stokes@mills.uk",
      "Comment": "doloribus",
      "FullName": "Mrs. Kianna Jackie O'Kon I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ea",
      "Description": "Open-source cohesive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 245
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ea",
      "Description": "Open-source cohesive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 245
        }
      }
    }
  ],
  "CreatedDate": "2011-03-03T16:32:47.7120406+01:00",
  "UpdatedDate": "2021-10-19T16:32:47.7120406+02:00",
  "Description": "Open-architected 24 hour toolset",
  "Postit": "ea",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cross-group radical service-desk",
  "ActiveStatusMonitorId": 786,
  "Links": [
    {
      "EntityName": "Metz-McGlynn",
      "Id": 140,
      "Description": "Inverse systematic standardization",
      "ExtraInfo": "possimus",
      "LinkId": 238,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "ActiveLinks": 201,
  "Completed": false,
  "NextMilestoneDate": "2011-07-16T16:32:47.7276607+02:00",
  "NmdAppointmentId": 567,
  "EndDate": "2007-02-26T16:32:47.7276607+01:00",
  "ActiveErpLinks": 193,
  "UserDefinedFields": {
    "SuperOffice:1": "Nicolas Altenwerth",
    "SuperOffice:2": "Miss Roderick Little"
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "suscipit"
  },
  "PublishEventDate": "2021-11-19T16:32:47.7276607+01:00",
  "PublishTo": "2006-05-03T16:32:47.7276607+02:00",
  "PublishFrom": "2025-02-25T16:32:47.7276607+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 581
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```