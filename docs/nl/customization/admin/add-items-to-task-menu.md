---
uid: help-nl-task-menu-add
title: Items toevoegen aan de lijst Taakmenu
description: Items toevoegen aan de lijst Taakmenu
keywords: Taakmenu
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /nl/admin/lists/learn/add-items-to-task-menu
language: nl
---

# Items toevoegen aan de lijst Taakmenu

## Stappen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de Navigator.

1. Selecteer **Taakmenu** uit het vervolgkeuzemenu.

1. Klik op de knop **Toevoegen** onder de lijst Items.

1. Typ de naam voor het item in het veld **Naam**. *(Verplicht)*

1. Selecteer het taakmenu waaraan u het item wilt koppelen.

1. Selecteer het gewenste taakmenutype:

    * URL: Voer het **URL-adres** in het URL-veld in en kies het gewenste type [URL-codering][4].
    * [CRMScript][5]: Selecteer welk **script** u in het taakmenu wilt uitvoeren.
    * [SOProtocol][6]: Voer de **SOProtocol**-URL in waarnaar u het lijstitem wilt navigeren.

1. Vink de selectievakjes aan voor de plaats waar u het menu-item Taak wilt weergeven.

1. Typ zo nodig een beschrijving voor de koptekst in het veld **Beschrijving**. Lees meer over [Vertaling][7].

1. Klik op **Opslaan** om de wijzigingen op te slaan of op **Annuleren** om ze te negeren.

## Sjabloonvariabelen gebruiken

Als u een URL-adres toevoegt, kan het handig zijn meerdere sjabloonvariabelen te gebruiken voor het actieve bedrijf, bijvoorbeeld om informatie van andere toepassingen via een URL op te halen.  Het URL-adres moet bepaalde parameters bevatten, zoals in dit fictieve voorbeeld: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn is hier de sjabloonvariabele voor het organisatienummer, maar andere variabelen zoals bedrijfsnaam &lt;name&gt;, bedrijfstelefoonnummer &lt;cpho&gt;, persoonsnaam &lt;attn&gt;, kunnen ook gebruikt worden.

## Is SuperOffice CRM for Web geïnstalleerd op een HTTPS-site? (Lokaal)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Gerelateerde inhoud

* [Een webpaneelitem toevoegen][1]
* [Een vertaling toevoegen][7]
* [Gespecialiseerde lijsten][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[3]: ../../admin/lists/specialized-lists.md
[4]: ../web-panels/admin/url-encoding.md
[5]: ../../automation/crmscript/learn/index.md
[6]: ../../../en/customization/soprotocol/index.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
