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
Last-Modified: Fri, 27 Sep 2019 16:55:29 G9T

{
  "ContactId": 461,
  "Name": "Labadie, Heidenreich and Kling",
  "Department": "",
  "OrgNr": "833158",
  "Number1": "714150",
  "Number2": "1877549",
  "UpdatedDate": "2019-09-27T16:55:29.4403154+02:00",
  "CreatedDate": "2004-12-17T16:55:29.4403154+01:00",
  "Emails": [
    {
      "Value": "magnam",
      "StrippedValue": "nisi",
      "Description": "Optional 5th generation secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "nisi",
      "Description": "Optional 5th generation secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 544,
      "Name": "Grimes-Hagenes",
      "ToolTip": "Ut dolor quam error voluptate reiciendis est amet.",
      "Deleted": false,
      "Rank": 782,
      "Type": "est",
      "ColorBlock": 678,
      "IconHint": "saepe",
      "Selected": true,
      "LastChanged": "1998-12-28T16:55:29.4403154+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "unde",
      "Hidden": false,
      "FullName": "Robyn Mraz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 43
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "odit",
      "Description": "Horizontal encompassing capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "odit",
      "Description": "Horizontal encompassing capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "corporis",
      "Description": "Fully-configurable 6th generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "corporis",
      "Description": "Fully-configurable 6th generation core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Stand-alone reciprocal policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Stand-alone reciprocal policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    }
  ],
  "Description": "Reduced non-volatile matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "delectus",
      "PersonId": 65,
      "Mrmrs": "recusandae",
      "Firstname": "Kamryn",
      "Lastname": "Corkery",
      "MiddleName": "Rau Inc and Sons",
      "Title": "dolor",
      "Description": "Synergistic national archive",
      "Email": "rosalia@feest.ca",
      "FullName": "Blanca Runte",
      "DirectPhone": "205-495-6559 x63178",
      "FormalName": "Dietrich Inc and Sons",
      "CountryId": 345,
      "ContactId": 611,
      "ContactName": "Moen, Cruickshank and Strosin",
      "Retired": 534,
      "Rank": 256,
      "ActiveInterests": 941,
      "ContactDepartment": "",
      "ContactCountryId": 671,
      "ContactOrgNr": "1475340",
      "FaxPhone": "180.854.6463 x8531",
      "MobilePhone": "335-155-3950 x8159",
      "ContactPhone": "1-754-471-3997",
      "AssociateName": "Rogahn-Roberts",
      "AssociateId": 976,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "quas",
      "Kanalname": "quaerat",
      "Post1": "et",
      "Post2": "tempora",
      "Post3": "laborum",
      "EmailName": "gust_bergnaum@schneiderkemmer.us",
      "ContactFullName": "Francisco Sanford",
      "ActiveErpLinks": 767,
      "TicketPriorityId": 982,
      "SupportLanguageId": 785,
      "SupportAssociateId": 514,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolor",
  "Xstop": true,
  "ActiveInterests": 209,
  "GroupId": 529,
  "ActiveStatusMonitorId": 573,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 727,
  "DbiAgentId": 668,
  "DbiLastSyncronized": "1999-02-10T16:55:29.4433358+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2011-02-24T16:55:29.4433358+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 606,
  "ActiveErpLinks": 984,
  "BounceEmails": [
    "travon@larson.info",
    "dorcas@cormier.ca"
  ],
  "Domains": [
    "aperiam",
    "harum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Katrine Cummings II",
    "SuperOffice:2": "2080569430"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "iusto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 629
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```