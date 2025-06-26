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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 43
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 838,
  "Firstname": "Charley",
  "MiddleName": "Aufderhar, Borer and Schulist",
  "Lastname": "Considine",
  "Mrmrs": "et",
  "Title": "voluptatem",
  "UpdatedDate": "2012-12-12T03:45:23.7016984+01:00",
  "CreatedDate": "2013-01-24T03:45:23.7016984+01:00",
  "BirthDate": "2019-12-02T03:45:23.7016984+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Reactive value-added intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Reactive value-added intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Description": "Robust reciprocal intranet",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Networked 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 396
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Networked 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 396
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "deleniti",
      "StrippedValue": "aut",
      "Description": "Ameliorated regional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "aut",
      "Description": "Ameliorated regional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Enhanced stable budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Enhanced stable budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "atque",
      "StrippedValue": "vel",
      "Description": "Integrated 5th generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "vel",
      "Description": "Integrated 5th generation strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "qui",
      "StrippedValue": "qui",
      "Description": "Persevering systematic conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "qui",
      "Description": "Persevering systematic conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 991
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
      "Id": 788,
      "Name": "McGlynn-Terry",
      "ToolTip": "Rerum nam ad occaecati voluptatem amet vero.",
      "Deleted": false,
      "Rank": 838,
      "Type": "eos",
      "ColorBlock": 619,
      "IconHint": "odio",
      "Selected": false,
      "LastChanged": "2021-05-30T03:45:23.7016984+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "totam",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Mrs. Lisette Favian Moore II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 533
        }
      }
    }
  ],
  "PersonNumber": "898290",
  "FullName": "Madilyn Quigley",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "fuga",
      "Description": "Seamless stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 517
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "fuga",
      "Description": "Seamless stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 517
        }
      }
    }
  ],
  "FormalName": "Ernser Inc and Sons",
  "Address": null,
  "Post3": "voluptate",
  "Post2": "magni",
  "Post1": "cum",
  "Kanalname": "eveniet",
  "Kanafname": "consectetur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tempora",
  "ActiveInterests": 392,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 360,
  "DbiKey": "vel",
  "DbiLastModified": "2012-12-19T03:45:23.7016984+01:00",
  "DbiLastSyncronized": "2019-05-04T03:45:23.7016984+02:00",
  "SentInfo": 557,
  "ShowContactTickets": 694,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "deleniti",
      "Description": "Cross-group methodical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "deleniti",
      "Description": "Cross-group methodical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ullam",
      "StrippedValue": "consequuntur",
      "Description": "Exclusive systematic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "consequuntur",
      "Description": "Exclusive systematic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "Source": 109,
  "ActiveErpLinks": 127,
  "ShipmentTypes": [
    {
      "Id": 864,
      "Name": "Aufderhar Inc and Sons",
      "ToolTip": "Rerum est.",
      "Deleted": false,
      "Rank": 601,
      "Type": "maiores",
      "ColorBlock": 814,
      "IconHint": "fuga",
      "Selected": false,
      "LastChanged": "2002-12-24T03:45:23.7016984+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "exercitationem",
      "Hidden": false,
      "FullName": "Eva Jacobs DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 108,
      "Comment": "est",
      "Registered": "2015-08-19T03:45:23.7016984+02:00",
      "RegisteredAssociateId": 936,
      "Updated": "2000-12-02T03:45:23.7016984+01:00",
      "UpdatedAssociateId": 125,
      "LegalBaseId": 410,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Hilll LLC",
      "ConsentPurposeId": 274,
      "ConsentPurposeKey": "nobis",
      "ConsentPurposeName": "Bechtelar-Dooley",
      "ConsentSourceId": 99,
      "ConsentSourceKey": "velit",
      "ConsentSourceName": "Okuneva, Abshire and Farrell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "BounceEmails": [
    "beth_fritsch@gulgowski.name",
    "jonatan@hamillrunte.name"
  ],
  "ActiveStatusMonitorId": 355,
  "CreatedByFormId": 716,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Mrs. Lane Kellie Blanda"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 588
    }
  }
}
```