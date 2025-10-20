---
uid: help-de-stopwords
title: Stoppwörter
description: Stoppwörter
keywords: Volltext, Suchen, Stoppwort
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
redirect_from: /de/admin/options/learn/freetext-search/stopwords
---

# Stoppwörter

Ein Stoppwort ist ein Wort, das nicht indiziert ist (d.h. nicht in eine Volltextsuche aufgenommen wird). Dies können beispielsweise Wörter wie *und*, *oder*, *es* und *für* sein. Stoppwörter werden definiert, damit es nicht so lange dauert, den Volltextindex zu durchsuchen, da unnötige Wörter ausgeschlossen werden und somit weniger Platz in der Datenbank belegt wird.

Die als Stoppwörter für Volltextsuchen definierten Wörter werden in der Ansicht Optionen auf der Registerkarte **Volltextsuche** in der Tabelle unter **Stoppwortliste** angezeigt.

## Bevor Sie beginnen

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Stellen Sie bei lokalen Installationen sicher, dass die Option **Freetext-Suche aktivieren** ausgewählt ist. In CRM Online ist diese Option immer aktiviert.

> [!TIP]
> Wenn Sie möchten, dass Ihre Änderungen einen rückwirkenden Effekt haben, müssen Sie den [Volltextindex erneuern][3]. Tun Sie dies, nachdem Sie Stoppwörter hinzugefügt haben, nachdem das System Stoppwörter vorgeschlagen hat oder nachdem Sie eine große Textmenge importiert haben.

## Stoppwörter hinzufügen

1. Klicken Sie unter der Stoppwortliste auf die Schaltfläche **Hinzu**.

1. Geben Sie eines oder mehrere Stoppwörter, die Sie hinzufügen möchten, in das Dialogfeld **Neue Stoppwörter** ein. Sie können alle Zeichen mit Ausnahme des Punkts als Trennzeichen eingeben.

1. Klicken Sie auf **Speichern**.

1. Sie erhalten die Meldung, dass Änderungen in der Stoppwortliste keinen rückwirkenden Effekt haben. Das heißt, neue Stoppwörter gelten nicht für Text, der vor dem Angeben des Stoppworts eingegeben wurde. Klicken Sie auf **OK**.

## Stoppwörter vorschlagen

Anstatt die Stoppwörter manuell einzugeben, können Sie sich auch Stoppwörter vom System vorschlagen lassen.

1. Klicken Sie unter der Stoppwortliste auf die Schaltfläche **Vorschlag**.

1. Sie erhalten die Meldung, dass es einige Zeit dauern kann, die Wortliste und den Index zu durchsuchen, um mögliche Stoppwörter zu finden. Klicken Sie auf **OK**.

1. Wenn das System mögliche Stoppwörter gefunden hat, werden diese im Dialogfeld **Neue Stoppwörter** angezeigt. Die in der Datenbank am häufigsten verwendeten Wörter werden am Anfang der Liste angezeigt. Prüfen Sie die Wörter, die Sie als Stoppwörter hinzufügen möchten. Halten Sie die **Strg**-Taste gedrückt und klicken Sie auf das entsprechende Stoppwort.

1. Klicken Sie auf **Speichern**.

1. Sie erhalten die Meldung, dass Änderungen in der Stoppwortliste keinen rückwirkenden Effekt haben, d.h., neue Stoppwörter gelten nicht für Felder, die vor den Stoppwörtern festgelegt wurden. Klicken Sie auf **OK**.

## Stoppwörter löschen

Stoppwörter werden gelöscht, damit sie nach dem Ausschließen doch in die Volltextsuche aufgenommen werden. So löschen Sie ein Stoppwort aus der Liste:

1. Wählen Sie das gewünschte Stoppwort.

1. Klicken Sie unter der Firmenliste auf die Schaltfläche **Löschen**.

<!-- Referenced links -->
[3]: regenerate-index.md

<!-- Referenced images -->
