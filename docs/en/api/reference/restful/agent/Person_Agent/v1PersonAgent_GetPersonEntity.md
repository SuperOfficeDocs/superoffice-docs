---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=62
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 691,
  "Firstname": "Liliana",
  "MiddleName": "Macejkovic-Schaefer",
  "Lastname": "Huels",
  "Mrmrs": "recusandae",
  "Title": "deserunt",
  "UpdatedDate": "2005-05-30T11:44:34.0096241+02:00",
  "CreatedDate": "2007-06-04T11:44:34.0096241+02:00",
  "BirthDate": "1997-01-18T11:44:34.0096241+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Networked object-oriented archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Networked object-oriented archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 895
        }
      }
    }
  ],
  "Description": "Total stable circuit",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "eaque",
      "Description": "Self-enabling user-facing framework",
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
      "StrippedValue": "eaque",
      "Description": "Self-enabling user-facing framework",
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
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "De-engineered motivating help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "De-engineered motivating help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "aut",
      "Description": "Customizable leading edge initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "aut",
      "Description": "Customizable leading edge initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "alias",
      "Description": "Quality-focused intermediate product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "alias",
      "Description": "Quality-focused intermediate product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "possimus",
      "Description": "Cloned 3rd generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "possimus",
      "Description": "Cloned 3rd generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
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
      "Id": 889,
      "Name": "Conn, Dicki and Gerhold",
      "ToolTip": "Similique quia.",
      "Deleted": true,
      "Rank": 707,
      "Type": "magnam",
      "ColorBlock": 284,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2019-01-28T11:44:34.0096241+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Mrs. Adah Nikolaus II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    }
  ],
  "PersonNumber": "204501",
  "FullName": "Miss Arvilla Sigmund Brakus PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nisi",
      "StrippedValue": "ipsa",
      "Description": "Horizontal dedicated moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "ipsa",
      "Description": "Horizontal dedicated moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    }
  ],
  "FormalName": "Terry-Kunde",
  "Address": null,
  "Post3": "necessitatibus",
  "Post2": "voluptate",
  "Post1": "ea",
  "Kanalname": "ut",
  "Kanafname": "eius",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ad",
  "ActiveInterests": 92,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 717,
  "DbiKey": "soluta",
  "DbiLastModified": "2010-08-06T11:44:34.0096241+02:00",
  "DbiLastSyncronized": "2001-01-04T11:44:34.0096241+01:00",
  "SentInfo": 110,
  "ShowContactTickets": 283,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "in",
      "StrippedValue": "tenetur",
      "Description": "Reverse-engineered solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "tenetur",
      "Description": "Reverse-engineered solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 248
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "tempore",
      "Description": "Sharable asynchronous hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "tempore",
      "Description": "Sharable asynchronous hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "Source": 640,
  "ActiveErpLinks": 110,
  "ShipmentTypes": [
    {
      "Id": 517,
      "Name": "Jakubowski-Weber",
      "ToolTip": "Incidunt temporibus et consequatur error ea qui voluptas.",
      "Deleted": false,
      "Rank": 974,
      "Type": "eius",
      "ColorBlock": 138,
      "IconHint": "commodi",
      "Selected": false,
      "LastChanged": "1998-07-29T11:44:34.0096241+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Lenore Huels",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 417,
      "Comment": "natus",
      "Registered": "1999-10-23T11:44:34.0096241+02:00",
      "RegisteredAssociateId": 74,
      "Updated": "2003-10-24T11:44:34.0096241+02:00",
      "UpdatedAssociateId": 622,
      "LegalBaseId": 443,
      "LegalBaseKey": "rerum",
      "LegalBaseName": "Kilback, Morissette and Wiegand",
      "ConsentPurposeId": 170,
      "ConsentPurposeKey": "necessitatibus",
      "ConsentPurposeName": "Schmitt, Thompson and White",
      "ConsentSourceId": 594,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Stamm, Boehm and Pacocha",
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
  "BounceEmails": [
    "margarete.smitham@stracke.info",
    "tod_bartell@stracke.co.uk"
  ],
  "ActiveStatusMonitorId": 824,
  "UserDefinedFields": {
    "SuperOffice:1": "859623001",
    "SuperOffice:2": "320669439"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 857
    }
  }
}
```