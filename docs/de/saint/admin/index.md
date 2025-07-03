---
uid: help-de-saint-admin
title: SAINT festlegen
description: Lernen Sie in dieser Anleitung, wie Sie SuperOffice SAINT festlegen.
keywords: SAINT, Statuskontrollen
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/sale/saint/learn/admin/index
---

# SAINT festlegen

Sie können Ihre Kunden mit SAINT (steht für Sales Intelligence) proaktiv betreuen. SuperOffice SAINT kann auf viele Weisen und für viele verschiedene Prozesse verwendet werden. Bevor Sie die SAINT-Funktion erfolgreich implementieren, ist es wichtig zu wissen, was Sie verbessern möchten und wie Sie dies untersuchen können.

Wenn Sie wissen, was Sie verbessern möchten, sollten Sie die Aktion nachdenken, die Ihre Firma ergreifen kann, um die vorhandene Situation zu verbessern. Welche Aktion werden Sie unternehmen?

* Senden Sie ein Gruppenkampagne mit SuperOffice Kampagnen
* Rufen Sie alle Kunden in der SAINT-Auswahl an
* Verfolgen Sie alle Anfragen

[!include[Requirement](../includes/note-saint-req.md)]

Mit der Registerkarte **Statuskontrollen/SAINT** können Sie Statusangaben für Firmen, Personen und Projekte erstellen. Statuskontrollen stellen die Funktionalität hinter dem SAINT-Konzept (Sales Intelligence) dar. Dies erleichtert die Folgeaufgaben für Firmen, Personen und Projekte und das Bereitstellen von sinnvolleren Suchoptionen in SuperOffice CRM.

## Statusbilder

Ein Status kann als Bilder auf den Karten der Projekte, Personen oder Firmen angezeigt werden, die Ihre Kriterien erfüllen. Das Statusbild für einen Kunden, mit dem Sie längere Zeit keinen Kontakt hatten, könnte zum Beispiel ein Spinnennetz sein. Dies ist ein visueller und sofortiger Hinweis für die aktuelle Beziehung zum Kunden oder für den Fortschritt eines Projekts. Wenn der Benutzer auf ein Statusbild in SuperOffice CRM klickt oder den Mauszeiger darüber hält, wird ein Teil des Textes angezeigt, um zum Beispiel die Aktionen anzugeben, die ausgeführt werden sollen (Sie selbst geben Status ein, wenn Sie den Text erstellen).

## Standardfolgeaufgabe für einen Status

Wenn der Benutzer das Statusdialogfeld in SuperOffice CRM öffnet, kann er auch eine Folgeaufgabe für den betreffenden Status erstellen. Der Folgeaufgabentyp und -text kann voreingestellt sein.

### Beispiel

Ein Status könnte sich zum Beispiel auf Firmen beziehen, die folgende Kriterien erfüllen:

* Kategorie = Kunde
* Letzter Verkauf älter als 2 Monate
* Anzahl der Verkäufe größer als 50

Der Text im Feld **Beschreibung** könnte wie folgt lauten:

"&lt;name&gt; war früher ein guter Kunde, aber wir haben seit 2 Monaten nichts mehr an sie verkauft. &lt;cont&gt; ist die Hauptperson für diesen Kunden und sollte sich demnächst telefonisch (&lt;cpho&gt;) oder per E-Mail (&lt;mail&gt;) mit dem Kunden in Verbindung setzen, um den Grund herauszufinden."

In diesem Beispiel wird der Text mit den folgenden Vorlagenvariablen an die entsprechende Firma angepasst:

| Variable | Beschreibung |
|---|---|
| Name | Der Name der Firma |
| cont | Der Name der Person für die Firma |
| cpho | Telefonnummer der Firma |
| mail | E-Mail-Adresse der Firma |

## Suchen und Selektionen

Statusangaben und Zähler können in Suchen und für das Erstellen dynamischer Selektionen verwendet werden. Sie können zum Beispiel nach Firmen, Personen oder Projekten, die einem Status oder Zähler entsprechen, suchen. [!include[Define counter](../includes/def-counter.md)]

Sie können 3 verschiedene Zähler/Zeiträume einrichten. Diese Zähler sind die Anzahl der Tage, die Sie für Aktivitäten, Verkäufe und Anfragen zählen möchten. Die verschiedenen Zeiträume werden nach dem festgelegt, was für Sie wichtig ist. Wenn Sie zum Beispiel benachrichtigt werden möchten, wenn einige Ihrer Kunden im letzten Monat (30 Tage) keine Aktivitäten hatten oder wenn es ungelöste Anfragen für die Kunden gibt, die älter als 30 Tage sind.

## Zeiträume

Sie können bis zu drei unterschiedliche Zeiträume für Zähler festlegen, sodass Sie die SAINT-Kriterien kürzere bzw. längere Zeiträume abdecken können. Wenn Sie jeweils drei Zeiträume von 30, 60 und 90 Tagen festlegen, können Sie SAINT-Kriterien für jeden dieser Zeiträume wählen.

## Neuen Status erstellen

Loggen Sie sich zunächst bei SuperOffice CRM ein, gehen Sie zum Hauptmenü in der oberen rechten Ecke, öffnen Sie Einstellungen und Verwaltung und klicken Sie im Navigator auf SAINT. Dort können Sie Ihre Sales Intelligence und Statuskontrollen einrichten.

Wie man einen Status erstellt:

1. [Neuen Status erstellen][1]
1. [Bild für einen Status auswählen][2]
1. [Standardfolgeaufgabe für einen Status auswählen][3]
1. [Statuskriterien festlegen][4]
1. [Zeitraum festlegen][5]

Sie können jetzt zu SuperOffice CRM zurückkehren und eine neue dynamische Selektion öffnen, um alle nachverfolgten Personen zu sehen.

Stellen Sie sicher, dass Sie Ihre SAINT-Kriterien hinzufügen. Klicken Sie auf Hinzufügen und dann neben das Feld und wählen Sie Firma – Zähler (SAINT) aus. Suchen Sie Ihre SAINT-Statuskontrolle. In unserem Beispiel wählen wir Vernachlässigte Kunden aus und klicken auf OK. Aktualisieren Sie Ihre Auswahl, damit Sie genau wissen, welche Kunden nachverfolgt werden müssen.

## Status wiederherstellen und bearbeiten

* [Gelöschten Status wiederherstellen][6]
* [Statusbeschreibung bearbeiten][7]

## Statuskontrollen verwalten und pflegen

* [Statuskontrollen verwalten][8]

<!-- Referenced links -->
[1]: create-status.md
[2]: select-image-for-status.md
[3]: select-default-follow-up-type-for-status.md
[4]: select-status-criteria.md
[5]: select-period-length.md
[6]: restore-status.md
[7]: edit-status.md
[8]: manage-status-monitors.md

<!-- Referenced images -->
