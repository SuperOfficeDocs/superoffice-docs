---
uid: help-sv-flow-content
title: Flödesinnehåll
description: Flödesinnehåll
keywords: flöde, flödesinnehåll, innehåll, skapa e-post, e-postmeddelande, e-poststeg
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Flödesinnehåll

Flödesinnehåll är e-postmeddelanden (och formulär) som används i ett flöde.

Det spelar ingen roll om du förbereder innehållet först, eller efter att du har designat flödet. Också, oavsett om separata personen arbetar med innehåll och flödets konfiguration - eller om samma person förbereder allt - är upp till dig.

## Steg

För att visa det förberedda innehållet för ett specifikt flöde:

1. Gå till **Marknadsföring** > **Flöden**.
1. Dubbelklicka för att välja ett flöde.
1. Välj fliken **Flödets innehåll**.

![Innehåll i välkomstmejlflöde -screenshot][img1]

## Skapa nytt innehåll

### Skapa e-post - som en flödesredigerare

1. På fliken **Flödets innehåll**, längst ned till vänster, skriv in ett namn för den nya e-posten och klicka på **Skapa**. Detta öppnar E-postguiden vid steget **Mall**.

    ![Flödesinnehåll - skapa ny e-post -screenshot][img3]

1. Välj en mall och klicka på **Nästa**.

    ![Flödesinnehåll - välj mall -screenshot][img4]

1. Skriv e-posten (som du skulle göra med en klassisk e-post).

    ![Flödesinnehåll - skriv -screenshot][img5]

    * [Lägg till innehåll][3], [Redigera ett stycke][4]
    * [Infoga kundspecifik information][5]
    * [Infoga spårningslänk][6]
    * [Lägg till prenumerationslänkar][8] för att vara GDPR-kompatibel
    * [Lägg till bilder i meddelandet][2]

    > [!NOTE]
    > Om du vill agera på länkklick (t.ex. som en trigger, uppdelning eller väntetillstånd), måste länken spåras.

1. Stäng e-poststeget och klicka på **Spara**.

### Skapa e-post - som en flödesadministratör

1. Öppna flödesredigeraren och gå till e-poststeget.

    ![Flödessteg - skapa ny e-post -screenshot][img6]

1. Välj en mall och skriv e-posten som beskrivet ovan (från steg 2).

> [!NOTE]
> Du kan inte klicka på **Redigera** om flödet körs. Om du inte vill pausa flödet medan du förbereder mer innehåll kan du skapa och förbereda ett nytt innehåll från fliken **Flödets innehåll**.

### Skapa formulär

Gå till **Marknadsföring** > **Formulär**. För detaljer, se [Skapa formulär][1].

## Lägg till flödesinnehåll till e-poststeget

1. Öppna flödesredigeraren.
1. Klicka för att välja e-poststeget där du vill lägga till innehåll.
1. Välj **Välj befintlig e-post för detta steg**. Klicka för att välja en förberedd e-post.
1. Välj eventuellt **Uppgift** > **Ändra** i e-postförhandsgranskningen för att uppdatera innehållet.
1. Stäng e-poststeget och klicka på **Spara**.

![Skicka e-poststeg med innehåll, ämne och bilaga -screenshot][img2]

## Redigera förberett innehåll

> [!NOTE]
> Du kan inte redigera flödesinnehåll som är inkluderat i ett steg utan att pausa flödet.

**Som en flödesredigerare:**

1. På fliken **Flödets innehåll**, klicka på menyknappen på den e-post du vill uppdatera och välj **Redigera**.

**Som en flödesadministratör:**

1. Öppna flödesredigeraren och gå till e-poststeget.
1. I e-postförhandsgranskningen:
    * Välj **Uppgift** > **Ändra** för att uppdatera innehållet.
    * Välj **Uppgift** > **Byt namn** för att ändra e-postens namn.
    * Klicka på den röda X:et för att ta bort e-postmeddelandet (så att du kan ersätta det med ett annat).

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
