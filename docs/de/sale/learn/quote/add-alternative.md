---
uid: help-de-quote-alternatives
title: Alternative zu Angebot hinzufügen
description: Erfahren Sie, wie Sie in SuperOffice CRM Angebotsalternativen erstellen und verwalten, um mehrere Vorschläge zu unterbreiten.
keywords: Angebot, Angebotsalternative
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Alternativen zum Angebot hinzufügen

Nutzen Sie Alternativen, um verschiedene Kombinationen von Produkten, Mengen oder Preisen innerhalb desselben Angebots anzubieten. Jede Alternative erscheint als eigene Registerkarte im Dialogfeld **Angebot bearbeiten**.

Sie können eine neue Alternative von Grund auf neu erstellen oder eine bestehende kopieren.

> [!NOTE]
> [Alternativen müssen für den Verkaufstyp in Einstellungen und Verwaltung aktiviert sein][3]. Wenn die Registerkarte **+** nicht sichtbar ist, wählen Sie einen anderen Verkaufstyp oder aktivieren Sie die Einstellung. Sie können auch nur eine Alternative im Angebot einbeziehen.

## Alternative erstellen oder kopieren

1. Öffnen Sie in der Bereichsregisterkarte **Angebot** den Verkauf und klicken Sie auf **Öffnen**, um das Angebot zu bearbeiten.

    Das Angebot muss sich im Status **Entwurf** befinden. Wenn es bereits gesendet wurde, [erstellen Sie eine neue Version][1].

1. Klicken Sie auf die Registerkarte **+** neben der letzten Alternative.

1. Wählen Sie eine der folgenden Optionen:

    * **Neue Alternative erstellen:** Beginnen Sie von Grund auf neu (ohne Produkte).
    * **Alternative kopieren:** Kopieren Sie eine bestehende Alternative einschließlich der Produkte.

1. Geben Sie im Feld **Name** einen Namen für die neue Alternative ein. Diese wird zum Registerkartennamen.

1. Klicken Sie auf **Hinzufügen**. Die neue Alternative wird als eigene Registerkarte angezeigt.

1. [Fügen Sie Produkte zur neuen Alternative hinzu][2].

1. Optional: Klicken Sie auf <i class="ph ph-star" aria-label="Star icon"></i> **Favorisierte Alternative** unten auf der Registerkarte, um diese Alternative als neuen Favoriten festzulegen.

    Geschätzte Verkaufsbeträge für den Verkauf (Prognosen) stammen vom Gesamtbetrag für die favorisierte Alternative.

## Alternative umbenennen oder löschen

1. Wählen Sie die Registerkarte der Alternative, die Sie aktualisieren möchten.

1. Klicken Sie unten links auf <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i>, um das Aufgabenmenü zu öffnen.

1. Wählen Sie eine der folgenden Optionen:

    * **Alternative umbenennen:** Geben Sie einen neuen Namen ein und drücken Sie **Enter**.
    * **\[Alternative\] löschen:** Bestätigen Sie das Löschen im Dialogfeld.

> [!NOTE]
> Das Symbol <i class="ph ph-trash" aria-hidden="true"></i> unterhalb der Produktliste löscht nur ausgewählte **Produktzeilen**, nicht ganze Alternativen.

<!-- Referenced links -->
[1]: send.md#versions
[2]: create.md#add-products
[3]: ../../admin/sale-type.md#quote-fields
