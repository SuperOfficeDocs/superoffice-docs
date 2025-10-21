---
uid: help-de-document-template-defaults
title: Standardwerte für neue Dokumentvorlagen
description: Standardwerte für neue Dokumentvorlagen
keywords: Nummernzuweisung, neuer Zähler, Dokumentvorlage Zähler, Standardwerte
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/options/learn/number-allocation/document-template-defaults
language: de
---

# Standardwerte für neue Dokumentvorlagen

Bei Bedarf können Sie [Standardwerte][1] für neue Dokumentvorlagen festlegen. Das bedeutet, dass der Wert im Feld **Unser Zeichen** in dem Dialogfeld Dokument bei jeder Verwendung genau dieser Vorlage um 1 erhöht wird. Wenn Sie das Kontrollkästchen **Automatisch einen neuen Zähler für neue Dokumentvorlagen erstellen** nicht aktivieren, wird derselbe Zähler für alle Dokumentvorlagen verwendet, so dass der Wert im Feld **Unser Zeichen** sich jedes Mal um 1 erhöht, wenn eine der Vorlagen verwendet wird.

> [!NOTE]
> Ob das Feld **Unser Zeichen** im Dialogfeld Dokument als Zähler fungiert, hängt davon ab, ob die {snum} Vorlagenvariabel in der betreffenden Vorlage festgelegt wurde. Dies wird in der Ansicht Listen festgelegt: Klicken Sie auf **Dokumentvorlage**, doppelklicken Sie dann auf die Dokumentvorlage unter **Objekte** und bearbeiten das Feld **Unser Zeichen (Standard)** im Dialogfeld **Listenobjekt bearbeiten**.

## Festlegen, dass neue Dokumentvorlagen ihre eigenen Zähler haben

1. Gehen Sie zu Einstellungen und Verwaltung und wählen Sie <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Optionen** aus.

1. Wählen Sie die Registerkarte **Nummernzuweisung**.

1. Aktivieren Sie im unteren Bereich der Registerkarte das Kontrollkästchen **Automatisch einen neuen Zähler für neue Dokumentvorlagen erstellen**.

1. Klicken Sie auf **Standards**.

1. Aktivieren Sie die Option **Eindeutig**, wenn Sie möchten, dass die Werte im Feld **Unser Zeichen** eindeutig sind. Dies ist nützlich, wenn SuperOffice CRM-Benutzer selbst Werte zuweisen.

1. Aktivieren Sie **Leerzeichen erlaubt**, um leere Zählerfelder zuzulassen. Dies ist nützlich, wenn die Zählerwerte eindeutig sein müssen. Für leere Felder gilt nämlich die Einschränkung der Eindeutigkeit nicht.

1. Aktivieren Sie die Option **Schreibgeschützt**, wenn Sie nicht möchten, dass die SuperOffice CRM-Benutzer selbst Werte in das Feld **Unser Zeichen** eingeben können.

1. Aktivieren Sie **Zuweisen**, um die automatische Zählerfunktion zu verwenden. Das System vergibt dann automatisch die Werte im Feld **Unser Zeichen**.

    [Sehen Sie sich die Ergebnisse verschiedener Kombinationen dieser Werte an][1].

1. Geben Sie den Wert, bei dem der Zähler beginnen soll, im Feld **Nächste Nummer** ein.

1. Klicken Sie auf **Speichern**.

<!-- Referenced links -->
[1]: ../../../admin/options/learn/number-allocation/index.md

<!-- Referenced images -->
