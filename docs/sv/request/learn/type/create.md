---
uid: help-sv-request-type-create
title: Skapa ärendetyp
description: Skapa ärendetyp
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: ärende, typ
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Skapa ärendetyp (endast i pilot)

## Steg

1. I Inställningar och underhåll, välj **Ärenden** i navigatören.

1. Välj fliken **Ärendetyper**.

1. Klicka på **Lägg till**-knappen.

    ![Inställningar och underhåll, ärendetypen -screenshot][img1]

1. Ange en kort beskrivande **Namn** för den nya ärendetypen. Du kan lägga till fler detaljer i **Beskrivning**-fältet.

1. Valfritt, ändra ikonen för att visuellt särskilja ärenden av denna typ från andra ärenden.

1. Markera **Använd som standard** om du vill att denna ärendentyp ska vara standarden för alla nya ärenden.

1. Valfritt, filtrera listan över tillgängliga statusar och/eller prioriteter för ärenden av denna typ.

    * För att tillåta vilken [status][4] eller [prioritet][3] som helst, lämna tillgänglighetsfältet tomt.
    * Om du väljer en eller flera statusar måste du också välja en standardstatus.
    * Om du väljer en eller flera prioriteter måste du också välja en standardprioritet.

1. Valfritt, välj en standardstatus och/eller prioritet att använda när en agent skapar ett ärende av denna typ. (Obligatorisk om du sätter tillgänglighet.) Denna inställning går före andra preferenser.

1. Valfritt, välj en [svarsmall][5] att använda när en agent svarar på ett ärende av denna typ.

    ![Inställningar och underhåll, Inställningar för ärendentyp -screenshot][img2]

1. Klicka på **Spara**. Ärendetypen är skapad.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png
