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

1. Indtast det ønskede navn for forekomsten i feltet **Navn**. *(Obligatorisk)*

    * Dette navn vises, når du tilføjer URL-adressen i SuperOffice CRM.

1. Angiv URL-adressen, f.eks. en webside eller en serverbaseret HTML-fil, i feltet **URL**. For detaljer om understøttede URL-typer, se [Brug af HTTP vs HTTPS URL'er](#https).

    * Når du tilføjer en URL-adresse, kan det være nyttigt at bruge skabelonvariabler for det aktive firma, for eksempel til at hente oplysninger fra andre programmer via en URL. URL-adressen skal angive parametre som i dette fiktive eksempel: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn er skabelonvariablen for organisationsnummer, men andre variabler, såsom firmanavn &lt;name&gt;, firmaets telefonnummer &lt;cpho&gt; eller personnavn &lt;attn&gt; kan også anvendes.

1. Angiv i feltet **Vinduesnavn** det nødvendige navn på det browservindue, hvor URL-adressen skal åbnes. Hvis du tidligere har tilføjet et eller flere vinduesnavne og vil genbruge dem, kan du klikke i feltet og vælge et navn på listen. Du kan også indtaste et nyt navn direkte i feltet. Det endelige vinduesnavn vises understreget nedenfor.

1. På listen **Synlig i** vælger du, hvor URL-adressen skal være tilgængelig i SuperOffice CRM.
    * **Sidepanel**: Vælg denne indstilling for at gøre URL-adressen tilgængelig i sidepanelerne i SuperOffice CRM.

    * **Værktøjslinje**: Vælg denne indstilling for at gøre URL-adressen tilgængelig som en knap på værktøjslinjen.

    * **Navigatorknap**: Vælg denne indstilling for at gøre URL-adressen tilgængelig som en knap i navigatoren i SuperOffice CRM.

    * **Panel**: Vælg [en indstilling på denne liste](#options) for at gøre URL-adressen tilgængelig som et panel/en fane i SuperOffice CRM.

    * **Dialog**: Vælg [en indstilling på denne liste](#options) for at gøre URL-adressen tilgængelig i en dialogboks.

    * **Menu**: Vælg [en indstilling på denne liste](#options) for at gøre URL-adressen tilgængelig fra en af menuerne i SuperOffice CRM.

1. I rullemenuen **URL-format** kan du vælge, om [URL-adressen][2] skal være ANSI eller Unicode (eller uden format).

1. Under **Vis** markerer du de linjer, som skal være tilgængelige i det browservindue, som URL-adressen åbnes i – menulinje, værktøjslinje, adresselinje og statuslinje.

1. Under **Tilgængelig på** vælger du, hvor URL-adressen skal være tilgængelig. Du kan vælge flere af disse indstillinger samtidig.
    * **SuperOffice CRM for Web**: Når du bruger webversionen af SuperOffice CRM.
    * **Mobile CRM**: Når du bruger mobilversionen af SuperOffice CRM.

    Ekstra indstillinger:
    * **Genindlæs altid** indhold ved fanenavigation.
    * **Vis link** til åbning i separat vindue.

1. Klik på listen **Ikon** for at vælge et ikon for webpanelet.

1. Angiv eventuelt en beskrivelse af forekomsten i feltet **Beskrivelse**. Læs om [Oversættelse][3].

1. Klik på **Gem** for at gemme ændringerne eller **Annuller** for at afvise dem.

## Efter at have gemt

Når elementet er gemt, kan du:

* Ændre rækkefølgen af elementer ved hjælp af pilknapperne til venstre for listen (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Angive yderligere indstillinger for hvert element:
  * Hvilke [brugergrupper elementet er synligt for][7].
  * Hvilken [overskrift][6] det skal vises under.

## <a id="options"></a>Indstillinger

### Panel

* **Firmakort**, **Personkort**, **Projektkort**, **Udvalgskort** og **Salgskort**: Der tilføjes en genvej til URL-adressen øverst på fanen **www** i skærmbillederne Firma, Person, Projekt, Udvalg og Salg. Når brugeren klikker på genvejen i SuperOffice CRM, vises den aktuelle internetside i et lille vindue med rullefelt under fanen. Det er også muligt at klikke på **Åbn i nyt vindue** for at åbne internetsiden i et nyt browservindue.

* **Webpanel på knappen SuperOffice**: URL-adressen tilføjes i webpanelet i SuperOffice CRM. Dermed kan adressen åbnes som en internetside. Hvis der er defineret flere URL-adresser til webpanelet, vises de som faner i højre side af webpanelet. Webpanelet åbnes ved at klikke på SuperOffice-logoet øverst til venstre i SuperOffice CRM.

* Detaljekort i skærmbillederne Firma, Person, Projekt og Salg: URL-adressen tilføjes som et ekstra detaljekort i skærmbilledet Firma/Person/Projekt/Læring/Salg. Når du vælger detaljekortet i SuperOffice CRM, åbnes URL-adressen. Det er også muligt at klikke på **Åbn i nyt vindue** for at åbne internetsiden i et nyt browservindue.

### Dialogboks

* **Dialogboksen for opfølgninger**: Der tilføjes en genvej til URL-adressen øverst på fanen **www** i dialogboksen **Opfølgning**. Det er også muligt at klikke på **Åbn i nyt vindue** for at åbne internetsiden i et nyt browservindue.

* **Dialogboksen Dokument/Tilbud/Produkt**: Der tilføjes en genvej til URL-adressen øverst under fanen **www** i disse dialogbokse.

### Menu

* **Værktøjsmenu**: URL-adressen vises, når brugeren klikker på knappen **Værktøj** (<i class="ph ph-wrench" aria-hidden="true"></i>) i navigatoren eller vælger **Andre programmer** i SuperOffice CRM.

* **Menuen Vis**: URL-adressen vises, når brugeren vælger **Andre programmer** i SuperOffice CRM.

## <a id="fields"></a>Reference

| Indstilling | Beskrivelse |
|---|---|
| Navn | UI-etiket |
| Vinduesnavn | ID for panelet, bruges i HTML-koden du indlæser i panelerne. Skal være unik, brug præfikser |
| Beskrivelse | Værktøjstip-tekst |
| URL | Placering af webside |
| URL-format | Ingen, ANSI eller Unicode |
| Synlig i | Visningsplacering |
| Tilgængelig på | Enhedstype (web, mobil) |
| Vis | Om menulinje, værktøjslinje, adresselinje og/eller statuslinje skal vises |

## <a id="https"></a>Brug af HTTP vs HTTPS URL'er

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

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
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/learn/organize/headings.md
[7]: ../../../admin/lists/learn/organize/user-group-filtering.md

<!-- Referenced images -->