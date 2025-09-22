---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
content_type: reference
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.







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

### Response body: PersonEntity

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

## Sample request

```http!
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 30 Jan 2025 11:24:53 G1T

{
  "PersonId": 87,
  "Firstname": "Josie",
  "MiddleName": "Dicki LLC",
  "Lastname": "Zulauf",
  "Mrmrs": "qui",
  "Title": "dolores",
  "UpdatedDate": "2025-01-30T11:24:53.3124447+01:00",
  "CreatedDate": "2011-11-20T11:24:53.3124447+01:00",
  "BirthDate": "1999-08-19T11:24:53.3124447+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "vel",
      "Description": "Configurable dedicated extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 381
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "vel",
      "Description": "Configurable dedicated extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 381
        }
      }
    }
  ],
  "Description": "Inverse grid-enabled interface",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Intuitive systematic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Intuitive systematic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Up-sized demand-driven access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 790
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Up-sized demand-driven access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 790
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quas",
      "StrippedValue": "at",
      "Description": "Assimilated stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "at",
      "Description": "Assimilated stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nisi",
      "StrippedValue": "ut",
      "Description": "Cloned heuristic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "ut",
      "Description": "Cloned heuristic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "qui",
      "Description": "Multi-lateral real-time encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "qui",
      "Description": "Multi-lateral real-time encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
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
      "Id": 144,
      "Name": "Kshlerin, Buckridge and Pouros",
      "ToolTip": "Facilis reprehenderit dicta nihil quis dolorum maxime.",
      "Deleted": false,
      "Rank": 977,
      "Type": "laborum",
      "ColorBlock": 536,
      "IconHint": "sequi",
      "Selected": false,
      "LastChanged": "2022-03-24T11:24:53.3124447+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Prof. Bernita Lily Stamm II",
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
  "PersonNumber": "920381",
  "FullName": "Dr. Randy Russell Lang",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "hic",
      "Description": "Face to face demand-driven website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "hic",
      "Description": "Face to face demand-driven website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    }
  ],
  "FormalName": "Yost, Cruickshank and Kulas",
  "Address": null,
  "Post3": "sit",
  "Post2": "ut",
  "Post1": "et",
  "Kanalname": "sit",
  "Kanafname": "voluptatem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "mollitia",
  "ActiveInterests": 135,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 706,
  "DbiKey": "distinctio",
  "DbiLastModified": "2009-05-07T11:24:53.3124447+02:00",
  "DbiLastSyncronized": "2010-06-01T11:24:53.3124447+02:00",
  "SentInfo": 297,
  "ShowContactTickets": 982,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quas",
      "StrippedValue": "enim",
      "Description": "Object-based content-based alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "enim",
      "Description": "Object-based content-based alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "asperiores",
      "Description": "Open-source optimal functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "asperiores",
      "Description": "Open-source optimal functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "Source": 558,
  "ActiveErpLinks": 955,
  "ShipmentTypes": [
    {
      "Id": 78,
      "Name": "Buckridge, McClure and Jerde",
      "ToolTip": "Reiciendis non iste ea eum et nesciunt.",
      "Deleted": false,
      "Rank": 50,
      "Type": "delectus",
      "ColorBlock": 271,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2000-07-17T11:24:53.3124447+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Dylan Ledner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 870,
      "Comment": "reprehenderit",
      "Registered": "2004-11-21T11:24:53.3124447+01:00",
      "RegisteredAssociateId": 442,
      "Updated": "2016-06-10T11:24:53.3124447+02:00",
      "UpdatedAssociateId": 281,
      "LegalBaseId": 657,
      "LegalBaseKey": "enim",
      "LegalBaseName": "Muller-Schmidt",
      "ConsentPurposeId": 545,
      "ConsentPurposeKey": "quasi",
      "ConsentPurposeName": "Kautzer-Schumm",
      "ConsentSourceId": 109,
      "ConsentSourceKey": "occaecati",
      "ConsentSourceName": "Larson Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "BounceEmails": [
    "calista_rohan@hacketthand.info",
    "lucius.pfannerstill@kuhlmanstiedemann.co.uk"
  ],
  "ActiveStatusMonitorId": 387,
  "CreatedByFormId": 975,
  "UtmParameters": null,
  "LeadstatusId": 231,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "170913129"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "pariatur",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 214
    }
  }
}
```