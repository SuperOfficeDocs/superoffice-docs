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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 70,
  "Name": "Miller, Heaney and Pacocha",
  "ProjectNumber": "1272375",
  "ProjectMembers": [
    {
      "ProjectmemberId": 40,
      "ContactId": 545,
      "ProjectId": 980,
      "ContactName": "Leffler LLC",
      "ContactDepartment": "",
      "ProjectName": "Brakus Group",
      "EmailId": 609,
      "EmailAddress": "christy@welch.name",
      "CountryId": 728,
      "Firstname": "Eda",
      "MiddleName": "Kirlin, Olson and Jones",
      "Lastname": "Reichel",
      "PersonId": 101,
      "Mrmrs": "modi",
      "ProjectMemberTypeName": "Lehner-Bailey",
      "Phone": "779-684-4647",
      "PhoneId": 525,
      "ProjectMemberTypeId": 377,
      "EmailAddressName": "ayden_bayer@weber.com",
      "Comment": "repellendus",
      "FullName": "Ari Collier"
    }
  ],
  "Urls": [
    {
      "Value": "nesciunt",
      "StrippedValue": "reiciendis",
      "Description": "Business-focused stable encoding"
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "reiciendis",
      "Description": "Business-focused stable encoding"
    }
  ],
  "CreatedDate": "2022-10-03T13:28:31.8510769+02:00",
  "UpdatedDate": "2008-06-22T13:28:31.8510769+02:00",
  "Description": "Synchronised modular approach",
  "Postit": "distinctio",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored system-worthy time-frame",
  "ActiveStatusMonitorId": 77,
  "Links": [
    {
      "EntityName": "Glover, Greenholt and Bartoletti",
      "Id": 561,
      "Description": "Pre-emptive zero defect collaboration",
      "ExtraInfo": "occaecati",
      "LinkId": 727
    },
    {
      "EntityName": "Glover, Greenholt and Bartoletti",
      "Id": 561,
      "Description": "Pre-emptive zero defect collaboration",
      "ExtraInfo": "occaecati",
      "LinkId": 727
    }
  ],
  "ActiveLinks": 6,
  "Completed": false,
  "NextMilestoneDate": "1998-03-24T13:28:31.8510769+01:00",
  "NmdAppointmentId": 222,
  "EndDate": "2019-01-31T13:28:31.8510769+01:00",
  "ActiveErpLinks": 410,
  "UserDefinedFields": {
    "SuperOffice:1": "1312565544",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "rem",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "itaque"
  },
  "PublishEventDate": "2012-04-14T13:28:31.8510769+02:00",
  "PublishTo": "2019-05-26T13:28:31.8510769+02:00",
  "PublishFrom": "2020-05-25T13:28:31.8510769+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 856,
  "Name": "Friesen, Towne and Oberbrunner",
  "ProjectNumber": "1382272",
  "ProjectMembers": [
    {
      "ProjectmemberId": 792,
      "ContactId": 903,
      "ProjectId": 982,
      "ContactName": "Oberbrunner-Stiedemann",
      "ContactDepartment": "",
      "ProjectName": "Tromp-Ortiz",
      "EmailId": 220,
      "EmailAddress": "idella@langosh.uk",
      "CountryId": 959,
      "Firstname": "Deontae",
      "MiddleName": "VonRueden, Hyatt and Blick",
      "Lastname": "Bode",
      "PersonId": 804,
      "Mrmrs": "quasi",
      "ProjectMemberTypeName": "Yost, Denesik and McGlynn",
      "Phone": "789.403.6004 x112",
      "PhoneId": 404,
      "ProjectMemberTypeId": 268,
      "EmailAddressName": "freddy.kirlin@goyettepfeffer.name",
      "Comment": "laborum",
      "FullName": "Braden Wintheiser IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "vero",
      "Description": "Innovative neutral emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "vero",
      "Description": "Innovative neutral emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "CreatedDate": "2007-07-11T13:28:31.8510769+02:00",
  "UpdatedDate": "2024-03-15T13:28:31.8510769+01:00",
  "Description": "Synergized 3rd generation project",
  "Postit": "vero",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Optimized assymetric budgetary management",
  "ActiveStatusMonitorId": 155,
  "Links": [
    {
      "EntityName": "Corwin, Leuschke and Moen",
      "Id": 784,
      "Description": "Quality-focused homogeneous interface",
      "ExtraInfo": "voluptatem",
      "LinkId": 282,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "ActiveLinks": 648,
  "Completed": false,
  "NextMilestoneDate": "1998-10-06T13:28:31.8510769+02:00",
  "NmdAppointmentId": 799,
  "EndDate": "2022-09-26T13:28:31.8510769+02:00",
  "ActiveErpLinks": 68,
  "UserDefinedFields": {
    "SuperOffice:1": "Guido Goyette IV",
    "SuperOffice:2": "1831923458"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "delectus"
  },
  "PublishEventDate": "2013-03-11T13:28:31.8510769+01:00",
  "PublishTo": "2015-04-20T13:28:31.8510769+02:00",
  "PublishFrom": "2008-03-14T13:28:31.8510769+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 178
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```