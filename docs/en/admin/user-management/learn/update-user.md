---
uid: help-en-user-update
title: Edit users information
description: Edit associate
author: Bergfrid Dias
so.date: 03.15.2023
keywords: user, associate
so.topic: howto
so.user: admin
language: en
---

# Update user information

## Edit associate

1. [!include[Click Users](includes/goto-users.md)]

2. Select the **Associates** tab.

3. [!include[Select user](includes/select-user.md)]

4. Make your changes and click **Save**.

## Batch update

You can also update several users at the same time.

1. Select ![icon][img1] **System settings** > **Users**.
2. Select the **Users** tab.
3. Click the **Filter** list to apply a filter to the list.
4. Check the users you want to update.
5. Click the ![icon][img2] menu button in the lower left corner, and select **Batch update** and **Change**.
6. In the **Batch update users** screen, check the boxes for the properties you want to change, and then select the value you want in the associated field. The available options are listed below.
7. Click **OK**. The selected users are updated with your changes.

### Options

* **Role**: Select a [role][3] you want to assign to the selected users.

    > [!NOTE]
    > The role may override other options further down.

* **Status**: Select the required status for the selected users. You can choose between **Normal** and **Not present**. If a user is not present, they will not receive any requests automatically, for example, when they are on holiday.

* **Group**: Select the user group you want to assign to the selected users.

* **Default status for new request**: Select the default status to appear in the Request screen for the selected users.

* **Default status for new message**: Select the default status to appear in the **Add message** screen for the selected users.

* **Language**: Select which language the SuperOffice Service interface should be in for the selected users. You can choose from Norwegian, English, German, Swedish, Danish and Dutch.

* **Sort messages in descending order**: Checking here causes the messages in a request to be sorted with the most recent at the top.

* **Preview image attachments in messages**: Checking here causes images attached to messages to be previewed in the Request screen.

* **New window when adding a message to a request**: Checking here causes a new browser window to be opened when the selected users add a message.

* **List only requests in own categories**: Check here to display only requests in the categories that the selected users are members of.

* **Automatically quote the last message**: If checked, the last message in the request is automatically pasted into the text field in the new message.

* **Show only own categories**: If checked, you can select only categories you are a member of.

* If extra fields have been added for users, you can also change these.

## Related

* [Edit anonymous or system user (onsite)][1]

<!-- Referenced links -->
[1]: other-users.md
[3]: role/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/settings-small.png
[img2]: ../../../../media/icons/btn-menu.png
