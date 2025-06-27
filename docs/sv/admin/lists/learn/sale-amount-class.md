---
uid: help-sv-sale-amount-class
title: Lägg till beloppsklass för försäljning
description: Lägg till beloppsklass för försäljning
author: SuperOffice RnD
date: 06.29.2022
keywords: försäljning, belopp
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägg till beloppsklass för försäljning

[!include[Must be admin](../../../learn/includes/req-admin.md)]

> [!NOTE]
> Listan **Försäljning - Beloppsklass** är en del av funktionen för statusövervakningen (SAINT), vilken kräver en **Sales Premium** eller **Service Premium** användarlicens.

En beloppsklass för en försäljning kan användas för att dela in försäljningar i olika kategorier, till exempel små, medelstora, stora och mycket stora. Specificera beloppsintervall för olika beloppsklasser i den valuta som ditt företag använder (och andra valutor om det behövs). Beloppsklasserna kan användas för att söka efter viktiga förlorade försäljningar under en period.

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] när posterna är beloppsklasser:

1. Skriv in namnet på posten i fältet **Namn**.

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

2. I fälten **Belopp från** och **Belopp till** kan du ange intervall för de försäljningar som ska placeras i den här kategorin. Beloppet måste anges i den valuta ditt företag använder.

    > [!NOTE]
    > Beloppsintervallet får inte överlappa intervallen för befintliga beloppsklasser.

3. Välj den valuta ditt företag använder i listan **Valuta**. Du kan lägga till flera beloppsklasser med andra valutor om det behövs i ditt företag.

4. Du kan också lägga till en beskrivning av beloppsklassen i fältet **Beskrivning**.

5. [!include[Save or cancel](includes/save-or-cancel.md)]
