---
title: GET Project/{id}
uid: v1ProjectEntity_GetProjectEntity
generated: true
---

# GET Project/{id}

```http
GET /api/v1/Project/{id}
```

Gets a ProjectEntity object.


Calls the Project agent service GetProjectEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ProjectEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Project/{id}?$select=name,department,category/id
GET /api/v1/Project/{id}?fk=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ProjectEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity found. |
| 304 | ProjectEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 09 Jun 2023 10:18:00 G6T

{
  "ProjectId": 924,
  "Name": "Ankunding, Stracke and Jaskolski",
  "ProjectNumber": "754078",
  "ProjectMembers": [
    {
      "ProjectmemberId": 728,
      "ContactId": 918,
      "ProjectId": 395,
      "ContactName": "Altenwerth, Koepp and Mueller",
      "ContactDepartment": "",
      "ProjectName": "Romaguera, Ritchie and Kessler",
      "EmailId": 430,
      "EmailAddress": "rupert_halvorson@schmittmueller.biz",
      "CountryId": 248,
      "Firstname": "Abdul",
      "MiddleName": "Kertzmann-Stoltenberg",
      "Lastname": "Kulas",
      "PersonId": 810,
      "Mrmrs": "enim",
      "ProjectMemberTypeName": "Collier, Nolan and Klocko",
      "Phone": "735.435.3312",
      "PhoneId": 575,
      "ProjectMemberTypeId": 982,
      "EmailAddressName": "shana@zemlak.ca",
      "Comment": "in",
      "FullName": "Wilburn Grimes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 353
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "quos",
      "Description": "Profit-focused tertiary orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 720
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "quos",
      "Description": "Profit-focused tertiary orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 720
        }
      }
    }
  ],
  "CreatedDate": "2001-11-20T10:18:00.5043364+01:00",
  "UpdatedDate": "2023-06-09T10:18:00.5043364+02:00",
  "Description": "Realigned stable encryption",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored impactful intranet",
  "ActiveStatusMonitorId": 822,
  "Links": [
    {
      "EntityName": "Stehr-Bayer",
      "Id": 522,
      "Description": "Profit-focused leading edge algorithm",
      "ExtraInfo": "consectetur",
      "LinkId": 625,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "ActiveLinks": 617,
  "Completed": false,
  "NextMilestoneDate": "2021-06-17T10:18:00.5043364+02:00",
  "NmdAppointmentId": 121,
  "EndDate": "2016-04-10T10:18:00.5043364+02:00",
  "ActiveErpLinks": 434,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rhea Daniel"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "eius"
  },
  "PublishEventDate": "1999-12-18T10:18:00.5043364+01:00",
  "PublishTo": "2021-09-23T10:18:00.5043364+02:00",
  "PublishFrom": "2003-05-16T10:18:00.5043364+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 113
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```