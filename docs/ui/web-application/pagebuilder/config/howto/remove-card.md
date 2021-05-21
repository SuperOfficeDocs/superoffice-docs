---
title: How to remove an existing card
uid: pb_remove_card
description: How to remove an existing card from a page
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to remove an existing card from a page

The PageBuilder XML configuration makes it easy to add and remove parts of the SuperOffice GUI. Here, we will focus on removal.

## Remove entire card

To remove an existing card, all you have to do is **delete the card config from the config file**. As an exercise, we will remove the config of the Main card from the **Project** page.

**Before:**

![11][img1]

If we were to remove the code section for the Project’s main section, the card would disappear from the screen. In the code below (*SoProjectPanel.config*), the `ProjectMainCard` card has been commented out.

```XML
<?xml version="1.0" encoding="utf-8" ?>
  <panel id="Project" type="SplitterPanel" soprotocol="project" paneltype="Main" placeholderid="MainPlaceHolder" width="100%" height="100%">
    <caption>[SR_COMMON_PROJECT]: [current:project_name]</caption>
    <cards>
      <!--The project Main card section which has been commented-->
      <!--<card id="ProjectMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard" width="100%" height="100%"> -->
      <views>
        <!--Some other code-->
      <card id="ProjectMiniCard" reference="MiniCard"></card>

      <card id="ProjectArchives" placeholderid="bottom" type="SoTabbedCard" cardtype="ArchiveCard">
    </cards>
  <config></config>
</panel>
```

**After:**

![12][img2]

Since a main card is required for a page, we must assign a new main card. Here, we have assigned the Archive card (ProjectArchives) as the main, thus changing `cardtype="ArchiveCard"` to `cardtype="MainCard"`:

```XML
<card id="ProjectArchives" placeholderid="bottom" type="SoTabbedCard" cardtype="MainCard">
```

## Remove a view from card

If we wish to remove a view from a card, we must remove the view element from the relevant card. In the below example, we have removed the event view of the Project Main card.

```XML
<?xml version="1.0" encoding="utf-8" ?>
<panel id="Project" type="SplitterPanel" soprotocol="project" paneltype="Main" placeholderid="MainPlaceHolder" width="100%" height="100%">
  <caption>[SR_COMMON_PROJECT]: [current:project_name]</caption>
  <cards>
    <card id="ProjectMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard" width="100%" height="100%">
      <views>
        <view id="ProjectMainView" type="SoView" soprotocol="main" current="project"></view>
        <view id="ProjectMoreView" type="SoView" soprotocol="udef" current="project"></view>
        <view id="ProjectImageView" type="SoView" soprotocol="image" current="project"></view>
        <!--Project Event view, This view has been removed from the Project card-->
        <!--<view id="ProjectEventView" type="SoView" soprotocol="event" current="project"></view>-->
        <view id="ProjectSystemView" type="SoView" rendermode="always"></view>
        <view id="WWW" type="SoView" soprotocol="www" current="project"></view>
      </views>
      <!--Some other codes-->
    </card>
    <card id="ProjectMiniCard" reference="MiniCard"></card>
    <card id="ProjectArchives" placeholderid="bottom" type="SoTabbedCard" cardtype="ArchiveCard"></card>
  </cards>
  <config></config>
</panel>
```

**After - project page without the Event view:**

![13][img3]

After we have removed the card the functionality of the rest of the page will work without an error.

## Limitation

There is one limitation since we are only removing the card and not replacing the card with another card, when we navigate from another page and back to the project page the first pages card will remain in the empty space of the project page. For example, we navigate to the Company page from the Project page and now if we navigate back to the project page the main card of the Company page will remain in the Project page as well since that space in the project page is empty. Though the card remains, the functionality of the card will not be functional since that card does not have any reference in the config of the Project page. The below screenshot depicts this scenario.

![14][img4]

As we can see above, the company exists on the project page. Except for the company card, all the other cards that appear on the page belong to the project page. This is a scenario we have to avoid in a real-life situation if we are removing a card we must a have card that will replace it.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image011.jpg
[img2]: media/image012.jpg
[img3]: media/image013.jpg
[img4]: media/image014.jpg
