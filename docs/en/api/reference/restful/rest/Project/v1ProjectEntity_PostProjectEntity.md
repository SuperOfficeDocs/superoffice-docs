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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 543,
  "Name": "Pfeffer, Hills and Bechtelar",
  "ProjectNumber": "1737369",
  "ProjectMembers": [
    {
      "ProjectmemberId": 590,
      "ContactId": 563,
      "ProjectId": 998,
      "ContactName": "Armstrong-Lang",
      "ContactDepartment": "",
      "ProjectName": "Schiller Inc and Sons",
      "EmailId": 545,
      "EmailAddress": "zelma@schmeler.info",
      "CountryId": 196,
      "Firstname": "Susana",
      "MiddleName": "Hilll-Cronin",
      "Lastname": "Smith",
      "PersonId": 832,
      "Mrmrs": "doloribus",
      "ProjectMemberTypeName": "Nikolaus, Rice and Nitzsche",
      "Phone": "1-853-427-4441",
      "PhoneId": 486,
      "ProjectMemberTypeId": 377,
      "EmailAddressName": "vivien.herzog@johns.co.uk",
      "Comment": "libero",
      "FullName": "Savion Reynolds"
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Secured fresh-thinking superstructure"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "et",
      "Description": "Secured fresh-thinking superstructure"
    }
  ],
  "CreatedDate": "2003-01-05T04:22:35.1428495+01:00",
  "UpdatedDate": "2018-11-16T04:22:35.1428495+01:00",
  "Description": "Object-based directional hierarchy",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Focused background parallelism",
  "ActiveStatusMonitorId": 144,
  "Links": [
    {
      "EntityName": "Schaden, Gleichner and Hammes",
      "Id": 772,
      "Description": "Public-key motivating ability",
      "ExtraInfo": "voluptates",
      "LinkId": 574
    },
    {
      "EntityName": "Schaden, Gleichner and Hammes",
      "Id": 772,
      "Description": "Public-key motivating ability",
      "ExtraInfo": "voluptates",
      "LinkId": 574
    }
  ],
  "ActiveLinks": 230,
  "Completed": true,
  "NextMilestoneDate": "1998-11-15T04:22:35.1428495+01:00",
  "NmdAppointmentId": 684,
  "EndDate": "1999-03-04T04:22:35.1428495+01:00",
  "ActiveErpLinks": 961,
  "UserDefinedFields": {
    "SuperOffice:1": "433885235",
    "SuperOffice:2": "Mr. Hortense Herman Schuppe"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "distinctio"
  },
  "PublishEventDate": "2004-07-08T04:22:35.1428495+02:00",
  "PublishTo": "2015-11-01T04:22:35.1428495+01:00",
  "PublishFrom": "2000-04-14T04:22:35.1428495+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 57,
  "Name": "Vandervort LLC",
  "ProjectNumber": "823847",
  "ProjectMembers": [
    {
      "ProjectmemberId": 893,
      "ContactId": 438,
      "ProjectId": 420,
      "ContactName": "Runte LLC",
      "ContactDepartment": "",
      "ProjectName": "Gislason Group",
      "EmailId": 399,
      "EmailAddress": "ines.weissnat@schmittrohan.ca",
      "CountryId": 118,
      "Firstname": "Kaia",
      "MiddleName": "Kuvalis-Tremblay",
      "Lastname": "Feil",
      "PersonId": 37,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "Johnston, Dach and Batz",
      "Phone": "(265)071-7090",
      "PhoneId": 72,
      "ProjectMemberTypeId": 759,
      "EmailAddressName": "verna@jast.name",
      "Comment": "recusandae",
      "FullName": "Fletcher Carroll",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Cross-platform upward-trending attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Cross-platform upward-trending attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "CreatedDate": "2019-03-13T04:22:35.1428495+01:00",
  "UpdatedDate": "2008-07-14T04:22:35.1428495+02:00",
  "Description": "Automated neutral forecast",
  "Postit": "magni",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enterprise-wide demand-driven interface",
  "ActiveStatusMonitorId": 192,
  "Links": [
    {
      "EntityName": "Baumbach Inc and Sons",
      "Id": 906,
      "Description": "Managed fault-tolerant access",
      "ExtraInfo": "voluptatem",
      "LinkId": 312,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    }
  ],
  "ActiveLinks": 571,
  "Completed": false,
  "NextMilestoneDate": "2005-08-05T04:22:35.1428495+02:00",
  "NmdAppointmentId": 97,
  "EndDate": "2015-01-12T04:22:35.1428495+01:00",
  "ActiveErpLinks": 921,
  "UserDefinedFields": {
    "SuperOffice:1": "Clair McCullough",
    "SuperOffice:2": "Miss Yasmin Corwin"
  },
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "2018-03-11T04:22:35.1428495+01:00",
  "PublishTo": "2005-08-20T04:22:35.1428495+02:00",
  "PublishFrom": "2023-11-25T04:22:35.1428495+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 457
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```