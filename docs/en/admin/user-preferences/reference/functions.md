---
title: Functions
uid: pref_functions
description: Preference section Functions
author: {github-id}
keywords: database
so.topic: reference
---

# Preference section Functions

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Functions'
```

The Functions section contains a variety of preferences that affect the SuperOffice client behavior in small but useful ways.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| ThreeStateStatusCheckbox | Enables three completion statuses for follow-ups:<br>Not started<br>Started<br>Completed. | NO | Bool | Admin, Admin users, Wizard |
| ActiveSound | Enables the use of sounds for events.<br>The various sounds may be defined individually under Sounds and Audio Devices in the Windows Control Panel. | | Bool | Admin, Crm, Admin users, Wizard |
| BackgroundDocumentCheckTimer | Documents on the Activities section tab can be checked in the background.<br>The availability of a specified document plug-in and of each individual document is checked. Here you enter the number of seconds between each document check. | 1 | Bool | Admin, Admin users, Wizard |
| BlankApptClick | Specifies the type of activity to create when you double-click on a blank line in the Activities section tab in the Company or Project screens. | | List | Admin, Crm, Admin users, Wizard |
| CapitalFirstLetterCompanyName | Should the first letter in every word in the company name automatically be converted to a capital letter? | YES | Bool | Admin, Crm, Admin users, Wizard |
| CapitalFirstLetterPersonName | Should the first letter in every word in the contact name automatically be converted to a capital letter? | YES | Bool | Admin, Crm, Admin users, Wizard |
| DisableContactDogEar | Removes the corner tabs on the Company card if there are too many companies (more than this number) | | Bool | Admin, Admin users, Wizard |
| DisableDelKey | If YES, the user has to use the menu to delete a company, project, or selection | YES | Bool | Admin, Admin users, Wizard |
| DisplayDateFormatInLists | Specifies the date format used in section tabs (ex. dd.mm.yyyy hh:mm).| computer's regional settings for short date format | Text | Wizard |
| EditIfVisible | Allows other users to add and remove members from any selection visible to the user | | Bool | Admin, Admin users, Wizard |
| EnableBackgroundDocumentCheck | Documents on the Activities section tab can be checked in the background.<br>The availability of a specified document plug-in and of each individual document is checked. This may happen at the cost of server capacity.<br>Alternatively, documents are checked when the user enables the right-click menu. It will then take longer for a document to open since it first has to be checked. | ON | Bool | Admin, Admin users, Wizard |
| FilterBookingSlaves | Filter out invitations for everyone except the person making the invitation, to avoid duplicates in the list. | | Bool | Admin, Crm, Admin users, Wizard |
| ForceConfirmation | Always displays confirmation dialog when deleting | | Bool | Admin, Admin users, Wizard |
| GetAdvanceDays | Number of days ahead to display to-dos in the checklist. | 21 days | Number | Admin, Crm, Admin users, Wizard |
| GetRecordCounts | Whether to display record counts in lists. This takes slightly longer but provides a useful overview. | | Bool | Admin, Crm, Admin users, Wizard |
| HomeContact | Which contact is displayed when you click on Hugo (the owl in the Navigator) | | ContactId | Admin, Crm, Admin users, Wizard |
| InternetUseIntegratedBrowser | Uses the internal browser when clicking a URL in SuperOffice.<br>If you set this preference to No, your computer's default browser will be used instead. | YES | Bool | Admin, Crm, Admin users, Wizard |
| PastDateAlert | Marks overdue activities in section tabs | YES | Bool | Admin, Crm, Admin users, Wizard |
| PeriodicCheckInterval | How often (in minutes) should SuperOffice check the database for new invitations etc. | | Number | Admin, Admin users, Wizard |
| RemoveInvitationDuplicates | This ensures that invitations are displayed only once in the Activities section tab. | YES | Bool | Admin, Admin users, Wizard |
| ShowAllPhoneNumbers | Allows the option of adding several phone numbers of the same type (e.g. mobile phone) in the Contact dialog. | NO | Bool | Admin, Admin users, Wizard |
| ShowDocs | Shows documents in the Activities section tab | | Bool | Wizard |
| ShowFollowUps | Shows follow-ups in the Activities section tab | | Bool | Wizard |
| ShowInviteDlgFromView | Should SuperOffice automatically display the Invitation dialog when creating an activity from the diary view. | NO | Bool | Admin, Crm, Admin users, Wizard |
| ShowRetiredPersons | Show former employees in the Contacts section tab | | Bool | Wizard |
| ShowSales | Shows sales in the Activities section tab | | Bool | Wizard |
| ShowTipNumber | Next tip of the day to be displayed. | | Number | Wizard |
| ShowTipsAtStart | Should a tip of the day be displayed every time a user logs in to SuperOffice. | YES | Bool | Admin, Crm, Admin users, Wizard |
| ShowToDo | Shows to-dos in the checklist | | Bool | Wizard |
| UseCaseOnTemplateVariables | The template variables used in, for instance, documents and addresses are output in lower case and get the text exactly as stored in the database by default.<br>Setting this preference will change the text to uppercase for all or just the first letter, depending on how the template variable is input. | NO | Bool | Admin, Admin users, Wizard |
| UseMiddleName | Enables the use of middle names in the Contact dialog | | Bool | Admin, Admin users, Wizard |
| ShowProgressInfo | Should a progress dialog be displayed on the Travel Gateway when active tasks are running? | YES | Bool | Admin, Admin users, Wizard |
| IdAllocationBatchSize | How many records should be inserted into the database during an import before they are committed? | | Number | Admin, Admin users, Wizard |
| MandatoryContactOnPerson | If all contacts have to be associated with a company. | YES | Bool | Admin, Admin users, Wizard |
