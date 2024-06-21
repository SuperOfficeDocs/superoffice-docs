---
title: Feature toggles
uid: feature_toggles
description: Feature toggles
author: Bergfrid Dias
date: 12.10.2021
keywords: feature toggle, FeatureToggles, feature_toggle, web.config, SuperOffice.config
topic: howto
envir: onsite
client: web
---

# Feature toggles

Some features are enabled by **feature toggles**.

To enable toggled features - you need to add two sections manually in your NetServer configuration file.

* Web Application: [*web.config*][2]
* For SuperOffice versions less than 10 that support the feature Windows Application: [*SuperOffice.config*][4] and [*SOUSER.INI*][3]

> [!NOTE]
> If you have used feature toggles before and want to enable a new feature, simply add a new key to your existing configuration.

1. Open the *web.config* file for your web installation.

2. Define a new section group named **FeatureToggles** inside the `SuperOffice` group.

    Locate the parent element:

    ```xml
    <configuration>
      <configSections>
        <sectionGroup name="SuperOffice">
      ```

    Add this (if it's not already defined):

    ```xml
    <sectionGroup name="FeatureToggles">
      <section name="State" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </sectionGroup>
    ```

3. Add (or update) the [FeatureToggles section][1]:

    Locate the SuperOffice element:

    ```xml
    </configSections>
    <SuperOffice>
    ```

    Add this:

    ```xml
    <FeatureToggles>
      <State>
        <add key="NewDashboards" value="true" />
        <add key="ConfigurableScreens" value="true" />
      </State>
    </FeatureToggles>
    ```

    Replace the key with the features you want to toggle (see list below).

4. Save the file. The application pool will be recycled to get the new settings. Now you can use the new features in the Web client.

## Previous feature toggles

| Feature                 | Toggle name |  Released in version | Available from version |
|---|---|---|---|
| New Follow-up            | NewFollowUpDialog              |  10.?.?  | 10.2.11 |
| Request types (*3)       | NSTicketType                   |  10.3.2  | 10.2.10 |
| New Service (*1)         | NewServiceRequest              |  10.2.5  | 10.2.1  |
| New Notifications        | NewNotifications               |  10.2.5  | 10.2.5  |
| New TimeZone             | NewTimezoneHandling            |  10.2.5  | 10.2.1  |
| Configurable Screens Sale (*2)| ConfigurableSale               |  10.2.5  | 10.2.1  |
| Configurable Screens Proj (*2)| ConfigurableProject            |  10.2.5  | 10.2.1  |
| Configurable Archives    | SCILHostedArchives,ConfigurableArchive | 10.1.3  | 10.1.6 |
| New Search               | NewSearch                      |  10.2.5  | 10.1.8 |
| Configurable Screens P&C | ConfigurableScreens            |  10.0.2  | 9.2 R12 |
| Dashboards 2.0           | NewDashboards                  |  10.0.2  | 9.2 R12 |
| OAuth 2.0 Service        | NewAuth                        |  10.0.6  | 9.2 R12 |
| OAuth 2.0 Authentication | NewAuthentication              |  10.0.6  | 9.2 R10 |
| New Selection            | NewSelection                   |  9.x     |  |
| New Export To Excel      | NewExportToExcel               |  9.x     |  |
| Bulk Update              | BulkUpdate                     |  9.x     |  |
| Consent Management       | ConsentManagement              |  9.x     |  |
| New Invitation           | NewInvitation                  |  9.x     |  |
| Email Template           | EmailTemplate                  |  9.x     |  |
| User Management          | UserManagement                 |  9.x     |  |

 Available from version = Version that support the FeatureToggle.

 Released in version = Version that have the feaure automatic on, and does not support the FeatureToggle

 *1 = The NewServiceRequest feature toggle is dependent on the NewTimezoneHandling feature toggle

 *2 = The ConfigurableSale and ConfigurableProject feature toggle is dependent on the SCILHostedArchives feature toggle
 
 *3 = The NSTicketType feature toggle is dependent on the NewServiceRequest feature toggle, and requries Service Premium and Developer tools

## Look up enabled features

You can use the value from the `feature_toggle` field of the `config` table to determine if a feature is enabled. It contains a delimited string of all the enabled feature toggles.

* Use comma ',' as the delimiter between the feature toggles
* Use colon ':' as the delimiter between the feature toggle name, and if it's enabled or not

**Example CRMScript:**

```crmscript
#setLanguageLevel 3;

SearchEngine seConfig;
seConfig.addField("config.feature_toggle");
seConfig.execute();

String featureTogglesString = seConfig.getField("config.feature_toggle");

String[] featureToggles = featureTogglesString.split(",");

for (Integer i = 0; i < featureToggles.length(); i++)
{
  String[] featureToggleValues = featureToggles[i].split(":");
  String featureToggleName = featureToggleValues[0];
  String featureToggleEnabled = featureToggleValues[1];
  printLine(featureToggleName + " = " + featureToggleEnabled);
}
```

**Result:**

![CRMScript get feature toggles result -screenshot][img2]

> [!TIP]
> You can retrieve the `feature_toggle` field value using the dynamic archive provider when using the SuperOffice web services.

<!-- Referenced links -->
[1]: ../api/config/featuretoggles.md
[2]: ../api/config/index.md
[3]: install/win-client/souser-ini.md
[4]: install/win-client/superoffice-config.md
<!-- Referenced images -->
[img2]: media/feature-toggle-result.png
