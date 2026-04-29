---
uid: help-de-request-relation-rules
title: Beziehungsregeln
description: Erfahren Sie, wie Sie Beziehungsregeln konfigurieren, um das Verhalten bei der Erstellung und Schließung von Anfragen auf Basis von übergeordnet-untergeordnet-Beziehungen in SuperOffice Service zu automatisieren.
keywords: Beziehungsregeln, Anfragebeziehung, übergeordnet-untergeordnet, Beziehungsregel, Automatisierung, Anfrage schließen, Registerkarte Beziehungsregeln
author: digitaldiina
date: 04.08.2026
version: 11.12
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: de
index: true
---

# Beziehungsregeln

Beziehungsregeln definieren automatische Verhaltensweisen, die beim Erstellen oder Schließen von Anfragen angewendet werden, basierend auf übergeordnet-untergeordnet-Beziehungen zwischen bestimmten Anfragetypen. Sie helfen Ihnen, Konsistenz in Ihrem Supportprozess zu gewährleisten — zum Beispiel, indem verhindert wird, dass eine übergeordnete Anfrage geschlossen wird, bis alle untergeordneten Anfragen gelöst sind, oder indem Agenten aufgefordert werden, verwandte Anfragen gemeinsam zu schließen.

> [!NOTE]
> Regeln lösen automatische Aktionen nur in der Benutzeroberfläche für Anfragen aus. API- und CRMScript-Vorgänge sind nicht betroffen.

## Was ist eine Beziehungsregel?

Eine Beziehungsregel besteht aus:

* **Bedingung:** Für welche Anfragetypen die Regel gilt (Quelle und Empfänger).
* **Reaktion:** Was automatisch passiert, wenn passende Anfragen erstellt oder geschlossen werden.

## Wo finde ich Beziehungsregeln?

Wählen Sie **Anfragen** im Navigator in **Einstellungen und Verwaltung** und wechseln Sie zur Registerkarte **Beziehungsregeln**.

![Einstellungen und Verwaltung, Beziehungsregeln -screenshot][img1]

[!include[Eingeschränkter Zugriff](../../learn/includes/note-insufficient-rights.md)]

## Einstellungen

### Bedingung

| Feld | Beschreibung |
|---|---|
| Von (Quelle) | Einen oder mehrere Quellanfragetypen. |
| Beziehung | Der Beziehungstyp (Übergeordnet oder Untergeordnet). |
| An (Empfänger) | Einen oder mehrere Zielanfragetypen. |

Die Zusammenfassungszeile unterhalb der Bedingung bestätigt den vollständigen Umfang der Regel in klarer Sprache. Eine Warnung wird angezeigt, wenn die Bedingung eine vorhandene Regel überschneidet.

### Reaktion: Bei der Erstellung

| Option | Beschreibung |
|---|---|
| **Erfordert die Angabe eines übergeordneten Objekts** | Verhindert das Speichern einer neuen Anfrage, wenn kein übergeordnetes Objekt angegeben wurde. Gilt nur, wenn das Feld **Übergeordnet** im Anfragebildschirm im [Screen Designer][3] hinzugefügt wurde. |

### Reaktion: Beim Schließen

| Option | Beschreibung |
|---|---|
| **Schließen des übergeordneten Objekts verhindern, bis alle untergeordneten Objekte geschlossen sind** | Blockiert das Schließen der übergeordneten Anfrage, solange noch untergeordnete Anfragen offen sind. |
| **Schließen des übergeordneten Objekts anbieten, wenn alle untergeordneten Objekte (Child) geschlossen werden** | Wenn die letzte untergeordnete Anfrage geschlossen wird, wird der Agent aufgefordert, auch die übergeordnete Anfrage zu schließen. |
| **Schließen der untergeordneten Objekte (Child) anbieten und Nachricht senden, wenn das übergeordnete Objekt geschlossen wird** | Wenn die übergeordnete Anfrage geschlossen wird, wird der Agent aufgefordert, alle noch offenen untergeordneten Anfragen zu schließen und eine Antwortnachricht zu jeder hinzuzufügen, die an die jeweiligen Empfänger gesendet wird. |

## Beziehungsregel hinzufügen

1. Wählen Sie **Anfragen** im Navigator in **Einstellungen und Verwaltung** und wechseln Sie zur Registerkarte **Beziehungsregeln**.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

    ![Beziehungsregel hinzufügen -screenshot][img2]

1. Geben Sie einen **Regelnamen** und optional eine **Beschreibung** ein.

1. Im Abschnitt **Bedingung** wählen Sie den **Beziehung**-Typ und anschließend einen oder mehrere Anfragetypen in den Feldern **Von (Quelle)** und **An (Empfänger)**. Die Zusammenfassungszeile unterhalb der Bedingung bestätigt, wofür die Regel gilt.

    > [!NOTE]
    > Wenn die Bedingung eine vorhandene Regel überschneidet, wird eine Konfliktwarnung angezeigt. Passen Sie die Anfragetypen an, um den Konflikt zu lösen, bevor Sie speichern.

1. Im Abschnitt **Reaktion** aktivieren Sie die Optionen, die Sie für **Bei der Erstellung** und **Beim Schließen** aktivieren möchten.

1. Klicken Sie auf **Speichern**.

## Beziehungsregel bearbeiten

1. In der Registerkarte **Beziehungsregeln** klicken Sie auf die Regel in der Liste auf der linken Seite.

1. Nehmen Sie Ihre Änderungen vor.

1. Klicken Sie auf **Speichern**.

## Beziehungsregel löschen

1. In der Registerkarte **Beziehungsregeln** wählen Sie die Regel in der Liste auf der linken Seite.

1. Klicken Sie auf die Schaltfläche **Löschen** am unteren Ende der Liste.

## Beispiel: Vorfallverwaltung

Ein größerer Dienstausfall generiert mehrere einzelne Problemberichte von betroffenen Kunden. Jeder Kundenbericht wird als untergeordnete Anfrage erfasst, die mit einem gemeinsamen Vorfall als übergeordnete Anfrage verknüpft ist.

* **Schließen des übergeordneten Objekts verhindern, bis alle untergeordneten Objekte geschlossen sind:** hält den Vorfall offen, bis jeder Problembericht bearbeitet wurde, und stellt sicher, dass nichts übersehen wird.

* **Schließen des übergeordneten Objekts anbieten, wenn alle untergeordneten Objekte (Child) geschlossen werden:** wenn der letzte Problembericht gelöst ist, wird der Agent aufgefordert, den Vorfall zu schließen.

* **Schließen der untergeordneten Objekte (Child) anbieten und Nachricht senden, wenn das übergeordnete Objekt geschlossen wird:** wenn der Vorfall gelöst ist, kann der Agent alle noch offenen untergeordneten Anfragen auf einmal schließen und eine Antwortnachricht zu jeder hinzufügen, die an die jeweiligen Empfänger gesendet wird.

## Verwandte Inhalte

* [Anfragebeziehungen][1]
* [Anfragetypen][2]

<!-- Referenced links -->
[1]: ../learn/request-relations.md
[2]: type/index.md
[3]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/relation-rules.png
[img2]: ../../../media/loc/en/request/add-relation-rule.png
