---
uid: help-no-video-meetings
title: Arbeide med videomøter
description: Lær hvordan du oppretter og blir med i et videomøte i SuperOffice her.
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbok, oppfølging, videomøte
so.topic: howto
language: no
---

# Arbeide med videomøter

SuperOffice-videomøtene lar deg planlegge og opprette videomøter direkte fra dagboken din. La oss ta en titt på hvordan du kan sette opp et videomøte.

> [!NOTE]
> Før du kan bruke denne funksjonen, [må administratoren konfigurere][1] din foretrukne videomøtetjeneste i SuperOffice - Innstillinger og vedlikehold.

## Tilgjengelige leverandører av videokonferanser

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (gratis å bruke, ingen abonnement nødvendig)

## Opprette et videomøte

Du kan enkelt konfigurere et videomøte når du oppretter en oppfølging. Se denne videoen for å lære hvordan du oppretter et videomøte, eller følg trinnene nedenfor (videolengde - 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Trinn

1. Opprett en ny avtale, og velg navnet på firmaet og personen du planlegger å møte.

2. Hvis du vil opprette en videomøte-URL, klikker du på ![icon][img1]. Ikonet endres til ![icon][img2] og en videomøtekobling legges til. SuperOffice CRM oppretter og legger til nettadressen for videomøter for videoleverandøren du bruker.

    ![Klikk på videomøteikonet for å opprette nettadressen til videomøtet -screenshot][img5]

    > [!NOTE]
    > Første gang du velger videoikonet ![icon][img1], må du logge på for å godkjenne brukeren i videomøtetjenesten som er definert av administratoren.
    >
    > Hvis du ikke ser iconet, betyr dette at videomøtefunksjonen ikke er konfigurert ennå. Ta kontakt med SuperOffice-administratoren din, som kan konfigurere funksjonen og videoleverandørtilkoblingen.

3. Du kan også konfigurere en alarm for å bli varslet av et popup-vindu før møtet starter.

4. [Inviter deltakere][2].

    Når du har lagt til alle du vil skal delta på møtet, klikker du på **Lagre**.

    Hvis du har slått på e-postinvitasjoner til deltakerne i oppfølgingen, sendes en e-postmelding med en kobling for å bli med i videomøtet når avtalen lagres. I dagboken vises oppfølging med videomøter med ikonet ![iconet][img3].

> [!TIP]
> Klikk på ![icon][img4] for å kopiere videomøtekoblingen. Du kan deretter lime inn koblingen i agendaen / beskrivelsen av avtalen eller sende til andre via direktemeldinger. Bruk malvariabelen {burl} til å legge til videomøtekoblingen i invitasjonsmaler.

## Bli med i videomøter

Du kan bli med på et videomøte i SuperOffice på flere måter:

* Klikk på **Bli med i møte** i dialogboksen **Oppfølging** (avtale).
* Klikk på **Bli med i møte** på sidepanelet.
* Klikk på et nettleservarsel (bare tilgjengelig hvis **Alarm**-alternativet er aktivt).
* Høyreklikk på et videomøte i dagboken, og velg **Bli med i møte**.

Se denne videoen eller følg trinnene nedenfor (videolengde - 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

### Trinn

#### I popup-vinduet for varsler

Hvis møtelederen har konfigurert varsler for møtet, vil SuperOffice CRM advare deg ved å vise et popup-varsel før møtet skal begynne. Du kan klikke på **Bli med i møte**-knappen i popup-vinduet for å starte videomøtet automatisk.

#### I avtalen

Du kan også bli med på videomøtet ved å åpne avtalen i dagboken din og klikke på **Bli med i møte**-knappen nederst i avtalen. Når du klikker på koblingen, starter videomøtet automatisk.

> [!TIP]
> Når du ikke bruker Videomøte-URL-en, men har en annen video-URL, legger du den ganske enkelt til i Sted-feltet, og det er enkelt for alle som bruker Mobile CRM å klikke på **Plassering** for å koble til videomøtet mens du er på farten.

#### I forhåndsvisningen på sidepanelet

Klikk på avtalen i SuperOffice-dagboken for å se detaljene i sidepanelet. (Aktiver forhåndsvisningen ved å velge den fra rullegardinmenyen øverst på sidepanelet).

For å bli med i videomøtet via forhåndsvisningsskjermen, klikker du bare på **Bli med i møte**-knappen. Etter at du har klikket på den, starter videomøtet automatisk.

<!-- Referenced links -->
[1]: ../../../en/video-meeting/howto/connect-provider.md
[2]: invitation/add-participant.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png
