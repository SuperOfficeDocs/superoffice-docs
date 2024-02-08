---
uid: help-de-mailing
title: Mit Kampagnen arbeiten
description: Mit Kampagnen arbeiten
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: help
language: de
---

# Mit Kampagnen arbeiten

Eine Kampagne wird normalerweise in zwei Schritten bearbeitet:

* [Vorbereiten und Versenden der Kampagne][1].
* [Nachverfolgen der abgeschlossenen Kampagne][2].

## Kampagnentyp

* E-Mail
* SMS
* Dokument
* Formularantwort

> [!NOTE]
> E-Mail-Kampagnen und Formularantworten bieten die meisten Funktionen. Funktionen wie überwachte Links und Links für Abonnements stehen in SMS- und Dokumentenkampagnen nicht zur Verfügung.

## Empfänger

Sie können Empfänger aus mehreren Quellen hinzufügen.

> [!NOTE]
> Beim Hinzufügen von Empfängern werden nur Personen mit einer gültigen E-Mail-Adresse (oder Mobilfunknummer für SMS-Kampagnen) zur Liste **Empfänger** hinzugefügt.

Importierte Empfänger, die in der Datenbank von SuperOffice NICHT gefunden werden können, setzen sich ausschließlich aus dem Namen und einer E-Mail-Adresse (bzw. nur einer E-Mail-Adresse) zusammen. Das bedeutet, dass nur die Vorlagenvariablen **\[\[customer.name\]\]** und/oder **\[\[customer.email\]\]** für diese Empfänger funktionieren werden. Um leere Variablen zu vermeiden, sehen Sie sich die [Kampagne zuvor in der Vorschau][4] an.

## Kampagne mit Selektion oder Projekt verknüpfen

Sie können die Kampagne mit einer Selektion und/oder einem Projekt verknüpfen, um den Überblick über alle Kampagnen zu behalten, die sich auf Ihre Selektion und Projekte beziehen.

Die Kampagnen sind in der Bereichsregisterkarte **Kampagnen** unter **Selektionen** sowie in der Bereichsregisterkarte **Aktivitäten** unter **Projekte** in SuperOffice CRM aufgelistet.

> [!NOTE]
> Wenn Sie eine Selektion oder ein Projekt hinzufügen, werden alle Personen aus der Selektion bzw. dem Projekt als Empfänger zur Kampagne hinzugefügt. Wenn Sie eine Selektion und ein Projekt hinzufügen, werden nur die Personen aus der Selektion als Empfänger hinzugefügt.

Beispiel: Wenn Sie mehrere Kampagnen zur Bewerbung eines Events versenden, können Sie diese Kampagnen zu einer sogenannten "Event 2015"-Selektion hinzufügen, um eine vollständige Liste aller Kampagnen für dieses Event zu erhalten.

Analog dazu können Sie, wenn Sie ein Projekt für Ihr Event erstellt haben, eine Liste aller mit dem Projekt in Zusammenhang stehenden Kampagnen unter der Bereichsregisterkarte **Aktivitäten** pflegen.

<!-- Referenced links -->
[1]: create/index.md
[2]: follow-up/index.md
[4]: create/send-test-email.md

<!-- Referenced images -->