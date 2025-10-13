---
uid: help-nl-task-menu-add
title: Items toevoegen aan de lijst Taakmenu
description: Items toevoegen aan de lijst Taakmenu
keywords: lijst Taakmenu
author: SuperOffice RnD
date: 03.14.2025
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Items toevoegen aan de lijst Taakmenu

Wanneer u een item toevoegt aan de lijst **Taakmenu** in Instellingen en onderhoud, ziet het dialoogvenster Item in lijst bewerken er anders uit dan is beschreven in [Items toevoegen][2].

Zo vult u de velden in het dialoogvenster Items in lijst bewerken voor het menu Taak in:

1. Klik op de knop Toevoegen onder de lijst Items.
    > Wilt u een item toevoegen aan een gespecialiseerde lijst?
    Sommige typen lijsten zijn gespecialiseerder dan de typen waarnaar wordt verwezen in deze procedure. [Gespecialiseerde lijsten][3]

1. Typ de naam voor het item in het veld **Naam**.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Selecteer het taakmenu waaraan u het item wilt koppelen.

1. Selecteer het gewenste taakmenutype URL, CRMScript of SOProtocol.
    * URL
        * Voer het **URL-adres** in het URL-veld in.
        * Kies het gewenste type **codering** .
        Meer weten over [URL-codering][4]?
    * CRMScript
        * Selecteer welk **script** u in het taakmenu wilt uitvoeren.
        Meer weten over [CRMScript][5]?
    * SOProtocol
        * Voer de **SOProtocol**-URL in waarnaar u het lijstitem wilt navigeren.
        Meer weten over [SOProtocol][6]?

1. Vink de selectievakjes aan voor de plaats waar u het menu-item Taak wilt weergeven.

1. Typ zo nodig een beschrijving voor de koptekst in het veld **Beschrijving**. Lees meer over [Vertaling][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Als u een URL-adres toevoegt, kan het handig zijn meerdere sjabloonvariabelen te gebruiken voor het actieve bedrijf, bijvoorbeeld om informatie van andere toepassingen via een URL op te halen.  Het URL-adres moet bepaalde parameters bevatten, zoals in dit fictieve voorbeeld: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn is hier de sjabloonvariabele voor het organisatienummer, maar andere variabelen zoals bedrijfsnaam &lt;name&gt;, bedrijfstelefoonnummer &lt;cpho&gt;, persoonsnaam &lt;attn&gt;, kunnen ook gebruikt worden.

## Is SuperOffice CRM for Web geïnstalleerd op een HTTPS-site? (Lokaal)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Gerelateerde inhoud

* [Een webpaneelitem toevoegen][1]
* [Een vertaling toevoegen][7]

<!-- Referenced links -->
[1]: ../../../customization/web-panels/admin/add-web-panel.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../../en/ui/web-panels/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/customization/soprotocol/index.md
[7]: ../../../localization/learn/translate-fields.md

<!-- Referenced images -->
