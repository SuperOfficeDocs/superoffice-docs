---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Last-Modified: Tue, 30 Jan 2007 03:41:58 G1T

{
  "ContactId": 981,
  "Name": "Ullrich LLC",
  "Department": "",
  "OrgNr": "1071457",
  "Number1": "1277363",
  "Number2": "1471353",
  "UpdatedDate": "2007-01-30T03:41:58.5899065+01:00",
  "CreatedDate": "2024-11-25T03:41:58.5899065+01:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "aliquam",
      "Description": "Phased full-range definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "aliquam",
      "Description": "Phased full-range definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 8,
      "Name": "Dickens-Johnston",
      "ToolTip": "Non vel dolorem esse voluptatum ducimus fugiat rerum.",
      "Deleted": false,
      "Rank": 214,
      "Type": "sunt",
      "ColorBlock": 137,
      "IconHint": "praesentium",
      "Selected": false,
      "LastChanged": "2009-12-28T03:41:58.5899065+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "ipsa",
      "Hidden": true,
      "FullName": "Miguel Alexandra Gutmann III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 778
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "doloremque",
      "Description": "Adaptive reciprocal emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "doloremque",
      "Description": "Adaptive reciprocal emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sunt",
      "StrippedValue": "illo",
      "Description": "Intuitive heuristic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "illo",
      "Description": "Intuitive heuristic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "nam",
      "Description": "Intuitive explicit attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "nam",
      "Description": "Intuitive explicit attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    }
  ],
  "Description": "Proactive homogeneous leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "iusto",
      "PersonId": 383,
      "Mrmrs": "aut",
      "Firstname": "Kylee",
      "Lastname": "Cummings",
      "MiddleName": "Paucek, Heathcote and Hintz",
      "Title": "tempore",
      "Description": "Diverse 24/7 intranet",
      "Email": "joannie.lang@robertscollier.ca",
      "FullName": "May Goodwin",
      "DirectPhone": "1-275-132-2879 x25640",
      "FormalName": "Hayes, Cummings and Grimes",
      "CountryId": 966,
      "ContactId": 536,
      "ContactName": "Wintheiser Inc and Sons",
      "Retired": 130,
      "Rank": 352,
      "ActiveInterests": 754,
      "ContactDepartment": "",
      "ContactCountryId": 71,
      "ContactOrgNr": "1350424",
      "FaxPhone": "434.204.7740",
      "MobilePhone": "590.320.6184 x4308",
      "ContactPhone": "217.129.2946 x5439",
      "AssociateName": "Heller-Kutch",
      "AssociateId": 264,
      "UsePersonAddress": false,
      "ContactFax": "sequi",
      "Kanafname": "architecto",
      "Kanalname": "accusamus",
      "Post1": "illum",
      "Post2": "magni",
      "Post3": "illum",
      "EmailName": "gene@raynor.us",
      "ContactFullName": "Garland Koepp",
      "ActiveErpLinks": 882,
      "TicketPriorityId": 192,
      "SupportLanguageId": 347,
      "SupportAssociateId": 978,
      "CategoryName": "VIP Customer",
      "PersonNumber": "394934",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "doloribus",
  "Xstop": false,
  "ActiveInterests": 15,
  "GroupId": 617,
  "ActiveStatusMonitorId": 704,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 229,
  "DbiAgentId": 759,
  "DbiLastSyncronized": "1998-07-22T03:41:58.5899065+02:00",
  "DbiKey": "voluptas",
  "DbiLastModified": "2009-09-15T03:41:58.5899065+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 420,
  "ActiveErpLinks": 158,
  "BounceEmails": [
    "otha@oconnell.us",
    "caleigh@davis.us"
  ],
  "Domains": [
    "illum",
    "ex"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Christiana Wyman Jr.",
    "SuperOffice:2": "Jorge Schmidt"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "repellendus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 921
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```