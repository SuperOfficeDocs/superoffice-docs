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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Padberg-Spinka",
  "PersonFirstname": "Trace",
  "PersonLastname": "Pagac",
  "EmailAddress": "angelita@kuhnabshire.us",
  "PhoneNumber": "953128"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 271,
  "Firstname": "Jordan",
  "MiddleName": "Jast-Gutkowski",
  "Lastname": "Bernier",
  "Mrmrs": "aut",
  "Title": "et",
  "UpdatedDate": "1997-10-15T04:22:27.1747424+02:00",
  "CreatedDate": "1999-02-18T04:22:27.1747424+01:00",
  "BirthDate": "2021-11-21T04:22:27.1747424+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ratione",
      "StrippedValue": "magni",
      "Description": "Re-engineered methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "magni",
      "Description": "Re-engineered methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 7
        }
      }
    }
  ],
  "Description": "Object-based heuristic local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "dolorem",
      "Description": "Synergized full-range core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "dolorem",
      "Description": "Synergized full-range core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 133
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "soluta",
      "Description": "Cross-platform demand-driven interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "soluta",
      "Description": "Cross-platform demand-driven interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 129
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nam",
      "StrippedValue": "unde",
      "Description": "Diverse empowering matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 729
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "unde",
      "Description": "Diverse empowering matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 729
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "vel",
      "StrippedValue": "ad",
      "Description": "Sharable clear-thinking attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "ad",
      "Description": "Sharable clear-thinking attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "accusamus",
      "StrippedValue": "quaerat",
      "Description": "Programmable user-facing approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "quaerat",
      "Description": "Programmable user-facing approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
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
      "Id": 13,
      "Name": "Mraz Inc and Sons",
      "ToolTip": "Aut qui ad corrupti ut.",
      "Deleted": true,
      "Rank": 356,
      "Type": "qui",
      "ColorBlock": 467,
      "IconHint": "pariatur",
      "Selected": true,
      "LastChanged": "2014-04-27T04:22:27.1747424+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "mollitia",
      "Hidden": false,
      "FullName": "Bettye Lockman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    }
  ],
  "PersonNumber": "1466176",
  "FullName": "Mr. Jameson Carmelo Lebsack",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "reprehenderit",
      "Description": "Programmable next generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "reprehenderit",
      "Description": "Programmable next generation interface",
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
  "FormalName": "Wisoky, Friesen and Dibbert",
  "Address": null,
  "Post3": "voluptatem",
  "Post2": "rem",
  "Post1": "dignissimos",
  "Kanalname": "debitis",
  "Kanafname": "natus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laborum",
  "ActiveInterests": 168,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 100,
  "DbiKey": "veritatis",
  "DbiLastModified": "1999-01-08T04:22:27.1903679+01:00",
  "DbiLastSyncronized": "1998-06-07T04:22:27.1903679+02:00",
  "SentInfo": 39,
  "ShowContactTickets": 353,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "praesentium",
      "Description": "Intuitive real-time paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "praesentium",
      "Description": "Intuitive real-time paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "vel",
      "StrippedValue": "laboriosam",
      "Description": "Focused asynchronous system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "laboriosam",
      "Description": "Focused asynchronous system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "Source": 669,
  "ActiveErpLinks": 358,
  "ShipmentTypes": [
    {
      "Id": 219,
      "Name": "Kris, Larson and Schmitt",
      "ToolTip": "Quod dolores et tempora eos adipisci et.",
      "Deleted": false,
      "Rank": 85,
      "Type": "consequatur",
      "ColorBlock": 208,
      "IconHint": "sint",
      "Selected": false,
      "LastChanged": "2018-08-18T04:22:27.1903679+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Janie Stoltenberg V",
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
  "Consents": [
    {
      "ConsentPersonId": 183,
      "Comment": "id",
      "Registered": "2008-06-24T04:22:27.1903679+02:00",
      "RegisteredAssociateId": 174,
      "Updated": "2022-11-17T04:22:27.1903679+01:00",
      "UpdatedAssociateId": 919,
      "LegalBaseId": 477,
      "LegalBaseKey": "assumenda",
      "LegalBaseName": "Ondricka-Cummings",
      "ConsentPurposeId": 79,
      "ConsentPurposeKey": "quod",
      "ConsentPurposeName": "Champlin Inc and Sons",
      "ConsentSourceId": 744,
      "ConsentSourceKey": "maxime",
      "ConsentSourceName": "Pouros, Labadie and Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "BounceEmails": [
    "mittie@cormier.co.uk",
    "zoila_dickinson@ferry.name"
  ],
  "ActiveStatusMonitorId": 614,
  "CreatedByFormId": 238,
  "UserDefinedFields": {
    "SuperOffice:1": "Dina Hayes",
    "SuperOffice:2": "Ms. Camille Vidal Baumbach"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "impedit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 992
    }
  }
}
```