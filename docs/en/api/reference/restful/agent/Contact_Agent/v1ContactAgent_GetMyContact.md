---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 757,
  "Name": "Conn-Gutmann",
  "Department": "",
  "OrgNr": "836823",
  "Number1": "1215821",
  "Number2": "798244",
  "UpdatedDate": "1998-05-23T14:19:02.9949033+02:00",
  "CreatedDate": "2009-07-30T14:19:02.9949033+02:00",
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Self-enabling intangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Self-enabling intangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 316,
      "Name": "Jewess, Dibbert and Prosacco",
      "ToolTip": "Repellendus praesentium fuga quisquam maxime unde.",
      "Deleted": true,
      "Rank": 20,
      "Type": "magni",
      "ColorBlock": 957,
      "IconHint": "aliquam",
      "Selected": false,
      "LastChanged": "2018-12-27T14:19:02.9949033+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "illo",
      "Hidden": true,
      "FullName": "Henri Wehner Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "mollitia",
      "Description": "Phased modular time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "mollitia",
      "Description": "Phased modular time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eaque",
      "StrippedValue": "maxime",
      "Description": "Synergistic logistical application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "maxime",
      "Description": "Synergistic logistical application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "ut",
      "Description": "Optimized heuristic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "ut",
      "Description": "Optimized heuristic task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 950
        }
      }
    }
  ],
  "Description": "Business-focused needs-based archive",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequuntur",
      "PersonId": 469,
      "Mrmrs": "magni",
      "Firstname": "Isabella",
      "Lastname": "O'Conner",
      "MiddleName": "Kertzmann-Hansen",
      "Title": "dolorem",
      "Description": "User-friendly human-resource intranet",
      "Email": "malinda_goodwin@leannonhills.com",
      "FullName": "Barton Sawayn",
      "DirectPhone": "1-735-433-2444",
      "FormalName": "Nikolaus LLC",
      "CountryId": 945,
      "ContactId": 546,
      "ContactName": "O'Connell-Gerlach",
      "Retired": 183,
      "Rank": 881,
      "ActiveInterests": 55,
      "ContactDepartment": "",
      "ContactCountryId": 976,
      "ContactOrgNr": "1522996",
      "FaxPhone": "271-464-9779",
      "MobilePhone": "1-390-254-2975 x77211",
      "ContactPhone": "318-977-0660 x8075",
      "AssociateName": "Cremin, Sporer and Williamson",
      "AssociateId": 495,
      "UsePersonAddress": true,
      "ContactFax": "ipsum",
      "Kanafname": "ipsam",
      "Kanalname": "tempore",
      "Post1": "eum",
      "Post2": "officia",
      "Post3": "eum",
      "EmailName": "buford_hudson@boehmmorar.co.uk",
      "ContactFullName": "Bud Kulas",
      "ActiveErpLinks": 857,
      "TicketPriorityId": 709,
      "SupportLanguageId": 7,
      "SupportAssociateId": 229,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 53,
  "GroupId": 929,
  "ActiveStatusMonitorId": 65,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 731,
  "DbiAgentId": 681,
  "DbiLastSyncronized": "2006-05-13T14:19:03.0105285+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2011-10-05T14:19:03.0105285+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 864,
  "ActiveErpLinks": 850,
  "BounceEmails": [
    "emilie.barrows@wiegand.us",
    "destiney_hayes@watsica.name"
  ],
  "Domains": [
    "sed",
    "aliquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Rashad Huels"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 217
    }
  }
}
```