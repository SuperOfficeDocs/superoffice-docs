---
uid: help-nl-video-meetings
title: Werken met videovergaderingen
description: Lees hier hoe u een videovergadering in SuperOffice kunt maken en eraan kunt deelnemen.
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: agenda, vervolgactiviteit, videovergadering
so.topic: howto
language: nl
---

# Werken met videovergaderingen

Met SuperOffice-videovergaderingen kunt u rechtstreeks vanuit uw agenda videovergaderingen plannen en maken. Laten we eens kijken hoe u een videovergadering kunt opzetten.

> [!NOTE]
> Voordat u deze functie kunt gebruiken, moet de [beheerder eerst de videovergaderingsservice][1] van uw voorkeur configureren in SuperOffice Instellingen en onderhoud.

## Beschikbare aanbieders van videoconferenties

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (gratis te gebruiken, geen abonnement nodig)

## Een videovergadering maken

U kunt eenvoudig een videovergadering instellen bij het maken van een vervolgactiviteit. Bekijk deze video om te leren hoe u een videovergadering maakt of volg de onderstaande stappen (videolengte - 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Stappen

1. Maak een nieuwe afspraak en selecteer de naam van het bedrijf en de contactpersoon die u wilt ontmoeten.

2. Als u de URL van de videovergadering wilt maken, klikt u op het pictogram van de videovergadering ![pictogram][img1]. Het pictogram wijzigt in ![pictogram][img2] en er wordt een koppeling naar de videovergadering toegevoegd. SuperOffice CRM maakt en voegt de URL van de videovergadering toe voor de videoprovider die u gebruikt.

    ![Klik op het pictogram van de videovergadering om de URL van de videovergadering te maken -screenshot][img5]

    > [!NOTE]
    > De eerste keer dat u het videopictogram ![pictogram][img1] selecteert, moet u zich aanmelden om uw gebruiker te verifiëren in de videovergaderingsservice die door uw beheerder is gedefinieerd.
    >
    > Als u het pictogram niet ziet, betekent dit dat de functie voor videovergaderingen nog niet is geconfigureerd. Neem contact op met uw SuperOffice-beheerder, die de functie en de verbinding met de videoprovider kan instellen.

3. U kunt optioneel een alarm instellen dat wordt gemeld door een pop-up voordat de vergadering begint.

4. [Deelnemers uitnodigen][2].

    Wanneer u iedereen hebt toegevoegd die u aan de vergadering wilt laten deelnemen, klikt u op **Opslaan**.

    Als u e-mailuitnodigingen hebt ingeschakeld voor de deelnemers aan de vervolgactiviteit, wordt er een e-mail met een koppeling voor deelname aan de videovergadering verzonden wanneer de afspraak wordt opgeslagen. In de agenda worden vervolgactiviteiten met videovergaderingen weergegeven met het pictogram ![pictogram][img3].

> [!TIP]
> Klik op ![pictogram][img4] om de koppeling naar de videovergadering te kopiëren. U kunt vervolgens de link in de agenda / beschrijving van de afspraak plakken of verzenden naar anderen via privéberichten. Gebruik de sjabloonvariabele {burl} om de link voor videovergaderingen toe te voegen aan de uitnodigingssjablonen.

## Deelnemen aan videovergaderingen

U kunt op verschillende manieren deelnemen aan een videovergadering in SuperOffice:

* Klik op **Deelnemen aan vergadering** in het dialoogvenster **Vervolgactiviteit** (afspraak).
* Klik op **Deelnemen aan vergadering** in het zijpaneel.
* Klik op een browsermelding (alleen beschikbaar als de optie **Alarm** is geactiveerd).
* Klik met de rechtermuisknop op een videovergadering in de agenda en selecteer **Deelnemen aan vergadering**.

Bekijk deze video of volg de onderstaande stappen (videolengte - 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

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
[1]: ../../../en/video-meeting/howto/connect-provider.md
[2]: invitation/add-participant.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png
