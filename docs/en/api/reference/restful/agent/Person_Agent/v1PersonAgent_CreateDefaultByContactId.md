---
title: POST Agents/Person/CreateDefaultByContactId
uid: v1PersonAgent_CreateDefaultByContactId
generated: true
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 480
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 394,
  "Firstname": "Annabell",
  "MiddleName": "Hessel-Halvorson",
  "Lastname": "Wehner",
  "Mrmrs": "laboriosam",
  "Title": "at",
  "UpdatedDate": "2000-05-17T02:38:21.635759+02:00",
  "CreatedDate": "2023-10-08T02:38:21.635759+02:00",
  "BirthDate": "2015-06-26T02:38:21.635759+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolore",
      "StrippedValue": "magni",
      "Description": "Adaptive zero tolerance protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "magni",
      "Description": "Adaptive zero tolerance protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "Description": "Stand-alone intangible functionalities",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "debitis",
      "StrippedValue": "quia",
      "Description": "Down-sized executive focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "quia",
      "Description": "Down-sized executive focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide human-resource policy",
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
      "Value": "voluptatibus",
      "StrippedValue": "qui",
      "Description": "Enterprise-wide human-resource policy",
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
  "MobilePhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "enim",
      "Description": "Managed contextually-based orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "enim",
      "Description": "Managed contextually-based orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Synergistic contextually-based parallelism",
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
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Synergistic contextually-based parallelism",
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
      "Value": "vitae",
      "StrippedValue": "consequatur",
      "Description": "Compatible systemic service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 661
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "consequatur",
      "Description": "Compatible systemic service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 661
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
      "Id": 260,
      "Name": "Koss-Lindgren",
      "ToolTip": "Vero magni ducimus.",
      "Deleted": false,
      "Rank": 889,
      "Type": "ab",
      "ColorBlock": 331,
      "IconHint": "rem",
      "Selected": false,
      "LastChanged": "2018-07-31T02:38:21.635759+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Calista Auer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "PersonNumber": "961563",
  "FullName": "Charley Rath",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "quia",
      "Description": "Cross-platform modular interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "quia",
      "Description": "Cross-platform modular interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "FormalName": "Kassulke, Mosciski and Mayer",
  "Address": null,
  "Post3": "ipsam",
  "Post2": "aut",
  "Post1": "totam",
  "Kanalname": "voluptatem",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "exercitationem",
  "ActiveInterests": 817,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 703,
  "DbiKey": "non",
  "DbiLastModified": "2007-01-30T02:38:21.635759+01:00",
  "DbiLastSyncronized": "2008-06-01T02:38:21.635759+02:00",
  "SentInfo": 515,
  "ShowContactTickets": 153,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Managed tangible success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Managed tangible success",
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
  "InternetPhones": [
    {
      "Value": "repellat",
      "StrippedValue": "cum",
      "Description": "Exclusive system-worthy groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "cum",
      "Description": "Exclusive system-worthy groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 970
        }
      }
    }
  ],
  "Source": 838,
  "ActiveErpLinks": 574,
  "ShipmentTypes": [
    {
      "Id": 582,
      "Name": "Hickle-Abbott",
      "ToolTip": "Exercitationem sed aliquid quisquam fuga sit.",
      "Deleted": false,
      "Rank": 982,
      "Type": "illo",
      "ColorBlock": 140,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "2017-08-15T02:38:21.635759+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "alias",
      "Hidden": true,
      "FullName": "Lucy Brakus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 407,
      "Comment": "saepe",
      "Registered": "2019-08-03T02:38:21.635759+02:00",
      "RegisteredAssociateId": 847,
      "Updated": "2021-07-17T02:38:21.635759+02:00",
      "UpdatedAssociateId": 727,
      "LegalBaseId": 997,
      "LegalBaseKey": "optio",
      "LegalBaseName": "Metz, Hegmann and Koelpin",
      "ConsentPurposeId": 624,
      "ConsentPurposeKey": "voluptates",
      "ConsentPurposeName": "Pollich-Bartell",
      "ConsentSourceId": 379,
      "ConsentSourceKey": "maxime",
      "ConsentSourceName": "Hintz, Crist and Schaden",
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
  "BounceEmails": [
    "leanna.towne@kutchjohnson.uk",
    "nicklaus@paucekwilderman.co.uk"
  ],
  "ActiveStatusMonitorId": 815,
  "CreatedByFormId": 94,
  "UserDefinedFields": {
    "SuperOffice:1": "Tiara Kuhlman",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "porro"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 158
    }
  }
}
```