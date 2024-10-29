---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 918,
  "Name": "Sanford, Strosin and Hamill",
  "Department": "",
  "OrgNr": "1738270",
  "Number1": "626700",
  "Number2": "523321",
  "UpdatedDate": "2006-02-22T13:14:05.6788931+01:00",
  "CreatedDate": "2012-08-12T13:14:05.6788931+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "blanditiis",
      "Description": "Self-enabling multi-state groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "blanditiis",
      "Description": "Self-enabling multi-state groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 944,
      "Name": "Mertz-Braun",
      "ToolTip": "Et autem laborum.",
      "Deleted": false,
      "Rank": 317,
      "Type": "repellat",
      "ColorBlock": 121,
      "IconHint": "repellat",
      "Selected": true,
      "LastChanged": "2023-08-07T13:14:05.6788931+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Kareem Green",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 640
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "qui",
      "Description": "Devolved systematic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "qui",
      "Description": "Devolved systematic capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "earum",
      "StrippedValue": "placeat",
      "Description": "Future-proofed uniform time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 777
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "placeat",
      "Description": "Future-proofed uniform time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 777
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "pariatur",
      "StrippedValue": "mollitia",
      "Description": "Managed systematic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "mollitia",
      "Description": "Managed systematic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Description": "Business-focused explicit encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sapiente",
      "PersonId": 667,
      "Mrmrs": "possimus",
      "Firstname": "Pasquale",
      "Lastname": "Cormier",
      "MiddleName": "Senger, Willms and Murray",
      "Title": "consequatur",
      "Description": "Proactive exuding orchestration",
      "Email": "lilliana@murrayanderson.com",
      "FullName": "Keira Shanahan",
      "DirectPhone": "617-788-8867 x5843",
      "FormalName": "Predovic LLC",
      "CountryId": 535,
      "ContactId": 71,
      "ContactName": "Abbott, Kulas and Nolan",
      "Retired": 538,
      "Rank": 183,
      "ActiveInterests": 828,
      "ContactDepartment": "",
      "ContactCountryId": 812,
      "ContactOrgNr": "370462",
      "FaxPhone": "(596)219-5964 x28040",
      "MobilePhone": "311.880.8899 x31428",
      "ContactPhone": "361-574-1746 x83786",
      "AssociateName": "Baumbach-Jakubowski",
      "AssociateId": 415,
      "UsePersonAddress": false,
      "ContactFax": "enim",
      "Kanafname": "dolores",
      "Kanalname": "debitis",
      "Post1": "inventore",
      "Post2": "et",
      "Post3": "unde",
      "EmailName": "carlee_ullrich@renner.name",
      "ContactFullName": "Raphael Marjolaine Brakus Jr.",
      "ActiveErpLinks": 385,
      "TicketPriorityId": 328,
      "SupportLanguageId": 659,
      "SupportAssociateId": 937,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 120
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sunt",
  "Xstop": false,
  "ActiveInterests": 465,
  "GroupId": 839,
  "ActiveStatusMonitorId": 314,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 747,
  "DbiAgentId": 455,
  "DbiLastSyncronized": "2011-09-05T13:14:05.6788931+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "2008-01-24T13:14:05.6788931+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 143,
  "ActiveErpLinks": 976,
  "BounceEmails": [
    "humberto@howell.ca",
    "kadin@legros.name"
  ],
  "Domains": [
    "atque",
    "eius"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Hailie Quitzon PhD",
    "SuperOffice:2": "Charley Carroll"
  },
  "ExtraFields": {
    "ExtraFields1": "nostrum",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 279
    }
  }
}
```