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
Last-Modified: Fri, 26 Mar 2021 13:14:08 G3T

{
  "ProjectId": 502,
  "Name": "Wyman-Jast",
  "ProjectNumber": "1215919",
  "ProjectMembers": [
    {
      "ProjectmemberId": 455,
      "ContactId": 614,
      "ProjectId": 817,
      "ContactName": "Beier, Gleichner and Marvin",
      "ContactDepartment": "",
      "ProjectName": "Wolf LLC",
      "EmailId": 924,
      "EmailAddress": "ima_lind@schulist.com",
      "CountryId": 200,
      "Firstname": "Loren",
      "MiddleName": "Jones-Kshlerin",
      "Lastname": "Denesik",
      "PersonId": 659,
      "Mrmrs": "odit",
      "ProjectMemberTypeName": "Erdman, Koelpin and Kiehn",
      "Phone": "(496)708-2081 x1827",
      "PhoneId": 435,
      "ProjectMemberTypeId": 143,
      "EmailAddressName": "dean_bechtelar@swaniawski.biz",
      "Comment": "eveniet",
      "FullName": "Germaine Jade Turner DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 852
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "reiciendis",
      "Description": "Enhanced asynchronous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "reiciendis",
      "Description": "Enhanced asynchronous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "CreatedDate": "1998-11-05T13:14:08.8992518+01:00",
  "UpdatedDate": "2021-03-26T13:14:08.8992518+01:00",
  "Description": "Quality-focused 24 hour matrix",
  "Postit": "earum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Proactive asynchronous adapter",
  "ActiveStatusMonitorId": 476,
  "Links": [
    {
      "EntityName": "Kulas Group",
      "Id": 204,
      "Description": "Automated systematic installation",
      "ExtraInfo": "praesentium",
      "LinkId": 666,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "ActiveLinks": 386,
  "Completed": true,
  "NextMilestoneDate": "2003-10-04T13:14:08.8992518+02:00",
  "NmdAppointmentId": 288,
  "EndDate": "2000-06-12T13:14:08.8992518+02:00",
  "ActiveErpLinks": 792,
  "UserDefinedFields": {
    "SuperOffice:1": "Baron Mueller",
    "SuperOffice:2": "Kane Haag"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2011-09-27T13:14:08.8992518+02:00",
  "PublishTo": "2016-10-05T13:14:08.8992518+02:00",
  "PublishFrom": "2004-09-24T13:14:08.8992518+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 836
    }
  }
}
```