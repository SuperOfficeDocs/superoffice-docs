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
  "ProjectId": 949,
  "Name": "Runolfsdottir, Pagac and Emmerich",
  "ProjectNumber": "1260662",
  "ProjectMembers": [
    {
      "ProjectmemberId": 589,
      "ContactId": 689,
      "ProjectId": 424,
      "ContactName": "Schinner Group",
      "ContactDepartment": "",
      "ProjectName": "Borer-O'Connell",
      "EmailId": 233,
      "EmailAddress": "carleton.leuschke@grimesgleason.info",
      "CountryId": 485,
      "Firstname": "Marcelina",
      "MiddleName": "Breitenberg, Bosco and Larkin",
      "Lastname": "Hudson",
      "PersonId": 957,
      "Mrmrs": "nemo",
      "ProjectMemberTypeName": "Feeney, Feeney and Pacocha",
      "Phone": "731-615-2808",
      "PhoneId": 948,
      "ProjectMemberTypeId": 397,
      "EmailAddressName": "david.kirlin@carter.info",
      "Comment": "et",
      "FullName": "Lauren Jacobi"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Monitored client-server database"
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Monitored client-server database"
    }
  ],
  "CreatedDate": "2013-02-13T12:19:53.7429635+01:00",
  "UpdatedDate": "2016-08-14T12:19:53.7429635+02:00",
  "Description": "Optional optimizing conglomeration",
  "Postit": "placeat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Persevering assymetric moratorium",
  "ActiveStatusMonitorId": 815,
  "Links": [
    {
      "EntityName": "Little LLC",
      "Id": 695,
      "Description": "Upgradable bandwidth-monitored standardization",
      "ExtraInfo": "aliquam",
      "LinkId": 992
    },
    {
      "EntityName": "Little LLC",
      "Id": 695,
      "Description": "Upgradable bandwidth-monitored standardization",
      "ExtraInfo": "aliquam",
      "LinkId": 992
    }
  ],
  "ActiveLinks": 715,
  "Completed": true,
  "NextMilestoneDate": "2014-10-13T12:19:53.7429635+02:00",
  "NmdAppointmentId": 989,
  "EndDate": "2011-02-05T12:19:53.7429635+01:00",
  "ActiveErpLinks": 105,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Miss Harmon Aurore Watsica I"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "consequatur"
  },
  "PublishEventDate": "2023-01-25T12:19:53.7429635+01:00",
  "PublishTo": "1999-02-12T12:19:53.7429635+01:00",
  "PublishFrom": "2015-07-06T12:19:53.7429635+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 776,
  "Name": "Leannon, Willms and O'Connell",
  "ProjectNumber": "1402605",
  "ProjectMembers": [
    {
      "ProjectmemberId": 530,
      "ContactId": 460,
      "ProjectId": 27,
      "ContactName": "Mueller-Heathcote",
      "ContactDepartment": "",
      "ProjectName": "Predovic LLC",
      "EmailId": 93,
      "EmailAddress": "joana_cruickshank@marvinschneider.uk",
      "CountryId": 330,
      "Firstname": "Rowland",
      "MiddleName": "Weimann, Carroll and Gottlieb",
      "Lastname": "Sawayn",
      "PersonId": 288,
      "Mrmrs": "explicabo",
      "ProjectMemberTypeName": "Frami LLC",
      "Phone": "(203)699-4038 x880",
      "PhoneId": 491,
      "ProjectMemberTypeId": 109,
      "EmailAddressName": "hildegard@jaskolski.name",
      "Comment": "dicta",
      "FullName": "Santino Blick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "quae",
      "Description": "Face to face attitude-oriented database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "quae",
      "Description": "Face to face attitude-oriented database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    }
  ],
  "CreatedDate": "2020-06-03T12:19:53.7585851+02:00",
  "UpdatedDate": "2011-03-15T12:19:53.7585851+01:00",
  "Description": "Expanded client-server initiative",
  "Postit": "dolorum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Innovative maximized ability",
  "ActiveStatusMonitorId": 446,
  "Links": [
    {
      "EntityName": "Dietrich, Schumm and Kirlin",
      "Id": 952,
      "Description": "Automated fault-tolerant service-desk",
      "ExtraInfo": "qui",
      "LinkId": 318,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "ActiveLinks": 269,
  "Completed": false,
  "NextMilestoneDate": "2012-10-01T12:19:53.7585851+02:00",
  "NmdAppointmentId": 832,
  "EndDate": "2005-06-06T12:19:53.7585851+02:00",
  "ActiveErpLinks": 636,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Brice Kerluke IV"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2018-04-29T12:19:53.7585851+02:00",
  "PublishTo": "2009-12-27T12:19:53.7585851+01:00",
  "PublishFrom": "2018-06-04T12:19:53.7585851+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 798
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```