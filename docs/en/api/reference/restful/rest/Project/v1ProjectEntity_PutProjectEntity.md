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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 454,
  "Name": "Wuckert LLC",
  "ProjectNumber": "1275693",
  "ProjectMembers": [
    {
      "ProjectmemberId": 727,
      "ContactId": 723,
      "ProjectId": 525,
      "ContactName": "Marvin-O'Keefe",
      "ContactDepartment": "",
      "ProjectName": "Pfannerstill LLC",
      "EmailId": 645,
      "EmailAddress": "frances.muller@leuschke.us",
      "CountryId": 623,
      "Firstname": "Winfield",
      "MiddleName": "Turcotte Group",
      "Lastname": "Howe",
      "PersonId": 53,
      "Mrmrs": "iure",
      "ProjectMemberTypeName": "McCullough, Bode and Johnston",
      "Phone": "988.145.2244 x466",
      "PhoneId": 912,
      "ProjectMemberTypeId": 12,
      "EmailAddressName": "garland@kassulke.info",
      "Comment": "et",
      "FullName": "Sydney Blanda"
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "nihil",
      "Description": "Down-sized real-time benchmark"
    },
    {
      "Value": "non",
      "StrippedValue": "nihil",
      "Description": "Down-sized real-time benchmark"
    }
  ],
  "CreatedDate": "2008-01-28T10:30:32.2136745+01:00",
  "UpdatedDate": "2017-10-20T10:30:32.2136745+02:00",
  "Description": "Automated solution-oriented knowledge user",
  "Postit": "exercitationem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Face to face homogeneous time-frame",
  "ActiveStatusMonitorId": 376,
  "Links": [
    {
      "EntityName": "Johnston LLC",
      "Id": 846,
      "Description": "Re-contextualized motivating installation",
      "ExtraInfo": "ut",
      "LinkId": 80
    },
    {
      "EntityName": "Johnston LLC",
      "Id": 846,
      "Description": "Re-contextualized motivating installation",
      "ExtraInfo": "ut",
      "LinkId": 80
    }
  ],
  "ActiveLinks": 878,
  "Completed": true,
  "NextMilestoneDate": "2021-01-27T10:30:32.2136745+01:00",
  "NmdAppointmentId": 199,
  "EndDate": "2021-01-15T10:30:32.2136745+01:00",
  "ActiveErpLinks": 538,
  "UserDefinedFields": {
    "SuperOffice:1": "Geoffrey Ryan",
    "SuperOffice:2": "Mr. Myah Trace Funk PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "vero"
  },
  "PublishEventDate": "2013-12-09T10:30:32.2136745+01:00",
  "PublishTo": "2015-12-01T10:30:32.2136745+01:00",
  "PublishFrom": "2006-01-17T10:30:32.2136745+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 335,
  "Name": "Howe-Hettinger",
  "ProjectNumber": "1315986",
  "ProjectMembers": [
    {
      "ProjectmemberId": 381,
      "ContactId": 366,
      "ProjectId": 608,
      "ContactName": "Windler-Satterfield",
      "ContactDepartment": "",
      "ProjectName": "Graham, Jacobs and Deckow",
      "EmailId": 847,
      "EmailAddress": "kaylee@yost.name",
      "CountryId": 446,
      "Firstname": "Hillary",
      "MiddleName": "Leffler-Wyman",
      "Lastname": "Murray",
      "PersonId": 280,
      "Mrmrs": "officia",
      "ProjectMemberTypeName": "Conroy Group",
      "Phone": "582.520.9273",
      "PhoneId": 839,
      "ProjectMemberTypeId": 245,
      "EmailAddressName": "morris_emard@schultz.uk",
      "Comment": "optio",
      "FullName": "Vernice O'Reilly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quam",
      "StrippedValue": "eveniet",
      "Description": "Versatile coherent focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "eveniet",
      "Description": "Versatile coherent focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "CreatedDate": "2023-06-18T10:30:32.2292996+02:00",
  "UpdatedDate": "2020-03-11T10:30:32.2292996+01:00",
  "Description": "Phased regional attitude",
  "Postit": "praesentium",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Right-sized intangible core",
  "ActiveStatusMonitorId": 556,
  "Links": [
    {
      "EntityName": "Labadie, Will and Bailey",
      "Id": 586,
      "Description": "Progressive assymetric toolset",
      "ExtraInfo": "aut",
      "LinkId": 28,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "ActiveLinks": 792,
  "Completed": true,
  "NextMilestoneDate": "2019-07-01T10:30:32.2292996+02:00",
  "NmdAppointmentId": 678,
  "EndDate": "2020-12-03T10:30:32.2292996+01:00",
  "ActiveErpLinks": 878,
  "UserDefinedFields": {
    "SuperOffice:1": "2081813626",
    "SuperOffice:2": "Diana Beahan"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "harum"
  },
  "PublishEventDate": "2018-06-12T10:30:32.2292996+02:00",
  "PublishTo": "2014-11-04T10:30:32.2292996+01:00",
  "PublishFrom": "2015-05-04T10:30:32.2292996+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 535
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```