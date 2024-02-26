---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.


If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Leffler-Altenwerth",
  "PersonFirstname": "Gia",
  "PersonLastname": "DuBuque",
  "EmailAddress": "hillard@oconner.info",
  "PhoneNumber": "877550"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 257,
  "Firstname": "Walton",
  "MiddleName": "Lubowitz, Dach and McCullough",
  "Lastname": "Conn",
  "Mrmrs": "velit",
  "Title": "debitis",
  "UpdatedDate": "2000-08-16T10:30:24.1975176+02:00",
  "CreatedDate": "2007-05-30T10:30:24.1975176+02:00",
  "BirthDate": "2002-03-11T10:30:24.1975176+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "assumenda",
      "Description": "Robust secondary portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "assumenda",
      "Description": "Robust secondary portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "Description": "Ameliorated bi-directional neural-net",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "provident",
      "StrippedValue": "vel",
      "Description": "Virtual content-based definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 578
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "vel",
      "Description": "Virtual content-based definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 578
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "occaecati",
      "StrippedValue": "et",
      "Description": "Configurable national open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "et",
      "Description": "Configurable national open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolor",
      "Description": "Realigned global core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolor",
      "Description": "Realigned global core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Assimilated upward-trending local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Assimilated upward-trending local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "atque",
      "StrippedValue": "odio",
      "Description": "Advanced even-keeled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "odio",
      "Description": "Advanced even-keeled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
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
      "Id": 158,
      "Name": "Johnson-Morissette",
      "ToolTip": "Eaque dolor.",
      "Deleted": true,
      "Rank": 138,
      "Type": "id",
      "ColorBlock": 167,
      "IconHint": "veniam",
      "Selected": false,
      "LastChanged": "2002-03-14T10:30:24.1975176+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "deserunt",
      "Hidden": false,
      "FullName": "Isidro Heathcote",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "PersonNumber": "1783121",
  "FullName": "Dr. Jackeline Craig Hilll DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "qui",
      "Description": "Seamless discrete database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "qui",
      "Description": "Seamless discrete database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "FormalName": "Moore-Metz",
  "Address": null,
  "Post3": "est",
  "Post2": "aut",
  "Post1": "ut",
  "Kanalname": "non",
  "Kanafname": "fuga",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 493,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 733,
  "DbiKey": "excepturi",
  "DbiLastModified": "2003-03-13T10:30:24.1975176+01:00",
  "DbiLastSyncronized": "2007-07-09T10:30:24.1975176+02:00",
  "SentInfo": 709,
  "ShowContactTickets": 534,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "debitis",
      "StrippedValue": "ea",
      "Description": "De-engineered cohesive conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "ea",
      "Description": "De-engineered cohesive conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "numquam",
      "StrippedValue": "quia",
      "Description": "Distributed context-sensitive architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "quia",
      "Description": "Distributed context-sensitive architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "Source": 827,
  "ActiveErpLinks": 42,
  "ShipmentTypes": [
    {
      "Id": 988,
      "Name": "Farrell, Kshlerin and Bartoletti",
      "ToolTip": "Saepe consequuntur praesentium totam aspernatur illum voluptatem quia.",
      "Deleted": false,
      "Rank": 728,
      "Type": "ab",
      "ColorBlock": 449,
      "IconHint": "aliquid",
      "Selected": false,
      "LastChanged": "2002-07-05T10:30:24.1975176+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Prof. Jesus Veum DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 598,
      "Comment": "qui",
      "Registered": "2001-01-09T10:30:24.1975176+01:00",
      "RegisteredAssociateId": 6,
      "Updated": "2024-02-13T10:30:24.1975176+01:00",
      "UpdatedAssociateId": 404,
      "LegalBaseId": 591,
      "LegalBaseKey": "et",
      "LegalBaseName": "Tremblay-Yundt",
      "ConsentPurposeId": 483,
      "ConsentPurposeKey": "animi",
      "ConsentPurposeName": "Orn-Lynch",
      "ConsentSourceId": 264,
      "ConsentSourceKey": "consectetur",
      "ConsentSourceName": "Brakus-McDermott",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "BounceEmails": [
    "angelita_champlin@kassulke.co.uk",
    "rowan_fisher@collier.com"
  ],
  "ActiveStatusMonitorId": 517,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Albert Hoeger",
    "SuperOffice:2": "Miss Jayme Quentin Hermann"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 508
    }
  }
}
```