---
uid: help-da-flow-content
title: Flowindhold
description: Flowindhold
keywords: Marketing, flow, flowindhold, indhold, e-mail
author: Bergfrid Dias, Trude Lien Smedbråten
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Flowindhold

Flowindhold er e-mails (og formularer), der bruges i et flow.

Det er ligegyldigt, om du forbereder indholdet først eller efter design af flowet. Desuden er det op til dig, om forskellige brugere arbejder med indhold og flow-konfiguration - eller om den samme bruger forbereder det hele.

## Trin

For at se det forberedte indhold til et specifikt flow:

1. Gå til **Marketing** > **Flows**.
1. Dobbeltklik for at vælge et flow.
1. Vælg fanen **Flowindhold**.

![Indhold af velkomst-e-mail flow -screenshot][img1]

## Opret nyt indhold

### Opret e-mail - som en flow-redaktør

1. På fanen **Flowindhold**, nederst til venstre, indtast et navn til den nye e-mail og klik **Opret**. Dette åbner udsendelses-wizarden ved **Skabelon**-trinnet.

    ![Flowindhold - opret ny e-mail -screenshot][img3]

1. Vælg en skabelon og klik **Næste**.

    ![Flowindhold - vælg skabelon -screenshot][img4]

1. Skriv e-mailen (som du ville en klassisk udsendelse).

    ![Flowindhold - skriv -screenshot][img5]

    * [Tilføj indhold][3], [Rediger et afsnit][4]
    * [Indsæt kundespecifik information][5]
    * [Indsæt tracking-link][6]
    * [Tilføj abonnement-links][8] for at være GDPR-kompatibel
    * [Tilføj billeder til meddelelsen][2]

    > [!NOTE]
    > Hvis du vil handle på baggrund af linkklik (f.eks. som en trigger, split eller ventebetingelse), skal linket spores.

1. Luk e-mail-trinnet og klik **Gem**.

### Opret e-mail - som en flow-administrator

1. Åbn Floweditoren og gå til e-mail-trinnet.

    ![Flow-trin - opret ny e-mail -screenshot][img6]

2. Vælg en skabelon og skriv e-mailen som beskrevet ovenfor (startende på trin 2).

> [!NOTE]
> Du kan ikke klikke **Rediger** hvis flowet kører. Hvis du ikke ønsker at sætte flowet på pause, mens du forbereder mere indhold, kan du oprette og forberede et nyt indholdsstykke fra fanen **Flowindhold**.

### Opret formular

Gå til **Marketing** > **Forms**. For detaljer, se [Opret formular][1].

## Tilføj flowindhold til e-mail-trin

1. Åbn Floweditoren.
1. Klik for at vælge det e-mail-trin, hvor du ønsker at tilføje indhold.
1. Vælg **Vælg eksisterende e-mail til dette trin**. Klik for at vælge en forberedt e-mail.
1. Valgfrit, vælg **Opgave** > **Rediger** i e-mail-forhåndsvisningen for at opdatere indholdet.
1. Luk e-mail-trinnet og klik **Gem**.

![Send e-mail trin med indhold, emne og vedhæftning -screenshot][img2]

## Rediger forberedt indhold

> [!NOTE]
> Du kan ikke redigere flowindhold, der er inkluderet i et trin uden at sætte flowet på pause.

**Som en flow-redaktør:**

1. På fanen **Flowindhold**, klik på menuknappen ![ikon][img11] på den e-mail, du ønsker at opdatere og vælg **Rediger**.

**Som en flow-administrator:**

1. Åbn Floweditoren og gå til e-mail-trinnet.
1. I e-mail-forhåndsvisningen:
    * Vælg **Opgave** > **Rediger** for at ændre indholdet.
    * Vælg **Opgave** > **Omdøb** for at ændre e-mailens navn.
    * Klik på det røde X for at slette e-mailen (så du kan erstatte den med en anden).

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
