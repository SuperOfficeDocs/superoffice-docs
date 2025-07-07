---
uid: pb-usercontrols-tutorial-mypage
title: How to add a new panel
description: How to add a panel and link it from the navigator
author: Tony Yates
date: 06.24.2016
content_type: tutorial
category: customization
topic: PageBuilder
platform: web
deployment: onsite
---

# How to add a new panel

In this tutorial, we are going to add a new button to the navigator which triggers a new panel.

## Add a new navigator button

The SoButton control is a standard ASP.NET button control inherited from `System.Web.UI.WebControls.Button`. It exposes all properties that a button control has. The only property that is set is the CSS class property: The SoButton will have the look defined in the INPUT.sobutton CSS definition.

The following tutorial shows how we can add a button to the Navigator panel by making modifications to the *SONavigatorPanel.config* file.

### Config

```xml
<panel id="Navigator" type="SoPanel" soprotocol="" paneltype="Navigator" top="20px" left="0px" height="800px" overflow="auto" width="160px" position="absolute" zindex="99">
  <cards>
    <card id="NavigatorCard" type="SoCard" placeholderid="" cardtype="NavigatorCard">
      <views>
        <view id="NavigatorView" type="SoPlainView" overflow="auto" soprotocol="Navigator" >
          <controlgroups>
            <!--Some other Control groups-->
            <controlgroup id="ButtonGroup" type="SoControlGroup" position="relative" left="16px" top="10px">
              <controls>
                <!--Some other buttons-->
                <!--Our Button code begins here-->
                <control id="myPageButton" type="SoToolButton">
                  <caption>My Page</caption>
                  <config>
                    <onclick>javascript:PageUpdate('soprotocol:test','');</onclick>
                    <ontextclick>javascript:dummy();</ontextclick>
                    <passiveimage>images/Myimages/myButton1.jpg</passiveimage>
                    <disabledimage>images/Myimages/myButton2.jpg</disabledimage>
                    <selectedimage>images/Myimages/myButton3.jpg</selectedimage>
                    <hoverimage>images/Myimages/myButton4.jpg</hoverimage>
                    <width>70</width>
                    <textalign>right</textalign>
                  </config>
                  <function-rights>
                    <function-right type="hide">hide-company</function-right>
                  </function-rights>
                </control>
                <!--Our Button code Ends here-->
              </controls>
            </controlgroup>
            <!--Some other Control groups-->
          </controlgroups>
        </view>
        <!--Some other Views groups-->
      </views>
    </card>
  </cards>
</panel>
```

### Walk-through

What we have done is added a code segment to the *SoNavigatorPanel.config* file so that a new button would be visible in the navigator panel. The most important element is `onclick`, which provides the navigation for the button. It defines the JavaScript to be used to call the `page_id`. Here, the JavaScript used is the `PageUpdate` and the `page_id` is *test*. Test is the SoProtocol of the panel created by us.

> [!NOTE]
> IIS should be restarted to make all changes take effect before refreshing SuperOffice.

Alternatively, you can enable the `CacheConfigurations` parameter in the [ClientConfigurationProvider section][1] of the *web.config* file to force the PageBuilder to load the config files from disk every time. Turning on this option will cause SuperOffice to run more slowly.

The new button should now be visible in the Navigator panel on the left side of the screen. By clicking the button, we would be able to our **Test** page (Custom Page).

![04][img1]

## Add page

This is the code for our new page.

```xml
<page id="TestPage">
  <data>
    <!--This section contains the data handlers to be used by the page -->
    <datahandlers>
      <datahandler id="NavigatorDataHandler" type="NavigatorDataHandler"></datahandler>
      <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler"></datahandler>
      <datahandler id="PersonEntityDataHandler" type="PersonEntityDataHandler"></datahandler>
      <datahandler id="ProjectEntityDataHandler" type="ProjectEntityDataHandler"></datahandler>
      <datahandler id="DiaryDataHandler" type="DiaryDataHandler"></datahandler>
      <datahandler id="MyDataHandler" type="MyDataHandler"></datahandler>
      <datahandler id="MiniCardDataHandler" type="MiniCardDataHandler">
        <config>
          <archivecolumninfos>
            <archivecolumninfo guiname="SelectionMemberMiniCardArchive" providername="contactselection"/>
            <archivecolumninfo guiname="ProjectMemberMiniCardArchive" providername="projectmember"/>
          </archivecolumninfos>
        </config>
      </datahandler>
      <datahandler id="ArchiveColumnConfigDataHandler" type="ArchiveColumnConfigDataHandler">
        <config>
          <archivecolumninfos>
            <archivecolumninfo guiname="ContactPersonArchive" providername="person"/>
            <archivecolumninfo guiname="ContactRelationArchive" providername="relation"/>
            <archivecolumninfo guiname="ContactActivityArchive" providername="contactactivity"/>
            <archivecolumninfo guiname="ContactProjectsArchive" providername="contactprojects"/>
          </archivecolumninfos>
        </config>
      </datahandler>
    </datahandlers>
  </data>
  <!--Identifies the Panels used by the Page-->
  <panels>
    <panel reference="Menu" />
    <panel reference="ButtonBar" />
    <panel reference="Navigator" />
    <panel reference="Test" />
  </panels>
</page>
```

The ID in the app settings determines the file name. The `panel reference="Test"` implies the existence of a *SoTestPanel.config* file containing the definition of the panel. And a reference to this page should be placed in the *SoApplicationConfiguration.config* file.

```XML
<?xml version="1.0" encoding="utf-8" ?>
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode" prefkey="MainPanel">
    <!--Some other Page references-->
    <!--Reference to our page-->
    <!--The id determines the file name. The page would be called SoTestPage.config-->
    <page id="test" type="mainpage" function-right="hide-company"/>
    <!--Some other Page references-->
  </pages>
  <currents>
    <!--Some current tab references-->
  </currents>
</applicationsettings>
```

The `page` element for our page should be added between the `pages` tag of the file.

> [!NOTE]
> All ID attributes should be in lower case since these will be matched with the SoProtocol query string pages. The query pages map the panels with the SuperMode in the database.

## Putting it together

In this tutorial, we have created a panel including cards, views, and control which is used by the page that has been created earlier.

The following code segment is associated with the panel that we have created.

[!code-xml[XML](includes/test-panel.xml)]

When saving the code it should be saved under the file name *SoTestPanel.config*.

The overall goal of our panel is to display Contact details in the Contact view and then to display data related to that Contact's selected project in the Project view. The Calendar and the NotePad views are not binding on any information on the Contact Card or the Archive Card. The archive Card contains a list of projects relating to the Contact details displayed in the Contact Card.

The different parts of the interface:

![05][img2]

The overall view of our page, which is linked to our button **My Page**:

![06][img3]

It consists of 4 panels and multiple cards and views.

<!-- **See Also:** System.Web.UI.WebControls.Button -->

<!-- Referenced links -->
[1]: ../../../../api/config/clientconfigurationprovider.md

<!-- Referenced images -->
[img1]: media/image004.jpg
[img2]: media/image005.jpg
[img3]: media/image006.jpg
