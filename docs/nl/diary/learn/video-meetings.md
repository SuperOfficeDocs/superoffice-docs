---
uid: help-nl-video-meetings
title: Werken met videovergaderingen
description: Lees hier hoe u een videovergadering in SuperOffice kunt maken en eraan kunt deelnemen.
keywords: videovergadering maken, videovergadering URL, agenda, vervolgactiviteit, videovergadering
author: digitaldiina
date: 10.16.2025
version: 11.5
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/admin/preferences/learn/video-meetings/index
---

# Werken met videovergaderingen <i class="ph ph-video-camera" aria-hidden="true"></i>

Met SuperOffice-videovergaderingen kunt u rechtstreeks vanuit uw agenda videovergaderingen plannen en maken. Laten we eens kijken hoe u een videovergadering kunt opzetten.

> [!NOTE]
> Voordat u deze functie kunt gebruiken, moet de [beheerder eerst de videovergaderingsservice][1] van uw voorkeur configureren in SuperOffice Instellingen en onderhoud.

## Vereisten

* [Algemene vereisten voor videovergaderingen][3]
* [Zoom][4]
* [Microsoft Teams (vereist Microsoft 365 voor bedrijven)][5]
* [Google Meet][6]
* [Cisco WebEx][7]
* [Jitsi Meet (gratis te gebruiken, geen abonnement nodig)][8]

## Een videovergadering maken

U kunt eenvoudig een videovergadering instellen bij het maken van een vervolgactiviteit. Bekijk deze video om te leren hoe u een videovergadering maakt of volg de onderstaande stappen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

(videolengte - 1:09)

### Stappen

1. Maak een nieuwe afspraak en selecteer de naam van het bedrijf en de contactpersoon die u wilt ontmoeten.

2. Als u de URL van de videovergadering wilt maken, klikt u op <i class="ph ph-video-camera" aria-label="Camera icon"></i>. Het pictogram verandert van kleur en er wordt een koppeling naar de videovergadering toegevoegd. SuperOffice CRM maakt en voegt de URL van de videovergadering toe voor de videoprovider die u gebruikt.

    ![Klik op het pictogram van de videovergadering om de URL van de videovergadering te maken -screenshot][img5]

    > [!NOTE]
    > De eerste keer dat u <i class="ph ph-video-camera" aria-label="Video meeting"></i> selecteert, moet u zich aanmelden om uw gebruiker te verifiëren in de videovergaderingsservice die door uw beheerder is gedefinieerd.
    >
    > Als u het pictogram niet ziet, betekent dit dat de functie voor videovergaderingen nog niet is geconfigureerd. Neem contact op met uw SuperOffice-beheerder, die de functie en de verbinding met de videoprovider kan instellen.

3. U kunt optioneel een alarm instellen dat wordt gemeld door een pop-up voordat de vergadering begint.

4. [Deelnemers uitnodigen][2].

    Wanneer u iedereen hebt toegevoegd die u aan de vergadering wilt laten deelnemen, klikt u op **Opslaan**.

    Als u e-mailuitnodigingen hebt ingeschakeld voor de deelnemers aan de vervolgactiviteit, wordt er een e-mail met een koppeling voor deelname aan de videovergadering verzonden wanneer de afspraak wordt opgeslagen. In de agenda worden vervolgactiviteiten met videovergaderingen weergegeven met <i class="ph ph-video-camera" aria-label="Camera icon"></i>.

> [!TIP]
> Klik op <i class="ph ph-copy" aria-label="Copy"></i> om de koppeling naar de videovergadering te kopiëren. U kunt vervolgens de link in de agenda / beschrijving van de afspraak plakken of verzenden naar anderen via privéberichten. Gebruik de sjabloonvariabele {burl} om de link voor videovergaderingen toe te voegen aan de uitnodigingssjablonen.

## Deelnemen aan videovergaderingen

U kunt op verschillende manieren deelnemen aan een videovergadering in SuperOffice:

* Klik op **Deelnemen aan vergadering** in het dialoogvenster **Vervolgactiviteit** (afspraak).
* Klik op **Deelnemen aan vergadering** in het zijpaneel.
* Klik op een browsermelding (alleen beschikbaar als de optie **Alarm** is geactiveerd).
* Klik met de rechtermuisknop op een videovergadering in de agenda en selecteer **Deelnemen aan vergadering**.

Bekijk deze video of volg de onderstaande stappen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

(videolengte - 1:11)

### Stappen

#### In de meldingspop-up

Als de host van de vergadering meldingen voor de vergadering heeft ingesteld, waarschuwt SuperOffice CRM u door een meldingspop-up weer te geven voordat uw vergadering op het punt staat te beginnen. U kunt op de knop **Deelnemen aan vergadering** in het pop-upvenster klikken om uw videovergadering automatisch te starten.

#### In de vergadering

U kunt ook deelnemen aan de videovergadering door de vergadering in uw agenda te openen en op de knop **Deelnemen aan vergadering** te klikken. Wanneer u op de link klikt, wordt uw videovergadering automatisch gestart.

> [!TIP]
> Wanneer u geen URL voor een videovergadering gebruikt, maar een andere video-URL hebt, voegt u deze eenvoudig toe aan het veld Locatie en kunt u eenvoudig op **Locatie** klikken om onderweg verbinding te maken met de videovergadering.

#### In de zijpaneelvoorbeeldweergave

Klik op de Vergadering in uw SuperOffice-agendaom de details ervan te bekijken in het zijpaneel. (U kunt de voorbeeldweergave openen door deze te selecteren in het vervolgkeuzemenu boven aan het zijpaneel.)

Om deel te nemen aan de videovergadering via het voorbeeldscherm, klikt u gewoon op de knop **Deelnemen aan vergadering**. Nadat u erop hebt geklikt, wordt uw videovergadering automatisch gestart.

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
