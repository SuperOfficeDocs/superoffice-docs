---
uid: help-en-chat-channel-create
title: Create a chat channel
description: Create a chat channel
keywords: chat channel, chat widget layout, add agent, offline form, pre-chat form, post-chat form, enable transcript
author: Bergfrid Dias
date: 09.25.2025
version: 10.5
content_type: howto
license: cep
category: Service
topic: chat
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from: /en/chat/learn/admin/channel-create
index: true
---

# Create a chat channel

You can create chat channels for specific uses, such as technical support, product inquiries and sales support, and assign the relevant agents to each channel.

![The Chat channels screen in Settings and maintenance with the Edit chat channel dialog open -screenshot][img1]

## Steps

1. Click <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> **Chat** in the Navigator.

2. Click **Add** at the bottom of the list of chat channels.

3. In the dialog, enter the name of the chat channel. This should be a unique name used to identify the topic and language (for example *Tech Support Norway*). The name is used internally only.

4. Complete the fields in the tabs as described below.

    Your changes are automatically saved when you go to another tab.

5. Click **Save** when you are done.

> [!NOTE]
> Fields with red frames are mandatory. Tabs with <i class="ph ph-warning-circle" aria-label="Warning icon"></i> contain empty mandatory fields.

## Properties

| Property | Description |
|---|---|
| Language | Select the language of the chat window. |
| Badge header | Enter a short text to display on the chat icon on your website. |
| Description | Explain the purpose of this chat channel. This text is displayed internally only. |
| Warning on new chat | If no agents respond to a new chat within the specified amount of time, a notification is sent to agents with status **Present**. Agents must also have the permission **Notifications** in the **Agents** tab. |
| Manager warning on new chat | If no agents respond to a new chat within the specified amount of time, a notification is sent to the manager(s). This warning is only sent if there are agents with status **Present**. |
| Enable opening hours | Enable this option to set opening hours for specific week days. You can also set your time zone and add lunch hours when chat is unavailable. Customers will always see their local time in the chat. |

The preview on the right displays the chat window with the current settings.

## Chat widget layout

In the **Chat widget layout** tab you can specify the layout and text in the chat window used by the customers.

| Field | Description |
|---|---|
| Theme | Select a theme for the chat window. |
| Color | Select the base color of the chat windows. This setting will override the color defined in the selected theme. |
| Font | Select the font of the chat windows. This setting will override the font defined in the selected theme. |
| Show logo | Select this option to display an image in the header of the chat window. To add an image, click the link or drag and drop an image file. |
| Show agent photo | Select this option to display the agent's photo in the chat window. After an agent responds to a new chat, the header logo and header text is replaced by the agent's photo and name. |
| Header | Enter a short welcome text to display in the chat window header. |
| Message | Enter a short message to display under the header. |
| Use custom queue message | Select this option to enter a customer message for the queue. |

You can use variables to indicate waiting time and position in queue:

* {cque} = A number indicating the position in the queue
* {cavw} = The average waiting time, in the format hh:mm

The preview on the right displays the chat window with the current settings.

## Agents

In the **Agents** tab you can give users access to a chat channel and what permissions they have in chat.

### Add an agent

1. Click the list to the left of the **Add** button, and select a user.
2. Click **Add**. The user is added to the list of agents and has access to the selected chat channel.
3. Select one or more of the following permissions:
    * **Can respond**: The agent can respond to incoming chats in this channel.
    * **Notifications**: The agent will receive notifications if they are present.
    * **Can listen in**: The agent can open and monitor another agent's ongoing chat conversation.
    * **Manager**: The agent will get manager warnings. This permission can for example be used for team leaders.
4. Repeat steps 1-3 for each agent you want to add.

## <a id="chatbot"></a>ChatBot

In the **ChatBot** tab you can activate the chatbot. When a chat is initiated on a channel where a chatbot is active, the "on-new-chat-message" script is triggered, and the message is passed to the script for processing. The script sends the message for processing, and receives the message, posts the results, and possibly marks the message for hand-off to an agent.

| Option | Description |
|---|---|
| Enable Chatbot | Select this option to activate the chatbot. |
| Chatbot CRMScript folder | Select the folder that contains the scripts for the chatbot. |
| Chatbot name | What do you want to name your chatbot? |

## Offline form

In the **Offline form** tab, you can enter a message to display to the customer if no agents are present (for example outside of your opening hours). In addition, you can let the customer submit a request.

| Field | Description |
|---|---|
| Header | Enter a short text to let the customer know why no agents are available. |
| Message | Enter a message. Examples: "Our opening hours are 08-18" or "Fill in the fields below, and we will get back to you as soon as possible". |
| Enable request submission | Select this option to let the customer submit a request if the chat is not available. |
| Request category | Select the category to be assigned to the requests. |
| Request priority | Select the priority to be assigned to the requests. |
| Mandatory fields required to submit request | Select the information the customer must enter to submit a request. |

The preview on the right displays the chat window with the current settings.

## Pre-chat form

In the **Pre-chat form** tab, you can define how customers should identify themselves (or not) in the chat. In addition, you can enable automated FAQ suggestions from SuperOffice.

| Field | Description |
|---|---|
| Enable pre-chat FAQ suggestions | If you enable FAQ suggestions, the top 3 FAQs that match the customers message are displayed in the chat window prior to the chat. The customer can click the FAQ links to view the complete FAQs in SuperOffice Customer Centre. If none of the suggested FAQs answer their questions, they can choose to start the chat. |
| FAQ folder | Select the folder that contains the FAQs (and sub-folders with FAQs) that should be displayed to the customers. Only FAQs that have been published and are accessible to everyone (no login required), are displayed to customers. |
| Enable pre-chat form for anonymous users | Select this option if the customers must identify themselves before starting the chat. Leave this option unselected to let the customers start the chat directly. |
| Message | Enter a message to the customer. Example: "Let us know who you are and how we can help you". |
| Fields required to initiate chat | Select the information the customer must enter to start the chat. |

The preview on the right displays the chat window with the current settings.

## Post-chat form

When the customer or the agent ends the chat, you can display a post-chat form with additional information and the option to receive a transcript of the chat.

| Field | Description |
|---|---|
| Enable post-chat form | Select this option to show the post-chat form to the customer when the chat is finished. |
| Header | Enter a short header text. |
| Message | Enter a short message to the customer. |
| Enable transcript | Select this option to enable transcript. The customer can enter an email address to send the transcript to. The reply template for the transcript can be found in SuperOffice. |

The preview on the right displays the chat window with the current settings.

## FAQ

### Can I delete a chat channel?

Yes, but make sure that the chat channel is not being used on a website. Otherwise the chat window is visible, but non-functional.

<!-- Referenced images -->
[img1]: ../../../media/loc/en/chat/admin-chat-channels.png
