---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 52,
  "Name": "O'Conner Inc and Sons",
  "Department": "",
  "OrgNr": "1968438",
  "Number1": "723030",
  "Number2": "179545",
  "UpdatedDate": "2011-09-22T13:57:11.9342044+02:00",
  "CreatedDate": "2010-10-01T13:57:11.9342044+02:00",
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Secured responsive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "et",
      "Description": "Secured responsive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 801,
      "Name": "Terry, Kirlin and Nolan",
      "ToolTip": "Deserunt velit quo consequatur.",
      "Deleted": false,
      "Rank": 797,
      "Type": "dolorem",
      "ColorBlock": 975,
      "IconHint": "quam",
      "Selected": false,
      "LastChanged": "2012-03-23T13:57:11.9342044+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "saepe",
      "StyleHint": "asperiores",
      "Hidden": true,
      "FullName": "Amelia Blick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "architecto",
      "Description": "De-engineered well-modulated capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 559
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "architecto",
      "Description": "De-engineered well-modulated capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 559
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vero",
      "StrippedValue": "debitis",
      "Description": "Digitized high-level interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "debitis",
      "Description": "Digitized high-level interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "commodi",
      "Description": "Cross-group composite frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "commodi",
      "Description": "Cross-group composite frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Description": "Synergized dynamic application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quos",
      "PersonId": 810,
      "Mrmrs": "autem",
      "Firstname": "Candice",
      "Lastname": "Yost",
      "MiddleName": "Wolf, McGlynn and Erdman",
      "Title": "molestias",
      "Description": "Inverse 6th generation structure",
      "Email": "brandon@schroederdoyle.name",
      "FullName": "Prof. Jamel Genoveva McCullough Jr.",
      "DirectPhone": "872-350-2915",
      "FormalName": "Heidenreich, Dickinson and Carter",
      "CountryId": 284,
      "ContactId": 410,
      "ContactName": "Franecki, Lesch and Cassin",
      "Retired": 483,
      "Rank": 866,
      "ActiveInterests": 567,
      "ContactDepartment": "",
      "ContactCountryId": 784,
      "ContactOrgNr": "453512",
      "FaxPhone": "1-275-550-8097 x7768",
      "MobilePhone": "710-349-0256",
      "ContactPhone": "(454)594-0769 x35419",
      "AssociateName": "Volkman-Cremin",
      "AssociateId": 198,
      "UsePersonAddress": false,
      "ContactFax": "quos",
      "Kanafname": "sit",
      "Kanalname": "dolorum",
      "Post1": "quasi",
      "Post2": "eum",
      "Post3": "et",
      "EmailName": "raphaelle.hodkiewicz@hamillturner.com",
      "ContactFullName": "Prof. Roman Russel",
      "ActiveErpLinks": 527,
      "TicketPriorityId": 969,
      "SupportLanguageId": 809,
      "SupportAssociateId": 236,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "consequuntur",
  "Xstop": false,
  "ActiveInterests": 735,
  "GroupId": 347,
  "ActiveStatusMonitorId": 974,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 183,
  "DbiAgentId": 440,
  "DbiLastSyncronized": "1996-10-26T13:57:11.949876+02:00",
  "DbiKey": "impedit",
  "DbiLastModified": "2021-10-19T13:57:11.949876+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 684,
  "ActiveErpLinks": 434,
  "BounceEmails": [
    "rusty_mayer@kuvalisdeckow.co.uk",
    "felicity.rempel@ornsimonis.biz"
  ],
  "Domains": [
    "vero",
    "recusandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1600602419",
    "SuperOffice:2": "Timmothy Abernathy PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "fugit"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 626
    }
  }
}
```