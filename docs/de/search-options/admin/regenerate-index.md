---
uid: help-de-free-text-index-regen
title: Volltextindex erneuern
description: Volltextindex neu generieren
keywords: Volltext, Suchindex
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
deployment: onsite
redirect_from: /de/admin/options/learn/freetext-search/regenerate-index
---

# Volltextindex erneuern (Vor Ort)

> [!NOTE]
> Diese Registerkarte ist nur verfügbar, wenn Ihre SuperOffice-Installation Onsite (vor Ort) ist. Wenn Sie die Online-Lösung verwenden, können Sie an diesen Einstellungen keine Änderungen vornehmen. Für SuperOffice Online wird der Freitext-Index standardmäßig alle 7 Tage neu generiert.
>
> Damit Sie einen Volltextindex erstellen können, müssen Sie zur Rolle **Benutzerebene 0** (oder gleichwertig) gehören. Bei Oracle-Datenbanken müssen Sie der Benutzer sein, der Datenbankbesitzer ist.

Wenn Sie [neue Stoppwörter hinzufügen oder löschen][1], haben Ihre Änderungen keine rückwirkende Wirkung. Wenn Sie also beispielsweise das Wort *und* als Stoppwort eintragen und das Wort *und*bereits häufig in der Datenbank vorkommt, wird es nicht automatisch aus dem Volltextindex entfernt. Die Änderung gilt nur für Treffer des Worts *und*, die Sie von jetzt an hinzufügen. In einigen Fällen kann es daher sinnvoll sein, den Volltextindex zu aktualisieren, so dass alle Stoppwörter daraus entfernt werden.

## Um den Volltextindex zu erneuern

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Stellen Sie sicher, dass die Option **Volltextsuche ermöglichen** ausgewählt ist.

1. Klicken Sie auf die Schaltfläche **Index neu erstellen**.

1. Sie erhalten nun die Mitteilung, dass es einige Zeit dauern kann, einen neuen Index zu erstellen, und dass die Benutzer in diesem Zeitraum nicht auf die Volltextsuchfunktion zugreifen können. Klicken Sie auf **OK**. Daraufhin wird ein Fenster geöffnet, das den Status der Generierung anzeigt. Wenn dieses Fenster verschwindet, ist der neue Volltextindex erstellt.

<!-- Referenced links -->
[1]: stopwords.md

<!-- Referenced images -->
