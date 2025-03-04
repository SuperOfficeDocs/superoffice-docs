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
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=212
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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
  "PersonId": 749,
  "Firstname": "Efrain",
  "MiddleName": "Prohaska LLC",
  "Lastname": "O'Keefe",
  "Mrmrs": "eos",
  "Title": "dignissimos",
  "UpdatedDate": "2017-01-30T14:13:40.6409266+01:00",
  "CreatedDate": "2016-02-22T14:13:40.6409266+01:00",
  "BirthDate": "2015-09-10T14:13:40.6409266+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "numquam",
      "Description": "Triple-buffered 24 hour access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "numquam",
      "Description": "Triple-buffered 24 hour access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "Description": "Vision-oriented dynamic contingency",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "debitis",
      "Description": "Implemented modular success",
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
      "Value": "quidem",
      "StrippedValue": "debitis",
      "Description": "Implemented modular success",
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
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "consequuntur",
      "Description": "De-engineered assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "consequuntur",
      "Description": "De-engineered assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "nihil",
      "Description": "Balanced hybrid middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "nihil",
      "Description": "Balanced hybrid middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Re-engineered interactive concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 421
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Re-engineered interactive concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 421
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "tenetur",
      "StrippedValue": "dolores",
      "Description": "Public-key intangible policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "dolores",
      "Description": "Public-key intangible policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
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
      "Id": 975,
      "Name": "Orn Group",
      "ToolTip": "Molestiae quia facilis dicta amet ipsam id.",
      "Deleted": true,
      "Rank": 632,
      "Type": "placeat",
      "ColorBlock": 98,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2006-11-12T14:13:40.6565478+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Deion Maggio",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    }
  ],
  "PersonNumber": "782189",
  "FullName": "Ike Zemlak",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "voluptatibus",
      "Description": "Public-key zero administration definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "voluptatibus",
      "Description": "Public-key zero administration definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "FormalName": "Blanda LLC",
  "Address": null,
  "Post3": "quo",
  "Post2": "repellendus",
  "Post1": "occaecati",
  "Kanalname": "et",
  "Kanafname": "totam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 142,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 525,
  "DbiKey": "dicta",
  "DbiLastModified": "2004-05-13T14:13:40.6565478+02:00",
  "DbiLastSyncronized": "2020-03-22T14:13:40.6565478+01:00",
  "SentInfo": 171,
  "ShowContactTickets": 545,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cumque",
      "StrippedValue": "temporibus",
      "Description": "Total next generation Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "temporibus",
      "Description": "Total next generation Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "vel",
      "Description": "Self-enabling incremental secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "vel",
      "Description": "Self-enabling incremental secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "Source": 216,
  "ActiveErpLinks": 725,
  "ShipmentTypes": [
    {
      "Id": 576,
      "Name": "White-Kshlerin",
      "ToolTip": "Est sint autem.",
      "Deleted": false,
      "Rank": 877,
      "Type": "aut",
      "ColorBlock": 389,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "1999-07-06T14:13:40.6565478+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Vicky Bernier DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 243,
      "Comment": "rem",
      "Registered": "2017-11-20T14:13:40.6565478+01:00",
      "RegisteredAssociateId": 504,
      "Updated": "2001-08-12T14:13:40.6565478+02:00",
      "UpdatedAssociateId": 397,
      "LegalBaseId": 361,
      "LegalBaseKey": "illo",
      "LegalBaseName": "O'Kon, Tremblay and Bauch",
      "ConsentPurposeId": 8,
      "ConsentPurposeKey": "nam",
      "ConsentPurposeName": "Yundt-McLaughlin",
      "ConsentSourceId": 197,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Hegmann LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 814
        }
      }
    }
  ],
  "BounceEmails": [
    "kobe_stehr@streich.info",
    "alisha_grady@zieme.com"
  ],
  "ActiveStatusMonitorId": 385,
  "CreatedByFormId": 2,
  "UserDefinedFields": {
    "SuperOffice:1": "Trevion Quigley",
    "SuperOffice:2": "1191978192"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 620
    }
  }
}
```