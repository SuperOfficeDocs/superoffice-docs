---
uid: help-en-customer-center-config
title: Customer centre configuration
description: Learn how to configure your Customer centre in this how-to guide.
author: SuperOffice RnD
so.date: 02.27.2023
keywords: Service, Customer centre, CEP
so.topic: howto
language: en
---

# Customer centre configuration

[!include[Requirement](../../../learn/includes/req-cep.md)]

You can edit the styling and layout of your customer centre and preview the changes.

![Set up the chat widget on your Customer centre so that customers can chat with you while they visit your website -screenshot][img2]

If your customer centre is multi-lingual, you can set options (such as welcome text, opening hours, and phone numbers) individually for each language.

> [!NOTE]
> To edit the HTML code for the various pages, [update the source files][1].

## Steps

You can configure your Customer Centre either in Settings and maintenance or in SuperOffice Service.

1. Select ![icon][img1] **Settings and maintenance** > **Customer centre** > **Configure**. On the **Customer centre** screen you’ll see two tabs, one for **Styling** and one for **Options**. At the top of this page, you’ll find a link to the Customer Centre page where you can preview your Customer Centre.

2. In the **Styling** tab, you can edit various settings for the look and feel of the customer centre: Logo, preferred width, colors and fonts. The preview is updated automatically.

    ![You check the preview on your Customer centre to see what it will look like -screenshot][img3]

3. Go to the **Options** tab.

4. Select the language version you want to edit.

5. Edit the options. See details about each option below.

6. Click **Save**.

7. Repeat steps 4-6 to set the options for another language.

8. Click **Save** when you are done.

## Options

| Option | Description |
|---|---|
| Logo URL | The link to the logo image. |
| Site name | The title of the web page. |
| Welcome, header | Title text displayed in the header field. |
| Welcome, body text | Body text displayed in the header field. |
| Show opening hours | Select this option to display opening hours beside the header field. Enter the opening hours in the field below. |
| Show phone number | Select this option to display your phone number beside of the header field. Enter the phone number in the field below. |
| Enable search in welcome page | Select this option to display the FAQ search field in the header field. Enter placeholder text in the field below. Example: "enter text here to search the FAQ". |
| Enable information on welcome page | Select this option to display a text field below the header field. Click **Edit** to enter text. |
| Show most common FAQs on the welcome page | Select this option to display the most popular questions and latest questions. |
| Enable footer | Select this option to display a footer at the bottom of the page. Click **Edit** to enter text. |
| Enable chat | Select this option to activate the chat window in the lower right corner of the page. Select **Always** if you want the chat window available for anyone accessing the customer centre. Otherwise select **Logged in customers** to require users to log in to access the chat window. |
| Chat channel | Select the chat channel you want to use. If no chat channel is selected, the chat window will not be available. |
| Use custom ”Contact us” form | Select this option to use a custom form instead of the default form. Select a form in the list.|

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/settings-small.png
[img2]: media/customer-centre-chat-with-agents.jpg
[img3]: media/config-cust-centre.png
