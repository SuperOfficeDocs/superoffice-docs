---
uid: help-en-users-screen
title: Users screen
description: Users screen
author: Bergfrid Dias
so.date: 03.27.2023
keywords: user, associate, our companies
so.topic: reference
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Users screen

In the Users screen, you can add and edit different types of users.

![An overview of the User screen in Settings and maintenance -screenshot][img1]

[**Our companies:**][2] For a person to be registered as a SuperOffice CRM user, this person must be registered with a company displayed in the **Company** list in the Users screen. And for a company to be displayed in the **Company** list in the Users screen, the company must appear on the company list in the **Our companies** tab.

> [!NOTE]
> Changes you make in the Users screen do not come into effect until you click **Save** at the bottom of the screen, and confirm that you want to save the changes in the dialog that then appears. If you click **Cancel**, you will lose all changes you have made in this screen  your last save.

## <a id="associates" />The associate list

By default, the list in the **Associates** tab consists of the following columns:

| Column | Description |
|---|---|
| User ID | The user name assigned to the associate. |
| First name | The user's first name. |
| Last name | The user's last name. |
| Primary group | The primary group of the user. |
| Role | The [role][7] assigned to the user. The role determines the user's access rights to data in SuperOffice CRM. |
| User plan | The user plan assigned to the user, |
| Owning company | The name of the organization the user belongs to (defined as database owner). |

> [!TIP]
> You can select which columns to display in the list. Just right-click a column heading, and select the relevant columns in the columns list. To change the order of the columns, click and drag a column heading.

### User information

On the rightmost side of the window, there is detailed information about the user selected in the list of associates.

The full name, email address and owning company is displayed at the top. At the bottom of this section, you can activate/deactivate the user in SuperOffice using the **Can log in** button. Click the **Task** button to access functions such as **Move user** and for sending welcome emails and emails for resetting passwords.

There are different tabs in the User overview:

* **Details** - main overview of user information like **User ID**, **Role**, **User plan**, **Primary group** and **Service categories**.
* **Licences** - extra license information like **Condfidential activities** that will give the user the option to set **visible for** on follow-ups, documents and selections.
* **More** - the tab shows if there are any extra fields on person.

## <a id="other-users" />Other users (Onsite)

On the **Other users** tab in the Users screen, you can edit login rights for and add anonymous users and System users.

## <a id="our-companies" />Our companies

The object of the company list in the **Our companies** tab in the Users screen is to specify:

* Who can be defined as users of SuperOffice CRM. For a person to be registered as a SuperOffice CRM user, this person must be registered with a company displayed in the **Company** list box in the Users screen. And for a company to be displayed in the **Company** list box in the Users screen, the company must appear on the company list in the **Our companies** tab.

* Which companies can be defined as owners of a satellite.

### Columns in the company list

| Column | Description |
|---|---|
| Company name | The company's name. |
| Department | The name of the department in the company. |
| City | Where the company is located. |
| Associates | How many associates have been created for the company. |
| Active satellite | Whether the company is recorded as an active satellite. |

## User licenses

On the **User licences** tab in the Users screen, you can get an overview of how many user licences are in use, and which users are using the various licences.

* Click a license in the **User licences** list to display a list of the users who are currently using this license.

* Hold the mouse-pointer over a license name to see detailed information about the license.

## User groups

On the **User groups** tab in the Users screen, you can get an overview of users and user groups. Click a group name in the **Available groups** list to display a list of the users who are currently assigned to this group.

## What would you like to do now?

* [Add users][2]
* [Move users][3]
* [Delete users][1]
* [Import users][4]
* [Read about user types][5]
* [Manage anonymous and system users (onsite)][11]
* [Add and remove companies in the Our companies tab][8]
* [Filter and group users][6]

<!-- Referenced links -->
[1]: ../delete-user.md
[2]: ../add-associate.md
[3]: ../move-user.md
[4]: ../import-users.md
[5]: ../index.md
[6]: ../associates-filter-group.md
[7]: ../role/index.md
[8]: ../our-companies.md
[11]: ../other-users.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/admin-users-overview.png
