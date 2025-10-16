---
uid: help-no-video-meetings
title: Arbeide med videomøter
description: Lær hvordan du oppretter og blir med i et videomøte i SuperOffice her.
keywords: opprett videomøte, videomøte URL, dagbok, oppfølging, videomøte
author: digitaldiina
date: 10.16.2025
version: 11.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/admin/preferences/learn/video-meetings/index
---

# Arbeide med videomøter <i class="ph ph-video-camera" aria-hidden="true"></i>

SuperOffice-videomøtene lar deg planlegge og opprette videomøter direkte fra dagboken din. La oss ta en titt på hvordan du kan sette opp et videomøte.

> [!NOTE]
> Før du kan bruke denne funksjonen, [må administratoren konfigurere][1] din foretrukne videomøtetjeneste i SuperOffice - Innstillinger og vedlikehold.

## Forutsetninger

* [Generelle forutsetninger for videomøter][3]
* [Zoom][4]
* [Microsoft Teams (krever Microsoft 365 for bedrifter)][5]
* [Google Meet][6]
* [Cisco WebEx][7]
* [Jitsi Meet (gratis å bruke, ingen abonnement nødvendig)][8]

## Opprette et videomøte

Du kan enkelt konfigurere et videomøte når du oppretter en oppfølging. Se denne videoen for å lære hvordan du oppretter et videomøte, eller følg trinnene nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

(videolengde - 1:09)

### Trinn

1. Opprett en ny avtale, og velg navnet på firmaet og personen du planlegger å møte.

2. Hvis du vil opprette en videomøte-URL, klikker du på <i class="ph ph-video-camera" aria-label="Camera icon"></i>. Ikonet endrer farge og en videomøtekobling legges til. SuperOffice CRM oppretter og legger til nettadressen for videomøter for videoleverandøren du bruker.

    ![Klikk på videomøteikonet for å opprette nettadressen til videomøtet -screenshot][img5]

    > [!NOTE]
    > Første gang du velger <i class="ph ph-video-camera" aria-label="Video meeting"></i>, må du logge på for å godkjenne brukeren i videomøtetjenesten som er definert av administratoren.
    >
    > Hvis du ikke ser iconet, betyr dette at videomøtefunksjonen ikke er konfigurert ennå. Ta kontakt med SuperOffice-administratoren din, som kan konfigurere funksjonen og videoleverandørtilkoblingen.

3. Du kan også konfigurere en alarm for å bli varslet av et popup-vindu før møtet starter.

4. [Inviter deltakere][2].

    Når du har lagt til alle du vil skal delta på møtet, klikker du på **Lagre**.

    Hvis du har slått på e-postinvitasjoner til deltakerne i oppfølgingen, sendes en e-postmelding med en kobling for å bli med i videomøtet når avtalen lagres. I dagboken vises oppfølging med videomøter med <i class="ph ph-video-camera" aria-label="Camera icon"></i>.

> [!TIP]
> Klikk på <i class="ph ph-copy" aria-label="Copy"></i> for å kopiere videomøtekoblingen. Du kan deretter lime inn koblingen i agendaen / beskrivelsen av avtalen eller sende til andre via direktemeldinger. Bruk malvariabelen {burl} til å legge til videomøtekoblingen i invitasjonsmaler.

## Bli med i videomøter

Du kan bli med på et videomøte i SuperOffice på flere måter:

* Klikk på **Bli med i møte** i dialogboksen **Oppfølging** (avtale).
* Klikk på **Bli med i møte** på sidepanelet.
* Klikk på et nettleservarsel (bare tilgjengelig hvis **Alarm**-alternativet er aktivt).
* Høyreklikk på et videomøte i dagboken, og velg **Bli med i møte**.

Se denne videoen eller følg trinnene nedenfor:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

(videolengde - 1:11)

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
[1]: ../../../../integrations/video-meetings/howto/connect-provider.md
[2]: invitation/add-attendee.md
[3]: ../../../../integrations/video-meetings/index.md
[4]: ../../../../integrations/video-meetings/zoom/index.md
[5]: ../../../../integrations/video-meetings/ms-teams/index.md
[6]: ../../../../integrations/video-meetings/google-meet/index.md
[7]: ../../../../integrations/video-meetings/webex/index.md
[8]: ../../../../integrations/video-meetings/jitsi/index.md

<!-- Referenced images -->
[img5]: ../../../media/loc/en/diary/follow-up-video-meeting.png
