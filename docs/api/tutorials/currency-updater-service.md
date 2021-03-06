---
title: currency_updater_service
description: Currency updater service
author: {github-id}
so.date: 
keywords: 
so.topic: tutorial 
---

# Currency updater service

**Purpose:** To automatically update the currency exchange rates in the `currency` table in SuperOffice.

## Implementation details

A Windows Service can call a web service to automatically update the currency rates once a day.

For that, a free web service from [http://www.webservicex.net/CurrencyConvertor.asmx][1] to get the currency rates. This service has a base method called `ConversionRate` with 2 parameters.

For example, we can use 2 currencies as parameters first one is the From currency(Base currency) next one is the To Currency

`ConversionRate("USD", "NOK")` gives value as 5.5352. This means it takes 5.5352 Norwegian Kroner to make one US Dollar.

Once the service starts to run, the `OnStart` method is invoked and starts the timer for a 24-hour time-interval. After 24 hours, timer `ElapsedEventHandler` is fired and then it runs the `OnElapsedTime` method. This method includes all the basic concepts to update the currency rates.

The service continues to run until the `OnStop` event is triggered by the service manager.

### Code

Basic Code used in the application is given below.

[!code-csharp[CS](includes/currency-converter.cs)]

Code segment from the App config file

### appSettings

```XML
<appSettings>
  <add key="UserName" value="SAL0" />
  <add key="Password" value="" />
</appSettings>
```

### Walk-through

In the app config file of the service, you must give the username and password in the `appSettings` element as shown above.

Within the `OnElapsedTime` method, it gets the `Username` and `Password` from the app config file to authenticate the user.

Using the `CurrencyConversionHelper` class, you can obtain the `BaseCurrencyId` and retrieve the `BaseCurrencyName`.

Currency Table data are filled into the `CurrencyRows` while reading the **SoDataReader**. For each Currency type in the CurrencyRows, update the Currency rate from the web service.

## Windows service installation process

To install the build Windows service:

1. Open a command line window by going to Start -&gt; Programs -&gt; Microsoft Visual Studio.Net -&gt; Visual Studio.Net Tools -&gt; Visual Studio.Net Command Prompt
2. Change to the directory where the executable is located.
3. Enter the following command: `Installutil CurrencyUpdataterService.exe`

    ![01][img1]

Now the service is installed. To start and stop the service, go to Control Panel -&gt; Administrative Tools -&gt; Services.  Right click the service and select Start.

To uninstall the Windows service:

`Installutil /u CurrencyUpdataterService.exe`

### Unsupported currency codes

For some of the above currency codes, web service does not support,  mainly due to the Euro replacing the currency in question. Those are (26)

* ADF- Franc (Andorra)
* ARP- Peso (Argentina)
* ATS- Schilling (Austria)
* BAK- Mark (Bosnia & Herzegovina)
* BEF- Franc (Belgium)
* BGL- Lev (Bulgaria)
* BRR- Real (Brazil)
* BYR- Ruble (Belarus)
* DEM- Mark (Germany)
* ERN- Nakfa (Eritrea)
* ESP- Peseta (Spain)
* FIM- Markka (Finland)
* FRF- Franc (France)
* GEL- Lari (Georgia)
* GRD- Drachma (Greece)
* IEP- Punt (Ireland)
* IRR- Rial (Iran)
* ITL- Lira (Italy)
* LUF- Franc (Luxembourg)
* MXP- Peso (Mexico)
* NLG- Dutch Guilder (Netherlands)
* PLE- Escudo (Portugal)
* PLZ- Zloty (Poland)
* RWF- Rwanda Franc (Rwanda)
* XDR- IMF Special Drawing Right
* YUN- Yugoslavia New Dinars (Montenegro)

<!-- [Source code (zip)](CurrencyUpdaterService.zip) -->

<!-- Referenced links -->
[1]: http://www.webservicex.net/CurrencyConvertor.asmx

<!-- Referenced images -->
[img1]: media/image001.jpg
