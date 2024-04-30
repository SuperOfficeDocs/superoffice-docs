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
Last-Modified: Sat, 18 Oct 2003 11:44:41 G10T

{
  "ContactId": 368,
  "Name": "Lindgren-Wiegand",
  "Department": "",
  "OrgNr": "1495347",
  "Number1": "1224745",
  "Number2": "830115",
  "UpdatedDate": "2003-10-18T11:44:41.7734006+02:00",
  "CreatedDate": "2008-05-20T11:44:41.7734006+02:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "eligendi",
      "Description": "Focused 24 hour instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "eligendi",
      "Description": "Focused 24 hour instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 97,
      "Name": "Dickens, Lynch and Friesen",
      "ToolTip": "Ad voluptatem.",
      "Deleted": true,
      "Rank": 33,
      "Type": "aliquid",
      "ColorBlock": 633,
      "IconHint": "minus",
      "Selected": false,
      "LastChanged": "2008-12-24T11:44:41.7890717+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Roxanne Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "velit",
      "Description": "Ameliorated full-range productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "velit",
      "Description": "Ameliorated full-range productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Diverse methodical alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Diverse methodical alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "aut",
      "Description": "Mandatory high-level neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 785
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "aut",
      "Description": "Mandatory high-level neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 785
        }
      }
    }
  ],
  "Description": "Stand-alone tertiary orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 259,
      "Mrmrs": "sint",
      "Firstname": "Price",
      "Lastname": "Mann",
      "MiddleName": "Conroy LLC",
      "Title": "incidunt",
      "Description": "Enterprise-wide modular intranet",
      "Email": "nyah@harris.uk",
      "FullName": "Roger Erdman",
      "DirectPhone": "926-213-7638",
      "FormalName": "Koss LLC",
      "CountryId": 956,
      "ContactId": 828,
      "ContactName": "Harber, Kemmer and Block",
      "Retired": 865,
      "Rank": 902,
      "ActiveInterests": 905,
      "ContactDepartment": "",
      "ContactCountryId": 402,
      "ContactOrgNr": "1020521",
      "FaxPhone": "883-353-0070 x81673",
      "MobilePhone": "1-707-864-7665 x35155",
      "ContactPhone": "791.176.4861",
      "AssociateName": "Durgan-Corkery",
      "AssociateId": 291,
      "UsePersonAddress": true,
      "ContactFax": "molestias",
      "Kanafname": "non",
      "Kanalname": "facilis",
      "Post1": "in",
      "Post2": "et",
      "Post3": "illo",
      "EmailName": "bettye@crooks.us",
      "ContactFullName": "Kaleb Schroeder",
      "ActiveErpLinks": 534,
      "TicketPriorityId": 359,
      "SupportLanguageId": 683,
      "SupportAssociateId": 544,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "similique",
  "Xstop": true,
  "ActiveInterests": 888,
  "GroupId": 808,
  "ActiveStatusMonitorId": 862,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 751,
  "DbiAgentId": 123,
  "DbiLastSyncronized": "2023-11-23T11:44:41.7890717+01:00",
  "DbiKey": "ex",
  "DbiLastModified": "2022-08-12T11:44:41.7890717+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 472,
  "ActiveErpLinks": 776,
  "BounceEmails": [
    "montana_welch@waelchi.uk",
    "manuela@miller.com"
  ],
  "Domains": [
    "nisi",
    "pariatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dortha Kling",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 827
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```