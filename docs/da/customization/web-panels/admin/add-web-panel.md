---
uid: help-da-add-web-panel
title: Tilføj webpanel
description: Sådan tilføjer du elementer til webpanellisten i Indstillinger og vedligeholdelse.
keywords: webpanel, listen GUI - Webpanel
author: digitaldiina
date: 10.13.2025
version: 11.5
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: da
index: true
redirect_from: /da/admin/lists/learn/web-panel-add-item
---

# Tilføj webpanel

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Webpaneler defineres i listen **GUI - Webpanel**, som du kan administrere i **Indstillinger og vedligeholdelse** under **Lister**. Hvor dit webpanel vises bestemmes af *Synlig i*. Indholdet af dit webpanel bestemmes af URL-adressen.

## Trin

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Vælg **GUI - Webpanel** fra rullemenuen. Fanen **Elementer** viser alle eksisterende webpaneler.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeelement**.

1. Indtast den etiket, der skal vises i SuperOffice CRM, i feltet **Navn**. *(Obligatorisk)*

    * Angiv eventuelt en beskrivelse af forekomsten i feltet **Beskrivelse**. Læs om [Oversættelse][3].

1. Angiv URL-adressen, f.eks. en webside eller en serverbaseret HTML-fil, i feltet **URL**. For detaljer om understøttede URL-typer, se [Brug af HTTP vs HTTPS URL'er](#https).

    * I feltet **URL-format** vælg, *Ingen*, *ANSI*, eller *Unicode*.

1. Angiv i feltet **Vinduesnavn** det nødvendige navn på det browservindue, hvor URL-adressen skal åbnes. Hvis du tidligere har tilføjet et eller flere vinduesnavne og vil genbruge dem, kan du klikke i feltet og vælge et navn på listen. Du kan også indtaste et nyt navn direkte i feltet. Det endelige vinduesnavn vises understreget nedenfor.

1. På listen **Synlig i** vælg, hvor webpanelet skal vises i SuperOffice CRM.

1. Under **Tilgængelig på** vælg, en eller begge muligheder:
    * **SuperOffice CRM for Web**
    * **Mobile CRM**

1. (Valgfrit) Sådan styrer du, hvordan panelet opfører sig:

    * Vælg **Genindlæs altid indhold ved fanebladsnavigation**, hvis indholdet skal opdateres hver gang brugeren skifter fane.
    * Vælg **Genindlæs ikke indhold ved navigation til hovedkort**, hvis indholdet skal caches under navigation mellem kort.
    * Vælg **Vis link til åbning i separat vindue**, hvis panelet også skal kunne åbnes i et nyt browservindue.

1. (Valgfrit) Klik på listen **Ikon** for at vælge et ikon for webpanelet.

1. Klik på **Gem** for at gemme ændringerne eller **Annuller** for at afvise dem.

## Efter at have gemt

Når elementet er gemt, kan du:

* Ændre rækkefølgen af elementer ved hjælp af pilknapperne til venstre for listen (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Angive yderligere indstillinger for hvert element:
  * Hvilke [brugergrupper elementet er synligt for][7].
  * Hvilken [overskrift][6] det skal vises under.

## <a id="fields"></a>Reference

| Indstilling | Beskrivelse |
|---|---|
| Navn | UI-etiket |
| Vinduesnavn | ID for panelet, bruges i HTML-koden du indlæser i panelerne. Skal være unik, brug præfikser |
| Beskrivelse | Værktøjstip-tekst |
| URL | Placering af webside |
| [URL-format][2] | Ingen, ANSI eller Unicode |
| Synlig i | Visningsplacering. Du kan vælge mellem paneler, dialogbokse, menuer, værktøjslinje eller sidepanelplaceringer. For en komplet liste over visningsindstillinger, se [Visningsplaceringer for webpaneler][8]. |
| Tilgængelig på | Enhedstype (web, mobil) - hvor URL-adressen skal være tilgængelig |

### <a id="https"></a>Brug af HTTP vs HTTPS URL'er

[!include[HTTPS restriction](../../includes/web-panels-and-https.md)]

### Brug af skabelonvariabler

Når du tilføjer en URL-adresse, kan det være nyttigt at bruge skabelonvariabler for det aktive firma, for eksempel til at hente oplysninger fra andre programmer via en URL. URL-adressen skal angive parametre som i dette fiktive eksempel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn er skabelonvariablen for organisationsnummer, men andre variabler, såsom firmanavn &lt;name&gt;, firmaets telefonnummer &lt;cpho&gt; eller personnavn &lt;attn&gt; kan også anvendes.

## Tilføj webpanel i Service (forældet)

I Service kaldes webpaneler for **ekstra browsertabs**. Du kan tilføje den samme type indhold som for [ekstra menuer][5].

1. Log ind i SuperOffice Service.
1. Vælg **Systemdesign** i hamburgermenuen, og vælg derefter **Webpaneler**.
1. Peg på den ønskede visningsplacering, og klik på **Nyt webpanel**.
1. Indtast en UI-etiket (faneteksten).
1. Vælg enten **Brug URL** eller **Brug skærmbillede**, og vælg derefter de tilsvarende oplysninger.
1. Vælg, hvor det nye menupunkt skal indsættes, på listen **Placering** (0 = øverst).
1. Klik på **OK**.
1. Test resultatet.

## Relateret indhold

* [Tilføj et opgavemenupunkt][1]
* [Basisprogrammer og URL-parametre][4]

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