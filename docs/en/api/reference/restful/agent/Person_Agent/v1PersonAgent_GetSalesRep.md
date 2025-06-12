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
  "ContactName": "Franecki Inc and Sons",
  "PersonFirstname": "Daija",
  "PersonLastname": "Graham",
  "EmailAddress": "lenora_konopelski@lakin.co.uk",
  "PhoneNumber": "1606925"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 72,
  "Firstname": "Ashley",
  "MiddleName": "Robel, Marquardt and Reynolds",
  "Lastname": "Howe",
  "Mrmrs": "cum",
  "Title": "nisi",
  "UpdatedDate": "2022-07-28T17:54:03.3826938+02:00",
  "CreatedDate": "2002-11-02T17:54:03.3826938+01:00",
  "BirthDate": "2011-01-01T17:54:03.3826938+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "quidem",
      "Description": "Customizable bottom-line structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "quidem",
      "Description": "Customizable bottom-line structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "Description": "Distributed systemic contingency",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "magni",
      "Description": "Focused upward-trending definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "magni",
      "Description": "Focused upward-trending definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iste",
      "StrippedValue": "iste",
      "Description": "Customer-focused solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "iste",
      "Description": "Customer-focused solution-oriented approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ea",
      "StrippedValue": "quis",
      "Description": "Optional full-range portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quis",
      "Description": "Optional full-range portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "excepturi",
      "Description": "Automated foreground core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 784
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "excepturi",
      "Description": "Automated foreground core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 784
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quam",
      "StrippedValue": "est",
      "Description": "Secured radical forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "est",
      "Description": "Secured radical forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
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
      "Id": 194,
      "Name": "Schaden-Toy",
      "ToolTip": "Voluptate id vel dignissimos consectetur necessitatibus incidunt eligendi.",
      "Deleted": false,
      "Rank": 323,
      "Type": "ipsam",
      "ColorBlock": 808,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2021-07-14T17:54:03.3826938+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Miss Sandrine Ozella Johns",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    }
  ],
  "PersonNumber": "1643574",
  "FullName": "Beau Conn I",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "provident",
      "StrippedValue": "minus",
      "Description": "Seamless local initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 224
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "minus",
      "Description": "Seamless local initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 224
        }
      }
    }
  ],
  "FormalName": "Hoeger, Bergstrom and Nitzsche",
  "Address": null,
  "Post3": "delectus",
  "Post2": "assumenda",
  "Post1": "esse",
  "Kanalname": "quod",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "culpa",
  "ActiveInterests": 263,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 292,
  "DbiKey": "quos",
  "DbiLastModified": "2009-01-23T17:54:03.3826938+01:00",
  "DbiLastSyncronized": "2005-12-15T17:54:03.3826938+01:00",
  "SentInfo": 860,
  "ShowContactTickets": 610,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Advanced disintermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Advanced disintermediate middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Persevering bandwidth-monitored info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Persevering bandwidth-monitored info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    }
  ],
  "Source": 404,
  "ActiveErpLinks": 932,
  "ShipmentTypes": [
    {
      "Id": 519,
      "Name": "Keeling-Schoen",
      "ToolTip": "Ipsa et sequi nobis eius sapiente odio ducimus.",
      "Deleted": true,
      "Rank": 472,
      "Type": "ducimus",
      "ColorBlock": 1002,
      "IconHint": "hic",
      "Selected": false,
      "LastChanged": "2011-01-04T17:54:03.3826938+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Keenan Marquardt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 172,
      "Comment": "id",
      "Registered": "2012-04-17T17:54:03.3826938+02:00",
      "RegisteredAssociateId": 901,
      "Updated": "1999-10-22T17:54:03.3826938+02:00",
      "UpdatedAssociateId": 834,
      "LegalBaseId": 255,
      "LegalBaseKey": "deserunt",
      "LegalBaseName": "Ullrich Group",
      "ConsentPurposeId": 688,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Gottlieb-Jenkins",
      "ConsentSourceId": 519,
      "ConsentSourceKey": "delectus",
      "ConsentSourceName": "Schumm LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 666
        }
      }
    }
  ],
  "BounceEmails": [
    "fabiola.fay@mccullough.uk",
    "shane@cormiersimonis.co.uk"
  ],
  "ActiveStatusMonitorId": 361,
  "CreatedByFormId": 453,
  "UserDefinedFields": {
    "SuperOffice:1": "598889294",
    "SuperOffice:2": "Mariela O'Reilly"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "tempora"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 742
    }
  }
}
```