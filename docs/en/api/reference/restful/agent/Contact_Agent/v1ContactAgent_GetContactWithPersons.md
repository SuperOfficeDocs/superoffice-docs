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
  "ContactId": 300
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 433,
  "Name": "Boyle, Swaniawski and Predovic",
  "Department": "",
  "OrgNr": "705609",
  "Number1": "580421",
  "Number2": "484711",
  "UpdatedDate": "2016-03-13T14:45:05.0846025+01:00",
  "CreatedDate": "2001-11-16T14:45:05.0846025+01:00",
  "Emails": [
    {
      "Value": "possimus",
      "StrippedValue": "aut",
      "Description": "Synchronised composite productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 964
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "aut",
      "Description": "Synchronised composite productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 964
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 290,
      "Name": "Krajcik, Kilback and Larkin",
      "ToolTip": "Libero aut cupiditate.",
      "Deleted": false,
      "Rank": 498,
      "Type": "sit",
      "ColorBlock": 523,
      "IconHint": "delectus",
      "Selected": false,
      "LastChanged": "2010-04-27T14:45:05.0846025+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Heather Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 591
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "quo",
      "Description": "Enhanced 5th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "quo",
      "Description": "Enhanced 5th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "aperiam",
      "Description": "Streamlined disintermediate artificial intelligence",
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
      "Value": "quos",
      "StrippedValue": "aperiam",
      "Description": "Streamlined disintermediate artificial intelligence",
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
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "ut",
      "Description": "Re-engineered local moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "ut",
      "Description": "Re-engineered local moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 148
        }
      }
    }
  ],
  "Description": "Integrated hybrid attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsum",
      "PersonId": 773,
      "Mrmrs": "qui",
      "Firstname": "Brown",
      "Lastname": "Heaney",
      "MiddleName": "Blanda-Powlowski",
      "Title": "suscipit",
      "Description": "Right-sized systematic concept",
      "Email": "kylie_kohler@runte.co.uk",
      "FullName": "Dianna Reanna Hayes IV",
      "DirectPhone": "156-549-7403 x197",
      "FormalName": "Paucek, Labadie and Cummerata",
      "CountryId": 161,
      "ContactId": 104,
      "ContactName": "Armstrong-Stracke",
      "Retired": 682,
      "Rank": 697,
      "ActiveInterests": 254,
      "ContactDepartment": "",
      "ContactCountryId": 865,
      "ContactOrgNr": "1644393",
      "FaxPhone": "(270)668-7548 x97123",
      "MobilePhone": "671-923-3825 x5105",
      "ContactPhone": "(703)213-5790 x7337",
      "AssociateName": "Rogahn-Stracke",
      "AssociateId": 448,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "sit",
      "Kanalname": "aut",
      "Post1": "quia",
      "Post2": "est",
      "Post3": "vel",
      "EmailName": "edgardo@upton.uk",
      "ContactFullName": "Damien Marvin",
      "ActiveErpLinks": 321,
      "TicketPriorityId": 915,
      "SupportLanguageId": 946,
      "SupportAssociateId": 832,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "corrupti",
  "Xstop": false,
  "ActiveInterests": 36,
  "GroupId": 705,
  "ActiveStatusMonitorId": 442,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 488,
  "DbiAgentId": 523,
  "DbiLastSyncronized": "2011-12-28T14:45:05.0846025+01:00",
  "DbiKey": "cum",
  "DbiLastModified": "1998-05-10T14:45:05.0846025+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 980,
  "ActiveErpLinks": 789,
  "BounceEmails": [
    "devonte@terrylarson.us",
    "manuela@smithsmith.uk"
  ],
  "Domains": [
    "officiis",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1581641079",
    "SuperOffice:2": "532420515"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "a"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 907
    }
  }
}
```