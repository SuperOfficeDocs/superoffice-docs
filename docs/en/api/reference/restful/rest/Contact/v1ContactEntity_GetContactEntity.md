---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 11 Jan 2013 11:16:13 G1T

{
  "ContactId": 836,
  "Name": "DuBuque LLC",
  "Department": "",
  "OrgNr": "1313458",
  "Number1": "538371",
  "Number2": "438698",
  "UpdatedDate": "2013-01-11T11:16:13.7925618+01:00",
  "CreatedDate": "2022-01-22T11:16:13.7925618+01:00",
  "Emails": [
    {
      "Value": "veniam",
      "StrippedValue": "architecto",
      "Description": "Networked systemic protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "architecto",
      "Description": "Networked systemic protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 648,
      "Name": "Murphy, Daugherty and Barrows",
      "ToolTip": "Consequatur omnis doloremque natus repellendus.",
      "Deleted": true,
      "Rank": 223,
      "Type": "et",
      "ColorBlock": 151,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "1996-12-19T11:16:13.7925618+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Daphne Tromp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "totam",
      "Description": "Phased heuristic open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "totam",
      "Description": "Phased heuristic open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "ad",
      "Description": "Down-sized radical analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 972
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "ad",
      "Description": "Down-sized radical analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 972
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "possimus",
      "StrippedValue": "necessitatibus",
      "Description": "Horizontal scalable hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "necessitatibus",
      "Description": "Horizontal scalable hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Description": "Organized cohesive application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 620,
      "Mrmrs": "officia",
      "Firstname": "Adrain",
      "Lastname": "Dietrich",
      "MiddleName": "Cruickshank Group",
      "Title": "voluptatem",
      "Description": "Operative reciprocal extranet",
      "Email": "harrison.block@lockmanlockman.uk",
      "FullName": "Eriberto Schaefer",
      "DirectPhone": "541-127-8161 x495",
      "FormalName": "McClure LLC",
      "CountryId": 68,
      "ContactId": 595,
      "ContactName": "Botsford Group",
      "Retired": 709,
      "Rank": 8,
      "ActiveInterests": 489,
      "ContactDepartment": "",
      "ContactCountryId": 357,
      "ContactOrgNr": "1070406",
      "FaxPhone": "926-443-6458",
      "MobilePhone": "1-000-345-8961 x9053",
      "ContactPhone": "247.179.9484",
      "AssociateName": "Harber Group",
      "AssociateId": 538,
      "UsePersonAddress": false,
      "ContactFax": "nihil",
      "Kanafname": "earum",
      "Kanalname": "quia",
      "Post1": "doloribus",
      "Post2": "assumenda",
      "Post3": "et",
      "EmailName": "jorge_klein@rempeltillman.biz",
      "ContactFullName": "Dr. Pauline Demario Walsh II",
      "ActiveErpLinks": 117,
      "TicketPriorityId": 803,
      "SupportLanguageId": 866,
      "SupportAssociateId": 187,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sunt",
  "Xstop": false,
  "ActiveInterests": 876,
  "GroupId": 4,
  "ActiveStatusMonitorId": 606,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 71,
  "DbiAgentId": 522,
  "DbiLastSyncronized": "2014-02-12T11:16:13.7925618+01:00",
  "DbiKey": "deserunt",
  "DbiLastModified": "2015-11-03T11:16:13.7925618+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 381,
  "ActiveErpLinks": 710,
  "BounceEmails": [
    "geovanny@hagenes.us",
    "daisy@ohara.com"
  ],
  "Domains": [
    "est",
    "repellendus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "833027352",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 838
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```