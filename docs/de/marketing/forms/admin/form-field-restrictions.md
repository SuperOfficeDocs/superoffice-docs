---
uid: help-de-marketing-forms-field-restrictions
title: Einschränkungen für Formularfelder
description: Erfahren Sie, wie Sie steuern können, welche Felder in Formularen verfügbar sind und ob Formularübermittlungen vorhandene Daten in diesen Feldern überschreiben können.
keywords: Einschränkungen für Formularfelder, Formular, Feld, nicht überschreiben, überschreiben, nicht in Formularen anzeigen
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
---

# Einschränkungen für Formularfelder

Mit Einschränkungen für Formularfelder können Sie steuern, welche Felder in Formularen verfügbar sind und ob eine Formularübermittlung vorhandene Daten in diesen Feldern überschreiben kann.

Standardmäßig überschreiben Formularübermittlungen keine vorhandenen Daten. Die Person, die das Formular erstellt, kann das Überschreiben für einzelne Felder aktivieren. Mit Feldeinschränkungen können Sie diese Option für sensible Felder entfernen oder verhindern, dass ein Feld im Formulareditor angezeigt wird.

> [!CAUTION]
> Formulare auf einer Website können von jedem ausgefüllt werden. Das Zulassen von Überschreibungen birgt Risiken, darunter unbeabsichtigter Datenverlust, unbefugte Änderungen an sensiblen Feldern und eine Beeinträchtigung der Datenintegrität durch falsche Eingaben. Behandeln Sie sensible Felder sorgfältig.

## Einschränkungen für Felder verwalten

Feldeinschränkungen werden in **Einstellungen und Verwaltung** konfiguriert und erfordern Administratorrechte.

1. Gehen Sie zu **Einstellungen und Verwaltung**.
1. Wählen Sie <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** im Navigator aus.
1. Wählen Sie die Registerkarte **Einschränkungen für Formularfelder** aus.

![Admin Marketing - Einschränkungen für in Marketing-Formularen sichtbare Felder festlegen -screenshot][img1]

## Feldeinschränkung hinzufügen

1. Wählen Sie im Bereich **Felder mit Einschränkungen** ein Feld aus der Dropdown-Liste aus.
1. Wählen Sie den Einschränkungstyp für das Feld aus.
1. Wählen Sie **Speichern** aus.

Wiederholen Sie diese Schritte, um Einschränkungen für weitere Felder hinzuzufügen.

## Einschränkungsoptionen

* **Nicht überschreiben:** Die Option zum Überschreiben wird für dieses Feld in allen Formularen entfernt, einschließlich bereits veröffentlichter Formulare. Das Feld bleibt im Formulareditor verfügbar und kann weiterhin zu Formularen hinzugefügt werden, aber übermittelte Daten überschreiben niemals vorhandene Werte.

* **Nicht in Formularen anzeigen:** Das Feld wird vollständig aus dem Formulareditor entfernt und kann neuen Formularen nicht hinzugefügt werden. Bereits veröffentlichte Formulare, die das Feld bereits enthalten, sind davon nicht betroffen.

## Feldeinschränkung entfernen

1. Suchen Sie das Feld in der Liste **Felder mit Einschränkungen**.
1. Wählen Sie das Entfernen-Symbol (<i class="ph ph-x-circle" aria-hidden="true"></i>) neben dem Feld aus.
1. Wählen Sie **Speichern** aus.

Das Entfernen einer Einschränkung stellt das Standardverhalten wieder her. Das Feld steht im Formulareditor wieder zur Verfügung, und der Formulareigentümer kann entscheiden, ob das Überschreiben erlaubt werden soll.

## Verwandte Inhalte

* [Feldoptionen][1]
* [Ein neues Formular erstellen][2]
* [Schriftarten für Formulare verwalten][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
