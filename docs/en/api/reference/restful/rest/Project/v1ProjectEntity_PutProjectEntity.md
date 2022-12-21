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
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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


## Response: 

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 976,
  "Name": "Mann-Prosacco",
  "ProjectNumber": "869567",
  "ProjectMembers": [
    {
      "ProjectmemberId": 749,
      "ContactId": 114,
      "ProjectId": 538,
      "ContactName": "Douglas-Cartwright",
      "ContactDepartment": "",
      "ProjectName": "Bins Inc and Sons",
      "EmailId": 827,
      "EmailAddress": "makayla_leffler@welchconsidine.com",
      "CountryId": 16,
      "Firstname": "Evelyn",
      "MiddleName": "Hane, Kessler and Ziemann",
      "Lastname": "Casper",
      "PersonId": 668,
      "Mrmrs": "fuga",
      "ProjectMemberTypeName": "Douglas-Sawayn",
      "Phone": "335.421.7578 x018",
      "PhoneId": 379,
      "ProjectMemberTypeId": 913,
      "EmailAddressName": "stefan.keeling@hirthe.co.uk",
      "Comment": "totam",
      "FullName": "Zoe Kshlerin"
    }
  ],
  "Urls": [
    {
      "Value": "dicta",
      "StrippedValue": "eos",
      "Description": "Pre-emptive assymetric circuit"
    },
    {
      "Value": "dicta",
      "StrippedValue": "eos",
      "Description": "Pre-emptive assymetric circuit"
    }
  ],
  "CreatedDate": "1998-10-25T02:49:51.3390666+01:00",
  "UpdatedDate": "2001-01-06T02:49:51.3390666+01:00",
  "Description": "User-centric radical customer loyalty",
  "Postit": "autem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored interactive throughput",
  "ActiveStatusMonitorId": 718,
  "Links": [
    {
      "EntityName": "McKenzie-Gislason",
      "Id": 927,
      "Description": "Up-sized user-facing analyzer",
      "ExtraInfo": "suscipit",
      "LinkId": 846
    },
    {
      "EntityName": "McKenzie-Gislason",
      "Id": 927,
      "Description": "Up-sized user-facing analyzer",
      "ExtraInfo": "suscipit",
      "LinkId": 846
    }
  ],
  "ActiveLinks": 809,
  "Completed": true,
  "NextMilestoneDate": "2016-09-16T02:49:51.3390666+02:00",
  "NmdAppointmentId": 935,
  "EndDate": "2018-05-25T02:49:51.3390666+02:00",
  "ActiveErpLinks": 806,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "provident",
    "CustomFields2": "in"
  },
  "PublishEventDate": "2017-12-07T02:49:51.3390666+01:00",
  "PublishTo": "2017-01-16T02:49:51.3390666+01:00",
  "PublishFrom": "2000-03-24T02:49:51.3390666+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 592,
  "Name": "Cassin LLC",
  "ProjectNumber": "627170",
  "ProjectMembers": [
    {
      "ProjectmemberId": 726,
      "ContactId": 319,
      "ProjectId": 511,
      "ContactName": "Braun, Heidenreich and Bashirian",
      "ContactDepartment": "",
      "ProjectName": "West, Dietrich and Zieme",
      "EmailId": 816,
      "EmailAddress": "abbie_ohara@wyman.ca",
      "CountryId": 43,
      "Firstname": "Elijah",
      "MiddleName": "Hirthe, Blanda and Hickle",
      "Lastname": "Grady",
      "PersonId": 784,
      "Mrmrs": "autem",
      "ProjectMemberTypeName": "Orn-Leuschke",
      "Phone": "169-650-5807 x211",
      "PhoneId": 945,
      "ProjectMemberTypeId": 461,
      "EmailAddressName": "arlo@welchaltenwerth.info",
      "Comment": "neque",
      "FullName": "Samara Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 938
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "placeat",
      "Description": "Reverse-engineered system-worthy hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "placeat",
      "Description": "Reverse-engineered system-worthy hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "CreatedDate": "2006-04-11T02:49:51.3390666+02:00",
  "UpdatedDate": "2003-07-14T02:49:51.3390666+02:00",
  "Description": "Inverse zero tolerance policy",
  "Postit": "corrupti",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Exclusive directional archive",
  "ActiveStatusMonitorId": 390,
  "Links": [
    {
      "EntityName": "Anderson, Dicki and Klein",
      "Id": 93,
      "Description": "Ameliorated eco-centric infrastructure",
      "ExtraInfo": "reprehenderit",
      "LinkId": 840,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "ActiveLinks": 310,
  "Completed": false,
  "NextMilestoneDate": "2019-06-29T02:49:51.3390666+02:00",
  "NmdAppointmentId": 418,
  "EndDate": "2012-03-09T02:49:51.3390666+01:00",
  "ActiveErpLinks": 988,
  "UserDefinedFields": {
    "SuperOffice:1": "Denis Stanton",
    "SuperOffice:2": "191837197"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "minima"
  },
  "PublishEventDate": "2005-06-25T02:49:51.3390666+02:00",
  "PublishTo": "2011-11-16T02:49:51.3390666+01:00",
  "PublishFrom": "2016-06-21T02:49:51.3390666+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 296
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```