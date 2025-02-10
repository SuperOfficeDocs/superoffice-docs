---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
generated: true
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 495
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 478,
  "Firstname": "Cleta",
  "MiddleName": "Bernier, Eichmann and Windler",
  "Lastname": "Paucek",
  "Mrmrs": "sint",
  "Title": "illo",
  "UpdatedDate": "2000-04-20T12:01:28.0565443+02:00",
  "CreatedDate": "2008-03-31T12:01:28.0565443+02:00",
  "BirthDate": "2022-05-31T12:01:28.0565443+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "suscipit",
      "StrippedValue": "asperiores",
      "Description": "Secured bi-directional archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "asperiores",
      "Description": "Secured bi-directional archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    }
  ],
  "Description": "User-friendly solution-oriented matrices",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quo",
      "StrippedValue": "in",
      "Description": "Automated stable utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "in",
      "Description": "Automated stable utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 612
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nobis",
      "StrippedValue": "libero",
      "Description": "Mandatory tangible policy",
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
      "Value": "nobis",
      "StrippedValue": "libero",
      "Description": "Mandatory tangible policy",
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
  "MobilePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "sit",
      "Description": "Visionary zero tolerance task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "sit",
      "Description": "Visionary zero tolerance task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Digitized leading edge matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Digitized leading edge matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "deserunt",
      "Description": "Configurable upward-trending productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 832
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "deserunt",
      "Description": "Configurable upward-trending productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 832
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
      "Id": 234,
      "Name": "Treutel, Yost and Koepp",
      "ToolTip": "Expedita error eius.",
      "Deleted": true,
      "Rank": 134,
      "Type": "nihil",
      "ColorBlock": 701,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2004-08-27T12:01:28.0565443+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Prof. Gisselle Koepp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 573
        }
      }
    }
  ],
  "PersonNumber": "231010",
  "FullName": "Rosella Sipes",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "est",
      "Description": "Business-focused directional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "est",
      "Description": "Business-focused directional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 269
        }
      }
    }
  ],
  "FormalName": "Stiedemann Inc and Sons",
  "Address": null,
  "Post3": "impedit",
  "Post2": "labore",
  "Post1": "similique",
  "Kanalname": "et",
  "Kanafname": "error",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eum",
  "ActiveInterests": 359,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 91,
  "DbiKey": "molestias",
  "DbiLastModified": "2015-09-19T12:01:28.0565443+02:00",
  "DbiLastSyncronized": "2008-07-27T12:01:28.0565443+02:00",
  "SentInfo": 560,
  "ShowContactTickets": 243,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "exercitationem",
      "StrippedValue": "debitis",
      "Description": "Re-contextualized explicit model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "debitis",
      "Description": "Re-contextualized explicit model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "quia",
      "Description": "Seamless user-facing protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quia",
      "Description": "Seamless user-facing protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    }
  ],
  "Source": 767,
  "ActiveErpLinks": 55,
  "ShipmentTypes": [
    {
      "Id": 106,
      "Name": "McCullough-Larkin",
      "ToolTip": "Deleniti sit facere est asperiores iste.",
      "Deleted": false,
      "Rank": 754,
      "Type": "quisquam",
      "ColorBlock": 826,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2011-05-07T12:01:28.0565443+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Cali Feeney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 444
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 178,
      "Comment": "quaerat",
      "Registered": "2014-10-17T12:01:28.0565443+02:00",
      "RegisteredAssociateId": 318,
      "Updated": "2017-09-25T12:01:28.0565443+02:00",
      "UpdatedAssociateId": 412,
      "LegalBaseId": 267,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Pouros, Connelly and Grady",
      "ConsentPurposeId": 477,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Harvey-Hilll",
      "ConsentSourceId": 788,
      "ConsentSourceKey": "enim",
      "ConsentSourceName": "Kulas-Kovacek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "BounceEmails": [
    "verda_barton@sauer.info",
    "lesley_schinner@strosin.name"
  ],
  "ActiveStatusMonitorId": 50,
  "CreatedByFormId": 897,
  "UserDefinedFields": {
    "SuperOffice:1": "87547101",
    "SuperOffice:2": "Frieda Bradtke I"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "dignissimos"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 792
    }
  }
}
```