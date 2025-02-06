---
uid: help-no-document-template-link
title: Legge til en dokumentmal
description: I denne veiledningen lærer du hvordan du legger til en ny dokumentmal i SuperOffice CRM.
keywords: dokument, mal, liste
author: Bergfrid Dias
date: 07.12.2024
version: 10
topic: howto
language: no
audience: settings
audience_tooltip: Settings and maintenance
---

# Legge til en dokumentmal

Hvis du lager nye maler eller endrer en standardmal og lagrer den med et annet filnavn, må du knytte malene til SuperOffice CRM, slik at programmet kan finne dem når du skriver dokumenter fra SuperOffice CRM.

Maler vises som forekomster på listen **Dokument - mal**, og du knytter en mal til SuperOffice CRM ved å legge den til som en forekomst på listen.

Se denne videoen, eller følg fremgangsmåten nedenfor for å finne ut hvordan du kan legge til en dokumentmal:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/FnhcmjP-TgE]

(videolengde – 2.30)

## Trinn

1. I Innstillinger og velikehold, velg **Lister** i navigatoren (1).

1. Velg fanen **Forekomster**, klikk på pilen, og velg **Dokument - Mal** (2).

1. Klikk på **Legg til**-knappen (3).

    ![Legge til en dokumentmal -screenshot][img3]

1. Skriv inn ønsket navn på forekomsten i feltet **Navn** (1).

    ![Angi dokumentmalnavn -screenshot ][img2]

1. Velg eventuelt hvor du vil lagre dokumentmalen, i listen **Lagre malen i** (2).

1. Nå har du to muligheter:

    * Laste opp en ny dokumentmal:

        1. Klikk på **Kopier en eksisterende dokumentmalfil**.
        2. Klikk på listen **Kopier mal**.
        3. Velg ønsket mal på listen.

    * Kopiere en eksisterende mal i SuperOffice:

        1. Velg **Last opp en ny dokumentmal fra disk** (3).
        2. Klikk på **Last opp**.
        3. Klikk på **Last opp fil** i dialogboksen **Last opp fil**.
        4. Velg ønsket fil, og klikk på **Åpne**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

1. Klikk på **Lagre** i dialogboksen **Rediger forekomst**. Dialogboksen oppdateres.

1. Valgfritt: Rediger om nødvendig malnavnet, og klikk på **Rediger** for å redigere selve malfilen.

1. Angi ønsket informasjon i fanene **Detaljer** og **Språk**.

1. Klikk på **Lagre**. Malen blir nå lagt til som en egen forekomst i listen **Forekomster** og er nå tilgjengelig i CRM-klienten:

![Nytt dokument -screenshot][img4]

![Nytt dokument -screenshot][img5]

> [!TIP]
> Gjenta prosedyren hvis du vil legge til flere maler.

## Fanen Detaljer

Angi følgende informasjon i fanen **Detaljer**:

1. I feltet **Retning** angir du om malen er utgående eller innkommende ved å klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velge fra listeboksen.

2. I feltet **Dokumenttype** velger du enten **Dokument** eller **Faks** som maltype.

3. I feltet **Dokument lagret i** kan du velge å lagre dokumentet et annet sted enn standardalternativet.

4. I **Hensikt**-feltet klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger et av de forhåndsdefinerte alternativene fra listen. Disse elementene brukes i forbindelse med statusovervåking (krever lisens for [Sales Intelligence][4]).

    > [!TIP]
    > Du kan opprette nye alternativer i tillegg til de forhåndsdefinerte ved å legge til forekomster på listen **Oppfølging - Hensikt** i Innstillinger og vedlikehold.

5. Onsite: Merk av for alternativet **Publiser** på dialogboksen Dokument hvis du vil at det skal være mulig å angi at den aktuelle dokumentmalen skal gjøres tilgjengelig for eksterne brukere.

6. Onsite: Merk av for valget **Lagre i database** for å angi at dokumenter du oppretter ved hjelp av denne malen, skal lagres i dokumentdatabasen. Hvis du merket av for dette alternativet, vises dokumentet på detaljkortet **Aktiviteter**. Hvis du ikke merker av for dette alternativet, vises ikke dokumentet i SuperOffice etter at du har opprettet det, og du får ikke tilgang til det via programmet.

7. Merk av for alternativet **Tilbudsdokument-type** (4) hvis dokumentet skal være tilgjengelig som [tilbudsmal][2] eller bekreftelsesdokument. Du velger typen tilbudsdokument i listen nedenfor.

    ![Dialogboksen Rediger forekomst -screenshot][img8]

8. Angi standardoppsett for feltet **Vår ref (standard)** (5) ved hjelp av malvariabler, for eksempel *auth* for avsenderens fornavn og etternavn, eller {oref}.

9. Legg eventuelt inn en beskrivelse av malen i feltet **Beskrivelse**.

    > [!TIP]
    > Du kan åpne malen for redigering direkte fra dialogboksen **Rediger forekomst** ved å klikke på **Rediger**-knappen øverst.

## Fanen Språk

Her kan du legge til oversatte versjoner av dokumentmalen.

1. Klikk på **Legg til**.

    ![Legg til språk -screenshot][img6]

1. I dialogboksen **Rediger forekomst** velger du ønsket språk fra listen **Legg til språk**.

1. Legg til den oversatte dokumentmalen som beskrevet ovenfor.

    ![Oversatt dokumentmalen -screenshot][img7]

1. Klikk på **Legg til**. Språket vises i fanen **Språk**.

1. Gjenta trinnene ovenfor for å legge til flere språk.

## Relatert

* [Erstatte eksisterende mal][1]

<!-- Referenced links -->
[1]: update-template.md
[2]: ../learn/quote-templates.md
[4]: ../../../saint/learn/index.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/document/edit-list-item.png
[img3]: ../../../../media/loc/en/document/lists-add.png
[img4]: ../../../../media/loc/en/document/imagedmnmi.png
[img5]: ../../../../media/loc/en/document/image6r9sc.png
[img6]: ../../../../media/loc/en/document/language-add.png
[img7]: ../../../../media/loc/en/document/deutch-document-upload.png
[img8]: ../../../../media/loc/en/document/reference-item.png
