---
uid: help-nl-add-web-panel
title: Webpaneel toevoegen
description: Hoe items toe te voegen aan de webpaneellijst in Instellingen en onderhoud.
keywords: webpaneel, lijst GUI - Webpaneel
author: digitaldiina
date: 11.04.2025
version: 11.6
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

Webpanelen worden gedefinieerd in de lijst **GUI - Webpaneel**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**. Waar uw webpaneel verschijnt wordt bepaald door *Zichtbaar in*. De inhoud van uw webpaneel wordt bepaald door de URL.

## Stappen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de Navigator.

1. Selecteer **GUI - Webpaneel** uit het vervolgkeuzemenu. Het tabblad **Items** toont alle bestaande webpanelen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Voer in het veld **Naam** het label in dat in SuperOffice CRM wordt weergegeven. *(Verplicht)*

    * Typ zo nodig een beschrijving voor de koptekst in het veld **Beschrijving**. Lees meer over [Vertaling][3].

1. Geef in het veld **URL** het URL-adres op, zoals een webpagina of een op een server gebaseerd HTML-bestand. Voor details over ondersteunde URL-types, zie [HTTP vs HTTPS URL's gebruiken](#https).

    * In de veld **URL-codering** selecteer *Geen*, *ANSI*, or *Unicode*.

1. Voer in het veld **Vensternaam** de gewenste naam in voor het browservenster waarin het URL-adres moet worden geopend. Als u eerder een of meer vensternamen hebt toegevoegd en ze opnieuw wilt gebruiken, kunt u in het veld klikken en een naam uit de lijst selecteren. U kunt een naam ook rechtstreeks in het veld typen. De vensternaam zoals deze uiteindelijk wordt weergegeven wordt hieronder onderstreept weergegeven.

1. Kies in de keuzelijst **Zichtbaar in** waar het webpaneel moet verschijnen in SuperOffice CRM.

1. Onder **Beschikbaar op**, selecteer een of beide opties:
    * **SuperOffice CRM for Web**
    * **Mobile CRM**

1. (Optioneel) Zo bepaalt u hoe het paneel zich gedraagt:

    * Selecteer **Inhoud altijd opnieuw laden bij tabbladnavigatie** als de inhoud elke keer vernieuwd moet worden wanneer u van tabblad wisselt.
    * Selecteer **Laad de inhoud niet opnieuw wanneer u naar de hoofdkaart navigeert** om de inhoud in het geheugen te houden tijdens navigatie.
    * Selecteer **Koppeling weergeven in afzonderlijk venster** als het paneel ook in een nieuw browservenster geopend moet worden.

1. (Optioneel) Klik op de lijst **Pictogram** om een pictogram voor het webpaneel te kiezen.

1. Klik op **Opslaan** om de wijzigingen op te slaan of op **Annuleren** om ze te negeren.

## Na het opslaan

Zodra het item is opgeslagen, kunt u:

* De volgorde van items wijzigen met de pijlknoppen links van de lijst (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Aanvullende instellingen specificeren voor elk item:
  * Voor welke [gebruikersgroepen het item zichtbaar is][7].
  * Onder welke [koptekst][6] het wordt weergegeven.

## <a id="fields"></a>Referentie

| Instelling | Beschrijving |
|---|---|
| Naam | UI-label |
| Vensternaam | ID van het paneel, gebruikt in de HTML die je in de panelen laadt. Moet uniek zijn, gebruik voorvoegsels |
| Beschrijving | Tooltip-tekst |
| URL | Locatie van de webpagina |
| [URL-codering][2] | Geen, ANSI of Unicode |
| Zichtbaar in | Weergavepositie. U kunt kiezen uit panelen, dialoogvensters, menu's, werkbalk of zijpaneellocaties. Voor een volledige lijst van weergaveopties, zie [Weergavelocaties voor webpanelen][8]. |
| Beschikbaar op | Apparaattype (web, mobiel) - aan waar het URL-adres beschikbaar moet zijn |

### <a id="https"></a>HTTP vs HTTPS URL's gebruiken

[!include[HTTPS restriction](../../includes/web-panels-and-https.md)]

### Sjabloonvariabelen gebruiken

Als u een URL-adres toevoegt, kan het nuttig zijn om sjabloonvariabelen te gebruiken voor het actieve bedrijf, bijvoorbeeld om informatie uit andere toepassingen op te halen via een URL. Het URL-adres moet parameters specificeren, zoals in dit fictieve voorbeeld: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn is hier de sjabloonvariabele voor het organisatienummer, maar andere variabelen zoals bedrijfsnaam &lt;name&gt;, bedrijfstelefoon &lt;cpho&gt;, contactnaam &lt;attn&gt; kunnen ook worden gebruikt.

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
[1]: ../../admin/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/headings.md
[7]: ../../../admin/lists/user-group-filtering.md
[8]: index.md

<!-- Referenced images -->