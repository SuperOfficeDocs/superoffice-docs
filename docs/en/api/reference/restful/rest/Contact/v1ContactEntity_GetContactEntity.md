---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 03 Jun 2005 16:32:47 G6T

{
  "ContactId": 60,
  "Name": "Frami Group",
  "Department": "",
  "OrgNr": "1282383",
  "Number1": "981047",
  "Number2": "323722",
  "UpdatedDate": "2005-06-03T16:32:47.3215068+02:00",
  "CreatedDate": "2019-03-05T16:32:47.3215068+01:00",
  "Emails": [
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Digitized high-level extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Digitized high-level extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 413,
      "Name": "Jerde, Wintheiser and Thiel",
      "ToolTip": "Dolores et distinctio omnis.",
      "Deleted": false,
      "Rank": 3,
      "Type": "ipsum",
      "ColorBlock": 901,
      "IconHint": "blanditiis",
      "Selected": true,
      "LastChanged": "2001-03-23T16:32:47.3215068+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "praesentium",
      "Hidden": true,
      "FullName": "Mrs. Mathias Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 284
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cupiditate",
      "StrippedValue": "quia",
      "Description": "Centralized mission-critical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "quia",
      "Description": "Centralized mission-critical model",
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
  "Phones": [
    {
      "Value": "porro",
      "StrippedValue": "aliquam",
      "Description": "Programmable multi-tasking initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "aliquam",
      "Description": "Programmable multi-tasking initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "eveniet",
      "Description": "Innovative upward-trending encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "eveniet",
      "Description": "Innovative upward-trending encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    }
  ],
  "Description": "Optional bifurcated concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "itaque",
      "PersonId": 146,
      "Mrmrs": "maiores",
      "Firstname": "Elva",
      "Lastname": "Bradtke",
      "MiddleName": "Kreiger-Conn",
      "Title": "voluptas",
      "Description": "Realigned next generation strategy",
      "Email": "avery_greenfelder@daniel.biz",
      "FullName": "Liliane Hane",
      "DirectPhone": "(720)813-3214",
      "FormalName": "Torphy, Lemke and Barton",
      "CountryId": 253,
      "ContactId": 22,
      "ContactName": "Larkin, Koss and Johnson",
      "Retired": 667,
      "Rank": 583,
      "ActiveInterests": 169,
      "ContactDepartment": "",
      "ContactCountryId": 504,
      "ContactOrgNr": "506663",
      "FaxPhone": "796.711.5142",
      "MobilePhone": "765.518.6046",
      "ContactPhone": "198.303.9264 x2985",
      "AssociateName": "Zemlak-Graham",
      "AssociateId": 221,
      "UsePersonAddress": true,
      "ContactFax": "ipsa",
      "Kanafname": "ducimus",
      "Kanalname": "corporis",
      "Post1": "eum",
      "Post2": "illo",
      "Post3": "harum",
      "EmailName": "elenora@vonernser.us",
      "ContactFullName": "Brown Stokes",
      "ActiveErpLinks": 245,
      "TicketPriorityId": 106,
      "SupportLanguageId": 618,
      "SupportAssociateId": 481,
      "CategoryName": "VIP Customer",
      "PersonNumber": "679044",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 966
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 138,
  "GroupId": 682,
  "ActiveStatusMonitorId": 250,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 710,
  "DbiAgentId": 823,
  "DbiLastSyncronized": "1998-03-16T16:32:47.3215068+01:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2000-08-11T16:32:47.3215068+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 932,
  "ActiveErpLinks": 340,
  "BounceEmails": [
    "sunny@smitham.uk",
    "keven@huelbartoletti.com"
  ],
  "Domains": [
    "dolorum",
    "dolor"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "753516982",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 568
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```