---
uid: help-de-service-screen-properties
title: Eigenschaften der Ansichten
description: Eigenschaften der Ansichten
author: SuperOffice RnD
date: 06.29.2022
keywords: Ansicht
content_type: reference
language: de
---

# Eigenschaften der Ansichten

Hier können Sie die Eigenschaften einer Ansicht bearbeiten. Sie können ein Skript zur Vorausberechnung von Variablen erstellen, z. B. basierend auf CGI-Variablen, die die Ansicht über eine URL erhält, oder basierend auf einem Formulareintrag in der aktuellen oder einer anderen Ansicht.

## Eigenschaften

* **Ordner:** Wenn Sie die Ansichten in einer Ordnerstruktur angeordnet haben, klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen einen Ordner aus.
* **Name**: Ein aussagekräftiger Name für den Bildschirm.
* **ID-String**: Eine Zeichenfolge mit einer eindeutigen Bezeichnung der Anzeige, damit diese in URL-Adressen verwendet werden kann.
* **Authentifizierungsschlüssel**: Sie können auch eine kundenspezifische Ansicht ausführen, ohne als Benutzer angemeldet zu sein. Dazu müssen Sie einen Authentifizierungsschlüssel eingeben.
* **Bei Seitenwechsel warnen**: Der Benutzer wird gewarnt, wenn er eine Seite verlässt, die ungespeicherte Daten enthält.
* **Automatisches Speichern verwenden**: Aktivieren Sie die [Funktion automatisches Speichern][1].

## Skripts

* **Ladeskript (vor setFromCgi)**: Dieses Skript wird ausgeführt, bevor den Ansichtselementen ihre Werte zugewiesen werden
* **Ladeskript (nach setFromCgi)**: Dieses Skript wird ausgeführt, nachdem den Ansichtselementen ihre Werte zugewiesen werden
* **Ladeskript (nach allem anderen ausführen)**: Dieses Skript wird zum Schluss ausgeführt, nachdem der Code und die Skripts aller Schaltflächen ausgeführt wurden.
* **Verborgene Variablen**: Die hier definierten Variablen werden beim Senden der Ansicht gespeichert, sodass die nächste Ansicht auf sie zugreifen kann.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
