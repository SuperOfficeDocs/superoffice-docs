---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 894
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 432,
  "Name": "Kessler Inc and Sons",
  "Department": "",
  "OrgNr": "724854",
  "Number1": "1167800",
  "Number2": "1033606",
  "UpdatedDate": "2001-01-09T14:28:21.6179108+01:00",
  "CreatedDate": "2010-04-11T14:28:21.6179108+02:00",
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "qui",
      "Description": "Expanded disintermediate Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "qui",
      "Description": "Expanded disintermediate Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 674,
      "Name": "Schimmel, Crist and Watsica",
      "ToolTip": "Aut optio ut ipsam porro ea voluptatem.",
      "Deleted": true,
      "Rank": 558,
      "Type": "ab",
      "ColorBlock": 846,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2010-05-06T14:28:21.6179108+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Mr. Krystel Miller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 681
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Programmable non-volatile neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Programmable non-volatile neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "expedita",
      "StrippedValue": "tempora",
      "Description": "Future-proofed dynamic flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "tempora",
      "Description": "Future-proofed dynamic flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Up-sized next generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Up-sized next generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "Description": "Public-key cohesive projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "debitis",
      "PersonId": 320,
      "Mrmrs": "ullam",
      "Firstname": "Vicenta",
      "Lastname": "Rutherford",
      "MiddleName": "Jones, Boehm and Bruen",
      "Title": "unde",
      "Description": "Enhanced discrete hierarchy",
      "Email": "ulises@boyer.info",
      "FullName": "Pat Hermiston",
      "DirectPhone": "1-712-784-4117 x3994",
      "FormalName": "Olson LLC",
      "CountryId": 49,
      "ContactId": 790,
      "ContactName": "Kub-Schamberger",
      "Retired": 989,
      "Rank": 434,
      "ActiveInterests": 171,
      "ContactDepartment": "",
      "ContactCountryId": 431,
      "ContactOrgNr": "1076663",
      "FaxPhone": "1-935-718-4679",
      "MobilePhone": "1-701-834-4848 x702",
      "ContactPhone": "1-889-243-5184 x652",
      "AssociateName": "Walter Inc and Sons",
      "AssociateId": 896,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "qui",
      "Kanalname": "officia",
      "Post1": "omnis",
      "Post2": "maiores",
      "Post3": "dolores",
      "EmailName": "emelia@bergstrom.info",
      "ContactFullName": "Milan Torp",
      "ActiveErpLinks": 879,
      "TicketPriorityId": 841,
      "SupportLanguageId": 531,
      "SupportAssociateId": 222,
      "CategoryName": "VIP Customer",
      "PersonNumber": "731790",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 790
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": true,
  "ActiveInterests": 634,
  "GroupId": 487,
  "ActiveStatusMonitorId": 442,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 407,
  "DbiAgentId": 107,
  "DbiLastSyncronized": "2023-06-23T14:28:21.6335339+02:00",
  "DbiKey": "totam",
  "DbiLastModified": "2002-08-09T14:28:21.6335339+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 327,
  "ActiveErpLinks": 543,
  "BounceEmails": [
    "walter.emard@klocko.ca",
    "fred@kessler.biz"
  ],
  "Domains": [
    "cum",
    "nesciunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Magali Stracke",
    "SuperOffice:2": "1509570459"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 363
    }
  }
}
```