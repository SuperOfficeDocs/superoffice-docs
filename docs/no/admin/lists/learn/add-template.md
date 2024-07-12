---
uid: help-no-add-template
title: Legge til en mal
description: I denne veiledningen lærer du hvordan du legger til en ny dokumentmal i SuperOffice CRM.
author: SuperOffice RnD
date: 03.24.2023
keywords: dokument, mal
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til en dokumentmal

Hvis du vil sikre at alle i firmaet bruker de samme dokumentene, kan du opprette og legge til dine egne dokumentmaler for ulike filtyper. Bruk de tilgjengelige malvariablene til å tilpasse og automatisere registrering av kundeinformasjon i dokumentene dine.

Hvis du lager nye maler eller endrer en standardmal og lagrer den med et annet filnavn, må du knytte malene til SuperOffice CRM, slik at programmet kan finne dem når du skriver dokumenter fra SuperOffice CRM. Når du har tilknyttet malene, kan du enkelt skrive brev, fakser og andre dokumenter du har laget maler for, ved hjelp av [Dokument-funksjonen i SuperOffice CRM][5].

Se denne videoen, eller følg fremgangsmåten nedenfor for å finne ut hvordan du kan legge til en dokumentmal (videolengde – 2.30):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

## Trinn

> [!TIP]
> Hvis du vil legge til nye maler, kan du enkelt kopiere en eksisterende dokumentmalfil og redigere den etter behov.

Maler vises som forekomster på listen **Dokument - mal**, og du knytter en mal til SuperOffice CRM ved å legge den til som en forekomst på listen.

[!include[Edit list item](includes/edit-list-item.md)] Når forekomstene er dokumentmaler:

1. Skriv inn ønsket navn på forekomsten i feltet **Navn**.
2. Velg eventuelt hvor du vil lagre dokumentmalen, i listen **Lagre malen i**.
3. Nå har du to muligheter:

    * Laste opp en ny dokumentmal:

        1. Klikk på **Kopier en eksisterende dokumentmalfil**.
        2. Klikk på listen **Kopier mal**.
        3. Velg ønsket mal på listen.

    * Kopiere en eksisterende mal i SuperOffice:

        1. Velg **Last opp en ny dokumentmal fra disk**.
        2. Klikk på **Last opp**.
        3. Klikk på **Last opp fil** i dialogboksen **Last opp fil**.
        4. Velg ønsket fil, og klikk på **Åpne**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

4. Klikk på **Lagre** i dialogboksen **Rediger forekomst**. Dialogboksen oppdateres.
5. Valgfritt: Rediger om nødvendig malnavnet, og klikk på **Rediger** for å redigere selve malfilen.
6. Angi ønsket informasjon i fanene **Detaljer** og **Språk**.
7. Klikk på **Lagre**. Malen blir nå lagt til som en egen forekomst i listen **Forekomster**. Gjenta prosedyren hvis du vil legge til flere maler.

## Fanen Detaljer

Angi følgende informasjon i fanen **Detaljer**:

1. I feltet **Retning** angir du om malen er utgående eller innkommende ved å klikke på ![ikon][img1] pilen og velge fra listeboksen.

2. I feltet **Dokumenttype** velger du enten **Dokument** eller **Faks** som maltype.

3. I feltet **Dokument lagret i** kan du velge å lagre dokumentet et annet sted enn standardalternativet.

4. I **Hensikt**-feltet klikker du på ![ikon][img1] pilen og velger et av de forhåndsdefinerte alternativene fra listen. Disse elementene brukes i forbindelse med statusovervåking (krever lisens for [Sales Intelligence][4]).

    > [!TIP]
    > Du kan opprette nye alternativer i tillegg til de forhåndsdefinerte ved å legge til forekomster på listen **Oppfølging - Hensikt** i Innstillinger og vedlikehold.

5. Onsite: Merk av for alternativet **Publiser** på Dokument-bildet hvis du vil at det skal være mulig å angi at den aktuelle dokumentmalen skal gjøres tilgjengelig for eksterne brukere.

6. Onsite: Merk av for valget **Lagre i database** for å angi at dokumenter du oppretter ved hjelp av denne malen, skal lagres i dokumentdatabasen. Hvis du merket av for dette alternativet, vises dokumentet på detaljkortet **Aktiviteter**. Hvis du ikke merker av for dette alternativet, vises ikke dokumentet i SuperOffice etter at du har opprettet det, og du får ikke tilgang til det via programmet.

7. Merk av for alternativet **Tilbudsdokument-type** hvis dokumentet skal være tilgjengelig som tilbudsmal eller bekreftelsesdokument. Du velger typen tilbudsdokument i listen nedenfor.

    [!include[Link to quote template docs](includes/learn-quote-templates.md)]

8. Angi standardoppsett for feltet **Vår ref (standard)** ved hjelp av [malvariabler][2], for eksempel *auth* for avsenderens fornavn og etternavn.

9. Legg eventuelt inn en beskrivelse av malen i feltet **Beskrivelse**.

    > [!TIP]
    > Du kan åpne malen for redigering direkte fra dialogboksen **Rediger forekomst** ved å klikke på **Rediger**-knappen øverst.

## Fanen Språk

Her kan du legge til oversatte versjoner av dokumentmalen.

1. Klikk på **Legg til**.
2. I dialogboksen **Rediger forekomst** velger du ønsket språk fra listen **Legg til språk**.
3. Legg til den oversatte dokumentmalen som beskrevet ovenfor.
4. Klikk på **Legg til**. Språket vises i fanen **Språk**.
5. Gjenta trinnene ovenfor for å legge til flere språk.

## Relatert

* [Hvordan laster jeg opp og bruker dokumentmaler?][3] – FAQ
* [Erstatte eksisterende mal][1]

<!-- Referenced links -->
[2]: ../../../document/templates/learn/template-variables.md
[5]: ../../../document/learn/index.md
[1]: replace-existing-template.md
[4]: ../../../sale/saint/learn/index.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-down.png
