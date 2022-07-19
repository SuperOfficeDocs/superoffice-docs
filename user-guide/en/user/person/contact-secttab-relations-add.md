---
uid: help-en-contact-secttab-relations-add
title: contact secttab relations add
description: contact secttab relations add
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Add relations (Contact screen)

To add a relation:

1. [!include[Go to Contact screen](../includes/goto-contact.md)]

2. Select the **Relations** section tab.

3. Click the **Add** button below the section tab. The **Relation** dialog opens.

    > [!NOTE]
    > A relation must always consist of two parties, one active and one passive, for example: Contact A owns Company B, while Company B is owned by Contact A.

4. Select companies and contacts under **Active part** and **Passive part** as required. Specify them either by clicking the arrow and selecting the required company or contact in the displayed list box, by typing in the whole or the beginning of the name. (See [FastSearcher][1] and [The History list][2]).

5. In the **Relation** list box, specify what relationship there is between the active and passive parties, "owns" for example. The available alternatives are defined in SuperOffice Settings and maintenance.

    > [!NOTE]
    > The alternatives displayed in this list box also depend on whether it is a relation between a company and a contact or between two contacts.

6. Enter any additional information as free text in the **Description** field. If you type in anything here, a paperclip symbol ( ![icon][img1] ) is displayed on the relevant line in the **Relations** section tab.

7. The **Result** field is automatically updated according to the information in the **Relation** field. Example: If you selected "owns" as a relationship, the result will show who owns whom, and who is owned by whom.

8. When you have finished entering information, click the **Save** button to close the dialog and save the information you entered.

## Delete relations

You can delete relations which have been set up, as follows:

1. [!include[Go to Contact screen](../includes/goto-contact.md)]
2. Right-click the required relation on the **Relations** section tab and select **Delete**. The **Delete Relation** dialog opens.
3. Click **Yes** to confirm that you really want to delete the relation. (For more details about this, see [Delete items in SuperOffice CRM][3].)

<!-- Referenced links -->
[1]: ../standardcrm/key-functions/using-fastsearcher.md
[2]: ../standardcrm/key-functions/using-history-list.md
[3]: ../standardcrm/key-functions/deleting-elements-in-crm.md

<!-- Referenced images -->
[img1]: ../../../media/icons/binders.bmp
