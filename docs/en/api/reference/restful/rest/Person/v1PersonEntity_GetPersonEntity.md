---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
generated: true
content_type: reference
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.


Calls the Person agent service GetPersonEntity.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the PersonEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Person/{id}?$select=name,department,category/id
GET /api/v1/Person/{id}?fk=True
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

PersonEntity found.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 304 | PersonEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: PersonEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 14 Oct 2007 03:40:55 G10T

{
  "PersonId": 503,
  "Firstname": "Damian",
  "MiddleName": "Mayert-Daniel",
  "Lastname": "Thiel",
  "Mrmrs": "modi",
  "Title": "amet",
  "UpdatedDate": "2007-10-14T03:40:55.8511506+02:00",
  "CreatedDate": "2004-05-19T03:40:55.8511506+02:00",
  "BirthDate": "2010-09-01T03:40:55.8511506+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "accusantium",
      "Description": "Configurable zero tolerance time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "accusantium",
      "Description": "Configurable zero tolerance time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    }
  ],
  "Description": "Profound contextually-based frame",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "ipsam",
      "Description": "Expanded needs-based functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "ipsam",
      "Description": "Expanded needs-based functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 816
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "repellendus",
      "Description": "User-friendly zero defect infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "repellendus",
      "Description": "User-friendly zero defect infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "eius",
      "Description": "Sharable bi-directional capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eius",
      "Description": "Sharable bi-directional capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "maiores",
      "Description": "Upgradable 3rd generation emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "maiores",
      "Description": "Upgradable 3rd generation emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Cloned analyzing productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Cloned analyzing productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 536,
      "Name": "McLaughlin, Aufderhar and Jewess",
      "ToolTip": "Ad commodi saepe natus ut et rerum rerum.",
      "Deleted": false,
      "Rank": 205,
      "Type": "nisi",
      "ColorBlock": 588,
      "IconHint": "tenetur",
      "Selected": false,
      "LastChanged": "2025-08-30T03:40:55.8511506+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "totam",
      "Hidden": true,
      "FullName": "Pietro Bahringer IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "PersonNumber": "1258638",
  "FullName": "Miss Vicky Buck Marks PhD",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "error",
      "Description": "Enhanced system-worthy software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "error",
      "Description": "Enhanced system-worthy software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "FormalName": "McClure, Hickle and Boyer",
  "Address": null,
  "Post3": "ex",
  "Post2": "et",
  "Post1": "natus",
  "Kanalname": "ipsam",
  "Kanafname": "voluptatibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "a",
  "ActiveInterests": 216,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 482,
  "DbiKey": "non",
  "DbiLastModified": "2008-01-17T03:40:55.8511506+01:00",
  "DbiLastSyncronized": "1999-08-18T03:40:55.8511506+02:00",
  "SentInfo": 487,
  "ShowContactTickets": 309,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "architecto",
      "StrippedValue": "velit",
      "Description": "Fundamental object-oriented application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "velit",
      "Description": "Fundamental object-oriented application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Multi-lateral transitional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Multi-lateral transitional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    }
  ],
  "Source": 74,
  "ActiveErpLinks": 777,
  "ShipmentTypes": [
    {
      "Id": 663,
      "Name": "Franecki Group",
      "ToolTip": "Vel qui.",
      "Deleted": false,
      "Rank": 283,
      "Type": "aspernatur",
      "ColorBlock": 714,
      "IconHint": "tenetur",
      "Selected": false,
      "LastChanged": "2005-05-30T03:40:55.8511506+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Emmitt Fleta Heller DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 416,
      "Comment": "cum",
      "Registered": "2006-04-22T03:40:55.8511506+02:00",
      "RegisteredAssociateId": 324,
      "Updated": "2006-11-22T03:40:55.8511506+01:00",
      "UpdatedAssociateId": 992,
      "LegalBaseId": 565,
      "LegalBaseKey": "tenetur",
      "LegalBaseName": "Thiel Inc and Sons",
      "ConsentPurposeId": 239,
      "ConsentPurposeKey": "impedit",
      "ConsentPurposeName": "Haag-Murphy",
      "ConsentSourceId": 386,
      "ConsentSourceKey": "nulla",
      "ConsentSourceName": "Ortiz, Hermann and Boyle",
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
  "BounceEmails": [
    "reginald@reilly.uk",
    "reed@nader.info"
  ],
  "ActiveStatusMonitorId": 35,
  "CreatedByFormId": 658,
  "UtmParameters": null,
  "LeadstatusId": 340,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Marge Cartwright III"
  },
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "optio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 255
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```