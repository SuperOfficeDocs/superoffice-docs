---
uid: help-en-our-companies-manage
title: Manage Our companies
description: How to add and remove companies in the Our companies tab
keywords: our companies
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
platform: web
index: true
redirect_from: 
  - /en/admin/user-management/learn/move-user
  - /en/admin/user-management/learn/our-companies
language: en
---

# Manage "Our companies"

You can manage "Our companies" and move users between them in the Users screen in Settings and maintenance.

## Add company in the Our companies tab

Pre-requisite: To add a company in the **Our companies** tab, it must first be registered as a company in SuperOffice.

1. Select the **Our companies** tab.

1. Click the **Add** button below the company list.

1. The Find screen opens. If there are already search criteria entered, but they are not ones you want to use, click the **Deactivate all** button to remove them or remove the checks from the checkboxes for the relevant criteria.

1. Search for a company. See details below.

1. When you have selected the company you require and clicked **OK**, it is displayed in the list.

## Delete company in the Our companies tab

1. Check that the criteria are met:

    * The company must not have any associates registered. The number of associates is displayed in the **Associates** column in the company list. To delete a company, you must first [delete the registered associates][2].
    * The company cannot be an active satellite. Check if the company is listed in the **Active satellite** column in the company list.

1. Select the **Our companies** tab.

1. Select the required company in the list.

1. Click the **Delete** button below the company list. The company is removed from the list.

> [!NOTE]
> You cannot delete the company if it is registered as a database owner. If you select a database owner, the **Delete** button is disabled.

## <a id="move"></a>Move user from one company to another

You can move a user from one company to another, if your organization consists of multiple companies registered in the **Our companies** tab. If a user was set up under the wrong company, or if they have changed positions/jobs within your organization, they can be moved, including their activities and sales.

1. Go to the **Associates** tab and select the required user from the list.

1. Click **Task** and select **Move user**.

1. In the dialog, select **Move to** and choose the company you want to move the contact to.

1. Select one of the following under **Action on all existing activities and sales**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > To see the results before you confirm the action, click **Show results** <i class="ph ph-info" aria-hidden="true"></i>.

1. Click **Move**. The user is moved to the specified company.

## How do I search for a company?

1. In the list box to the right of the field you want to search on, choose if you want to search for a company that **Starts with**, **Contains**, or **Equals** the search criteria you enter.

2. You can specify several different search criteria, for example name, code, telephone number or email address. If you specify several search criteria, a search is performed for companies that fulfil all the criteria simultaneously.

3. When you have specified the required criteria, click the **Find** button.

4. When the search is finished, these are the possible outcomes:

    * **One hit**: the company that matches the search criteria is displayed in the list.

    * **Two or more hits**: The Find screen shows a list of matches. Here you can select the required company in the list and click **OK** to go to that company.

    * **No hits**: A message is displayed stating that no record matches the search criteria. Click **OK**, and search again using different criteria.

### <a id="criteria"></a>The search criteria

The fields below correspond to the fields on the company card.

* Name: Enter the whole or start of the company name.
* Number: Enter the whole or start of the company name.
* Code: Enter the whole or start of the code.
* VAT No.: Enter the whole or start of the VAT no.
* First Name: Enter the whole or part of the first name of a contact at the company.
* Last Name: Enter the whole or part of the last name of a contact at the company.
* Telephone: Enter the whole or part of a phone number for the company.
* Email: Enter the whole or part of an email address for the company.
* Match also: Here you can specify further [search criteria][1].

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
