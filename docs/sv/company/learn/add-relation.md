---
uid: help-sv-company-add-relation
title: Lägg till relation
description: Lägg till relation
author: SuperOffice RnD
date: 06.29.2022
keywords: företag
topic: howto
language: sv
---

# Lägg till en relation(fönstret Företag)

> [!NOTE]
> En relation ska alltid bestå av två parter där den ena parten är aktiv och den andra är passiv. Exempel: Företag A äger företag B, medan företag B ägs av företag A.

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Välj detaljkortet **Relationer**.

1. Klicka på **Lägg till**-knappen under detaljkortet. Dialogrutan **Relation** öppnas.

    ![Dialogrutan Relationer -screenshot][img2]

1. Du måste ange ett företag i listrutan **Företag** under **Aktiv**. Detta är obligatoriskt.

    Ange informationen antingen genom att klicka på pilen och välja ett företag i listrutan som visas, genom att skriva in hela eller början på företagsnamnet.

1. Ange eventuellt en kontakt i listrutan **Kontakt** under **Aktiv**. Till exempel om en kontakt på Företag A är en tidigare kollega till en kontakt på Företag B.

1. I listrutan **Företag** under **Passiv** anger du det företag som är den passiva parten i relationen. Gör på samma sätt som under **Aktiv**.

1. I listrutan **Kontakt** under **Passiv** anger du eventuell kontakt hos den passiva parten. Gör på samma sätt som under **Aktiv**.

1. I listrutan **Relation** anger du vilken relation som finns mellan den aktiva och den passiva parten, till exempel "ägare". [!include[SM](../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Vilka alternativ som visas i den här listrutan beror också på om det är en relation mellan två företag, ett företag och en kontakt eller mellan två kontakter.

1. I fältet **Beskrivning** kan du skriva ytterligare information. Om du skriver något här visas en ![ikon][img1] gemsymbol på den aktuella raden på detaljkortet **Relationer**.

1. Fältet **Resultat** uppdateras automatiskt av informationen i fältet **Relation**. Exempel: Om du till exempel väljer "ägare" som relation, visas information om vem som äger vem, och vem som ägs av vem.

1. När du är klar stänger du dialogrutan och sparar informationen genom att klicka på **Spara**.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/icons/binders.png
[img2]: ../../../media/loc/en/company/relation.png
