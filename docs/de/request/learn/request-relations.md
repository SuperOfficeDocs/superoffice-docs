---
uid: help-de-request-relations
title: Anfragebeziehungen
description: Erfahren Sie, wie Sie verwandte Anfragen mithilfe von übergeordneten, untergeordneten und verknüpften Beziehungen verknüpfen können, um verbundene Probleme in SuperOffice Service besser zu verfolgen und zu verwalten.
keywords: Anfragebeziehungen, Anfragen verknüpfen, übergeordnete Anfrage, untergeordnete Anfrage, verknüpfte Anfragen
author: digitaldiina
date: 02.17.2026
version: 11.10
content_type: howto
category: service
topic: request
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: de
---

# Anfragebeziehungen

Anfragebeziehungen ermöglichen es Ihnen, Anfragen zu verknüpfen, um Verbindungen zwischen Problemen anzuzeigen. Dies ist nützlich, wenn mehrere Anfragen mit demselben Problem zusammenhängen, wenn eine Anfrage von einer anderen abhängt oder wenn Sie hierarchische Verbindungen zwischen Anfragen verfolgen müssen.

> [!NOTE]
> Anfragebeziehungen werden verwendet, um Anfragen mit anderen Anfragen zu verknüpfen. Um Beziehungen zwischen Firmen und Personen zu definieren, siehe [Firmen- und Personenbeziehungen][4].

## Beziehungstypen

Es gibt drei Arten von Anfragebeziehungen:

* **Verknüpft:** Eine nicht-hierarchische Verbindung zwischen Anfragen.

* **Übergeordnet:** Eine Anfrage, die eine oder mehrere untergeordnete Anfragen hat.

* **Untergeordnet:** Eine Anfrage, die unter einer übergeordneten Anfrage verknüpft ist. Jede Anfrage kann nur eine übergeordnete Anfrage haben.

## Anwendungsfälle

Verwenden Sie **verknüpft**, wenn Anfragen verbunden sind, aber keine Hierarchie haben.

**Mehrere Kunden melden dasselbe Problem**
Wenn verschiedene Kunden unabhängig voneinander dasle Problem melden, verknüpfen Sie die Anfragen als verwandt. Dies bietet eine flache Ansicht aller betroffenen Kunden und hilft, eine konsistente Kommunikation sicherzustellen.

**Anfragen mit mehreren Fragen**
Wenn eine Anfrage nicht zusammenhängende Fragen enthält, teilen Sie sie in separate Anfragen für jede Abteilung auf. Verknüpfen Sie sie dann als verwandt, um zu zeigen, dass sie aus demselben Kontext stammen.

Verwenden Sie **übergeordnet und untergeordnet**, wenn Anfragen eine hierarchische oder Abhängigkeitsbeziehung haben.

**Vorfallmanagement mit Ursachenverfolgung**
Erstellen Sie eine übergeordnete Anfrage, um das zugrunde liegende Problem zu verfolgen. Verknüpfen Sie jeden Kundenbericht als untergeordnete Anfrage. Eine übergeordnete Anfrage kann mehrere untergeordnete Anfragen haben, aber jede Anfrage kann nur eine übergeordnete Anfrage haben.

**Verwaltung von Abhängigkeiten**
Wenn eine Anfrage gelöst werden muss, bevor eine andere abgeschlossen werden kann, verknüpfen Sie sie mit einer übergeordnet-untergeordnet-Beziehung, um die Abhängigkeit klar zu zeigen.

## Anfragebeziehungen anzeigen

Wenn eine Anfrage eine oder mehrere Beziehungen hat, können Sie diese auf der Registerkarte **Beziehungen** im Anfragebild sehen.

### Archivansicht

Die Standardansicht zeigt Beziehungen als Liste mit den folgenden Spalten an:

* Anfrage-ID
* Titel
* Zuletzt geändert
* Eigentümer
* Status
* Beziehungstyp

![Anfragebeziehungen in Listenansicht -screenshot][img1]

### Baumansicht

Klicken Sie auf **Baumansicht**, um Beziehungen in einer hierarchischen Struktur anzuzeigen, was übergeordnete und untergeordnete Beziehungen einfacher zu visualisieren macht:

![Anfragebeziehungen in Baumansicht -screenshot][img2]

> [!TIP]
> Die Registerkarte **Beziehungen** zeigt einen orangefarbenen Indikator an, wenn die Anfrage eine oder mehrere Beziehungen hat, sodass verknüpfte Anfragen auf einen Blick leicht zu erkennen sind.

### Verschiedene Perspektiven

Beziehungen sind bidirektional. Beide Anfragen in der Beziehung zeigen die Verbindung an:

* Wenn Anfrage A **übergeordnet** von Anfrage B ist, zeigt Anfrage B Anfrage A als ihre übergeordnete Anfrage an
* Wenn Anfrage A **verknüpft** mit Anfrage B ist, zeigt Anfrage B an, dass sie mit Anfrage A verknüpft ist

![Dieselbe Beziehung aus der verknüpften Anfrage betrachtet -screenshot][img3]

## <a id="add"></a>Anfragebeziehung hinzufügen

Sie können eine Beziehung an den folgenden Stellen hinzufügen:

### Vom Anfragebild aus

