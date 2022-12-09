---
uid: help-en-mail-link-create-template
title: Creating email templates
description: Creating email templates
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Mail Link
so.topic: howto
language: en
---

# Creating email templates

You can create your own templates to use when creating emails from SuperOffice CRM. Follow these steps:

1. Create a new email using for example Outlook Express. If you use standard document template variables, enclosed them in braces like this: `{name}`.

2. Save the file in *.oft* format, but set the extension to be *.somail*. For example, *mymail.somail*.

3. Move the file to the *\so\_arc\template* folder.

4. Open SuperOffice Settings and maintenance.

5. Open the **Lists** screen.

6. Choose the **Items** tab.

7. [!include[Click arrow and select](../../../includes/expand-list.md)] **Document template** from the **List** dropdown.

8. Click the **Add** button ![icon][img2] below the **Items** list.

9. In the **Edit list item** dialog, enter the required name of the template in the mandatory **Name** field.

10. In the **File name** field, click the arrow ![icon][img1] and select the *.somail* file you just created.

11. In the **Direction** field, click the arrow ![icon][img1] and choose **Outgoing** from the dropdown.

12. In the **Record type** field, click the arrow ![icon][img1] and choose **Email**.

13. In the **Document plugin** field, select the program to be used to display the document by clicking the arrow ![icon][img1] and selecting from the dropdown.

14. In the **Intention** field, click the arrow ![icon][img1] and select one of the predefined options from the dropdown. These items are used in connection with status monitors in SuperOffice CRM (requires a SAINT licence).

15. Check the **Publish** box if you want it to be possible to specify, in the **Document** dialog in SuperOffice CRM, that the document template in question should be made available to external users.

16. Specify the default setting for the **Our reference (default)** field using template variables, for example {auth} for the sender’s first and last names.

17. In the **Save to database** field, choose **No**.

18. In the **Registry Open Key** field, enter *SoMailParser.exe*.

19. Optionally, type in a description of the email template in the **Description** field.

20. Click **OK**. The template is added as a separate item in the **Items** list.

21. Click **Save**.

You may now create new emails from SuperOffice CRM using this template.

<!-- Referenced images -->
[img1]: ../../../../common/icons/dropdown-arrow.png
[img2]: ../../../media/icons/btn-add.png
