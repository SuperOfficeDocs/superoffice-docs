---
uid: help-nl-add-web-panel
title: Webpaneel toevoegen
description: Hoe items toe te voegen aan de webpaneellijst in Instellingen en onderhoud.
keywords: webpaneel, lijst GUI - Webpaneel
author: digitaldiina
date: 10.13.2025
version: 11.5
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: nl
index: true
redirect_from: /nl/admin/lists/learn/web-panel-add-item
---

# Webpaneel toevoegen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Webpanelen worden gedefinieerd in de lijst **GUI - Webpaneel**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**.

## Stappen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de Navigator.

1. Selecteer **GUI - Webpaneel** uit het vervolgkeuzemenu. Het tabblad **Items** toont alle bestaande webpanelen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Typ de gewenste naam voor het item in het veld **Naam**. *(Verplicht)*

    * Deze naam wordt weergegeven wanneer u het URL-adres toevoegt in SuperOffice CRM.

1. Geef in het veld **URL** het URL-adres op, zoals een webpagina of een op een server gebaseerd HTML-bestand. Bekijk alstublieft de informatie hierboven voor het gebruik van HTTP/HTTPS URL's.

1. Voer in het veld **Vensternaam** de gewenste naam in voor het browservenster waarin het URL-adres moet worden geopend. Als u eerder een of meer vensternamen hebt toegevoegd en ze opnieuw wilt gebruiken, kunt u in het veld klikken en een naam uit de lijst selecteren. U kunt een naam ook rechtstreeks in het veld typen. De vensternaam zoals deze uiteindelijk wordt weergegeven wordt hieronder onderstreept weergegeven.