1. Öffnen Sie die Anfrage, die Sie verknüpfen möchten.

1. Wählen Sie die Registerkarte **Beziehungen**.

1. Klicken Sie auf **Neue Beziehung**.

1. Wählen Sie im Feld **Beziehungstyp** **Verknüpft**, **Übergeordnet** oder **Untergeordnet**.

1. Wählen Sie im Abschnitt **Link zu** die Option **Link zu bestehenden** (Standard).

1. Beginnen Sie mit der Eingabe im Suchfeld, um die Anfrage zu finden, die Sie verknüpfen möchten. Sie können nach Anfrage-ID, Titel, Firma oder Person suchen.

1. Wählen Sie die Anfrage aus der Liste aus. Sie können den Cursor über eine Anfrage in der Liste bewegen, um eine Vorschau ihrer Details anzuzeigen.

1. Fügen Sie optional einen Kommentar hinzu, der die Beziehung erklärt.

1. Klicken Sie auf **Verknüpfen**, um die Verbindung zu erstellen.

### Von der Bereichsregisterkarte Anfragen

1. Gehen Sie zu einem Firmen-, Personen-, Verkaufs- oder Projektbild.

1. Wählen Sie die Bereichsregisterkarte **Anfragen**.

1. Klicken Sie mit der rechten Maustaste auf die Anfrage, von der aus Sie eine Beziehung erstellen möchten.

1. Wählen Sie **Beziehungen** aus dem Kontextmenü.

1. Befolgen Sie die Schritte 4-9 oben, um die Beziehung abzuschließen.

![Kontextmenü mit Beziehungen-Option -screenshot][img4]

## Neue Anfrage als Beziehung erstellen

Anstatt eine Verknüpfung zu einer vorhandenen Anfrage herzustellen, können Sie eine neue Anfrage erstellen, während Sie die Beziehung herstellen:

1. Befolgen Sie die obigen Schritte, um das Dialogfeld **Beziehungen** zu öffnen.

1. Wählen Sie im Abschnitt **Link zu** die Option **Neue Anfrage erstellen**.

1. Füllen Sie die Anfragedetails aus.

1. Klicken Sie auf **Verknüpfen**, um sowohl die neue Anfrage als auch die Verbindung gleichzeitig zu erstellen.

## <a id="delete"></a>Anfragebeziehung entfernen

1. Öffnen Sie die Anfrage und wählen Sie die Registerkarte **Beziehungen**.

1. Finden Sie die Beziehung, die Sie entfernen möchten.

1. Klicken Sie unten im Dialogfeld auf <i class="ph ph-x-circle" aria-label="Symbol entfernen"></i> **Beziehung entfernen**, oder klicken Sie mit der rechten Maustaste auf die Beziehung und wählen Sie **Beziehung entfernen**.

1. Bestätigen Sie die Löschung.

Durch das Entfernen einer Beziehung wird nur die Verknüpfung gelöscht. Die Anfragen bleiben unverändert.

## Fehlerbehebung

### Schaltfläche Beziehung entfernen kann nicht angeklickt werden

Die Schaltfläche **Beziehung entfernen** ist nur aktiv, wenn Sie genau eine Beziehung ausgewählt haben. Stellen Sie sicher, dass Sie:

* Eine einzelne Beziehung aus der Liste ausgewählt haben
* Nicht mehrere Beziehungen ausgewählt haben

### Kann keine übergeordnete oder untergeordnete Beziehung hinzufügen

**Ursache:** Eine Anfrage kann nur eine übergeordnete Anfrage haben. Wenn die Anfrage bereits eine übergeordnete Anfrage hat, können Sie keine weitere übergeordnete Beziehung zuweisen.

**Lösung:** Entfernen Sie zuerst die vorhandene übergeordnete Beziehung, oder verwenden Sie stattdessen einen **Verknüpft**-Beziehungstyp, der mehrere Verbindungen zulässt.

### Kann keine Beziehung erstellen

**Mögliche Ursachen:**

* **Doppelte Beziehung:** Die beiden Anfragen sind bereits verknüpft. Überprüfen Sie die Registerkarte Beziehungen, um zu sehen, ob die Beziehung bereits existiert.
* **Zirkuläre Hierarchie:** Sie können keine übergeordnete-untergeordnete Beziehung erstellen, die zu einer zirkulären Referenz führen würde (z. B. Anfrage A ist das übergeordnete Element von Anfrage B und Anfrage B ist das übergeordnete Element von Anfrage A).

**Lösung:** Überprüfen Sie vorhandene Beziehungen und passen Sie Ihre Hierarchiestruktur an, um zirkuläre Abhängigkeiten zu vermeiden.

## Verwandte Inhalte

* [Anfrage teilen][2]
* [Anfragen zusammenführen][1]
* [Bereichsregisterkarte Anfragen][3]
* [Firmen- und Personenbeziehungen][4]

<!-- Referenced links -->
[1]: merge.md
[2]: split-request.md
[3]: ../../learn/section-tabs/requests-tab.md
[4]: ../../learn/basics/relations.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/request-relations-archive.png
[img2]: ../../../media/loc/en/request/request-relations-tree.png
[img3]: ../../../media/loc/en/request/request-relations-perspective.png
[img4]: ../../../media/loc/en/request/request-relations-context-menu.png
