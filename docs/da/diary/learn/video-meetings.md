---
uid: help-da-video-meetings
title: Arbejde med videomøder
description: Lær, hvordan du opretter og deltager i et videomøde i SuperOffice her.
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbog, opfølgning, videomøde
so.topic: howto
language: da
---

# Arbejde med videomøder

SuperOffice-videomøder giver dig mulighed for at planlægge og oprette videomøder direkte fra din dagbog. Lad os tage et kig på, hvordan du kan oprette et videomøde.

> [!NOTE]
> Før du kan bruge denne funktion, skal [administratoren først konfigurere][1] din foretrukne videomødetjeneste i Indstillinger og vedligeholdelse i SuperOffice.

## Tilgængelige udbydere af videokonferencer

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (gratis at bruge, intet abonnement nødvendigt)

## Opret et videomøde

Du kan nemt oprette et videomøde, når du opretter en opfølgning. Se denne video for at lære, hvordan du opretter et videomøde eller følg nedenstående trin (videolængde - 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Trin

1. Opret en ny aftale, og vælg navnet på det firma og den person, du planlægger at møde.

2. For at oprette videomødets URL-adresse skal du klikke på ![ikonet][img1]. Ikonet ændres til ![ikon][img2], og der tilføjes et link til videomøde. SuperOffice CRM opretter og tilføjer URL-adressen til videomødet for den videoudbyder, du bruger.

    ![Klik på videomødeikonet for at oprette URL-adressen til videomødet -screenshot][img5]

    > [!NOTE]
    > Første gang du vælger videoikonet ![ikon][img1], skal du logge ind for at godkende din bruger i den videomødetjeneste, der er defineret af din administrator.
    >
    > Hvis du ikke kan se ikonet, betyder det, at videomødefunktionen endnu ikke er konfigureret. Kontakt din SuperOffice-administrator, som vil være i stand til at konfigurere forbindelsen mellem funktionen og videoudbyderen.

3. Du kan også konfigurere en alarm, der skal vises via et pop op-vindue, før mødet starter.

4. [Inviter deltagere][2].

    Når du har tilføjet alle, som du ønsker skal deltage i mødet, skal du klikke på **Gem**.

    Hvis du har slået e-mailinvitationer til for deltagerne i opfølgningen, sendes der en e-mail med et link til at deltage i videomødet, når aftalen gemmes. I dagbogen vises opfølgninger med videomøder med ikonet ![ikon][img3].

> [!TIP]
> Klik på ![ikon][img4] for at kopiere linket til videomødet. Du kan derefter indsætte linket i dagsorden / beskrivelsen af aftalen eller sende det til andre via direkte beskeder. Brug skabelonvariablen {burl} til at føje videomødelinket til invitationsskabeloner.

## Deltage i videomøder

Du kan deltage i et videomøde i SuperOffice på flere måder:

* Klik på **Deltag i møde** i dialogboksen **Opfølgning** (aftale).
* Klik på **Deltag i møde** i sidepanelet.
* Klik på en browserbesked (kun tilgængelig, hvis indstillingen **Alarm** er aktiveret.)
* Højreklik på et videomøde i dagbogen, og vælg **Deltag i møde**.

Se denne video, eller følg nedenstående trin (videolængde - 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

### Trin

#### På pop op-meddelelsen

Hvis værten for mødet har oprettet meddelelser for mødet, advarer SuperOffice CRM dig ved at vise en pop op-meddelelse, før dit møde skal til at begynde. Du kan klikke på knappen **Deltag i møde** i pop op-meddelelsen for automatisk at starte dit videomøde.

#### I aftalen

Du kan også deltage i videomødet ved at åbne aftalen i din dagbog og klikke på knappen **Deltag i møde** nederst i aftalen. Når du klikker på linket, starter dit videomøde automatisk.

> [!TIP]
> Når du ikke bruger URL-adresse til videomøde, men har en anden video-URL, skal du blot føje den til feltet Placering, og det er nemt for alle, der bruger Mobile CRM, at klikke på Placering **for at oprette forbindelse til videomødet på farten**.

#### I sidepanelets forhåndsvisning

Klik på aftalen i din SuperOffice-dagbog for at se dens detaljer i sidepanelet. (Aktiver forhåndsvisning ved at vælge det i rullemenuen øverst i sidepanelet).

Du deltager i videomødet via forhåndsvisningsskærmen ved at klikke på knappen **Deltag i møde**. Når du klikker på linket, starter dit videomøde automatisk.

<!-- Referenced links -->
[1]: ../../../en/video-meeting/howto/connect-provider.md
[2]: invitation/add-participant.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png
