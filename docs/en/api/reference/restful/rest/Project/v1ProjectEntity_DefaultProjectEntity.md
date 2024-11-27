---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
generated: true
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.







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
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 13 Nov 2013 14:45:12 G11T

{
  "ProjectId": 255,
  "Name": "Ward, Hudson and Abbott",
  "ProjectNumber": "920751",
  "ProjectMembers": [
    {
      "ProjectmemberId": 932,
      "ContactId": 743,
      "ProjectId": 857,
      "ContactName": "Effertz LLC",
      "ContactDepartment": "",
      "ProjectName": "Bayer Group",
      "EmailId": 894,
      "EmailAddress": "xavier@rosenbaum.co.uk",
      "CountryId": 570,
      "Firstname": "Melisa",
      "MiddleName": "Bogan-Quigley",
      "Lastname": "Grady",
      "PersonId": 940,
      "Mrmrs": "autem",
      "ProjectMemberTypeName": "Little, Little and Schaefer",
      "Phone": "(556)727-1978 x4429",
      "PhoneId": 245,
      "ProjectMemberTypeId": 447,
      "EmailAddressName": "mathew.gutkowski@hudsoncummerata.uk",
      "Comment": "occaecati",
      "FullName": "Moses Mills",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sequi",
      "StrippedValue": "animi",
      "Description": "Diverse non-volatile policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "animi",
      "Description": "Diverse non-volatile policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "CreatedDate": "2005-05-23T14:45:12.9431644+02:00",
  "UpdatedDate": "2013-11-13T14:45:12.9431644+01:00",
  "Description": "Reactive 24/7 portal",
  "Postit": "nesciunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Enhanced asynchronous data-warehouse",
  "ActiveStatusMonitorId": 941,
  "Links": [
    {
      "EntityName": "Kuhn Group",
      "Id": 516,
      "Description": "Adaptive modular process improvement",
      "ExtraInfo": "reiciendis",
      "LinkId": 194,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "ActiveLinks": 790,
  "Completed": true,
  "NextMilestoneDate": "2009-11-11T14:45:12.9431644+01:00",
  "NmdAppointmentId": 317,
  "EndDate": "2022-08-26T14:45:12.9431644+02:00",
  "ActiveErpLinks": 356,
  "UserDefinedFields": {
    "SuperOffice:1": "Melody Hilll",
    "SuperOffice:2": "Raquel Bernice Zieme III"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "tempore"
  },
  "PublishEventDate": "1999-08-09T14:45:12.9431644+02:00",
  "PublishTo": "2012-04-30T14:45:12.9431644+02:00",
  "PublishFrom": "2012-05-25T14:45:12.9431644+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 584
    }
  }
}
```