---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

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
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 255,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 433,
  "Firstname": "Virginia",
  "MiddleName": "Ernser-Bergstrom",
  "Lastname": "Hoppe",
  "Mrmrs": "repellendus",
  "Title": "sequi",
  "UpdatedDate": "2020-05-23T14:23:46.1730823+02:00",
  "CreatedDate": "2015-10-27T14:23:46.1730823+01:00",
  "BirthDate": "2022-09-13T14:23:46.1730823+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sequi",
      "StrippedValue": "sint",
      "Description": "Adaptive multimedia groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "sint",
      "Description": "Adaptive multimedia groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "Description": "Triple-buffered motivating circuit",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "sunt",
      "Description": "Seamless regional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "sunt",
      "Description": "Seamless regional policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "error",
      "Description": "Total modular utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "error",
      "Description": "Total modular utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "modi",
      "StrippedValue": "suscipit",
      "Description": "Business-focused global open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "suscipit",
      "Description": "Business-focused global open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "reiciendis",
      "Description": "Configurable methodical help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 203
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "reiciendis",
      "Description": "Configurable methodical help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 203
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "similique",
      "StrippedValue": "suscipit",
      "Description": "Progressive real-time time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "suscipit",
      "Description": "Progressive real-time time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
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
      "Id": 83,
      "Name": "Cruickshank, Maggio and Ankunding",
      "ToolTip": "Voluptas aut.",
      "Deleted": true,
      "Rank": 916,
      "Type": "et",
      "ColorBlock": 830,
      "IconHint": "asperiores",
      "Selected": true,
      "LastChanged": "2023-09-22T14:23:46.1887063+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "delectus",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Bryon Franecki Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "PersonNumber": "1167349",
  "FullName": "Jan Hyatt",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "quia",
      "Description": "Secured global help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "quia",
      "Description": "Secured global help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    }
  ],
  "FormalName": "DuBuque, McDermott and Donnelly",
  "Address": null,
  "Post3": "et",
  "Post2": "veniam",
  "Post1": "ad",
  "Kanalname": "consequatur",
  "Kanafname": "nihil",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laboriosam",
  "ActiveInterests": 804,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 472,
  "DbiKey": "sed",
  "DbiLastModified": "2023-07-19T14:23:46.1887063+02:00",
  "DbiLastSyncronized": "2010-10-10T14:23:46.1887063+02:00",
  "SentInfo": 901,
  "ShowContactTickets": 32,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "velit",
      "StrippedValue": "excepturi",
      "Description": "Expanded eco-centric groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "excepturi",
      "Description": "Expanded eco-centric groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "vero",
      "Description": "Cloned national middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "vero",
      "Description": "Cloned national middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Source": 815,
  "ActiveErpLinks": 452,
  "ShipmentTypes": [
    {
      "Id": 290,
      "Name": "Satterfield, Connelly and Lehner",
      "ToolTip": "Laboriosam asperiores.",
      "Deleted": false,
      "Rank": 337,
      "Type": "libero",
      "ColorBlock": 201,
      "IconHint": "reiciendis",
      "Selected": true,
      "LastChanged": "1996-12-30T14:23:46.1887063+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "a",
      "Hidden": true,
      "FullName": "Annabel Leuschke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 895,
      "Comment": "est",
      "Registered": "2001-08-31T14:23:46.1887063+02:00",
      "RegisteredAssociateId": 782,
      "Updated": "2015-08-05T14:23:46.1887063+02:00",
      "UpdatedAssociateId": 673,
      "LegalBaseId": 895,
      "LegalBaseKey": "minus",
      "LegalBaseName": "Beahan, Abbott and Veum",
      "ConsentPurposeId": 1001,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Grady-Pfannerstill",
      "ConsentSourceId": 761,
      "ConsentSourceKey": "cupiditate",
      "ConsentSourceName": "Dare Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 650
        }
      }
    }
  ],
  "BounceEmails": [
    "gaetano.friesen@farrell.info",
    "allison@cummerata.uk"
  ],
  "ActiveStatusMonitorId": 531,
  "UserDefinedFields": {
    "SuperOffice:1": "Dena Waters",
    "SuperOffice:2": "Winona Arely Haag I"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "officiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 121
    }
  }
}
```