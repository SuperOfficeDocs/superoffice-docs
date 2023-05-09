---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 163,
  "Name": "Cremin, Medhurst and Bernhard",
  "ProjectNumber": "647233",
  "ProjectMembers": [
    {
      "ProjectmemberId": 48,
      "ContactId": 397,
      "ProjectId": 472,
      "ContactName": "Kuhlman LLC",
      "ContactDepartment": "",
      "ProjectName": "Bechtelar-Cormier",
      "EmailId": 959,
      "EmailAddress": "karli@borer.name",
      "CountryId": 301,
      "Firstname": "Kira",
      "MiddleName": "Fay LLC",
      "Lastname": "Blick",
      "PersonId": 31,
      "Mrmrs": "dolorem",
      "ProjectMemberTypeName": "Schiller-Toy",
      "Phone": "481.160.4805",
      "PhoneId": 247,
      "ProjectMemberTypeId": 540,
      "EmailAddressName": "caden.raynor@mohr.co.uk",
      "Comment": "consectetur",
      "FullName": "Mrs. Ernestina Adrian McKenzie PhD"
    }
  ],
  "Urls": [
    {
      "Value": "accusantium",
      "StrippedValue": "ipsum",
      "Description": "Reduced even-keeled moratorium"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "ipsum",
      "Description": "Reduced even-keeled moratorium"
    }
  ],
  "CreatedDate": "2003-09-24T03:51:33.8334253+02:00",
  "UpdatedDate": "2010-06-08T03:51:33.8334253+02:00",
  "Description": "Monitored systematic flexibility",
  "Postit": "nam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Expanded leading edge parallelism",
  "ActiveStatusMonitorId": 360,
  "Links": [
    {
      "EntityName": "Buckridge-Cormier",
      "Id": 209,
      "Description": "Organic systemic hardware",
      "ExtraInfo": "quibusdam",
      "LinkId": 837
    },
    {
      "EntityName": "Buckridge-Cormier",
      "Id": 209,
      "Description": "Organic systemic hardware",
      "ExtraInfo": "quibusdam",
      "LinkId": 837
    }
  ],
  "ActiveLinks": 331,
  "Completed": false,
  "NextMilestoneDate": "2006-02-13T03:51:33.8334253+01:00",
  "NmdAppointmentId": 562,
  "EndDate": "2006-10-07T03:51:33.8334253+02:00",
  "ActiveErpLinks": 542,
  "UserDefinedFields": {
    "SuperOffice:1": "2044546588",
    "SuperOffice:2": "Jamey Brown"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "harum"
  },
  "PublishEventDate": "2010-04-04T03:51:33.8334253+02:00",
  "PublishTo": "2013-08-27T03:51:33.8334253+02:00",
  "PublishFrom": "2019-11-13T03:51:33.8334253+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 541,
  "Name": "Dibbert LLC",
  "ProjectNumber": "798169",
  "ProjectMembers": [
    {
      "ProjectmemberId": 453,
      "ContactId": 834,
      "ProjectId": 632,
      "ContactName": "Hackett LLC",
      "ContactDepartment": "",
      "ProjectName": "Schowalter-Lynch",
      "EmailId": 454,
      "EmailAddress": "walker@turcotte.us",
      "CountryId": 115,
      "Firstname": "Geovanny",
      "MiddleName": "Bahringer Group",
      "Lastname": "Christiansen",
      "PersonId": 396,
      "Mrmrs": "autem",
      "ProjectMemberTypeName": "Schiller Inc and Sons",
      "Phone": "621.226.4086 x78912",
      "PhoneId": 657,
      "ProjectMemberTypeId": 507,
      "EmailAddressName": "curt_hessel@mcclure.biz",
      "Comment": "ullam",
      "FullName": "Gwen Koss",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 994
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "perferendis",
      "Description": "Profound 24/7 benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "perferendis",
      "Description": "Profound 24/7 benchmark",
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
  "CreatedDate": "2004-09-18T03:51:33.8334253+02:00",
  "UpdatedDate": "1997-07-25T03:51:33.8334253+02:00",
  "Description": "Assimilated non-volatile secured line",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Expanded 24/7 neural-net",
  "ActiveStatusMonitorId": 423,
  "Links": [
    {
      "EntityName": "Zboncak-Conroy",
      "Id": 7,
      "Description": "Face to face asynchronous leverage",
      "ExtraInfo": "vero",
      "LinkId": 547,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "ActiveLinks": 317,
  "Completed": true,
  "NextMilestoneDate": "2023-05-05T03:51:33.8334253+02:00",
  "NmdAppointmentId": 23,
  "EndDate": "2018-10-02T03:51:33.8334253+02:00",
  "ActiveErpLinks": 69,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "880376128"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "rem"
  },
  "PublishEventDate": "2014-09-18T03:51:33.8334253+02:00",
  "PublishTo": "2006-05-05T03:51:33.8334253+02:00",
  "PublishFrom": "2016-07-30T03:51:33.8334253+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 304
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```