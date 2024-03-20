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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Hintz LLC",
  "PersonFirstname": "Vivienne",
  "PersonLastname": "Wintheiser",
  "EmailAddress": "nicolette@gulgowskiquigley.com",
  "PhoneNumber": "774835"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 745,
  "Firstname": "Macie",
  "MiddleName": "Mraz-Crooks",
  "Lastname": "Aufderhar",
  "Mrmrs": "maxime",
  "Title": "voluptatem",
  "UpdatedDate": "1998-09-05T12:19:45.6796709+02:00",
  "CreatedDate": "2000-03-19T12:19:45.6796709+01:00",
  "BirthDate": "2019-10-15T12:19:45.6796709+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "numquam",
      "Description": "Synergistic coherent synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "numquam",
      "Description": "Synergistic coherent synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Description": "Operative fault-tolerant model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "id",
      "Description": "Phased executive moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "id",
      "Description": "Phased executive moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rem",
      "StrippedValue": "est",
      "Description": "Sharable local productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "est",
      "Description": "Sharable local productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "accusamus",
      "Description": "Progressive human-resource throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "accusamus",
      "Description": "Progressive human-resource throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Stand-alone mission-critical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Stand-alone mission-critical interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "suscipit",
      "Description": "Sharable demand-driven toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "suscipit",
      "Description": "Sharable demand-driven toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
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
      "Id": 1002,
      "Name": "Fahey Group",
      "ToolTip": "Doloribus dolorem porro.",
      "Deleted": false,
      "Rank": 124,
      "Type": "eum",
      "ColorBlock": 976,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2001-09-06T12:19:45.6796709+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Alek Stokes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    }
  ],
  "PersonNumber": "1854414",
  "FullName": "Mr. Hiram Cortney Sporer",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "fugit",
      "Description": "Digitized executive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "fugit",
      "Description": "Digitized executive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    }
  ],
  "FormalName": "Walsh, O'Keefe and Quitzon",
  "Address": null,
  "Post3": "iste",
  "Post2": "praesentium",
  "Post1": "ea",
  "Kanalname": "qui",
  "Kanafname": "vel",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "expedita",
  "ActiveInterests": 35,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 194,
  "DbiKey": "provident",
  "DbiLastModified": "2009-05-19T12:19:45.6796709+02:00",
  "DbiLastSyncronized": "2022-09-17T12:19:45.6796709+02:00",
  "SentInfo": 263,
  "ShowContactTickets": 558,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "debitis",
      "StrippedValue": "dolorem",
      "Description": "Face to face 5th generation alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "dolorem",
      "Description": "Face to face 5th generation alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Expanded didactic workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Expanded didactic workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    }
  ],
  "Source": 114,
  "ActiveErpLinks": 156,
  "ShipmentTypes": [
    {
      "Id": 478,
      "Name": "Mills Inc and Sons",
      "ToolTip": "Adipisci totam.",
      "Deleted": true,
      "Rank": 386,
      "Type": "perferendis",
      "ColorBlock": 622,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2021-02-16T12:19:45.6796709+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Orlo Dach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 724,
      "Comment": "provident",
      "Registered": "2009-09-20T12:19:45.6796709+02:00",
      "RegisteredAssociateId": 480,
      "Updated": "2013-09-06T12:19:45.6796709+02:00",
      "UpdatedAssociateId": 351,
      "LegalBaseId": 416,
      "LegalBaseKey": "quo",
      "LegalBaseName": "Moen Inc and Sons",
      "ConsentPurposeId": 139,
      "ConsentPurposeKey": "occaecati",
      "ConsentPurposeName": "Green-Effertz",
      "ConsentSourceId": 401,
      "ConsentSourceKey": "amet",
      "ConsentSourceName": "Boyer-Stanton",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 897
        }
      }
    }
  ],
  "BounceEmails": [
    "salvador.torphy@price.us",
    "carole@wolfschultz.ca"
  ],
  "ActiveStatusMonitorId": 664,
  "UserDefinedFields": {
    "SuperOffice:1": "Chanel Marquardt",
    "SuperOffice:2": "Gina Carroll Gleason IV"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 524
    }
  }
}
```