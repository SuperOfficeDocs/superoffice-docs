---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=698
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 871,
  "Name": "Schuster-Watsica",
  "Department": "",
  "OrgNr": "1255398",
  "Number1": "314713",
  "Number2": "1527371",
  "UpdatedDate": "2018-10-04T02:38:21.0420796+02:00",
  "CreatedDate": "2009-12-13T02:38:21.0420796+01:00",
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "officia",
      "Description": "Grass-roots neutral conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "officia",
      "Description": "Grass-roots neutral conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 751
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 738,
      "Name": "Tremblay, Marks and Rice",
      "ToolTip": "Tempora non voluptas.",
      "Deleted": false,
      "Rank": 596,
      "Type": "deserunt",
      "ColorBlock": 445,
      "IconHint": "pariatur",
      "Selected": true,
      "LastChanged": "2004-05-13T02:38:21.0420796+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Kip Rory West DVM",
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
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "quis",
      "Description": "Balanced empowering architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "quis",
      "Description": "Balanced empowering architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 838
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "Managed national hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "Managed national hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptas",
      "Description": "Multi-lateral value-added frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptas",
      "Description": "Multi-lateral value-added frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    }
  ],
  "Description": "Innovative well-modulated instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "unde",
      "PersonId": 595,
      "Mrmrs": "sit",
      "Firstname": "Julius",
      "Lastname": "Kerluke",
      "MiddleName": "Fadel-Weimann",
      "Title": "laborum",
      "Description": "Enhanced didactic structure",
      "Email": "donna.ankunding@rutherford.com",
      "FullName": "Mr. Ahmad Tad Hamill",
      "DirectPhone": "(922)072-2254 x3682",
      "FormalName": "Pfeffer, Rosenbaum and Larkin",
      "CountryId": 594,
      "ContactId": 284,
      "ContactName": "Cartwright, Barrows and Lakin",
      "Retired": 693,
      "Rank": 87,
      "ActiveInterests": 609,
      "ContactDepartment": "",
      "ContactCountryId": 171,
      "ContactOrgNr": "232097",
      "FaxPhone": "842-407-9926 x05347",
      "MobilePhone": "884.543.2918",
      "ContactPhone": "786-148-5427",
      "AssociateName": "Medhurst, Bayer and Crist",
      "AssociateId": 667,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "ut",
      "Kanalname": "debitis",
      "Post1": "quis",
      "Post2": "molestiae",
      "Post3": "facere",
      "EmailName": "enrico_bayer@wilkinson.biz",
      "ContactFullName": "Ricardo Joaquin Koelpin III",
      "ActiveErpLinks": 456,
      "TicketPriorityId": 667,
      "SupportLanguageId": 78,
      "SupportAssociateId": 53,
      "CategoryName": "VIP Customer",
      "PersonNumber": "857588",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 877,
  "GroupId": 655,
  "ActiveStatusMonitorId": 725,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 593,
  "DbiAgentId": 206,
  "DbiLastSyncronized": "2014-01-05T02:38:21.0420796+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2016-03-06T02:38:21.0420796+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 304,
  "ActiveErpLinks": 831,
  "BounceEmails": [
    "stanley.schuster@hanejaskolski.ca",
    "kattie@schneider.biz"
  ],
  "Domains": [
    "est",
    "facilis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Herta Wyman",
    "SuperOffice:2": "Miss Princess Keagan Will"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "nisi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 324
    }
  }
}
```