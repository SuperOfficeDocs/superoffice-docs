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
  "ContactName": "Hegmann-Tillman",
  "PersonFirstname": "Ona",
  "PersonLastname": "Hand",
  "EmailAddress": "arden_carroll@mayert.biz",
  "PhoneNumber": "798105"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 567,
  "Firstname": "Cade",
  "MiddleName": "Schaefer, Okuneva and Breitenberg",
  "Lastname": "Blanda",
  "Mrmrs": "quia",
  "Title": "similique",
  "UpdatedDate": "2008-09-15T02:38:21.6201414+02:00",
  "CreatedDate": "2012-09-11T02:38:21.6201414+02:00",
  "BirthDate": "2018-04-23T02:38:21.6201414+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "exercitationem",
      "StrippedValue": "aut",
      "Description": "Balanced dynamic project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 690
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "aut",
      "Description": "Balanced dynamic project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 690
        }
      }
    }
  ],
  "Description": "Configurable systemic process improvement",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sit",
      "StrippedValue": "ad",
      "Description": "Organic directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ad",
      "Description": "Organic directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "distinctio",
      "StrippedValue": "occaecati",
      "Description": "Diverse scalable migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 324
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "occaecati",
      "Description": "Diverse scalable migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 324
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "dolorem",
      "Description": "Digitized disintermediate throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 377
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "dolorem",
      "Description": "Digitized disintermediate throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 377
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "laboriosam",
      "Description": "Customizable optimizing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "laboriosam",
      "Description": "Customizable optimizing knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Cloned eco-centric attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 115
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Cloned eco-centric attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 115
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
      "Id": 497,
      "Name": "Nolan, Rice and Douglas",
      "ToolTip": "Aperiam error eius qui consequatur voluptatibus iste quia.",
      "Deleted": true,
      "Rank": 341,
      "Type": "eligendi",
      "ColorBlock": 833,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2024-06-22T02:38:21.6201414+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Mrs. Kyra Jast Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "PersonNumber": "1248448",
  "FullName": "Miss Dorris Jimmie Upton II",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "amet",
      "Description": "Exclusive optimizing collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "amet",
      "Description": "Exclusive optimizing collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "FormalName": "Beatty, Stark and Beier",
  "Address": null,
  "Post3": "id",
  "Post2": "qui",
  "Post1": "tempora",
  "Kanalname": "ad",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "explicabo",
  "ActiveInterests": 904,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 260,
  "DbiKey": "est",
  "DbiLastModified": "2003-07-24T02:38:21.6201414+02:00",
  "DbiLastSyncronized": "2009-10-01T02:38:21.6201414+02:00",
  "SentInfo": 575,
  "ShowContactTickets": 72,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nam",
      "StrippedValue": "nostrum",
      "Description": "Multi-layered full-range firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "nostrum",
      "Description": "Multi-layered full-range firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "magni",
      "StrippedValue": "quo",
      "Description": "Reactive zero administration matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "quo",
      "Description": "Reactive zero administration matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "Source": 177,
  "ActiveErpLinks": 84,
  "ShipmentTypes": [
    {
      "Id": 49,
      "Name": "Kohler, Nicolas and Konopelski",
      "ToolTip": "Nihil ut recusandae.",
      "Deleted": false,
      "Rank": 133,
      "Type": "in",
      "ColorBlock": 957,
      "IconHint": "magni",
      "Selected": false,
      "LastChanged": "2008-05-13T02:38:21.6201414+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "assumenda",
      "Hidden": false,
      "FullName": "Judah Schowalter I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 462
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 557,
      "Comment": "qui",
      "Registered": "2022-04-18T02:38:21.6201414+02:00",
      "RegisteredAssociateId": 251,
      "Updated": "2003-11-15T02:38:21.6201414+01:00",
      "UpdatedAssociateId": 850,
      "LegalBaseId": 592,
      "LegalBaseKey": "assumenda",
      "LegalBaseName": "Gaylord LLC",
      "ConsentPurposeId": 189,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Hand Inc and Sons",
      "ConsentSourceId": 278,
      "ConsentSourceKey": "illum",
      "ConsentSourceName": "Casper LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "BounceEmails": [
    "tessie.heidenreich@bergnaum.com",
    "jasper.grant@krislarson.co.uk"
  ],
  "ActiveStatusMonitorId": 598,
  "CreatedByFormId": 992,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Lavern Mayert",
    "SuperOffice:2": "Benton Willms"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "voluptate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 899
    }
  }
}
```