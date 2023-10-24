---
uid: help-no-adding-items-to-web-panel-list
title: Legge til elementer i listen webpanel
description: Legge til elementer i listen webpanel
author: SuperOffice RnD
so.date: 01.20.2023
keywords: liste, webpanel
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: no
---

# Legge til forekomster på listen GUI - Webpanel

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

## Slik fyller du ut felt når forekomstene er URL-adresser

1. Skriv inn ønsket navn på forekomsten i feltet **Navn**. Dette navnet vises når du legger inn URL-adressen i SuperOffice CRM.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. I **URL-feltet** angir du URL-adressen, for eksempel en webside eller en serverbasert HTML-fil. Øverst finner du informasjon om bruk av URL-adresser med HTTP/HTTPS.

1. I feltet **Vindusnavn** angir du det påkrevde navnet på nettleservinduet der URL-adressen skal åpnes. Hvis du har lagt til ett eller flere vindusnavn tidligere og ønsker å bruke det samme om igjen, kan du klikke i feltet og velge navn fra listen. Du kan også skrive inn et nytt navn direkte i feltet. Det endelige vindusnavnet vises nedenfor med strek under.

1. I listeboksen **Synlig i** velger du hvor nettadressen skal være tilgjengelig i SuperOffice CRM.
    * **Sidepanel**: Velg dette alternativet for å gjøre URL-adressen tilgjengelig i sidepanelene i SuperOffice CRM.

    * **Knapperad**: Velg dette alternativet for å gjøre URL-adressen tilgjengelig som en knapp i knapperaden.

    * **Navigatorknapp**: Velg dette alternativet for å gjøre nettadressen tilgjengelig som en knapp i navigatoren i SuperOffice CRM.

    * **Panel**: Velg [et alternativ i denne listen](#options) for å gjøre nettadressen tilgjengelig som et panel / en fane i SuperOffice CRM.

    * **Dialog**: Velg et [alternativ i denne listen](#options) for å gjøre URL-adressen tilgjengelig i en dialogboks.

    * **Meny**: Velg et [alternativ i denne listen](#options) for å gjøre URL-adressen tilgjengelig fra en av menyene i SuperOffice CRM.

1. I listeboksen **URL-format** kan du velge om [URL-adressen][2] skal være ANSI eller Unicode (eller uten format).

1. Under **Vis** merker du av for de linjene som skal være tilgjengelige i nettleservinduet som URL-adressen åpnes i: menylinje, knapperad, adresselinje og statuslinje.

1. Under **Tilgjengelig på** velger du hvor du vil at URL-adressen skal være tilgjengelig. Du kan velge flere av disse alternativene samtidig.
    * **SuperOffice CRM for Web**: Når du bruker Web-versjonen av SuperOffice CRM.
    * **Mobile CRM**: Når du bruker mobilversjonen av SuperOffice CRM.

    Ekstra innstillinger:
    * **Last alltid innhold på nytt** ved fanebytte.
    * **Vis kobling** for å åpne i nytt vindu.

1. Klikk på **Ikon**-listen for å velge et ikon for webpanelet.

1. Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**. Les om [Oversettelse][3].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> Når du legger til en URL-adresse, kan det være nyttig å bruke for eksempel malvariabelen for aktivt firma til å hente ut informasjon fra andre applikasjoner via URL. URL-adressen må angi parametere, for eksempel slik: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. org.nr. her er malvariabelen for organisasjonsnummeret, men andre variabler som firmanavn &lt;name&gt;, firmatelefonnummer &lt;cpho&gt; og navn på personen &lt;attn&gt;, kan også brukes.

## <a id="options" />Systemvalg

### Panel

* **Firmakort**, **Personkort**, **Prosjektkort**, **Utvalgskort** og **Salgskort**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i bildene Firma, Person, Prosjekt, Utvalg og Salg. Når du klikker på snarveien i SuperOffice CRM, vises den aktuelle nettsiden i et lite vindu med rullefelt i fanen. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

* **Webpanel**: URL-adressen legges til i webpanelet i SuperOffice CRM. Dermed kan adressen åpnes som en Internett-side. Hvis det er definert flere URL-adresser for webpanelet, vises de som faner til høyre i webpanelet. Webpanelet åpnes ved å klikke på SuperOffice-logoen øverst til venstre i SuperOffice CRM.

* Detaljkort i Firma-, Person-, Prosjekt- og Salg-bildet: URL-adressen legges til som et ekstra detaljkort i Firma/Person/Prosjekt/Lær/Salg-bildet. Når du velger detaljkortet i SuperOffice CRM, åpnes URL-adressen. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

### Dialogboks

* **Dialogboksen for oppfølginger**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i dialogboksen **Oppfølging**. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

* **Dialogboksen Dokument/Tilbud/Produkt**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i disse dialogboksene.

### Meny

* **Verktøykassemeny**: URL-adressen vises når brukeren klikker på **Verktøy**-knappen ![ikon][img1] i navigatoren eller velger **Andre applikasjoner** i SuperOffice CRM.

* **Vis-menyen**: URL-adressen vises når brukeren velger **Andre applikasjoner** i SuperOffice CRM.

## Er SuperOffice CRM for Web installert på en https-webside?

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Aktuelle emner

* [Legge til en valg på oppgavemenyen][1]
* [Legge til en oversettelse][3]

<!-- Referenced links -->
[1]: add-items-to-task-menu.md
[2]: ../../../../en/ui/web-panels/url-encoding.md
[3]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-tools.png
