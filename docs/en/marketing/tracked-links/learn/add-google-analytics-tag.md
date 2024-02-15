---
uid: help-en-mailing-add-google-analytics
title: How to add your Google Analytics tag to a mailing
description: In this how-to guide, you will learn how to track your visitors.
keywords: Marketing
author: SuperOffice RnD
so.date: 02.14.2024
so.version: 10
so.topic: howto
language: en
so.audience: user
so.audience.tooltip: SuperOffice Marketing
---

# How to add your Google Analytics tag to a mailing

You can track the people visiting your website as a result of them reading your mailings by using the Google Analytics feature in SuperOffice Marketing. The Google Analytics tracking must be set in the [first step of for every mailing][1] you create.

## Requirements

To use the [Google Analytics feature][2], you need a Google Analytics account connected to your website.

[!include[Requirement](includes/req-marketing.md)]

## Steps

1. Start by opening the mailing you want to track with Google Analytics or create a new mailing. Go to the first step of the mailing wizard (Setup). The heading **Tracking** is located in the bottom-right corner. Here you can check the boxes **Track all links** and **Use Google Analytics**. When you check Use Google Analytics, the Google Analytics text fields will appear.

    ![Check off the box for Google Analytics and track all links -screenshot][img1]

2. In the **Google Analytics tracking** fields, "Email" is pre-defined as the medium. This means that tracked mailings sent from SuperOffice CRM are now found in Google Channel reports under **Email** rather than **Other**.

3. To identify a specific mailing as a source, the fields for Source and Campaign also need to be completed.

    * In the **Source** field you can add the source of your website traffic. Here you can choose to use the different E-marketing subscriptions, like, for example, Monthly newsletter, Promotion mailing, etc.

    * In the **Campaign** field you can enter the name of the campaign you are running. This will make it easier to track and report the results of the mailing you have sent out. Here you can enter campaign names, like, for example, Christmas sales campaign or Autumn sales campaign, and so on.

4. After you have set up all the details you want to use to track your mailing in Google Analytics, you can follow the steps of the mailing wizard. Click **Next** to choose your template, add content, add recipients and send your mailing.

All the links you add in the third step (Content) will automatically be tracked because you have turned on the Google Analytics feature. As soon as your recipients click on the links to your website, you can track their visits to your website in Google Analytics.

## How to check your mailing's results in Google Analytics

You can check the results of your mailings by logging in to your Google Analytics account. Your mailings should be visible in the Google Channel reports under Email.

> [!NOTE]
> Please allow Google Analytics some time to process your tracking information. Your mailing source may take somewhere between 1-24 hours to register in your reports.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/tutorial-email-mailing.yml
[2]: index.md#google

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/google-analytics-tag.png
