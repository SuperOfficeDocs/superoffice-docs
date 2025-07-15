---
uid: help-sv-request-type-create
title: Skapa ärendetyp
description: Lär dig hur du skapar en ärendetyp i SuperOffice Service.
keywords: skapa ärendetyp, ny ärendetyp, lägg till ärendetyp, ärendetyp, fliken Ärendetyper, typ, ärende
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/request/learn/type/create
index: true
---

# Skapa ärendetyp

## Steg

1. I Inställningar och underhåll, välj **Ärenden** i navigatören.

1. Gå till fliken **Ärendetyper**.

1. Klicka på **Lägg till**-knappen.

    ![Inställningar och underhåll, ärendetyper -screenshot][img1]

1. Ange ett kort och beskrivande **Namn** för den nya ärendetypen. Du kan lägga till fler detaljer i fältet **Beskrivning**.

1. Valfritt: Ändra ikonen för att visuellt särskilja ärenden av denna typ från andra ärenden.

1. Markera **Använd som standard** om du vill att denna ärendetyp ska vara standard för alla nya ärenden.

1. Valfritt: Filtrera listan över tillgängliga statusar och/eller prioriteter för ärenden av denna typ.

    * För att tillåta vilken [status][4] eller [prioritet][3] som helst, lämna tillgänglighetsfältet tomt.
    * Om du väljer en eller flera statusar måste du även välja en standardstatus.
    * Om du väljer en eller flera prioriteter måste du även välja en standardprioritet.

    ![Inställningar och underhåll, ärendetypens status/prioritet -screenshot][img3]

1. Valfritt: Välj en standardstatus och/eller prioritet att använda när en agent skapar ett ärende av denna typ. *(Obligatoriskt om du har begränsat tillgängliga alternativ.)* Denna inställning har högre prioritet än andra preferenser.

1. Valfritt: Välj en [svarsmall][5] som ska användas när en agent svarar på ett ärende av denna typ.

1. Klicka på **Spara**. Ärendetypen har nu skapats.

<!-- Refererade länkar -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../../knowledge-base/learn/reply-templates/index.md

<!-- Refererade bilder -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img3]: ../../../../media/loc/en/request/edit-request-type-values.png
