---
title: POST Agents/Project/GetProjectEntity
uid: v1ProjectAgent_GetProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/GetProjectEntity

```http
POST /api/v1/Agents/Project/GetProjectEntity
```

Gets a ProjectEntity object.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The identifier of the ProjectEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=507
POST /api/v1/Agents/Project/GetProjectEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Project/GetProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 205,
  "Name": "Koelpin, Corkery and Schneider",
  "ProjectNumber": "1114701",
  "ProjectMembers": [
    {
      "ProjectmemberId": 933,
      "ContactId": 975,
      "ProjectId": 947,
      "ContactName": "Medhurst, VonRueden and Parker",
      "ContactDepartment": "enable magnetic e-tailers",
      "ProjectName": "Barton LLC",
      "EmailId": 354,
      "EmailAddress": "cedrick_funk@lesch.name",
      "CountryId": 288,
      "Firstname": "Lysanne",
      "MiddleName": "Goodwin LLC",
      "Lastname": "Lebsack",
      "PersonId": 809,
      "Mrmrs": "officiis",
      "ProjectMemberTypeName": "Labadie-Gleichner",
      "Phone": "1-702-087-7002",
      "PhoneId": 802,
      "ProjectMemberTypeId": 74,
      "EmailAddressName": "elsie@jast.info",
      "Comment": "autem",
      "FullName": "Ruben Stiedemann",
      "Registered": "2000-12-18T03:40:47.4687299+01:00",
      "Updated": "2015-01-28T03:40:47.4687299+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "perspiciatis",
      "Description": "Optional intermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "perspiciatis",
      "Description": "Optional intermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "CreatedDate": "2014-08-13T03:40:47.4687299+02:00",
  "UpdatedDate": "2000-12-04T03:40:47.4687299+01:00",
  "Description": "Advanced dedicated hierarchy",
  "Postit": "necessitatibus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Business-focused client-driven projection",
  "ActiveStatusMonitorId": 401,
  "Links": [
    {
      "EntityName": "Christiansen-Ward",
      "Id": 161,
      "Description": "Right-sized assymetric toolset",
      "ExtraInfo": "sint",
      "LinkId": 34,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "ActiveLinks": 207,
  "Completed": false,
  "NextMilestoneDate": "2019-11-06T03:40:47.4687299+01:00",
  "NmdAppointmentId": 553,
  "EndDate": "2020-07-19T03:40:47.4687299+02:00",
  "ActiveErpLinks": 89,
  "UserDefinedFields": {
    "SuperOffice:1": "Pasquale Rempel",
    "SuperOffice:2": "1178820649"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "blanditiis"
  },
  "PublishEventDate": "2016-09-04T03:40:47.4687299+02:00",
  "PublishTo": "2013-07-04T03:40:47.4687299+02:00",
  "PublishFrom": "2020-05-23T03:40:47.4687299+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 764
    }
  }
}
```