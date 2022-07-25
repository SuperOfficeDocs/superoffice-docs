---
title: Versioning
uid: dp-versioning
description: Introduction to versioned information and configuration in the SuperOffice Online Developer Portal and how it relates to our different environments (SOD, Stage, Production).
author: Bergfrid Dias
so.date: 06.09.2022
keywords: developer, Developer Portal, apps, app-store
so.topic: concept
so.version:
so.envir: cloud
so.client:
---

# Versioning

All applications start in SuperOffice Online Development (SOD) and might eventually go live (via our stage environment). [!include[What needs approval for Stage and Production?](includes/what-to-publish.md)]

To keep track of what currently is (or is desired to be) active in each environment we use **versions**.

## What is a version?

A version is a **labelled snapshot** of the app configuration or the App Store information.

![Versions published, pending, rejected -screenshot][img1]

The initial version is automatically published to SOD. You can then:

* Update the initial version
* Create a new version
* Publish the new version to SOD yourself
* Request to publish a version to stage

In SOD, a version is a **draft** and can be edited until you request to publish it to stage. Then it is locked. If we reject it, the version is unlocked and you can update it to fix any issues.

### States

| State | Color | Description |
|---|---|---|
| Draft | | A new version that can be edited.|
| Published | green | The version is currently active for the environment. |
| Request pending | yellow | Someone has requested to publish this version to an environment. |
| Rejected | red | The version was not approved for the requested environment. |

## Where are my versions?

The **Overview** section of the app page and partner page shows the current state of the app configuration and the App Store information per environment. From this overview, you can click any version to open it.

To see all versions of a section, select that section and click **More versions**

![Versions published, pending, rejected -screenshot][img2]

## Edit version

All changes happen in SOD!

* Pending versions can't be changed.
* Rejected versions can be edited and saved in SOD.
* Versions published to stage and/or production can't be changed.

To make changes:

1. Locate the version you want to update either from the **Overview**, **App Store information**, or **Configuration** section.
2. If it is locked, [create a new version](#create-new-version).
3. Change the configuration or information you want and click **Save Settings**.

> [!NOTE]
> Some settings can be configured per environment. A single configuration will then hold multiple values of that setting. For example, if you have environment-specific certificates you handle this within one configuration and request it published to Stage and Production. Don't confuse settings per environment with versions per environment.

## Change label of version

You can change the label of a version to make it more descriptive.

1. Locate the version you want to update either from the **Overview**, **App Store information**, or **Configuration** section.
2. Select the **Versions** section.

    ![Versioning page -screenshot][img3]

3. Enter a new label and click **Save Settings**.

## Create new version

1. Locate the version you want to update either from the **Overview**, **App Store information**, or **Configuration** section.
2. Click **More versions**.
3. Click **Add New Configuration** or **New App Store Change** depending on your context.
4. Enter a label and click the green checkmark.

    The new version appears in the list and you can select it to edit.

## Request to publish

[!include[When to publish](includes/ready-to-publish.md)]

* If your version was **approved** for Stage, you can test it there before requesting to publish to Production.
* If your version was **rejected** for Stage, you need to fix the problems in SOD and then request to publish again.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/app-versions-2.png
[img2]: media/more-versions.png
[img3]: media/versioning-page.png
