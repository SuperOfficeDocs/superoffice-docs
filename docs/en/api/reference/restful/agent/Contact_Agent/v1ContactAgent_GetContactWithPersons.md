---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 961
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 106,
  "Name": "Gleason, Lindgren and Predovic",
  "Department": "",
  "OrgNr": "845402",
  "Number1": "551642",
  "Number2": "1098664",
  "UpdatedDate": "2001-05-18T03:44:52.3240217+02:00",
  "CreatedDate": "2015-06-01T03:44:52.3240217+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "eius",
      "Description": "Focused cohesive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "eius",
      "Description": "Focused cohesive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 137,
      "Name": "Borer, Rice and Bradtke",
      "ToolTip": "Id beatae incidunt perferendis natus quo ratione amet.",
      "Deleted": false,
      "Rank": 421,
      "Type": "quia",
      "ColorBlock": 714,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2020-11-25T03:44:52.3240217+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fuga",
      "StyleHint": "placeat",
      "Hidden": false,
      "FullName": "Dr. Gaetano Sauer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "nulla",
      "Description": "Virtual contextually-based help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nulla",
      "Description": "Virtual contextually-based help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "rem",
      "Description": "Devolved needs-based interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "rem",
      "Description": "Devolved needs-based interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "atque",
      "Description": "Horizontal non-volatile product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "atque",
      "Description": "Horizontal non-volatile product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    }
  ],
  "Description": "Focused high-level access",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maxime",
      "PersonId": 588,
      "Mrmrs": "velit",
      "Firstname": "Odell",
      "Lastname": "Kirlin",
      "MiddleName": "Schowalter Inc and Sons",
      "Title": "voluptatem",
      "Description": "Up-sized asynchronous complexity",
      "Email": "valentin@robertswilliamson.uk",
      "FullName": "Lexi Lueilwitz",
      "DirectPhone": "(069)958-6900 x4908",
      "FormalName": "Beier, Williamson and Lind",
      "CountryId": 166,
      "ContactId": 887,
      "ContactName": "Kreiger LLC",
      "Retired": 570,
      "Rank": 436,
      "ActiveInterests": 364,
      "ContactDepartment": "",
      "ContactCountryId": 515,
      "ContactOrgNr": "1213306",
      "FaxPhone": "1-532-153-3352 x67669",
      "MobilePhone": "1-112-787-1882",
      "ContactPhone": "1-161-594-5366 x95355",
      "AssociateName": "Emard, Mohr and Stroman",
      "AssociateId": 639,
      "UsePersonAddress": false,
      "ContactFax": "earum",
      "Kanafname": "quae",
      "Kanalname": "in",
      "Post1": "rem",
      "Post2": "et",
      "Post3": "sed",
      "EmailName": "haylee.mclaughlin@bayer.com",
      "ContactFullName": "Abagail Bernhard",
      "ActiveErpLinks": 432,
      "TicketPriorityId": 378,
      "SupportLanguageId": 673,
      "SupportAssociateId": 34,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 446
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "optio",
  "Xstop": false,
  "ActiveInterests": 725,
  "GroupId": 294,
  "ActiveStatusMonitorId": 438,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 405,
  "DbiAgentId": 472,
  "DbiLastSyncronized": "2023-01-15T03:44:52.3240217+01:00",
  "DbiKey": "ea",
  "DbiLastModified": "2003-07-11T03:44:52.3240217+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 126,
  "ActiveErpLinks": 152,
  "BounceEmails": [
    "claudie.deckow@weimann.biz",
    "paula.goyette@conroymedhurst.us"
  ],
  "Domains": [
    "voluptatem",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Edgar Greenfelder"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 734
    }
  }
}
```