1. Kies in de keuzelijst **Zichtbaar in** of het URL-adres toegankelijk moet zijn in SuperOffice CRM.
    * **Zijpaneel**: selecteer deze optie om het URL-adres beschikbaar te maken op de zijpanelen in SuperOffice CRM.

    * **Werkbalk**: selecteer deze optie om de URL toegankelijk te maken als een knop op de werkbalk.

    * **Navigator-knop**: selecteer deze optie om de URL toegankelijk te maken als een knop in de navigator in SuperOffice CRM.

    * **Venster**: selecteer [een optie in deze keuzelijst](#options) om het URL-adres toegankelijk te maken als een venster/tabblad in SuperOffice CRM.

    * **Dialoogvenster**: selecteer [optie in deze lijst](#options) om het URL-adres beschikbaar te maken in een dialoogvenster.

    * **Menu**: selecteer [optie in deze lijst](#options) om het URL-adres toegankelijk te maken op een van de menu's in SuperOffice CRM.

1. In de keuzelijst **URL-codering** kunt u selecteren of de [URL][2] moet worden weergegeven in ANSI of Unicode (of geen indeling).

1. Selecteer bij **Weergeven** welke balken beschikbaar moeten zijn in de browser waarin de URL wordt geopend: menubalk, werkbalk, adresbalk of statusbalk.

1. Geef onder **Beschikbaar op** aan waar het URL-adres beschikbaar moet zijn. U kunt meerdere opties tegelijk selecteren.
    * **SuperOffice CRM for Web**: wanneer u de webversie van SuperOffice CRM gebruikt.
    * **Mobile CRM**: wanneer u de mobiele versie gebruikt van SuperOffice CRM.

    Extra instellingen:
    * **Inhoud altijd opnieuw laden** bij tabbladnavigatie.
    * **Koppeling weergeven** in afzonderlijk venster.

1. Klik op de lijst **Pictogram** om een pictogram voor het webpaneel te kiezen.

1. Typ zo nodig een beschrijving voor de koptekst in het veld **Beschrijving**. Lees meer over [Vertaling][3].

1. Klik op **Opslaan** om de wijzigingen op te slaan of op **Annuleren** om ze te negeren.

> [!TIP]
> Als u een URL-adres toevoegt, kan het handig zijn meerdere sjabloonvariabelen te gebruiken voor het actieve bedrijf, bijvoorbeeld om informatie van andere toepassingen via een URL op te halen. Het URL-adres moet bepaalde parameters bevatten, zoals in dit fictieve voorbeeld: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn is hier de sjabloonvariabele voor het organisatienummer, maar andere variabelen zoals bedrijfsnaam &lt;name&gt;, bedrijfstelefoonnummer &lt;cpho&gt;, persoonsnaam &lt;attn&gt;, kunnen ook gebruikt worden.

## <a id="options"></a>Opties

### Venster

* **Bedrijfskaart**, **Visitekaartje**, **Projectkaart**, **Selectiekaart** en **Verkoopkaart**: er wordt een snelkoppeling naar het URL-adres toegevoegd boven aan het tabblad **WWW** in de schermen Bedrijf, Persoon, Project, Selectie en Verkoop. Wanneer u op een snelkoppeling in SuperOffice CRM klikt, wordt de betreffende webpagina weergegeven in een klein schuifbaar venster op het tabblad. U kunt vervolgens ook op **Openen in apart venster** klikken om de webpagina in een apart browservenster weer te geven.

* **Webpaneel op SuperOffice-knop**: het URL-adres wordt toegevoegd op het webpaneel in SuperOffice CRM. Het adres kan dan worden geopend als een internetpagina. Wanneer meerdere URL-adressen zijn gedefinieerd voor het webpaneel, worden deze weergegeven als tabbladen aan de rechterkant van het webpaneel. U opent het webpaneel door te klikken op het SuperOffice-logo linksboven in SuperOffice CRM.

* Sectietabbladen in de schermen Bedrijf, Persoon, Project en Verkoop: het URL-adres wordt toegevoegd als een extra sectietabblad op het scherm Bedrijf/Persoon/Project/Verkoop. Wanneer u het sectietabblad in SuperOffice CRM selecteert, wordt de URL geopend. U kunt vervolgens ook op **Openen in apart venster** klikken om de webpagina in een apart browservenster weer te geven.

### Dialoogvenster

* **Het dialoogvenster voor vervolgactiviteiten**: er wordt een snelkoppeling naar het URL-adres toegevoegd boven aan het tabblad **WWW** in de dialoogvenster **Vervolgactiviteit**. U kunt vervolgens ook op **Openen in apart venster** klikken om de webpagina in een apart browservenster weer te geven.

* **De dialoogvensters Document/Offerte/Product**: er wordt een snelkoppeling naar het URL-adres toegevoegd boven aan het tabblad **WWW** in deze dialoogvensters.

### Menu

* **Modulemenu**: het URL-adres wordt weergegeven wanneer de gebruiker op de knop **Hulpmiddelen** (<i class="ph ph-wrench" aria-hidden="true"></i>) klikt in de Navigator of **Andere toepassingen** selecteert in SuperOffice CRM.

* **Weergavemenu**: het URL-adres wordt weergegeven wanneer de gebruiker **Andere toepassingen** selecteert in SuperOffice CRM.

## <a id="fields"></a>Referentie

| Instelling | Beschrijving |
|---|---|
| Naam | UI-label |
| Vensternaam | ID van het paneel, gebruikt in de HTML die je in de panelen laadt. Moet uniek zijn, gebruik voorvoegsels |
| Beschrijving | Tooltip-tekst |
| URL | Locatie van de webpagina |
| URL-codering | Geen, ANSI of Unicode |
| Zichtbaar in | Weergavepositie |
| Beschikbaar op | Apparaattype (web, mobiel) |
| Tonen | Of de menubalk, werkbalk, adresbalk en/of statusbalk moet worden getoond |

## <a id="https"></a>HTTP vs HTTPS URL's gebruiken

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

## Webpaneel in toevoegen Service (verouderd)

In Service worden webpanelen **extra browsertabs** genoemd. Je kunt hetzelfde type inhoud toevoegen als bij [extra menu's][4].

1. Meld je aan bij SuperOffice Service.
1. Selecteer **Systeemontwerp** in het hamburgermenu en kies vervolgens **Webpanelen**.
1. Wijs naar de gewenste weergavepositie en klik op **Nieuw webpaneel**.
1. Voer een UI-label in (de tekst op het tabblad).
1. Kies **URL gebruiken** of **Scherm gebruiken** en selecteer de bijbehorende details.
1. Kies in de lijst **Positie** waar het nieuwe menu-item moet worden ingevoegd (0 = bovenaan).
1. Klik op **OK**.
1. Test het resultaat.

## Gerelateerde inhoud

* [Een taakmenu-item toevoegen][1]
* [Basisprogramma's en URL-parameters][5]

<!-- Referenced links -->
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md

<!-- Referenced images -->