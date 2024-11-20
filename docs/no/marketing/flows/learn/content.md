---
uid: help-no-flow-content
title: Flytinnhold
description: Hvordan opprette og administrere flytinnhold i SuperOffice Marketing
keywords: flyt, markedsføring, flytinnhold, innholdsopprettelse, innholdsproduksjon
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: no
---

# Flytinnhold

Flytinnhold refererer til e-poster og skjemaer som brukes i en flyt.

Du kan forberede innholdet enten før eller etter at du designer flyten. Det er også opp til deg om separate brukere arbeider med innholdsproduksjon og flytkonfigurasjon, eller om en enkelt bruker håndterer begge oppgaver.

## Trinn for å vise forberedt innhold

For å se det forberedte innholdet for en spesifikk flyt:

1. Gå til **Markedsføring** > **Flyter**.
1. Dobbeltklikk for å velge en flyt.
1. Velg fanen **Flytinnhold**.

![Innhold av velkomst-e-postflyt -screenshot][img1]

## Opprette nytt innhold

### Opprett e-post som flytredaktør

1. På **Flytinnhold**-fanen, nederst til venstre, angi et navn for den nye e-posten og klikk **Opprett**. Dette åpner veiviseren på **Mal**-trinnet.

    ![Flytinnhold - opprett ny e-post -screenshot][img3]

1. Velg en mal og klikk **Neste**.

    ![Flytinnhold - velg mal -screenshot][img4]

1. Lag e-posten (som du ville gjort med en klassisk utsendelse).

    ![Flytinnhold - skriv e-post -screenshot][img5]

    * [Legg til innhold][3], [Rediger et avsnitt][4]
    * [Sett inn kundespesifikk informasjon][5]
    * [Sett inn sporingslenke][6]
    * [Legg til abonnementslenker][8] for å være GDPR-kompatibel
    * [Legg til bilder i meldingen][2]

    > [!NOTE]
    > Hvis du vil handle basert på lenkeklikk (f.eks. som en trigger, splitt, eller ventekondisjon), må lenken spores.

1. Lukk e-posttrinnet og klikk **Lagre**.

### Opprett e-post som flytadministrator

1. Åpne dialogvindu for å redigere flyt og gå til e-posttrinnet.

    ![Flyttrinn - opprett ny e-post -screenshot][img6]

1. Velg en mal og lag e-posten som beskrevet ovenfor (start på trinn 2).

> [!NOTE]
> Du kan ikke klikke **Rediger** hvis flyten kjører. Hvis du ikke ønsker å pause flyten mens du forbereder mer innhold, kan du opprette og forberede et nytt stykke innhold fra **Flytinnhold**-fanen.

### Opprett skjema

For å opprette et skjema, gå til **Markedsføring** > **Skjemaer**. For detaljer, se [Opprett skjema][1].

## Legg til flytinnhold i e-posttrinn

1. Åpne dialogvindu for å redigere flyt.
1. Klikk for å velge e-posttrinnet der du ønsker å legge til innhold.
1. Velg **Velg eksisterende e-post for dette trinnet**. Klikk for å velge en forberedt e-post.
1. Eventuelt, velg **Oppgave** > **Endre** i e-postforhåndsvisningen for å oppdatere innholdet.
1. Lukk e-posttrinnet og klikk **Lagre**.

![Send-e-posttrinn med innhold, emne og vedlegg -screenshot][img2]

## Rediger forberedt innhold

> [!NOTE]
> Du kan ikke redigere flytinnhold som er inkludert i et trinn uten å stoppe flyten.

**Som flytredaktør:**

1. På **Flytinnhold**-fanen, klikk på menyknappen ![ikon][img11] på e-posten du ønsker å oppdatere og velg **Rediger**.

**Som flytadministrator:**

1. Åpne dialogvindu for å redigere flyt og gå til e-posttrinnet.
1. I e-postforhåndsvisningen:
    * Velg **Oppgave** > **Endre** for å oppdatere innholdet.
    * Velg **Oppgave** > **Gi nytt navn** for å endre e-postens navn.
    * Klikk på den røde X-en for å fjerne e-posten (slik at du kan erstatte den med en annen).

<!-- Referenced links -->
[1]: ../../forms/learn/create.md
[2]: ../../editor/learn/insert-images-in-message.md
[3]: ../../editor/learn/add-content.md
[4]: ../../editor/learn/edit-paragraph.md
[5]: ../../editor/learn/add-merge-tag.md
[6]: ../../editor/learn/add-tracked-link-to-msg.md
[8]: ../../editor/learn/add-unsubscribe-link.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-flow-contents.png
[img2]: ../../../../media/loc/en/marketing/send-email-welcome-with-attachment.png
[img3]: ../../../../media/loc/en/marketing/create-new-email-in-flow.png
[img4]: ../../../../media/loc/en/marketing/choose-flow-email-template.png
[img5]: ../../../../media/loc/en/marketing/flow-email-content-compose.png
[img6]: ../../../../media/loc/en/marketing/flow-send-email-new.png
[img11]: ../../../../media/icons/btn-menu.png
