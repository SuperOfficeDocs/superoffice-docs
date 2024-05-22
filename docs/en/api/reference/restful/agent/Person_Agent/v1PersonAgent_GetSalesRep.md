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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Murphy, Leffler and Cartwright",
  "PersonFirstname": "Josh",
  "PersonLastname": "Ziemann",
  "EmailAddress": "bette@rau.uk",
  "PhoneNumber": "1184629"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 789,
  "Firstname": "Tabitha",
  "MiddleName": "Lubowitz-Glover",
  "Lastname": "Heller",
  "Mrmrs": "quis",
  "Title": "ab",
  "UpdatedDate": "2021-05-31T12:57:34.4772484+02:00",
  "CreatedDate": "2008-07-27T12:57:34.4772484+02:00",
  "BirthDate": "2003-11-29T12:57:34.4772484+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "harum",
      "Description": "Enhanced context-sensitive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "harum",
      "Description": "Enhanced context-sensitive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "Description": "Focused exuding challenge",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nam",
      "StrippedValue": "veritatis",
      "Description": "Public-key motivating system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "veritatis",
      "Description": "Public-key motivating system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "pariatur",
      "StrippedValue": "voluptatem",
      "Description": "Balanced bifurcated paradigm",
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
      "Value": "pariatur",
      "StrippedValue": "voluptatem",
      "Description": "Balanced bifurcated paradigm",
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
      "Value": "dolores",
      "StrippedValue": "maiores",
      "Description": "Devolved optimal product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "maiores",
      "Description": "Devolved optimal product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 943
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "aut",
      "Description": "Advanced real-time frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "aut",
      "Description": "Advanced real-time frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "quae",
      "Description": "Reduced homogeneous projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "quae",
      "Description": "Reduced homogeneous projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
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
      "Id": 942,
      "Name": "Waelchi-Grant",
      "ToolTip": "Omnis et perspiciatis eaque consequatur doloribus dolor.",
      "Deleted": false,
      "Rank": 796,
      "Type": "ut",
      "ColorBlock": 178,
      "IconHint": "iste",
      "Selected": false,
      "LastChanged": "2007-04-02T12:57:34.4772484+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Margie Kovacek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "PersonNumber": "1137644",
  "FullName": "Monte Brekke",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "ratione",
      "StrippedValue": "deserunt",
      "Description": "Focused non-volatile knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "deserunt",
      "Description": "Focused non-volatile knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    }
  ],
  "FormalName": "Hickle, Hoppe and Koch",
  "Address": null,
  "Post3": "excepturi",
  "Post2": "fugiat",
  "Post1": "aspernatur",
  "Kanalname": "blanditiis",
  "Kanafname": "temporibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ex",
  "ActiveInterests": 13,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 799,
  "DbiKey": "illo",
  "DbiLastModified": "2022-02-02T12:57:34.4772484+01:00",
  "DbiLastSyncronized": "2002-08-02T12:57:34.4772484+02:00",
  "SentInfo": 666,
  "ShowContactTickets": 636,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "maxime",
      "StrippedValue": "nobis",
      "Description": "Extended transitional time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "nobis",
      "Description": "Extended transitional time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 356
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "saepe",
      "StrippedValue": "quas",
      "Description": "Networked national definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "quas",
      "Description": "Networked national definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "Source": 249,
  "ActiveErpLinks": 197,
  "ShipmentTypes": [
    {
      "Id": 953,
      "Name": "Steuber Inc and Sons",
      "ToolTip": "Dolores cupiditate excepturi magnam ut enim tenetur.",
      "Deleted": true,
      "Rank": 861,
      "Type": "et",
      "ColorBlock": 245,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2021-12-29T12:57:34.4928697+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Dr. Jefferey Reynolds Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 841,
      "Comment": "laborum",
      "Registered": "1997-05-19T12:57:34.4928697+02:00",
      "RegisteredAssociateId": 326,
      "Updated": "1999-10-29T12:57:34.4928697+02:00",
      "UpdatedAssociateId": 176,
      "LegalBaseId": 811,
      "LegalBaseKey": "quo",
      "LegalBaseName": "Kiehn Inc and Sons",
      "ConsentPurposeId": 231,
      "ConsentPurposeKey": "culpa",
      "ConsentPurposeName": "Schiller, Goldner and Grimes",
      "ConsentSourceId": 771,
      "ConsentSourceKey": "sint",
      "ConsentSourceName": "Tillman, Bradtke and Grant",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "BounceEmails": [
    "geo_ward@halvorson.info",
    "cameron@romaguera.info"
  ],
  "ActiveStatusMonitorId": 645,
  "UserDefinedFields": {
    "SuperOffice:1": "1712764626",
    "SuperOffice:2": "Ada Spinka"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "maiores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 69
    }
  }
}
```