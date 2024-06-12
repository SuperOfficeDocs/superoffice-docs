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
GET /api/v1/Contact/{id}?fk=True
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
Last-Modified: Tue, 01 May 2018 04:22:34 G5T

{
  "ContactId": 899,
  "Name": "Orn-Deckow",
  "Department": "",
  "OrgNr": "1211957",
  "Number1": "809679",
  "Number2": "766615",
  "UpdatedDate": "2018-05-01T04:22:34.796505+02:00",
  "CreatedDate": "2003-11-08T04:22:34.796505+01:00",
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "De-engineered composite knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "De-engineered composite knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 347,
      "Name": "Johnston-Wintheiser",
      "ToolTip": "Earum dolorem iste quo ut officiis occaecati voluptas.",
      "Deleted": false,
      "Rank": 6,
      "Type": "fugit",
      "ColorBlock": 427,
      "IconHint": "optio",
      "Selected": false,
      "LastChanged": "2014-10-28T04:22:34.796505+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Ivory Krajcik",
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
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "perspiciatis",
      "Description": "Synergistic intermediate leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "perspiciatis",
      "Description": "Synergistic intermediate leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sed",
      "Description": "Open-source leading edge help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sed",
      "Description": "Open-source leading edge help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "qui",
      "Description": "Automated client-server challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "qui",
      "Description": "Automated client-server challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "Description": "Vision-oriented executive help-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorum",
      "PersonId": 240,
      "Mrmrs": "et",
      "Firstname": "Arvilla",
      "Lastname": "Mayer",
      "MiddleName": "Bartell, Kub and Lakin",
      "Title": "quis",
      "Description": "Decentralized optimal time-frame",
      "Email": "alison@thompson.com",
      "FullName": "Beverly Gusikowski",
      "DirectPhone": "1-807-608-2438 x825",
      "FormalName": "Orn LLC",
      "CountryId": 861,
      "ContactId": 483,
      "ContactName": "Kuhic Inc and Sons",
      "Retired": 673,
      "Rank": 445,
      "ActiveInterests": 772,
      "ContactDepartment": "",
      "ContactCountryId": 616,
      "ContactOrgNr": "1806596",
      "FaxPhone": "669-584-5594 x2552",
      "MobilePhone": "137.605.4938",
      "ContactPhone": "1-324-288-0007",
      "AssociateName": "Abbott Inc and Sons",
      "AssociateId": 466,
      "UsePersonAddress": true,
      "ContactFax": "dolor",
      "Kanafname": "ullam",
      "Kanalname": "minus",
      "Post1": "dolor",
      "Post2": "nostrum",
      "Post3": "aliquid",
      "EmailName": "reba@stracke.us",
      "ContactFullName": "Dr. Maryjane Shayna Strosin",
      "ActiveErpLinks": 197,
      "TicketPriorityId": 667,
      "SupportLanguageId": 671,
      "SupportAssociateId": 632,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 912,
  "GroupId": 739,
  "ActiveStatusMonitorId": 407,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 689,
  "DbiAgentId": 269,
  "DbiLastSyncronized": "2013-07-18T04:22:34.796505+02:00",
  "DbiKey": "repellendus",
  "DbiLastModified": "2004-07-12T04:22:34.796505+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 902,
  "ActiveErpLinks": 57,
  "BounceEmails": [
    "valentine@anderson.co.uk",
    "pat.smith@hesselanderson.uk"
  ],
  "Domains": [
    "ex",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1311675047",
    "SuperOffice:2": "Prof. Rod Eichmann PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "a"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 753
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```