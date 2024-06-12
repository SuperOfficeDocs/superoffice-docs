---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
generated: true
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.


Calls the Person agent service GetPersonEntity.





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
GET /api/v1/Person/{id}?fk=False
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
Last-Modified: Sun, 18 Oct 2020 04:22:35 G10T

{
  "PersonId": 339,
  "Firstname": "Gilda",
  "MiddleName": "Hansen LLC",
  "Lastname": "Johnson",
  "Mrmrs": "omnis",
  "Title": "libero",
  "UpdatedDate": "2020-10-18T04:22:35.0635909+02:00",
  "CreatedDate": "1998-11-25T04:22:35.0635909+01:00",
  "BirthDate": "2018-02-17T04:22:35.0635909+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "placeat",
      "Description": "Mandatory client-server contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "placeat",
      "Description": "Mandatory client-server contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 523
        }
      }
    }
  ],
  "Description": "Pre-emptive composite knowledge base",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "qui",
      "StrippedValue": "incidunt",
      "Description": "Robust mobile encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 881
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "incidunt",
      "Description": "Robust mobile encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 881
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "commodi",
      "StrippedValue": "quisquam",
      "Description": "Phased 24/7 methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "quisquam",
      "Description": "Phased 24/7 methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "sint",
      "Description": "Integrated asynchronous synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 246
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "sint",
      "Description": "Integrated asynchronous synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 246
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "nisi",
      "Description": "Vision-oriented 6th generation portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "nisi",
      "Description": "Vision-oriented 6th generation portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Function-based assymetric core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Function-based assymetric core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 255
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
      "Id": 108,
      "Name": "Bashirian-Heathcote",
      "ToolTip": "Molestias corporis magnam optio numquam minima id.",
      "Deleted": true,
      "Rank": 189,
      "Type": "nihil",
      "ColorBlock": 101,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2015-03-17T04:22:35.0635909+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magnam",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Miss Ottis Virgie Walter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    }
  ],
  "PersonNumber": "1190369",
  "FullName": "Camron Muller IV",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "consequatur",
      "Description": "Ameliorated regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "consequatur",
      "Description": "Ameliorated regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "FormalName": "Stroman Inc and Sons",
  "Address": null,
  "Post3": "est",
  "Post2": "delectus",
  "Post1": "autem",
  "Kanalname": "corporis",
  "Kanafname": "voluptates",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sit",
  "ActiveInterests": 545,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 308,
  "DbiKey": "eveniet",
  "DbiLastModified": "2008-12-05T04:22:35.0635909+01:00",
  "DbiLastSyncronized": "2004-03-08T04:22:35.0635909+01:00",
  "SentInfo": 804,
  "ShowContactTickets": 342,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolore",
      "StrippedValue": "cumque",
      "Description": "Diverse composite algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "cumque",
      "Description": "Diverse composite algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iure",
      "StrippedValue": "qui",
      "Description": "Universal leading edge matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "qui",
      "Description": "Universal leading edge matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "Source": 631,
  "ActiveErpLinks": 988,
  "ShipmentTypes": [
    {
      "Id": 243,
      "Name": "Ernser-Nader",
      "ToolTip": "Non vero asperiores dolor.",
      "Deleted": true,
      "Rank": 382,
      "Type": "repellat",
      "ColorBlock": 388,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "2024-01-09T04:22:35.0635909+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "molestias",
      "Hidden": false,
      "FullName": "Dr. Zella Brain Douglas IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 576,
      "Comment": "error",
      "Registered": "2021-10-02T04:22:35.0635909+02:00",
      "RegisteredAssociateId": 428,
      "Updated": "2015-08-02T04:22:35.0635909+02:00",
      "UpdatedAssociateId": 288,
      "LegalBaseId": 340,
      "LegalBaseKey": "odit",
      "LegalBaseName": "Miller, Glover and Shanahan",
      "ConsentPurposeId": 633,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Hauck-Dibbert",
      "ConsentSourceId": 813,
      "ConsentSourceKey": "dolores",
      "ConsentSourceName": "Harvey-Mayert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 796
        }
      }
    }
  ],
  "BounceEmails": [
    "sammie@stokes.us",
    "bryana_grady@dare.co.uk"
  ],
  "ActiveStatusMonitorId": 477,
  "CreatedByFormId": 235,
  "UserDefinedFields": {
    "SuperOffice:1": "646342665",
    "SuperOffice:2": "865876978"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 901
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```